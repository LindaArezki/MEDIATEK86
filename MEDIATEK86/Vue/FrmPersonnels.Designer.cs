
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtTEL = new System.Windows.Forms.TextBox();
            this.cmbxServices = new System.Windows.Forms.ComboBox();
            this.LlbTEL = new System.Windows.Forms.Label();
            this.lblServices = new System.Windows.Forms.Label();
            this.bttnModifier = new System.Windows.Forms.Button();
            this.bttnajoutperso = new System.Windows.Forms.Button();
            this.bttnSupp = new System.Windows.Forms.Button();
            this.BttnVoirabsence = new System.Windows.Forms.Button();
            this.dgvPersonnels = new System.Windows.Forms.DataGridView();
            this.lblPrénom = new System.Windows.Forms.Label();
            this.txtPrénom = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.lblNOM = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEMAIL = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtTEL);
            this.panel2.Controls.Add(this.cmbxServices);
            this.panel2.Controls.Add(this.LlbTEL);
            this.panel2.Controls.Add(this.lblServices);
            this.panel2.Controls.Add(this.bttnModifier);
            this.panel2.Controls.Add(this.bttnajoutperso);
            this.panel2.Controls.Add(this.bttnSupp);
            this.panel2.Controls.Add(this.BttnVoirabsence);
            this.panel2.Controls.Add(this.dgvPersonnels);
            this.panel2.Controls.Add(this.lblPrénom);
            this.panel2.Controls.Add(this.txtPrénom);
            this.panel2.Controls.Add(this.TxtNom);
            this.panel2.Controls.Add(this.lblNOM);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.lblEMAIL);
            this.panel2.Location = new System.Drawing.Point(0, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1824, 881);
            this.panel2.TabIndex = 1;
            // 
            // TxtTEL
            // 
            this.TxtTEL.Location = new System.Drawing.Point(807, 46);
            this.TxtTEL.Name = "TxtTEL";
            this.TxtTEL.Size = new System.Drawing.Size(207, 29);
            this.TxtTEL.TabIndex = 7;
            // 
            // cmbxServices
            // 
            this.cmbxServices.FormattingEnabled = true;
            this.cmbxServices.Location = new System.Drawing.Point(1116, 46);
            this.cmbxServices.Name = "cmbxServices";
            this.cmbxServices.Size = new System.Drawing.Size(238, 32);
            this.cmbxServices.TabIndex = 9;
            // 
            // LlbTEL
            // 
            this.LlbTEL.AutoSize = true;
            this.LlbTEL.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LlbTEL.Location = new System.Drawing.Point(801, 9);
            this.LlbTEL.Name = "LlbTEL";
            this.LlbTEL.Size = new System.Drawing.Size(153, 34);
            this.LlbTEL.TabIndex = 2;
            this.LlbTEL.Text = "Téléphone";
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServices.Location = new System.Drawing.Point(1110, 8);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(123, 34);
            this.lblServices.TabIndex = 4;
            this.lblServices.Text = "Services";
            // 
            // bttnModifier
            // 
            this.bttnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnModifier.Location = new System.Drawing.Point(14, 772);
            this.bttnModifier.Name = "bttnModifier";
            this.bttnModifier.Size = new System.Drawing.Size(267, 67);
            this.bttnModifier.TabIndex = 10;
            this.bttnModifier.Text = "MODIFIER UN PERSONNEL";
            this.bttnModifier.UseVisualStyleBackColor = true;
            this.bttnModifier.Click += new System.EventHandler(this.bttnModifier_Click);
            // 
            // bttnajoutperso
            // 
            this.bttnajoutperso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnajoutperso.Location = new System.Drawing.Point(315, 766);
            this.bttnajoutperso.Name = "bttnajoutperso";
            this.bttnajoutperso.Size = new System.Drawing.Size(289, 73);
            this.bttnajoutperso.TabIndex = 11;
            this.bttnajoutperso.Text = "AJOUTER UN PERSONNEL";
            this.bttnajoutperso.UseVisualStyleBackColor = true;
            this.bttnajoutperso.Click += new System.EventHandler(this.bttnajoutperso_Click);
            // 
            // bttnSupp
            // 
            this.bttnSupp.BackColor = System.Drawing.Color.LavenderBlush;
            this.bttnSupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSupp.Location = new System.Drawing.Point(652, 767);
            this.bttnSupp.Name = "bttnSupp";
            this.bttnSupp.Size = new System.Drawing.Size(341, 72);
            this.bttnSupp.TabIndex = 12;
            this.bttnSupp.Text = "SUPPRIMER UN PERSONNEL";
            this.bttnSupp.UseVisualStyleBackColor = false;
            this.bttnSupp.Click += new System.EventHandler(this.bttnSupp_Click);
            // 
            // BttnVoirabsence
            // 
            this.BttnVoirabsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnVoirabsence.Location = new System.Drawing.Point(1047, 767);
            this.BttnVoirabsence.Name = "BttnVoirabsence";
            this.BttnVoirabsence.Size = new System.Drawing.Size(622, 81);
            this.BttnVoirabsence.TabIndex = 13;
            this.BttnVoirabsence.Text = "VOIR LES ABSENCES";
            this.BttnVoirabsence.UseVisualStyleBackColor = true;
            this.BttnVoirabsence.Click += new System.EventHandler(this.BttnVoirabsence_Click);
            // 
            // dgvPersonnels
            // 
            this.dgvPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnels.Location = new System.Drawing.Point(14, 98);
            this.dgvPersonnels.Name = "dgvPersonnels";
            this.dgvPersonnels.RowHeadersWidth = 72;
            this.dgvPersonnels.RowTemplate.Height = 31;
            this.dgvPersonnels.Size = new System.Drawing.Size(1725, 654);
            this.dgvPersonnels.TabIndex = 0;
          
            // 
            // lblPrénom
            // 
            this.lblPrénom.AutoSize = true;
            this.lblPrénom.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrénom.Location = new System.Drawing.Point(249, 8);
            this.lblPrénom.Name = "lblPrénom";
            this.lblPrénom.Size = new System.Drawing.Size(117, 34);
            this.lblPrénom.TabIndex = 1;
            this.lblPrénom.Text = "Prénom";
            // 
            // txtPrénom
            // 
            this.txtPrénom.Location = new System.Drawing.Point(255, 46);
            this.txtPrénom.Name = "txtPrénom";
            this.txtPrénom.Size = new System.Drawing.Size(223, 29);
            this.txtPrénom.TabIndex = 6;
            // 
            // TxtNom
            // 
            this.TxtNom.Location = new System.Drawing.Point(14, 46);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(198, 29);
            this.TxtNom.TabIndex = 5;
            // 
            // lblNOM
            // 
            this.lblNOM.AutoSize = true;
            this.lblNOM.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNOM.Location = new System.Drawing.Point(12, 9);
            this.lblNOM.Name = "lblNOM";
            this.lblNOM.Size = new System.Drawing.Size(79, 34);
            this.lblNOM.TabIndex = 0;
            this.lblNOM.Text = "Nom";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(517, 46);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 29);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEMAIL
            // 
            this.lblEMAIL.AutoSize = true;
            this.lblEMAIL.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEMAIL.Location = new System.Drawing.Point(524, 0);
            this.lblEMAIL.Name = "lblEMAIL";
            this.lblEMAIL.Size = new System.Drawing.Size(103, 34);
            this.lblEMAIL.TabIndex = 3;
            this.lblEMAIL.Text = "E-mail";
            // 
            // FrmPersonnels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1946, 912);
            this.Controls.Add(this.panel2);
            this.Name = "FrmPersonnels";
            this.Text = "FrmPersonnels";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPersonnels;
        private System.Windows.Forms.TextBox TxtTEL;
        private System.Windows.Forms.ComboBox cmbxServices;
        private System.Windows.Forms.Label LlbTEL;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Button bttnModifier;
        private System.Windows.Forms.Button bttnajoutperso;
        private System.Windows.Forms.Button bttnSupp;
        private System.Windows.Forms.Button BttnVoirabsence;
        private System.Windows.Forms.Label lblPrénom;
        private System.Windows.Forms.TextBox txtPrénom;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label lblNOM;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEMAIL;
    }
}