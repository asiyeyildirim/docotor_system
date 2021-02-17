using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doctor_system
{
    public partial class Form1 : Form
    {

        ContactEntities db;

        public Form1()
        {
            InitializeComponent();
        }
        ContactEntities contact = new ContactEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new ContactEntities();
            contactsBindingSource.DataSource = db.Contacts.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmAddEditContact frm = new frmAddEditContact(null))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    contactsBindingSource.DataSource = db.Contacts.ToList();
                  
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (contactsBindingSource.Current == null)
                return;

            using (frmAddEditContact frm = new frmAddEditContact(contactsBindingSource.Current as Contacts))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    contactsBindingSource.DataSource = db.Contacts.ToList();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (contactsBindingSource.Current != null)
            { 
                if(MessageBox.Show("Kaydı silmek istediğinize emin misiniz?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Contacts.Remove(contactsBindingSource.Current as Contacts);
                    contactsBindingSource.RemoveCurrent();
                    db.SaveChanges();

                }

            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
