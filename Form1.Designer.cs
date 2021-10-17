
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
            this.Box1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_queue = new System.Windows.Forms.Label();
            this.Box2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).BeginInit();
            this.SuspendLayout();
            // 
            // Box1
            // 
            this.Box1.BackColor = System.Drawing.Color.Ivory;
            this.Box1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Box1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box1.Location = new System.Drawing.Point(181, 135);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(70, 70);
            this.Box1.TabIndex = 5;
            this.Box1.TabStop = false;
            this.Box1.Click += new System.EventHandler(this.Box1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Текущий ход";
            // 
            // label_queue
            // 
            this.label_queue.AutoSize = true;
            this.label_queue.Location = new System.Drawing.Point(335, 85);
            this.label_queue.Name = "label_queue";
            this.label_queue.Size = new System.Drawing.Size(47, 13);
            this.label_queue.TabIndex = 10;
            this.label_queue.Text = "Игрок 1";
            // 
            // Box2
            // 
            this.Box2.BackColor = System.Drawing.Color.Ivory;
            this.Box2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Box2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box2.Location = new System.Drawing.Point(260, 135);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(70, 70);
            this.Box2.TabIndex = 11;
            this.Box2.TabStop = false;
            this.Box2.Click += new System.EventHandler(this.Box2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.label_queue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        public System.Windows.Forms.PictureBox Box1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox Box2;
        public System.Windows.Forms.Label label_queue;
    }
}

