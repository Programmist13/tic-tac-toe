
namespace tic_tac_toe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_queue = new System.Windows.Forms.Label();
            this.label_P1 = new System.Windows.Forms.Label();
            this.label_P2 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.textBox_NP1 = new System.Windows.Forms.TextBox();
            this.textBox_NP2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Rename_button = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Box9 = new System.Windows.Forms.PictureBox();
            this.Box8 = new System.Windows.Forms.PictureBox();
            this.Box7 = new System.Windows.Forms.PictureBox();
            this.Box6 = new System.Windows.Forms.PictureBox();
            this.Box5 = new System.Windows.Forms.PictureBox();
            this.Box4 = new System.Windows.Forms.PictureBox();
            this.Box3 = new System.Windows.Forms.PictureBox();
            this.Box2 = new System.Windows.Forms.PictureBox();
            this.Box1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Box9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Текущий ход";
            // 
            // label_queue
            // 
            this.label_queue.AutoSize = true;
            this.label_queue.Location = new System.Drawing.Point(312, 105);
            this.label_queue.Name = "label_queue";
            this.label_queue.Size = new System.Drawing.Size(47, 13);
            this.label_queue.TabIndex = 10;
            this.label_queue.Text = "Игрок 1";
            // 
            // label_P1
            // 
            this.label_P1.AutoSize = true;
            this.label_P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_P1.Location = new System.Drawing.Point(233, 73);
            this.label_P1.Name = "label_P1";
            this.label_P1.Size = new System.Drawing.Size(156, 20);
            this.label_P1.TabIndex = 19;
            this.label_P1.Text = "Игрок 1 победил!";
            this.label_P1.Visible = false;
            // 
            // label_P2
            // 
            this.label_P2.AutoSize = true;
            this.label_P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_P2.Location = new System.Drawing.Point(233, 72);
            this.label_P2.Name = "label_P2";
            this.label_P2.Size = new System.Drawing.Size(156, 20);
            this.label_P2.TabIndex = 20;
            this.label_P2.Text = "Игрок 2 победил!";
            this.label_P2.Visible = false;
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(1, 0);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(165, 70);
            this.button_start.TabIndex = 21;
            this.button_start.Text = "Новая игра";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // textBox_NP1
            // 
            this.textBox_NP1.Location = new System.Drawing.Point(269, 12);
            this.textBox_NP1.Name = "textBox_NP1";
            this.textBox_NP1.Size = new System.Drawing.Size(100, 20);
            this.textBox_NP1.TabIndex = 22;
            // 
            // textBox_NP2
            // 
            this.textBox_NP2.Location = new System.Drawing.Point(269, 39);
            this.textBox_NP2.Name = "textBox_NP2";
            this.textBox_NP2.Size = new System.Drawing.Size(100, 20);
            this.textBox_NP2.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Имя игрока 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Имя игрока 2";
            // 
            // Rename_button
            // 
            this.Rename_button.Location = new System.Drawing.Point(375, 12);
            this.Rename_button.Name = "Rename_button";
            this.Rename_button.Size = new System.Drawing.Size(89, 47);
            this.Rename_button.TabIndex = 26;
            this.Rename_button.Text = "Сменить имена";
            this.Rename_button.UseVisualStyleBackColor = true;
            this.Rename_button.Click += new System.EventHandler(this.Rename_button_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "1";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Игра против компьютера",
            "Игра против человека"});
            this.comboBox1.Location = new System.Drawing.Point(1, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.ValueMember = "1";
            // 
            // Box9
            // 
            this.Box9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Box9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Box9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box9.Location = new System.Drawing.Point(338, 287);
            this.Box9.Name = "Box9";
            this.Box9.Size = new System.Drawing.Size(70, 70);
            this.Box9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Box9.TabIndex = 18;
            this.Box9.TabStop = false;
            this.Box9.BackgroundImageChanged += new System.EventHandler(this.Bot_move_thread);
            this.Box9.Click += new System.EventHandler(this.Box9_Click);
            // 
            // Box8
            // 
            this.Box8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Box8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Box8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box8.Location = new System.Drawing.Point(260, 287);
            this.Box8.Name = "Box8";
            this.Box8.Size = new System.Drawing.Size(70, 70);
            this.Box8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Box8.TabIndex = 17;
            this.Box8.TabStop = false;
            this.Box8.BackgroundImageChanged += new System.EventHandler(this.Bot_move_thread);
            this.Box8.Click += new System.EventHandler(this.Box8_Click);
            // 
            // Box7
            // 
            this.Box7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Box7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Box7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box7.Location = new System.Drawing.Point(181, 287);
            this.Box7.Name = "Box7";
            this.Box7.Size = new System.Drawing.Size(70, 70);
            this.Box7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Box7.TabIndex = 16;
            this.Box7.TabStop = false;
            this.Box7.BackgroundImageChanged += new System.EventHandler(this.Bot_move_thread);
            this.Box7.Click += new System.EventHandler(this.Box7_Click);
            // 
            // Box6
            // 
            this.Box6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Box6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Box6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box6.Location = new System.Drawing.Point(338, 211);
            this.Box6.Name = "Box6";
            this.Box6.Size = new System.Drawing.Size(70, 70);
            this.Box6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Box6.TabIndex = 15;
            this.Box6.TabStop = false;
            this.Box6.BackgroundImageChanged += new System.EventHandler(this.Bot_move_thread);
            this.Box6.Click += new System.EventHandler(this.Box6_Click);
            // 
            // Box5
            // 
            this.Box5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Box5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Box5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box5.Location = new System.Drawing.Point(260, 211);
            this.Box5.Name = "Box5";
            this.Box5.Size = new System.Drawing.Size(70, 70);
            this.Box5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Box5.TabIndex = 14;
            this.Box5.TabStop = false;
            this.Box5.BackgroundImageChanged += new System.EventHandler(this.Bot_move_thread);
            this.Box5.Click += new System.EventHandler(this.Box5_Click);
            // 
            // Box4
            // 
            this.Box4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Box4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Box4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box4.Location = new System.Drawing.Point(181, 211);
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(70, 70);
            this.Box4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Box4.TabIndex = 13;
            this.Box4.TabStop = false;
            this.Box4.BackgroundImageChanged += new System.EventHandler(this.Bot_move_thread);
            this.Box4.Click += new System.EventHandler(this.Box4_Click);
            // 
            // Box3
            // 
            this.Box3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Box3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Box3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box3.Location = new System.Drawing.Point(338, 135);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(70, 70);
            this.Box3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Box3.TabIndex = 12;
            this.Box3.TabStop = false;
            this.Box3.BackgroundImageChanged += new System.EventHandler(this.Bot_move_thread);
            this.Box3.Click += new System.EventHandler(this.Box3_Click);
            // 
            // Box2
            // 
            this.Box2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Box2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box2.Location = new System.Drawing.Point(259, 135);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(70, 70);
            this.Box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Box2.TabIndex = 11;
            this.Box2.TabStop = false;
            this.Box2.BackgroundImageChanged += new System.EventHandler(this.Bot_move_thread);
            this.Box2.Click += new System.EventHandler(this.Box2_Click);
            // 
            // Box1
            // 
            this.Box1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Box1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Box1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box1.Location = new System.Drawing.Point(181, 135);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(70, 70);
            this.Box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Box1.TabIndex = 5;
            this.Box1.TabStop = false;
            this.Box1.BackgroundImageChanged += new System.EventHandler(this.Bot_move_thread);
            this.Box1.Click += new System.EventHandler(this.Box1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Rename_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_NP2);
            this.Controls.Add(this.textBox_NP1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_P2);
            this.Controls.Add(this.label_P1);
            this.Controls.Add(this.Box9);
            this.Controls.Add(this.Box8);
            this.Controls.Add(this.Box7);
            this.Controls.Add(this.Box6);
            this.Controls.Add(this.Box5);
            this.Controls.Add(this.Box4);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.label_queue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Box9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        public System.Windows.Forms.PictureBox Box1;
        public System.Windows.Forms.PictureBox Box2;
        public System.Windows.Forms.Label label_queue;
        public System.Windows.Forms.PictureBox Box3;
        public System.Windows.Forms.PictureBox Box4;
        public System.Windows.Forms.PictureBox Box5;
        public System.Windows.Forms.PictureBox Box6;
        public System.Windows.Forms.PictureBox Box7;
        public System.Windows.Forms.PictureBox Box8;
        public System.Windows.Forms.PictureBox Box9;
        public System.Windows.Forms.Label label_P1;
        public System.Windows.Forms.Label label_P2;
        private System.Windows.Forms.Button button_start;
        public System.Windows.Forms.TextBox textBox_NP1;
        public System.Windows.Forms.TextBox textBox_NP2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button Rename_button;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}

