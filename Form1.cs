using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Model1 db = new Model1();

        private void Form1_Load(object sender, EventArgs e)
        {
            db.lab8.Load();
            lab8BindingSource.DataSource = db.lab8.Local.ToBindingList();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            db.Dispose();
        }

        private void lab8BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
