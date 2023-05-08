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
    public partial class Actor : Form
    {
        private TableActor tableActor;
        private Menu menu;
        public Actor()
        {
            InitializeComponent();
        }

        private void actorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theareDataSet);

        }

        private void Actor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theareDataSet.Actors". При необходимости она может быть перемещена или удалена.
            this.actorsTableAdapter.Fill(this.theareDataSet.Actors);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actorsBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actorsBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.actorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theareDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableActor = new TableActor();
            tableActor.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            menu = new Menu();
            menu.Visible = true;
        }
    }
}
