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
    public partial class Menu : Form
    {
        private Performance performance;
        private Actor actor;
        private Structure structure;
        private Ticket ticket;
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            performance = new Performance();
            performance.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actor = new Actor();
            actor.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            structure = new Structure();
            structure.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ticket = new Ticket();
            ticket.Visible = true;
        }
    }
}
