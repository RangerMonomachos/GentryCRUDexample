using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GentryCRUDexample
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();
        }

        private void HomeBotton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage Home = new HomePage();
            Home.ShowDialog();
            this.Close();
        }

        private void PeopleBotton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PeopleForm people = new PeopleForm();
            people.ShowDialog();
            this.Close();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorksLT2019DataSet.productView' table. You can move, or remove it, as needed.
            this.productViewTableAdapter.Fill(this.adventureWorksLT2019DataSet.productView);

        }
    }
}
