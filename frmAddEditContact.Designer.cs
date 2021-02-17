
namespace doctor_system
{
    partial class frmAddEditContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lbl_Ad = new System.Windows.Forms.Label();
            this.Branş = new System.Windows.Forms.Label();
            this.Clinic = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.Label();
            this.Soyad = new System.Windows.Forms.Label();
            this.Yaş = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtBranş = new System.Windows.Forms.TextBox();
            this.txtYaş = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtClinic = new System.Windows.Forms.TextBox();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnKaydet.Location = new System.Drawing.Point(195, 251);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(88, 31);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "&Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // lbl_Ad
            // 
            this.lbl_Ad.AutoSize = true;
            this.lbl_Ad.Location = new System.Drawing.Point(33, 38);
            this.lbl_Ad.Name = "lbl_Ad";
            this.lbl_Ad.Size = new System.Drawing.Size(25, 17);
            this.lbl_Ad.TabIndex = 0;
            this.lbl_Ad.Text = "Ad";
            // 
            // Branş
            // 
            this.Branş.AutoSize = true;
            this.Branş.Location = new System.Drawing.Point(29, 186);
            this.Branş.Name = "Branş";
            this.Branş.Size = new System.Drawing.Size(45, 17);
            this.Branş.TabIndex = 0;
            this.Branş.Text = "Branş";
            // 
            // Clinic
            // 
            this.Clinic.AutoSize = true;
            this.Clinic.Location = new System.Drawing.Point(29, 153);
            this.Clinic.Name = "Clinic";
            this.Clinic.Size = new System.Drawing.Size(41, 17);
            this.Clinic.TabIndex = 0;
            this.Clinic.Text = "Clinic";
            this.Clinic.Click += new System.EventHandler(this.label3_Click);
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Location = new System.Drawing.Point(29, 94);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(45, 17);
            this.Adres.TabIndex = 0;
            this.Adres.Text = "Adres";
            this.Adres.Click += new System.EventHandler(this.label4_Click);
            // 
            // Soyad
            // 
            this.Soyad.AutoSize = true;
            this.Soyad.Location = new System.Drawing.Point(33, 66);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(48, 17);
            this.Soyad.TabIndex = 0;
            this.Soyad.Text = "Soyad";
            this.Soyad.Click += new System.EventHandler(this.label5_Click);
            // 
            // Yaş
            // 
            this.Yaş.AutoSize = true;
            this.Yaş.Location = new System.Drawing.Point(29, 217);
            this.Yaş.Name = "Yaş";
            this.Yaş.Size = new System.Drawing.Size(32, 17);
            this.Yaş.TabIndex = 0;
            this.Yaş.Text = "Yaş";
            // 
            // txtAd
            // 
            this.txtAd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Ad", true));
            this.txtAd.Location = new System.Drawing.Point(112, 38);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 1;
            // 
            // txtBranş
            // 
            this.txtBranş.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Branş", true));
            this.txtBranş.Location = new System.Drawing.Point(112, 181);
            this.txtBranş.Name = "txtBranş";
            this.txtBranş.Size = new System.Drawing.Size(100, 22);
            this.txtBranş.TabIndex = 5;
            // 
            // txtYaş
            // 
            this.txtYaş.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Yaş", true));
            this.txtYaş.Location = new System.Drawing.Point(112, 214);
            this.txtYaş.Name = "txtYaş";
            this.txtYaş.Size = new System.Drawing.Size(100, 22);
            this.txtYaş.TabIndex = 6;
            this.txtYaş.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtAdres
            // 
            this.txtAdres.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Adres", true));
            this.txtAdres.Location = new System.Drawing.Point(112, 89);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(310, 53);
            this.txtAdres.TabIndex = 3;
            // 
            // txtSoyad
            // 
            this.txtSoyad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Soyad", true));
            this.txtSoyad.Location = new System.Drawing.Point(112, 63);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtClinic
            // 
            this.txtClinic.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Clinic", true));
            this.txtClinic.Location = new System.Drawing.Point(112, 148);
            this.txtClinic.Name = "txtClinic";
            this.txtClinic.Size = new System.Drawing.Size(100, 22);
            this.txtClinic.TabIndex = 4;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataSource = typeof(doctor_system.Contacts);
            this.contactsBindingSource.Filter = "";
            this.contactsBindingSource.CurrentChanged += new System.EventHandler(this.contactsBindingSource_CurrentChanged);
            // 
            // frmAddEditContact
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 294);
            this.Controls.Add(this.txtClinic);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtYaş);
            this.Controls.Add(this.txtBranş);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.Yaş);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.Clinic);
            this.Controls.Add(this.Branş);
            this.Controls.Add(this.lbl_Ad);
            this.Controls.Add(this.btnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddEditContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add/Edit Contact";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddEditContact_FormClosing);
            this.Load += new System.EventHandler(this.frmAddEditContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lbl_Ad;
        private System.Windows.Forms.Label Branş;
        private System.Windows.Forms.Label Clinic;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.Label Soyad;
        private System.Windows.Forms.Label Yaş;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtBranş;
        private System.Windows.Forms.TextBox txtYaş;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtClinic;
    }
}