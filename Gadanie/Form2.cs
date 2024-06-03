using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gadanie
{
    public partial class Form2 : Form
    {
        StreamReader sr_1 = new StreamReader("live.txt");
        StreamReader sr_2 = new StreamReader("heart.txt");
        StreamReader sr_3 = new StreamReader("mind.txt");
        StreamReader sr_4 = new StreamReader("destiny.txt");
        String[] ss = new String[100];
        int rand_live, rand_destiny, rand_health, rand_mind;

        public Form2()
        {
            InitializeComponent();
            Read_File();
        }


        void Read_File()
        {
            string str_1 = "1", str_2 = "2", str_3 = "3", str_4 = "4";

            byte[] rngBytes = new byte[4];
            RandomNumberGenerator.Create().GetBytes(rngBytes);
            int myInt = BitConverter.ToInt32(rngBytes, 0);
            rand_live = Math.Abs(myInt) % 10;
            rand_destiny = Math.Abs(myInt / 10) % 10;
            rand_health = Math.Abs(myInt / 100) % 10;
            rand_mind = Math.Abs(myInt / 1000) % 10;

            for (int i = 0; i <= rand_live; i++)
            {
                str_1 = (String)sr_1.ReadLine();
            }
            for (int i = 0; i <= rand_destiny; i++)
            {
                str_2 = (String)sr_2.ReadLine();
            }
            for (int i = 0; i <= rand_health; i++)
            {
                str_3 = (String)sr_3.ReadLine();
            }
            for (int i = 0; i <= rand_mind; i++)
            {
                str_4 = (String)sr_4.ReadLine();
            }




            textBox1.Text = str_1;
            textBox2.Text = str_2;
            textBox3.Text = str_3;
            textBox4.Text = str_4;
        }


    }
}
