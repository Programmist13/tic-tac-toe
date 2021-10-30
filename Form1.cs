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
// TODO: Проверить бота (усложнить бота, а то он слишком тупой)
// TODO: Сделать приятный дизайн
// TODO: Упаковать всё в 1 exe файл
// TODO: Можно упростить код, когда передаётся ход, чтобы Name_object брался автоматически от хода игрока по средствам "Box"+m


namespace tic_tac_toe
{
    delegate void Update_label(string text);
    delegate void check_game();
    public partial class Form1 : Form
    {
        public int queue; //Текущий игрок 0-первый, 1-второй
        public int[] matrix = new int[10]; //Матрица ходов игроков на поле. 0-пустая ячейка, 1-поставил ход игрок1, 2-игрок2
        public string Name_P1 = "Игрок 1";
        public string Name_P2 = "Игрок 2";
        public string Bot_box_move;
        public int Bot_move_index;
        public bool end_game;

        public Form1()
        {
            Program.f1 = this; //f1 теперь будет ссылкой для доступа к форме
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

        }

        public void to_check()
        {
            check_game();
        }
        public void change_control_form (string text) //функция которую я хочу вызвать из отдельного потока -------создание делегата? для изменения значения контрола winform в основном потоке из параллельного потока
        {
            Program.f1.label_queue.Text = text;
            Controls[Bot_box_move].BackgroundImage = new Bitmap(Properties.Resources.Zero);
            Controls[Bot_box_move].Enabled = false;
        }
        private void Bot_move_thread()
        {
            if (queue == 1 & comboBox1.SelectedIndex == 0 & !end_game)
            {
                Thread Bot_Thread = new Thread(this.Bot_move);
                Bot_Thread.Start();
            }
        }
        private void Bot_move () //Ход бота выполняется отдельным потоком. Приказываем боту ходить после изменения картинки (окончания хода пользователя)
        {
            Thread.Sleep(500);
            if (!end_game)
            {
                move();
            }
        }

        #region Box
        private void Box1_Click(object sender, EventArgs e)
        {
            calc("Box1", 1);
            Bot_move_thread();
        }

        private void Box2_Click(object sender, EventArgs e)
        {
            calc("Box2", 2);
            Bot_move_thread();
        }

        private void Box3_Click(object sender, EventArgs e)
        {
            calc("Box3", 3);
            Bot_move_thread();
        }

        private void Box4_Click(object sender, EventArgs e)
        {
            calc("Box4", 4);
            Bot_move_thread();
        }

        private void Box5_Click(object sender, EventArgs e)
        {
            calc("Box5", 5);
            Bot_move_thread();
        }

        private void Box6_Click(object sender, EventArgs e)
        {
            calc("Box6", 6);
            Bot_move_thread();
        }

        private void Box7_Click(object sender, EventArgs e)
        {
            calc("Box7", 7);
            Bot_move_thread();
        }

        private void Box8_Click(object sender, EventArgs e)
        {
            calc("Box8", 8);
            Bot_move_thread();
        }

        private void Box9_Click(object sender, EventArgs e)
        {
            calc("Box9", 9);
            Bot_move_thread();
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
            Program.f1.end_game = false;
            Bot_move_thread();
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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //button_start.BackColor = Color.Blue;


            button_start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;


        }
        #endregion
        public void check_game() //проверяем конец игры
        {
            // Проверка выигрыша игрока 1. Проверяем поле на 3 креста подряд
            if (matrix[1] == 1 && matrix[2] == 1 && matrix[3] == 1 ||
                matrix[4] == 1 && matrix[5] == 1 && matrix[6] == 1 ||
                matrix[7] == 1 && matrix[8] == 1 && matrix[9] == 1 ||
                matrix[1] == 1 && matrix[4] == 1 && matrix[7] == 1 ||
                matrix[2] == 1 && matrix[5] == 1 && matrix[8] == 1 ||
                matrix[3] == 1 && matrix[6] == 1 && matrix[9] == 1 ||
                matrix[1] == 1 && matrix[5] == 1 && matrix[9] == 1 ||
                matrix[7] == 1 && matrix[5] == 1 && matrix[3] == 1)
            {
                label_P1.Visible = true;
                end_game = true;
            }
            // Проверка выигрыша игрока 2. Проверяем поле на 3 нолика подряд
            if (matrix[1] == 2 && matrix[2] == 2 && matrix[3] == 2 ||
                matrix[4] == 2 && matrix[5] == 2 && matrix[6] == 2 ||
                matrix[7] == 2 && matrix[8] == 2 && matrix[9] == 2 ||
                matrix[1] == 2 && matrix[4] == 2 && matrix[7] == 2 ||
                matrix[2] == 2 && matrix[5] == 2 && matrix[8] == 2 ||
                matrix[3] == 2 && matrix[6] == 2 && matrix[9] == 2 ||
                matrix[1] == 2 && matrix[5] == 2 && matrix[9] == 2 ||
                matrix[7] == 2 && matrix[5] == 2 && matrix[3] == 2)
            {
                label_P2.Visible = true;
                end_game = true;
            }

            if (end_game)   //блокируем поле от повторных нажатий по окончанию игры
            {
                Box1.Enabled = false;
                Box2.Enabled = false;
                Box3.Enabled = false;
                Box4.Enabled = false;
                Box5.Enabled = false;
                Box6.Enabled = false;
                Box7.Enabled = false;
                Box8.Enabled = false;
                Box9.Enabled = false;
                label1.Visible = false;
                label_queue.Visible = false;
            }
        }

        public void calc(string Name_object, int m)
        {
            //Используем эту конструкцию для изенения именно того Box'а с которого осуществился переход
            if (comboBox1.SelectedIndex == 0 & queue == 0 || comboBox1.SelectedIndex == 1)
                if (queue == 0) //ход игрока 1
                {
                    queue = 1;
                    matrix[m] = 1;
                    label_queue.Text = Name_P2;
                    Controls[Name_object].Enabled = false;
                    Controls[Name_object].BackgroundImage = new Bitmap(Properties.Resources.Chrest);
                }
                else //ход игрока 2
                {
                    queue = 0;
                    matrix[m] = 2;
                    label_queue.Text = Name_P1;
                    Controls[Name_object].Enabled = false;
                    Controls[Name_object].BackgroundImage = new Bitmap(Properties.Resources.Zero);
                }
            check_game();
        }

        public void move() //Ход бота
        {
            // Просканировать поле, найти пустые ячейки и выписать их в отдельный новосозданный массив
            // узнать длину массива
            // зарандомить ячейку массива ограниченую его длиной
            // вернуть в return значение ячейки массива, что и будет являться ходом бота

            int Bot_motion;
            int[] bot_matrix = new int[10]; //вспомогательная матрица для определения свободных ячеек для хода бота
            int m = 1;
            int count_move = 0;
            for (int i = 1; i < 10; i++) // ищем пустые поля для хода
            {
                if (Program.f1.matrix[i] == 0)
                {
                    bot_matrix[m] = i;
                    m++;
                }
            }
            for (int i = 1; i < 10; i++) // считаем количество свободных ячеек
            {
                if (bot_matrix[i] != 0)
                {
                    count_move++;
                }
                else { break; }
            }
            // делаем случайный ход бота в зависимости от свободных ячеек
            Random rnd = new Random();
            Bot_motion = rnd.Next(1, count_move);
            queue = 0;
            matrix[bot_matrix[Bot_motion]] = 2;
            Bot_move_index = bot_matrix[Bot_motion];
            Bot_box_move = "Box" + Bot_move_index;
            Invoke(new Update_label(change_control_form), Name_P1);
            Invoke(new check_game(to_check));
        }
    }
}