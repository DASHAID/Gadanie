namespace Gadanie
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2_left = new System.Windows.Forms.PictureBox();
            this.pictureBox3_right = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_live = new System.Windows.Forms.Button();
            this.button_destiny = new System.Windows.Forms.Button();
            this.button_mind = new System.Windows.Forms.Button();
            this.button_hurt = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button_del_live = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_right)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Gabriola", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Image = global::Gadanie.Properties.Resources._2;
            this.button2.Location = new System.Drawing.Point(245, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(295, 347);
            this.button2.TabIndex = 0;
            this.button2.Text = "Правая рука";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Gabriola", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Image = global::Gadanie.Properties.Resources._2__1_;
            this.button3.Location = new System.Drawing.Point(765, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 347);
            this.button3.TabIndex = 1;
            this.button3.Text = "Левая рука";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::Gadanie.Properties.Resources.old_old_paper_jpg_design_keynote_backgrounds;
            this.button1.Location = new System.Drawing.Point(573, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 64);
            this.button1.TabIndex = 2;
            this.button1.Text = "Начать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Image = global::Gadanie.Properties.Resources.old_old_paper_jpg_design_keynote_backgrounds;
            this.label2.Location = new System.Drawing.Point(521, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 74);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберете руку:";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Image = global::Gadanie.Properties.Resources.Нежный_задний_фон_в_стиле_пергамента_006;
            this.label1.Location = new System.Drawing.Point(518, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 74);
            this.label1.TabIndex = 4;
            this.label1.Text = "Гадание на руке";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Image = global::Gadanie.Properties.Resources.old_old_paper_jpg_design_keynote_backgrounds;
            this.button4.Location = new System.Drawing.Point(45, 617);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 66);
            this.button4.TabIndex = 5;
            this.button4.Text = "Загрузить фото";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Image = global::Gadanie.Properties.Resources.old_old_paper_jpg_design_keynote_backgrounds;
            this.button5.Location = new System.Drawing.Point(1021, 617);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 56);
            this.button5.TabIndex = 6;
            this.button5.Text = "Начать";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(431, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 644);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox2_left
            // 
            this.pictureBox2_left.Image = global::Gadanie.Properties.Resources.Слой_1;
            this.pictureBox2_left.Location = new System.Drawing.Point(66, 237);
            this.pictureBox2_left.Name = "pictureBox2_left";
            this.pictureBox2_left.Size = new System.Drawing.Size(331, 307);
            this.pictureBox2_left.TabIndex = 8;
            this.pictureBox2_left.TabStop = false;
            this.pictureBox2_left.Visible = false;
            this.pictureBox2_left.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_left_Paint);
            // 
            // pictureBox3_right
            // 
            this.pictureBox3_right.Image = global::Gadanie.Properties.Resources.Слой_2;
            this.pictureBox3_right.Location = new System.Drawing.Point(66, 237);
            this.pictureBox3_right.Name = "pictureBox3_right";
            this.pictureBox3_right.Size = new System.Drawing.Size(331, 307);
            this.pictureBox3_right.TabIndex = 9;
            this.pictureBox3_right.TabStop = false;
            this.pictureBox3_right.Visible = false;
            this.pictureBox3_right.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_right_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Image = global::Gadanie.Properties.Resources.old_old_paper_jpg_design_keynote_backgrounds;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(38, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 84);
            this.label3.TabIndex = 10;
            this.label3.Text = "Поставьте точки на начало и конец линий,\r\n как показано на примере:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Visible = false;
            // 
            // button_live
            // 
            this.button_live.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_live.Image = global::Gadanie.Properties.Resources.old_old_paper_jpg_design_keynote_backgrounds;
            this.button_live.Location = new System.Drawing.Point(1041, 71);
            this.button_live.Name = "button_live";
            this.button_live.Size = new System.Drawing.Size(159, 68);
            this.button_live.TabIndex = 11;
            this.button_live.Text = "Линия жизни";
            this.button_live.UseVisualStyleBackColor = true;
            this.button_live.Visible = false;
            this.button_live.Click += new System.EventHandler(this.button_live_Click);
            // 
            // button_destiny
            // 
            this.button_destiny.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_destiny.Image = global::Gadanie.Properties.Resources.old_old_paper_jpg_design_keynote_backgrounds;
            this.button_destiny.Location = new System.Drawing.Point(1041, 171);
            this.button_destiny.Name = "button_destiny";
            this.button_destiny.Size = new System.Drawing.Size(159, 68);
            this.button_destiny.TabIndex = 12;
            this.button_destiny.Text = "Линия судьбы";
            this.button_destiny.UseVisualStyleBackColor = true;
            this.button_destiny.Visible = false;
            this.button_destiny.Click += new System.EventHandler(this.button_destiny_Click);
            // 
            // button_mind
            // 
            this.button_mind.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_mind.Image = global::Gadanie.Properties.Resources.old_old_paper_jpg_design_keynote_backgrounds;
            this.button_mind.Location = new System.Drawing.Point(1041, 275);
            this.button_mind.Name = "button_mind";
            this.button_mind.Size = new System.Drawing.Size(159, 68);
            this.button_mind.TabIndex = 13;
            this.button_mind.Text = "Линия ума";
            this.button_mind.UseVisualStyleBackColor = true;
            this.button_mind.Visible = false;
            this.button_mind.Click += new System.EventHandler(this.button_head_Click);
            // 
            // button_hurt
            // 
            this.button_hurt.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_hurt.Image = global::Gadanie.Properties.Resources.old_old_paper_jpg_design_keynote_backgrounds;
            this.button_hurt.Location = new System.Drawing.Point(1041, 380);
            this.button_hurt.Name = "button_hurt";
            this.button_hurt.Size = new System.Drawing.Size(159, 68);
            this.button_hurt.TabIndex = 14;
            this.button_hurt.Text = "Линия сердца";
            this.button_hurt.UseVisualStyleBackColor = true;
            this.button_hurt.Visible = false;
            this.button_hurt.Click += new System.EventHandler(this.button_hurt_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Info;
            this.button6.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(1081, 635);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 64);
            this.button6.TabIndex = 15;
            this.button6.Text = "Выход";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button_del_live
            // 
            this.button_del_live.Location = new System.Drawing.Point(1061, 406);
            this.button_del_live.Name = "button_del_live";
            this.button_del_live.Size = new System.Drawing.Size(139, 51);
            this.button_del_live.TabIndex = 16;
            this.button_del_live.Text = "Убрать последнюю точку";
            this.button_del_live.UseVisualStyleBackColor = true;
            this.button_del_live.Visible = false;
            this.button_del_live.Click += new System.EventHandler(this.button_del_live_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(103, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 37);
            this.label4.TabIndex = 17;
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gadanie.Properties.Resources._1644194890_18_abrakadabra_fun_p_fon_dlya_taro_261;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 729);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_del_live);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button_hurt);
            this.Controls.Add(this.button_mind);
            this.Controls.Add(this.button_destiny);
            this.Controls.Add(this.button_live);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3_right);
            this.Controls.Add(this.pictureBox2_left);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3_right)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2_left;
        private System.Windows.Forms.PictureBox pictureBox3_right;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_live;
        private System.Windows.Forms.Button button_destiny;
        private System.Windows.Forms.Button button_mind;
        private System.Windows.Forms.Button button_hurt;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button_del_live;
        private System.Windows.Forms.Label label4;
    }
}

