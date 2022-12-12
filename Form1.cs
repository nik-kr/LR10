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

namespace LR10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./Database.mdb;OLE DB Services=-1";
        private OleDbConnection myConnection;
        private void b_login_Click(object sender, EventArgs e)
        {
            string login = tb_login.Text;
            string password = tb_password.Text;

            myConnection = new OleDbConnection(connectString);
            myConnection.Open();

            string query = "SELECT Права FROM Пользователи WHERE Логин=\"" + login +"\" and Пароль=\"" + password + "\"";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            try {
                string rights = command.ExecuteScalar().ToString();
                var nform = new FLogo();
                nform.rights = rights;
                nform.Show();
                nform.Activate();
                this.Hide();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(Text = "Логин либо Пароль введен не правильно");
            }

        }
    }
}
