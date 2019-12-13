using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesApp
{
    public partial class Insertar : Form
    {
        public Insertar()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var CEntities = new Entities.Productos();
            Productos adProc = new Productos();
            adProc.IdType = int.Parse(numericUpDown1.Text);
            adProc.IdColor = int.Parse(numericUpDown5.Text);
            adProc.IdBrand = int.Parse(numericUpDown2.Text);
            adProc.IdProvider = int.Parse(numericUpDown3.Text);
            adProc.IdCatalog = int.Parse(numericUpDown4.Text);
            adProc.Title = textBox1.Text;
            adProc.Nombre = textBox7.Text;
            adProc.Description = textBox6.Text;
            adProc.Observations = textBox5.Text;
            adProc.PriceDistributor = Decimal.Parse(textBox3.Text);
            adProc.PriceClient = Decimal.Parse(textBox4.Text);
            adProc.PriceMember = Decimal.Parse(textBox2.Text);
            adProc.IsEnabled = bool.Parse(textBox9.Text);
            
            adProc.Keywords = textBox8.Text;
            adProc.DateUpdate = Convert.ToDateTime(dateTimePicker1.Text);
            var buss = new Bussines.BProducts();
            buss.Insertar(adProc);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
