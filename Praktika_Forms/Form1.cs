using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Praktika_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void RefreshList(List<string[]> list)
        {
            listView1.Items.Clear();
            foreach (string[] s in list)
            {
                listView1.Items.Add(new ListViewItem(s));
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Data.list.Count < 10 & (Data.male + Data.female) != 10)
            {
                MessageBox.Show("Группа должна состоять не менее чем из 10 человек (не менее 5 мальчиков и 5 девочек)!");
            }
            else
            {
                using (StreamWriter streamwriter = new StreamWriter(Data.filename, false))
                {
                    for (int i = 0; i < Data.list.Count; i++)
                    {
                        string action = string.Join(" ", Data.list[i]);
                        streamwriter.WriteLine(action + " ");
                    }
                }
                MessageBox.Show(
                "Данные успешно сохранены!",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddForm form3 = new AddForm();
            form3.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            RefreshList(Data.list);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var row in Data.list)
                {
                    if (row[0] == listView1.FocusedItem.Text)
                    {
                        if(row[4]== "М")
                        {
                            Data.male--;
                        }else if(row[4] == "Ж")
                        {
                            Data.female--;
                        }
                        int index = Data.list.IndexOf(row);
                        Data.RemoveItem = index;
                        break;
                    }
                }               
                Data.list.RemoveAt(Data.RemoveItem);
                RefreshList(Data.list);
            }
            catch
            {

            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (listView1.FocusedItem.Bounds.Contains(e.Location))
                    {
                        contextMenuStrip1.Show(Cursor.Position);
                        Data.Item = listView1.FocusedItem.Text;
                    }
                }
            }
            catch
            {

            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Edit = true;
            AddForm form3 = new AddForm();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Data.list.Clear();
            using (StreamReader streamreader = new StreamReader(File.Open(Data.filename, FileMode.OpenOrCreate)))
            {
                while (streamreader.Peek() > -1)
                {
                    Data.list.Add(streamreader.ReadLine().Split());
                }
            }
            RefreshList(Data.list);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Data.grants.Clear();
                foreach (string[] row in Data.list)
                {
                    if (int.Parse(row[5]) >= 4& int.Parse(row[6]) >= 4 & int.Parse(row[7]) >= 4 & int.Parse(row[8]) >= 4 & int.Parse(row[9]) >= 4 & row[4] == "М")
                    {
                        Data.grants.Add(row);
                    }
                }
                RefreshList(Data.grants);               
            }
            else
            {
                RefreshList(Data.list);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Помощь form3 = new Помощь();
            form3.ShowDialog();
        }
    }
}
