using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
// TODO: определить как после завершения метода хода игрока (грубо говоря после отрисовки хода) вызвать метод бота
// TODO: Сделать приятный дизайн
// TODO: Упаковать всё в 1 exe файл

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public int queue; //Текущий игрок 
        public int[] matrix = new int[10]; //Матрица ходов игроков на поле. 0-пустая ячейка, 1-поставил ход игрок1, 2-игрок2
        public string Name_P1 = "Игрок 1";
        public string Name_P2 = "Игрок 2";
        public Form1()
        {
            Program.f1 = this; //f1 теперь будет ссылкой для доступа к форме
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        #region Box
        private void Box1_Click(object sender, EventArgs e)
        {
            motion Box1 = new motion("Box1", 1);
            Box1.calc();
        }

        private void Box2_Click(object sender, EventArgs e)
        {
            motion Box2 = new motion("Box2", 2);
            Box2.calc();
        }

        private void Box3_Click(object sender, EventArgs e)
        {
            motion Box3 = new motion("Box3", 3);
            Box3.calc();
        }

        private void Box4_Click(object sender, EventArgs e)
        {
            motion Box4 = new motion("Box4", 4);
            Box4.calc();
        }

        private void Box5_Click(object sender, EventArgs e)
        {
            motion Box5 = new motion("Box5", 5);
            Box5.calc();
        }

        private void Box6_Click(object sender, EventArgs e)
        {
            motion Box6 = new motion("Box6", 6);
            Box6.calc();
        }

        private void Box7_Click(object sender, EventArgs e)
        {
            motion Box7 = new motion("Box7", 7);
            Box7.calc();
        }

        private void Box8_Click(object sender, EventArgs e)
        {
            motion Box8 = new motion("Box8", 8);
            Box8.calc();
        }

        private void Box9_Click(object sender, EventArgs e)
        {
            motion Box9 = new motion("Box9", 9);
            Box9.calc();
        }
        #endregion

        #region Buttons
        private void button_start_Click(object sender, EventArgs e)
        {
            // подготавливаем поле для новой игры
            Program.f1.Box1.Enabled = true;
            Program.f1.Box2.Enabled = true;
            Program.f1.Box3.Enabled = true;
            Program.f1.Box4.Enabled = true;
            Program.f1.Box5.Enabled = true;
            Program.f1.Box6.Enabled = true;
            Program.f1.Box7.Enabled = true;
            Program.f1.Box8.Enabled = true;
            Program.f1.Box9.Enabled = true;

            // очищаем матрицу предыдущей игры
            for (int i=0; i<10; i++)
            {
                Program.f1.matrix[i] = 0;
            }

            // очищаем само поле от изображений предыдущих ходов
            Program.f1.Box1.BackgroundImage = null;
            Program.f1.Box2.BackgroundImage = null;
            Program.f1.Box3.BackgroundImage = null;
            Program.f1.Box4.BackgroundImage = null;
            Program.f1.Box5.BackgroundImage = null;
            Program.f1.Box6.BackgroundImage = null;
            Program.f1.Box7.BackgroundImage = null;
            Program.f1.Box8.BackgroundImage = null;
            Program.f1.Box9.BackgroundImage = null;

            Program.f1.label_P1.Visible = false;
            Program.f1.label_P2.Visible = false;
            Program.f1.label1.Visible = true;
            Program.f1.label_queue.Visible = true;

        }

        private void Rename_button_Click(object sender, EventArgs e)
        {
            Name_P1 = textBox_NP1.Text;
            Name_P2 = textBox_NP2.Text;
            label_P1.Text = Name_P1 + " победил!";
            label_P2.Text = Name_P2 + " победил!";
            if (queue==0)
            {
                label_queue.Text = Name_P1;
            }
            if (queue==1)
            {
                label_queue.Text = Name_P2;
            }
        }
        #endregion
    }
    public class motion //осуществляем изменение ячейки поля обрабатывая ход игрока
    {
        public string Name_object;
        public int m; //индекс массива, на какую ячейку был осуществлён ход

        public motion (string n, int m) { Name_object = n; this.m = m; } //конструктор класса
        public void calc()
        {

            //Используем эту конструкцию для изенения именно того Box'а с которого осуществился переход
            if (Program.f1.matrix[m]==0)
            {
                if (Program.f1.queue == 0) //ход игрока 1
                {
                    Program.f1.Controls[Name_object].BackgroundImage = Image.FromFile(@"C:\Users\Admin\source\repos\tic tac toe\Resources\Chrest.jpg");
                    Program.f1.matrix[m] = 1;
                    Program.f1.queue = 1;
                    Program.f1.label_queue.Text = Program.f1.Name_P2;
                }
                else //ход игрока 2
                {
                    Program.f1.Controls[Name_object].BackgroundImage = Image.FromFile(@"C:\Users\Admin\source\repos\tic tac toe\Resources\Zero.jpg");
                    Program.f1.matrix[m] = 2;
                    Program.f1.queue = 0;
                    Program.f1.label_queue.Text = Program.f1.Name_P1;
                }
                check.check_game();
               
            }
            
        }

        public int Bot () //Ход бота
        {
            int Bot_motion;
            // Просканировать поле, найти пустые ячейки и выписать их в отдельный новосозданный массив
            // узнать длину массива
            // зарандомить ячейку массива ограниченую его длиной
            // вернуть в return значение ячейки массива, что и будет являться ходом бота
            int[] bot_matrix = new int[10]; //спомогательная матрица для определения свободных ячеек для хода бота
            int m = 1;
            int count_move = 0; 
            for (int i=1; i<10; i++) // ищем пустые поля для хода
            {
                if (Program.f1.matrix[i]==0)
                {
                    bot_matrix[m] = Program.f1.matrix[i];
                    m++;
                }    
            }
            for (int i=0; i<10; i++) // считаем количество свободных ячеек
            {
                if (bot_matrix[i]!=0)
                {
                    count_move++;
                }
                else { break; }
            }
            // делаем случайный ход бота в зависимости от свободных ячеек
            Random rnd = new Random();
            Bot_motion = rnd.Next(count_move);
            return Bot_motion;
        }
    }
    public class check //проверяем конец игры
    {
        public static void check_game ()
        {
            bool end_game=false;
            // Проверка выигрыша игрока 1. Проверяем поле на 3 креста подряд
           if (Program.f1.matrix[1] == 1 && Program.f1.matrix[2] == 1 && Program.f1.matrix[3] == 1 ||
               Program.f1.matrix[4] == 1 && Program.f1.matrix[5] == 1 && Program.f1.matrix[6] == 1 ||
               Program.f1.matrix[7] == 1 && Program.f1.matrix[8] == 1 && Program.f1.matrix[9] == 1 ||
               Program.f1.matrix[1] == 1 && Program.f1.matrix[4] == 1 && Program.f1.matrix[7] == 1 ||
               Program.f1.matrix[2] == 1 && Program.f1.matrix[5] == 1 && Program.f1.matrix[8] == 1 ||
               Program.f1.matrix[3] == 1 && Program.f1.matrix[6] == 1 && Program.f1.matrix[9] == 1 ||
               Program.f1.matrix[1] == 1 && Program.f1.matrix[5] == 1 && Program.f1.matrix[9] == 1 ||
               Program.f1.matrix[7] == 1 && Program.f1.matrix[5] == 1 && Program.f1.matrix[3] == 1 )
            {
                Program.f1.label_P1.Visible = true;
                end_game = true;
            }
            // Проверка выигрыша игрока 2. Проверяем поле на 3 нолика подряд
            if (Program.f1.matrix[1] == 2 && Program.f1.matrix[2] == 2 && Program.f1.matrix[3] == 2 ||
                Program.f1.matrix[4] == 2 && Program.f1.matrix[5] == 2 && Program.f1.matrix[6] == 2 ||
                Program.f1.matrix[7] == 2 && Program.f1.matrix[8] == 2 && Program.f1.matrix[9] == 2 ||
                Program.f1.matrix[1] == 2 && Program.f1.matrix[4] == 2 && Program.f1.matrix[7] == 2 ||
                Program.f1.matrix[2] == 2 && Program.f1.matrix[5] == 2 && Program.f1.matrix[8] == 2 ||
                Program.f1.matrix[3] == 2 && Program.f1.matrix[6] == 2 && Program.f1.matrix[9] == 2 ||
                Program.f1.matrix[1] == 2 && Program.f1.matrix[5] == 2 && Program.f1.matrix[9] == 2 ||
                Program.f1.matrix[7] == 2 && Program.f1.matrix[5] == 2 && Program.f1.matrix[3] == 2)
            {
                Program.f1.label_P2.Visible = true;
                end_game = true;
            }

            if (end_game)   //блокируем поле от повторных нажатий по окончанию игры
            {
                Program.f1.Box1.Enabled = false;
                Program.f1.Box2.Enabled = false;
                Program.f1.Box3.Enabled = false;
                Program.f1.Box4.Enabled = false;
                Program.f1.Box5.Enabled = false;
                Program.f1.Box6.Enabled = false;
                Program.f1.Box7.Enabled = false;
                Program.f1.Box8.Enabled = false;
                Program.f1.Box9.Enabled = false;
                Program.f1.label1.Visible = false;
                Program.f1.label_queue.Visible = false;
                end_game = false;
            }

        }
    }
}
            
        


 
