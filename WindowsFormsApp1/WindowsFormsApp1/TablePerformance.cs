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
    public partial class TablePerformance : Form
    {
        public TablePerformance()
        {
            InitializeComponent();
        }

        private void performancesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.performancesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theareDataSet);

        }

        private void TablePerformance_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theareDataSet.Performances". При необходимости она может быть перемещена или удалена.
            this.performancesTableAdapter.Fill(this.theareDataSet.Performances);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            performancesBindingSource.Filter = "Name_Performance='" + comboBox1.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < performancesDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < performancesDataGridView.RowCount - 1; j++)
                {
                    performancesDataGridView[i, j].Style.BackColor = Color.White;
                    performancesDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < performancesDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < performancesDataGridView.RowCount - 1; j++)
                {
                    if (performancesDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        performancesDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        performancesDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            performancesBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
