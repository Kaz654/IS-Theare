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
    public partial class TableStructure : Form
    {
        public TableStructure()
        {
            InitializeComponent();
        }

        private void structurePerformanceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.structurePerformanceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theareDataSet);

        }

        private void TableStructure_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theareDataSet.StructurePerformance". При необходимости она может быть перемещена или удалена.
            this.structurePerformanceTableAdapter.Fill(this.theareDataSet.StructurePerformance);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            structurePerformanceBindingSource.Filter = "Role_Structure='" + comboBox1.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < structurePerformanceDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < structurePerformanceDataGridView.RowCount - 1; j++)
                {
                    structurePerformanceDataGridView[i, j].Style.BackColor = Color.White;
                    structurePerformanceDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < structurePerformanceDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < structurePerformanceDataGridView.RowCount - 1; j++)
                {
                    if (structurePerformanceDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        structurePerformanceDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        structurePerformanceDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            structurePerformanceBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
