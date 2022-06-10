using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_Forms
{
    public partial class Помощь : Form
    {
        public Помощь()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При активации кнопки в списке по центру экрана выводятся студенты мужского пола с оценками 4+. После снятия галочки список возвращается к начальному виду.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Открывается окно с добавлением студентов в список группы по центру экрана.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сохранение списка находящегося в центре экрана в файл. При добавлении предыдущие данные будут утеряны (Чтобы данные уцелели необходимо открыть их из файла, а после добавлять новых студентов). \nФайл находится по пути: \n" + Data.filename);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выводит данные из файла на экран. Если в списке по центру экрана находятся данные, они будут удалены.");
        }
    }
}
