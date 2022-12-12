using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR10
{
    public partial class FLogo : Form
    {
        public FLogo()
        {
            InitializeComponent();
        }

        private void FLogo_Load(object sender, EventArgs e)
        {
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;
            this.TransparencyKey = this.BackColor;
        }
        public string rights = "edit";
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            var form2 = new Form2();
            form2.rights = rights;
            form2.Show();
            form2.Activate();
            this.Hide();
        }
    }
}
