using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    static class Program
    {
        public static Form1 f1; //Создаём ссылку на форму для доступа из других классов
        public static Form2 f2;
        public static Form3 f3;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
