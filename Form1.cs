using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public int queue; //Текущий игрок 
        public int [] matrix = new int[9]; //Матрица ходов игроков на поле. 0-пустая ячейка, 1-поставил ход игрок1, 2-игрок2
        
        public Form1()
        {
            Program.f1 = this; //f1 теперь будет ссылкой для доступа к форме
            InitializeComponent();            
        }
        private void Box1_Click(object sender, EventArgs e)
        {
            motion Box1 = new motion ("Box1", 1);
            Box1.calc();
        } 

        private void Box2_Click(object sender, EventArgs e)
        {
            motion Box2 = new motion("Box2", 2);
            Box2.calc();
        }
        
    }
    public class motion //осуществляем изменение ячейки поля обрабатывая ход игрока
    {
        public string Name_object;
        public int m; //индекс массива, на какую ячейку бы осуществлён ход

        public motion (string n, int m) { Name_object = n; this.m = m; } //конструктор класса
        public void calc()
        {

            //Используем эту конструкцию для изенения именно того Box'а с которого осуществился переход
            if (Program.f1.Controls[Name_object].BackColor == Color.Ivory)
            {
                if (Program.f1.queue == 0) //ход игрока 1
                {
                    Program.f1.Controls[Name_object].BackColor = Color.Red;
                    Program.f1.matrix[m] = 1;
                    Program.f1.queue = 1;
                    Program.f1.label_queue.Text = "Игрок 2";

                }
                else //ход игрока 2
                {
                    Program.f1.Controls[Name_object].BackColor = Color.Blue;
                    Program.f1.matrix[m] = 2;
                    Program.f1.queue = 0;
                    Program.f1.label_queue.Text = "Игрок 1";
                }
            }
        }
    }


}
            
        


 
