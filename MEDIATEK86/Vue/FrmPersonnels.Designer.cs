
namespace MEDIATEK86.Vue
{
    /// <summary>
    /// Classe pour la page du personnel
    /// </summary>
    partial class FrmPersonnels
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNOM = new System.Windows.Forms.Label();
            this.lblPrénom = new System.Windows.Forms.Label();
            this.LlbTEL = new System.Windows.Forms.Label();
            this.lblEMAIL = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.txtPrénom = new System.Windows.Forms.TextBox();
            this.TxtTEL = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cmbxServices = new System.Windows.Forms.ComboBox();
            this.bttnModifier = new System.Windows.Forms.Button();
            this.bttnajoutperso = new System.Windows.Forms.Button();
            this.bttnSupp = new System.Windows.Forms.Button();
            this.BttnVoirabsence = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BttnVoirabsence);
            this.panel1.Controls.Add(this.bttnSupp);
            this.panel1.Controls.Add(this.bttnajoutperso);
            this.panel1.Controls.Add(this.bttnModifier);
            this.panel1.Controls.Add(this.cmbxServices);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.TxtTEL);
            this.panel1.Controls.Add(this.txtPrénom);
            this.panel1.Controls.Add(this.TxtNom);
            this.panel1.Controls.Add(this.lblServices);
            this.panel1.Controls.Add(this.lblEMAIL);
            this.panel1.Controls.Add(this.LlbTEL);
            this.panel1.Controls.Add(this.lblPrénom);
            this.panel1.Controls.Add(this.lblNOM);
            this.panel1.Location = new System.Drawing.Point(3, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 880);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(587, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1157, 866);
            this.panel2.TabIndex = 1;
            // 
            // lblNOM
            // 
            this.lblNOM.AutoSize = true;
            this.lblNOM.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOM.Location = new System.Drawing.Point(45, 56);
            this.lblNOM.Name = "lblNOM";
            this.lblNOM.Size = new System.Drawing.Size(79, 34);
            this.lblNOM.TabIndex = 0;
            this.lblNOM.Text = "Nom";
            this.lblNOM.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrénom
            // 
            this.lblPrénom.AutoSize = true;
            this.lblPrénom.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrénom.Location = new System.Drawing.Point(410, 56);
            this.lblPrénom.Name = "lblPrénom";
            this.lblPrénom.Size = new System.Drawing.Size(117, 34);
            this.lblPrénom.TabIndex = 1;
            this.lblPrénom.Text = "Prénom";
            // 
            // LlbTEL
            // 
            this.LlbTEL.AutoSize = true;
            this.LlbTEL.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlbTEL.Location = new System.Drawing.Point(44, 176);
            this.LlbTEL.Name = "LlbTEL";
            this.LlbTEL.Size = new System.Drawing.Size(153, 34);
            this.LlbTEL.TabIndex = 2;
            this.LlbTEL.Text = "Téléphone";
            // 
            // lblEMAIL
            // 
            this.lblEMAIL.AutoSize = true;
            this.lblEMAIL.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMAIL.Location = new System.Drawing.Point(424, 175);
            this.lblEMAIL.Name = "lblEMAIL";
            this.lblEMAIL.Size = new System.Drawing.Size(103, 34);
            this.lblEMAIL.TabIndex = 3;
            this.lblEMAIL.Text = "E-mail";
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(214, 295);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(123, 34);
            this.lblServices.TabIndex = 4;
            this.lblServices.Text = "Services";
            this.lblServices.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(50, 104);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(198, 29);
            this.TxtNom.TabIndex = 5;
            this.TxtNom.TextChanged += new System.EventHandler(this.TxtNom_TextChanged);
            // 
            // txtPrénom
            // 
            this.txtPrénom.Location = new System.Drawing.Point(304, 104);
            this.txtPrénom.Name = "txtPrénom";
            this.txtPrénom.Size = new System.Drawing.Size(223, 29);
            this.txtPrénom.TabIndex = 6;
            // 
            // TxtTEL
            // 
            this.TxtTEL.Location = new System.Drawing.Point(50, 226);
            this.TxtTEL.Name = "TxtTEL";
            this.TxtTEL.Size = new System.Drawing.Size(207, 29);
            this.TxtTEL.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(304, 226);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 29);
            this.txtEmail.TabIndex = 8;
            // 
            // cmbxServices
            // 
            this.cmbxServices.FormattingEnabled = true;
            this.cmbxServices.Location = new System.Drawing.Point(157, 343);
            this.cmbxServices.Name = "cmbxServices";
            this.cmbxServices.Size = new System.Drawing.Size(238, 32);
            this.cmbxServices.TabIndex = 9;
            // 
            // bttnModifier
            // 
            this.bttnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnModifier.Location = new System.Drawing.Point(122, 452);
            this.bttnModifier.Name = "bttnModifier";
            this.bttnModifier.Size = new System.Drawing.Size(341, 67);
            this.bttnModifier.TabIndex = 10;
            this.bttnModifier.Text = "MODIFIER UN PERSONNEL";
            this.bttnModifier.UseVisualStyleBackColor = true;
            // 
            // bttnajoutperso
            // 
            this.bttnajoutperso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnajoutperso.Location = new System.Drawing.Point(122, 551);
            this.bttnajoutperso.Name = "bttnajoutperso";
            this.bttnajoutperso.Size = new System.Drawing.Size(341, 63);
            this.bttnajoutperso.TabIndex = 11;
            this.bttnajoutperso.Text = "AJOUTER UN PERSONNEL";
            this.bttnajoutperso.UseVisualStyleBackColor = true;
            // 
            // bttnSupp
            // 
            this.bttnSupp.BackColor = System.Drawing.Color.LavenderBlush;
            this.bttnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSupp.Location = new System.Drawing.Point(122, 642);
            this.bttnSupp.Name = "bttnSupp";
            this.bttnSupp.Size = new System.Drawing.Size(341, 66);
            this.bttnSupp.TabIndex = 12;
            this.bttnSupp.Text = "SUPPRIMER UN PERSONNEL";
            this.bttnSupp.UseVisualStyleBackColor = false;
            // 
            // BttnVoirabsence
            // 
            this.BttnVoirabsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnVoirabsence.Location = new System.Drawing.Point(25, 764);
            this.BttnVoirabsence.Name = "BttnVoirabsence";
            this.BttnVoirabsence.Size = new System.Drawing.Size(532, 89);
            this.BttnVoirabsence.TabIndex = 13;
            this.BttnVoirabsence.Text = "VOIR LES ABSENCES";
            this.BttnVoirabsence.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 833);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmPersonnels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1751, 890);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPersonnels";
            this.Text = "FrmPersonnels";
            this.Load += new System.EventHandler(this.FrmPersonnels_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BttnVoirabsence;
        private System.Windows.Forms.Button bttnSupp;
        private System.Windows.Forms.Button bttnajoutperso;
        private System.Windows.Forms.Button bttnModifier;
        private System.Windows.Forms.ComboBox cmbxServices;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox TxtTEL;
        private System.Windows.Forms.TextBox txtPrénom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Label lblEMAIL;
        private System.Windows.Forms.Label LlbTEL;
        private System.Windows.Forms.Label lblPrénom;
        private System.Windows.Forms.Label lblNOM;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}