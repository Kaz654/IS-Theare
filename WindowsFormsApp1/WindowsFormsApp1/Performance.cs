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
    public partial class Performance : Form
    {
        private TablePerformance tablePerformance;
        private Menu menu;
        public Performance()
        {
            InitializeComponent();
        }

        private void actorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theareDataSet);

        }

        private void Performance_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theareDataSet.Performances". При необходимости она может быть перемещена или удалена.
            this.performancesTableAdapter.Fill(this.theareDataSet.Performances);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theareDataSet.Actors". При необходимости она может быть перемещена или удалена.
            this.actorsTableAdapter.Fill(this.theareDataSet.Actors);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            performancesBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            performancesBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.performancesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theareDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tablePerformance = new TablePerformance();
            tablePerformance.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            menu = new Menu();
            menu.Visible = true;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
