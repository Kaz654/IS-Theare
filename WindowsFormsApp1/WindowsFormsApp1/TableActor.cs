using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class TableActor : Form
    {
        public TableActor()
        {
            InitializeComponent();
        }

        private void actorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theareDataSet);

        }

        private void TableActor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theareDataSet.Actors". При необходимости она может быть перемещена или удалена.
            this.actorsTableAdapter.Fill(this.theareDataSet.Actors);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actorsBindingSource.Filter = "FIO_Actor='" + comboBox1.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < actorsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < actorsDataGridView.RowCount - 1; j++)
                {
                    actorsDataGridView[i, j].Style.BackColor = Color.White;
                    actorsDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < actorsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < actorsDataGridView.RowCount - 1; j++)
                {
                    if (actorsDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        actorsDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        actorsDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actorsBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
