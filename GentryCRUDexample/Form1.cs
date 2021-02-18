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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void ToPeople_Click(object sender, EventArgs e)
        {
            this.Hide();
            PeopleForm people = new PeopleForm();
            people.ShowDialog();
            this.Close();
        }

        private void ToItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemForm Item = new ItemForm();
            Item.ShowDialog();
            this.Close();
        }
    }
}
