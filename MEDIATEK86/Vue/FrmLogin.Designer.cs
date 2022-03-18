
namespace MEDIATEK86.Vue
{
    partial class FrmLogin
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
            this.lblMediatek = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblmdp = new System.Windows.Forms.Label();
            this.btnConnecter1 = new System.Windows.Forms.Button();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxMDP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMediatek
            // 
            this.lblMediatek.AutoSize = true;
            this.lblMediatek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediatek.Location = new System.Drawing.Point(246, 129);
            this.lblMediatek.Name = "lblMediatek";
            this.lblMediatek.Size = new System.Drawing.Size(203, 39);
            this.lblMediatek.TabIndex = 0;
            this.lblMediatek.Text = "Mediatek86";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(86, 275);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(147, 36);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Identifiant";
            this.lblid.Click += new System.EventHandler(this.lblid_Click);
            // 
            // lblmdp
            // 
            this.lblmdp.AutoSize = true;
            this.lblmdp.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmdp.Location = new System.Drawing.Point(86, 422);
            this.lblmdp.Name = "lblmdp";
            this.lblmdp.Size = new System.Drawing.Size(191, 36);
            this.lblmdp.TabIndex = 2;
            this.lblmdp.Text = "Mot de passe";
            // 
            // btnConnecter1
            // 
            this.btnConnecter1.Font = new System.Drawing.Font("Yu Gothic", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnecter1.Location = new System.Drawing.Point(156, 678);
            this.btnConnecter1.Name = "btnConnecter1";
            this.btnConnecter1.Size = new System.Drawing.Size(400, 92);
            this.btnConnecter1.TabIndex = 3;
            this.btnConnecter1.Text = "SE CONNECTER";
            this.btnConnecter1.UseVisualStyleBackColor = true;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(92, 357);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(371, 29);
            this.textBoxID.TabIndex = 4;
            // 
            // textBoxMDP
            // 
            this.textBoxMDP.Location = new System.Drawing.Point(92, 487);
            this.textBoxMDP.Name = "textBoxMDP";
            this.textBoxMDP.Size = new System.Drawing.Size(371, 29);
            this.textBoxMDP.TabIndex = 5;
            this.textBoxMDP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(735, 858);
            this.Controls.Add(this.textBoxMDP);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.btnConnecter1);
            this.Controls.Add(this.lblmdp);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblMediatek);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMediatek;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblmdp;
        private System.Windows.Forms.Button btnConnecter1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxMDP;
    }
}