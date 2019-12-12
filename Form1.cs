using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussines;
namespace ShoesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = new Bussines.BProducts();
            int ID = int.Parse(textBox1.Text);
            var Productos = a.Datos(ID);
            dataGridView1.Rows.Clear();
            foreach (var item in Productos)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Title });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Nombre });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Description });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.Observations });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PriceDistributor });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = item.PriceClient });
                dataGridView1.Rows.Add(row);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
