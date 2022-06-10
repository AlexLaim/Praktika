using System;
using System.Windows.Forms;

namespace Praktika_Forms
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Sex.SelectedIndex == 0 & Data.male <5)
            {
                Data.male++;
            }else if (Sex.SelectedIndex == 1 & Data.female < 5)
            {
                Data.female++;
            }
            
            if (textBox1.Text != string.Empty & textBox2.Text != string.Empty & textBox3.Text != string.Empty)
            {
                if (!string.IsNullOrEmpty(Sex.Text) & !string.IsNullOrEmpty(Rus.Text) & !string.IsNullOrEmpty(Mat.Text) & !string.IsNullOrEmpty(Fiz.Text) & !string.IsNullOrEmpty(Eng.Text) & !string.IsNullOrEmpty(Inf.Text))
                {
                    if (Data.Edit == false)
                    {         
                        Data.list.Add(new string[] { textBox1.Text, textBox3.Text, textBox2.Text, dateTimePicker1.Text, Sex.Text, Rus.Text, Inf.Text, Eng.Text, Mat.Text, Fiz.Text });
                        this.Close();
                    }else if(Data.Edit == true)
                    {
                        foreach (var row in Data.list)
                        {
                            if (row[0] == Data.Item)
                            {
                                int index = Data.list.IndexOf(row);
                                Data.list[index]=(new string[] { textBox1.Text, textBox3.Text, textBox2.Text, dateTimePicker1.Text, Sex.Text, Rus.Text, Inf.Text, Eng.Text, Mat.Text, Fiz.Text });
                                Data.Edit = false;
                                break;

                            }
                        }
                        this.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Введите все необходимые данные!");
                }
            }
            else
            {
                MessageBox.Show("Заполните ФИО!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsLetter(number) && number != 8)
            {
                e.Handled = true;
            }
        }
    }
}
