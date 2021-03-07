using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnVoc
{
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(text_ID.Text == "root"&&text_password.Text=="root")
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("帳號密碼錯誤!");
            }
        }
    }
}
