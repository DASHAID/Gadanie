using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Gadanie
{
    public partial class Form1 : Form
    {
        private Point PreviousPoint;
        private Bitmap bmp, bmp_traf;
        Point[] point_live = new Point[2];
        Point[] point_mind = new Point[2];
        Point[] point_destiny = new Point[2];
        Point[] point_hurt = new Point[2];

        public Graphics g;

        Form2 frm2 = new Form2();

        int hand_side = 0;
        bool paint_val = false;
        int width = 0;
        int height = 0;
        int count = 0;
        int count_mouse = 0;
        int live = 0, destiny = 0, hurt = 0, mind = 0;
        bool paint_lines=false;




        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            label2.Visible = false;
            button5.Visible = true;
            pictureBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            label2.Visible = true;
            label1.Visible = false;
            button1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hand_side = 1;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
            label2.Visible = false;
            pictureBox1.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            button_del_live.Visible = false;
            var contrast = Math.Pow((100.0 + 80) / 100.0, 2);
            button4.Visible = false;
            button5.Visible = false;


            // Циклы для перебора всех пикселей на изображении


            //повышение экспозиции
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    var oldColor = bmp.GetPixel(i, j);
                    var red = ((((oldColor.R / 255.0) - 0.5) * contrast) + 0.5) * 255.0;
                    var green = ((((oldColor.G / 255.0) - 0.5) * contrast) + 0.5) * 255.0;
                    var blue = ((((oldColor.B / 255.0) - 0.5) * contrast) + 0.5) * 255.0;
                    if (red > 255)
                        red = 255;
                    if (red < 0)
                        red = 0;
                    if (green > 255)
                        green = 255;
                    if (green < 0)
                        green = 0;
                    if (blue > 255)
                        blue = 255;
                    if (blue < 0)
                        blue = 0;

                    var new_color = Color.FromArgb(oldColor.A, (int)red, (int)green, (int)blue);
                    bmp.SetPixel(i, j, new_color);
                }
            }
            Refresh();


            //перевод в черно-белое
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                {

                    int R = bmp.GetPixel(i, j).R;
                    int G = bmp.GetPixel(i, j).G;
                    int B = bmp.GetPixel(i, j).B;
                    int Black = (R = G + B) / 4;

                    Color p = Color.FromArgb(255, Black, Black, Black);

                    bmp.SetPixel(i, j, p);
                }

            Refresh();
            Thread.Sleep(1000);
            //Sort_point();
            paint_val = true;
            frm2.Show();
            button_live.Visible = true;
            button_hurt.Visible = true;
            button_destiny.Visible = true;
            button_mind.Visible = true;
            button6.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Point Find_point(int i, int diff_x, int diff_y)
        {
            Point midle_point = new Point(0, 0);
            if (i == 0)
            {
                midle_point.X = (point_live[i].X + point_live[i + 1].X) / 2 + diff_x;
                midle_point.Y = (point_live[i].Y + point_live[i + 1].Y) / 2 + diff_y;
            }
            else
            {
                midle_point.X = (point_hurt[0].X + point_hurt[1].X) / 2 + diff_x;
                midle_point.Y = (point_hurt[0].Y + point_hurt[1].Y) / 2 + diff_y;
            }
            return midle_point;

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (paint_val == true)
            {

                Pen live_p = new Pen(Color.Red, 6);
                Pen destiny_p = new Pen(Color.Green, 6);
                Pen hurt_p = new Pen(Color.Orange, 6);
                Pen mind_p = new Pen(Color.Blue, 6);
                Point point = new Point(0, 0);

                int differ = point_hurt[0].X - point_hurt[1].X;


                if (live == 1)
                {

                    Point[] p = { point_live[0], Find_point(0, 0, Math.Abs((point_live[0].Y - point_live[1].Y)) / 2), Find_point(0, 0, Math.Abs((point_live[0].Y - point_live[1].Y)) / 2), point_live[1] };
                    e.Graphics.DrawBeziers(live_p, p);
                }

                if (mind == 1) e.Graphics.DrawLine(mind_p, new Point(point_mind[0].X, point_mind[0].Y), new Point(point_mind[1].X, point_mind[1].Y));

                if (destiny == 1) e.Graphics.DrawLine(destiny_p, new Point(point_destiny[0].X, point_destiny[0].Y), new Point(point_destiny[1].X, point_destiny[1].Y));

                if (hurt == 1)
                {
                    int diff_x = 0;
                    int diff_y = 0;
                    if (hand_side == 1)
                    {
                        if (differ < -70)
                        {
                            diff_x = -65;
                            diff_y = -10;
                        }
                        else
                        {
                            diff_x = -60;
                            diff_y = -30;
                        }
                    }
                    else
                    {
                        if (differ < 40)
                        {
                            diff_x = -45;
                            diff_y = -10;
                        }
                        else
                        {
                            diff_x = -55;
                            diff_y = -40;
                        }
                    }


                    Point[] p = { point_hurt[0], Find_point(1, Math.Abs((point_hurt[0].X - point_hurt[1].X)) + diff_x, diff_y), Find_point(1, Math.Abs((point_hurt[0].X - point_hurt[1].X)) + diff_x, diff_y), point_hurt[1] };
                    e.Graphics.DrawBeziers(hurt_p, p);
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {

            Graphics Canvas;
            Canvas = (sender as Control).CreateGraphics();
            Canvas.SmoothingMode = SmoothingMode.HighQuality;
            
            if (count == 0 || count == 1)
            {
                Canvas.FillEllipse(new SolidBrush(Color.Red), e.X, e.Y, 7, 7); //Рисуем на picturebox
                point_live[count]= e.Location;
                if(count==0)label4.Text = "Выбирается линия жизни";
                else label4.Text = "Выбирается линия ума";
               

            }
            if (count == 2 || count == 3)
            {
                Canvas.FillEllipse(new SolidBrush(Color.Blue), e.X, e.Y, 7, 7); //Рисуем на picturebox
                point_mind[count%2] = e.Location;
                if(count==2)label4.Text = "Выбирается линия ума";
                else label4.Text = "Выбирается линия судьбы";
               

            }
            if (count == 4 || count == 5)
            {
                Canvas.FillEllipse(new SolidBrush(Color.Green), e.X, e.Y, 7, 7); //Рисуем на picturebox
                point_destiny[count%2] = e.Location;
                if(count==4)label4.Text = "Выбирается линия судьбы";
                else label4.Text = "Выбирается линия сердца";
                

            }
            if (count == 6 || count == 7)
            {
                Canvas.FillEllipse(new SolidBrush(Color.Yellow), e.X, e.Y, 7, 7); //Рисуем на picturebox
                point_hurt[count % 2] = e.Location;
                label4.Text = "Выбирается линия сердца";
               

            }
            count++;
            pictureBox3_right.Refresh();
            pictureBox2_left.Refresh();
        }

        private void button_live_Click(object sender, EventArgs e)
        {
            if (mind == 1) mind = 0;
            if (hurt == 1) hurt = 0;
            if (destiny == 1) destiny = 0;
            live = 1;
            Refresh();
        }

        private void button_destiny_Click(object sender, EventArgs e)
        {
            if (live == 1) live = 0;
            if (mind == 1) mind = 0;
            if (hurt == 1) hurt = 0;
            destiny = 1;
            Refresh();
        }

        private void button_head_Click(object sender, EventArgs e)
        {
            if (live == 1) live = 0;
            if (destiny == 1) destiny = 0;
            if (hurt == 1) hurt = 0;
            mind = 1;
            Refresh();

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button_del_live_Click(object sender, EventArgs e)
        {

            Point tmp = new Point(0, 0);

            if (count == 1)
            {
                point_live[0] = tmp;
                count--;
                
                Refresh();
            }
            else if (count == 2)
            {
                point_live[1] = tmp;
                label4.Text = "Выбирается линия жизни";
                count--;
                Refresh();
       ;
            }
            else if (count == 3)
            {
                point_mind[0] = tmp;
                count--;
                Refresh();
              
            }
            else if (count == 4)
            {
                point_mind[1] = tmp;
                label4.Text = "Выбирается линия ума";
                count--;
         
                Refresh();
            }
            else if (count == 5)
            {
                point_destiny[0] = tmp;
                count--;
                Refresh();
            }
            else if (count == 6)
            {
                point_destiny[1] = tmp;
                count--;
                label4.Text = "Выбирается линия судьбы";

                Refresh();
            }
            else if (count == 7)
            {
                point_hurt[0] = tmp;

                count--;
                Refresh();
            }
            else if(count == 8)
            {
                point_hurt[1] = tmp;
                label4.Text = "Выбирается линия сердца";
                count--;
                Refresh();

            }

            OnPaint(sender, e); // Вызывает перерисовку формы
            
        }

        private void pictureBox3_right_Paint(object sender, PaintEventArgs e)
        {
            if (paint_lines == true)

            {
                Pen live_p = new Pen(Color.Red, 7);
                Pen destiny_p = new Pen(Color.Green, 7);
                Pen hurt_p = new Pen(Color.Orange, 7);
                Pen mind_p = new Pen(Color.Blue, 7);
               
                if(count == 0 || count == 1)
                {
                   e.Graphics.DrawLine(live_p, 140, 130, 30, 140);
                   


                }
                if (count == 2 || count == 3)
                {
                    e.Graphics.DrawLine(mind_p, 150, 140, 50, 155);
                  


                }
                if (count == 4 || count == 5)
                {
                   e.Graphics.DrawLine(destiny_p, 100, 110, 110, 220);
                   


                }
                if (count == 6 || count == 7|| count == 8)
                {
                    e.Graphics.DrawLine(hurt_p, 165, 145, 140, 165);
                    e.Graphics.DrawLine(hurt_p, 140, 165, 145, 200);
                    e.Graphics.DrawLine(hurt_p, 143, 200, 161, 227);


                }



            }


        }

        private void pictureBox2_left_Paint(object sender, PaintEventArgs e)
        {
            if (paint_lines == true)

            {
                Pen live_p = new Pen(Color.Red, 7);
                Pen destiny_p = new Pen(Color.Green, 7);
                Pen hurt_p = new Pen(Color.Orange, 7);
                Pen mind_p = new Pen(Color.Blue, 7);

                if (count == 0 || count == 1)
                {
                    e.Graphics.DrawLine(live_p, 116, 137, 220, 145);



                }
                if (count == 2 || count == 3)
                {
                    e.Graphics.DrawLine(mind_p, 85, 140, 200, 155);



                }
                if (count == 4 || count == 5)
                {
                    e.Graphics.DrawLine(destiny_p, 140, 110, 145, 220);



                }
                if (count == 6 || count == 7 || count == 8)
                {
                    e.Graphics.DrawLine(hurt_p, 88, 147, 110, 165);
                    e.Graphics.DrawLine(hurt_p, 106, 165, 104, 200);
                    e.Graphics.DrawLine(hurt_p, 104, 200, 85, 217);


                }



            }
        }

        private void OnPaint(object sender, EventArgs e)
        {

            Graphics g = pictureBox1.CreateGraphics();

            for (int i = 0; i < count; i++)
            {
                if (i == 0 || i == 1)
                {
                    g.FillEllipse(new SolidBrush(Color.Red), point_live[i].X, point_live[i].Y, 7, 7);
                }
                else if (i == 2 || i == 3)
                {
                    g.FillEllipse(new SolidBrush(Color.Blue), point_mind[i%2].X, point_mind[i%2].Y, 7, 7);
                }
                else if (i == 4 || i == 5)
                {
                    g.FillEllipse(new SolidBrush(Color.Green), point_destiny[i%2].X, point_destiny[i%2].Y, 7, 7);
                }
                else if (i == 6 || i == 7)
                {
                    g.FillEllipse(new SolidBrush(Color.Yellow), point_hurt[i%2].X, point_hurt[i%2].Y, 7, 7);
                }
            }
          
            
            
        }

        private void button_hurt_Click(object sender, EventArgs e)
        {
            if (live == 1) live = 0;
            if (destiny == 1) destiny = 0;
            if (mind == 1) mind = 0;
            hurt = 1;
            Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {


            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Image files (*.BMP, *.JPG," + " *.GIF, *.PNG)| *.bmp; *.jpg; *.gif; *.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {

                Image image = Image.FromFile(dialog.FileName);

                width = image.Width;
                height = image.Height;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                bmp = new Bitmap(image, width / 2, height / 2);
                pictureBox1.Image = bmp;

                g = Graphics.FromImage(pictureBox1.Image);

            }
            label3.Visible = true;
            if (hand_side == 1) pictureBox2_left.Visible = true;
            if (hand_side == 0) pictureBox3_right.Visible = true;
            button_del_live.Visible = true;
            label4.Visible = true;
            label4.Text = "Выбирается линия жизни";
            paint_lines=true;

        }

        static unsafe float ToGray(byte* bgr)
        {
            return bgr[2] * 0.3f + bgr[1] * 0.59f + bgr[0] * 0.11f;
        }

       


  
    }
}