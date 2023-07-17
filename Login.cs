using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoDeTickets
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public object Messagebox { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "Douglas Dinivio" || password == "1961")
            {
                MessageBox.Show("Seja Bem Vindo " + txtUsername.Text + " Login Feito Com Sucesso!");
                Form1 log = new Form1();
                log.ShowDialog();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Username ou Password Incorretos!");
            }


        }

    }
}
