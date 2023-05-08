﻿using System;
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
    public partial class TableTicket : Form
    {
        public TableTicket()
        {
            InitializeComponent();
        }

        private void ticketsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.theareDataSet);

        }

        private void TableTicket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "theareDataSet.Tickets". При необходимости она может быть перемещена или удалена.
            this.ticketsTableAdapter.Fill(this.theareDataSet.Tickets);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ticketsBindingSource.Filter = "Price_Ticket='" + comboBox1.Text + "'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ticketsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < ticketsDataGridView.RowCount - 1; j++)
                {
                    ticketsDataGridView[i, j].Style.BackColor = Color.White;
                    ticketsDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < ticketsDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < ticketsDataGridView.RowCount - 1; j++)
                {
                    if (ticketsDataGridView[i, j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        ticketsDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        ticketsDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ticketsBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
