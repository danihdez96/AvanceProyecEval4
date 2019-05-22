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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        public DataTable dt = new DataTable();
        Mantenimiento mt = new Mantenimiento();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void limpiar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

        }
        public void cargar()
        {

            mt.mostrarProd();
            dataGridView1.DataSource = mt.dt;

        }


        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mt.test());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mt.Id_producto = textBox1.Text;
            mt.Nombre_pro = textBox2.Text;
            mt.insertProd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mt.Id_producto= textBox1.Text;
            mt.Nombre_pro= textBox2.Text;
            mt.updateProd();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mt.Id_producto = textBox1.Text;
            mt.Nombre_pro = textBox2.Text;
            mt.deleteProd();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            limpiar();
            cargar();
        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }
    }
}
