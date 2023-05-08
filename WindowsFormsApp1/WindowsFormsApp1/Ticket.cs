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
    public partial class Ticket : Form
    {
        private TableTicket tableTicket;
        private Menu menu;
        public Ticket()
        {
            InitializeComponent();
        }

        private void ticketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theareDataSet);

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theareDataSet.Performances". При необходимости она может быть перемещена или удалена.
            this.performancesTableAdapter.Fill(this.theareDataSet.Performances);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theareDataSet.Tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter.Fill(this.theareDataSet.Tickets);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ticketsBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ticketsBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theareDataSet);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tableTicket = new TableTicket();
            tableTicket.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            menu = new Menu();
            menu.Visible = true;
        }
    }
}
