using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSistem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario, password;
            usuario = textLogin.Text;
            password = textPassword.Text;

            if (usuario == "admin" && password == "ad789")
            {
                MessageBox.Show("Bienvenido al sistema ADMIN");

            }
            else if ((usuario == "other_user") && (password == "ou123"))
            {
                MessageBox.Show("Bienvenido al sistema Otro Usuario");


            }
            else if (usuario == "propietario" && password == "propie456")
            {
                MessageBox.Show("Bienvenido al sistema PROPIETARIO");

            }
            
            if ((usuario == "admin" && password == "ad789")|| (usuario == "other_user" && password == "ou123")||(usuario == "propietario" && password == "propie456"))
            {
                Stock st = new Stock();
                st.Show();
            }
            else
            {
                Application.Exit();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
