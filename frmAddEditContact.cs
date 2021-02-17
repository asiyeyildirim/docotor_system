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
    public partial class frmAddEditContact : Form
    {

        

        ContactEntities db;
        public frmAddEditContact(Contacts obj)
        {
            InitializeComponent();
            db = new ContactEntities();
            if (obj == null)
            {
                contactsBindingSource.DataSource = new Contacts();
                db.Contacts.Add(contactsBindingSource.Current as Contacts);

            }
            else
            {
                contactsBindingSource.DataSource = obj;
                db.Contacts.Attach(contactsBindingSource.Current as Contacts);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        

        private void frmAddEditContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtAd.Text))
                {
                    MessageBox.Show("Lütfen isminizi girin", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAd.Focus();
                    e.Cancel = true;
                    return;
                }

                db.SaveChanges();
                e.Cancel = false;


            }
            e.Cancel = false;




            

        }

        private void txtYas_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddEditContact_Load(object sender, EventArgs e)
        {

        }

        private void contactsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}