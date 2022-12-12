using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;

namespace LR10
{
    public partial class Form2 : Form
    {
        Bitmap memoryImage;
        public Form2()
        {
            InitializeComponent();
        }

        public string rights;


        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet2.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.databaseDataSet2.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet1.Студенты". При необходимости она может быть перемещена или удалена.
            this.студентыTableAdapter.Fill(this.databaseDataSet1.Студенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Преподаватели". При необходимости она может быть перемещена или удалена.
            this.преподавателиTableAdapter.Fill(this.databaseDataSet.Преподаватели);
            if (rights == "edit")
            {
                MessageBox.Show(Text = "Вы вошли как Редактор");
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);

            }
            else if (rights == "all")
            {
                MessageBox.Show(Text = "Вы вошли как Admin");
            }

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void сохранитьИзмененияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.преподавателиBindingSource.EndEdit();
            this.студентыBindingSource.EndEdit();
            this.пользователиBindingSource.EndEdit();

            this.преподавателиTableAdapter.Update(databaseDataSet.Преподаватели);
            this.студентыTableAdapter.Update(databaseDataSet1.Студенты);
            this.пользователиTableAdapter.Update(databaseDataSet2.Пользователи);
        }

        private void сохранитьИВыйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Validate();

            this.преподавателиBindingSource.EndEdit();
            this.студентыBindingSource.EndEdit();
            this.пользователиBindingSource.EndEdit();

            this.преподавателиTableAdapter.Update(databaseDataSet.Преподаватели);
            this.студентыTableAdapter.Update(databaseDataSet1.Студенты);
            this.пользователиTableAdapter.Update(databaseDataSet2.Пользователи);

            Application.Exit();
            
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void выйтиБезСохраненияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutform = new AboutForm();
            aboutform.Show();
            aboutform.Activate();
        }
        
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);


            PrintDocument pd = new PrintDocument();
            pd.PrintPage += PrintPage;
            pd.Print();
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }
        private void PrintPage(object o, PrintPageEventArgs e)
        {
            System.Drawing.Image img = memoryImage;
            Point loc = new Point(0, 0);
            e.Graphics.DrawImage(img, loc);
        }
    }
}