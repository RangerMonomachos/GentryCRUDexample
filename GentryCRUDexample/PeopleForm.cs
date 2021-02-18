using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GentryCRUDexample
{
    public partial class PeopleForm : Form
    {
        public PeopleForm()
        {
            InitializeComponent();
        }

        private void ItemBotton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemForm Item = new ItemForm();
            Item.ShowDialog();
            this.Close();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage Home = new HomePage();
            Home.ShowDialog();
            this.Close();
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksLT2019DataSet1.GetCustomers' table. You can move, or remove it, as needed.
            this.getCustomersTableAdapter.Fill(this.adventureWorksLT2019DataSet1.GetCustomers);

        }

        private void InsertUpdate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;
            RowData rd = new RowData(dataGridView1);
            DBProcs.updateRow(rd);

            this.Hide();
            PeopleForm peopleForm = new PeopleForm();
            peopleForm.ShowDialog();
            this.Close();
        }

        private void DeleatBotten_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;
            DBProcs.deleteTheRow(dataGridView1);

            this.Hide();
            PeopleForm peopleForm = new PeopleForm();
            peopleForm.ShowDialog();
            this.Close();
        }
    }
}
