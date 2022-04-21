
namespace MEDIATEK86.Vue
{
    /// <summary>
    /// Classe pour la page des absences
    /// </summary>
    partial class Frmabsence
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bttnretour = new System.Windows.Forms.Button();
            this.bttnSupp1 = new System.Windows.Forms.Button();
            this.bttnAjout1 = new System.Windows.Forms.Button();
            this.bttnmodif1 = new System.Windows.Forms.Button();
            this.cmbxmotifs = new System.Windows.Forms.ComboBox();
            this.lblMotifs = new System.Windows.Forms.Label();
            this.lbldatefin = new System.Windows.Forms.Label();
            this.lbldebutabs = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(646, 55);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(400, 29);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(431, 29);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 15, 9, 44, 0, 0);
            // 
            // bttnretour
            // 
            this.bttnretour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnretour.Location = new System.Drawing.Point(63, 782);
            this.bttnretour.Name = "bttnretour";
            this.bttnretour.Size = new System.Drawing.Size(401, 81);
            this.bttnretour.TabIndex = 13;
            this.bttnretour.Text = "RETOUR AUX PERSONNELS";
            this.bttnretour.UseVisualStyleBackColor = true;
            this.bttnretour.Click += new System.EventHandler(this.Bttnretour_Click);
            // 
            // bttnSupp1
            // 
            this.bttnSupp1.BackColor = System.Drawing.Color.LavenderBlush;
            this.bttnSupp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSupp1.Location = new System.Drawing.Point(1336, 789);
            this.bttnSupp1.Name = "bttnSupp1";
            this.bttnSupp1.Size = new System.Drawing.Size(352, 68);
            this.bttnSupp1.TabIndex = 12;
            this.bttnSupp1.Text = "SUPPRIMER UNE ABSENCE";
            this.bttnSupp1.UseVisualStyleBackColor = false;
            this.bttnSupp1.Click += new System.EventHandler(this.BttnSupp1_Click);
            // 
            // bttnAjout1
            // 
            this.bttnAjout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAjout1.Location = new System.Drawing.Point(943, 789);
            this.bttnAjout1.Name = "bttnAjout1";
            this.bttnAjout1.Size = new System.Drawing.Size(352, 68);
            this.bttnAjout1.TabIndex = 11;
            this.bttnAjout1.Text = "AJOUTER UNE ABSENCE";
            this.bttnAjout1.UseVisualStyleBackColor = true;
            this.bttnAjout1.Click += new System.EventHandler(this.BttnAjout1_Click);
            // 
            // bttnmodif1
            // 
            this.bttnmodif1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnmodif1.Location = new System.Drawing.Point(545, 789);
            this.bttnmodif1.Name = "bttnmodif1";
            this.bttnmodif1.Size = new System.Drawing.Size(352, 69);
            this.bttnmodif1.TabIndex = 10;
            this.bttnmodif1.Text = "MODIFIER UNE ABSENCE";
            this.bttnmodif1.UseVisualStyleBackColor = true;
            this.bttnmodif1.Click += new System.EventHandler(this.Bttnmodif1_Click);
            // 
            // cmbxmotifs
            // 
            this.cmbxmotifs.FormattingEnabled = true;
            this.cmbxmotifs.Location = new System.Drawing.Point(1216, 56);
            this.cmbxmotifs.Name = "cmbxmotifs";
            this.cmbxmotifs.Size = new System.Drawing.Size(256, 32);
            this.cmbxmotifs.TabIndex = 9;
            // 
            // lblMotifs
            // 
            this.lblMotifs.AutoSize = true;
            this.lblMotifs.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotifs.Location = new System.Drawing.Point(1210, 10);
            this.lblMotifs.Name = "lblMotifs";
            this.lblMotifs.Size = new System.Drawing.Size(98, 34);
            this.lblMotifs.TabIndex = 4;
            this.lblMotifs.Text = "Motifs";
            // 
            // lbldatefin
            // 
            this.lbldatefin.AutoSize = true;
            this.lbldatefin.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatefin.Location = new System.Drawing.Point(687, 10);
            this.lbldatefin.Name = "lbldatefin";
            this.lbldatefin.Size = new System.Drawing.Size(297, 34);
            this.lbldatefin.TabIndex = 3;
            this.lbldatefin.Text = "Date fin de l\'absence";
            // 
            // lbldebutabs
            // 
            this.lbldebutabs.AutoSize = true;
            this.lbldebutabs.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldebutabs.Location = new System.Drawing.Point(123, 10);
            this.lbldebutabs.Name = "lbldebutabs";
            this.lbldebutabs.Size = new System.Drawing.Size(341, 34);
            this.lbldebutabs.TabIndex = 2;
            this.lbldebutabs.Text = "Date début de l\'absence";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bttnretour);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.bttnSupp1);
            this.panel2.Controls.Add(this.dgvAbsences);
            this.panel2.Controls.Add(this.bttnmodif1);
            this.panel2.Controls.Add(this.bttnAjout1);
            this.panel2.Controls.Add(this.lblMotifs);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.cmbxmotifs);
            this.panel2.Controls.Add(this.lbldatefin);
            this.panel2.Controls.Add(this.lbldebutabs);
            this.panel2.Location = new System.Drawing.Point(-4, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1758, 903);
            this.panel2.TabIndex = 1;
           
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(43, 106);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.RowHeadersWidth = 72;
            this.dgvAbsences.RowTemplate.Height = 31;
            this.dgvAbsences.Size = new System.Drawing.Size(1645, 635);
            this.dgvAbsences.TabIndex = 0;
            // 
            // Frmabsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1751, 891);
            this.Controls.Add(this.panel2);
            this.Name = "Frmabsence";
            this.Text = "MEDIATEK86 Absences";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttnretour;
        private System.Windows.Forms.Button bttnSupp1;
        private System.Windows.Forms.Button bttnAjout1;
        private System.Windows.Forms.Button bttnmodif1;
        private System.Windows.Forms.ComboBox cmbxmotifs;
        private System.Windows.Forms.Label lblMotifs;
        private System.Windows.Forms.Label lbldatefin;
        private System.Windows.Forms.Label lbldebutabs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}