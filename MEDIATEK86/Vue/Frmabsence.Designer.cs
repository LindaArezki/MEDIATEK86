
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPrénom2 = new System.Windows.Forms.TextBox();
            this.txtnom2 = new System.Windows.Forms.TextBox();
            this.lblMotifs = new System.Windows.Forms.Label();
            this.lbldatefin = new System.Windows.Forms.Label();
            this.lbldebutabs = new System.Windows.Forms.Label();
            this.lblPrénom1 = new System.Windows.Forms.Label();
            this.lblNom1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(996, 46);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(291, 29);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(603, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(335, 29);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 15, 9, 44, 0, 0);
            // 
            // bttnretour
            // 
            this.bttnretour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnretour.Location = new System.Drawing.Point(16, 781);
            this.bttnretour.Name = "bttnretour";
            this.bttnretour.Size = new System.Drawing.Size(401, 81);
            this.bttnretour.TabIndex = 13;
            this.bttnretour.Text = "RETOUR AUX PERSONNELS";
            this.bttnretour.UseVisualStyleBackColor = true;
            // 
            // bttnSupp1
            // 
            this.bttnSupp1.BackColor = System.Drawing.Color.LavenderBlush;
            this.bttnSupp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSupp1.Location = new System.Drawing.Point(1327, 781);
            this.bttnSupp1.Name = "bttnSupp1";
            this.bttnSupp1.Size = new System.Drawing.Size(352, 68);
            this.bttnSupp1.TabIndex = 12;
            this.bttnSupp1.Text = "SUPPRIMER UNE ABSENCE";
            this.bttnSupp1.UseVisualStyleBackColor = false;
            // 
            // bttnAjout1
            // 
            this.bttnAjout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAjout1.Location = new System.Drawing.Point(919, 788);
            this.bttnAjout1.Name = "bttnAjout1";
            this.bttnAjout1.Size = new System.Drawing.Size(352, 68);
            this.bttnAjout1.TabIndex = 11;
            this.bttnAjout1.Text = "AJOUTER UNE ABSENCE";
            this.bttnAjout1.UseVisualStyleBackColor = true;
            this.bttnAjout1.Click += new System.EventHandler(this.bttnAjout1_Click);
            // 
            // bttnmodif1
            // 
            this.bttnmodif1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnmodif1.Location = new System.Drawing.Point(524, 788);
            this.bttnmodif1.Name = "bttnmodif1";
            this.bttnmodif1.Size = new System.Drawing.Size(352, 69);
            this.bttnmodif1.TabIndex = 10;
            this.bttnmodif1.Text = "MODIFIER UNE ABSENCE";
            this.bttnmodif1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1365, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(256, 32);
            this.comboBox1.TabIndex = 9;
            // 
            // txtPrénom2
            // 
            this.txtPrénom2.Location = new System.Drawing.Point(312, 47);
            this.txtPrénom2.Name = "txtPrénom2";
            this.txtPrénom2.Size = new System.Drawing.Size(212, 29);
            this.txtPrénom2.TabIndex = 6;
            // 
            // txtnom2
            // 
            this.txtnom2.Location = new System.Drawing.Point(16, 47);
            this.txtnom2.Name = "txtnom2";
            this.txtnom2.Size = new System.Drawing.Size(233, 29);
            this.txtnom2.TabIndex = 5;
            // 
            // lblMotifs
            // 
            this.lblMotifs.AutoSize = true;
            this.lblMotifs.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotifs.Location = new System.Drawing.Point(1359, 6);
            this.lblMotifs.Name = "lblMotifs";
            this.lblMotifs.Size = new System.Drawing.Size(98, 34);
            this.lblMotifs.TabIndex = 4;
            this.lblMotifs.Text = "Motifs";
            // 
            // lbldatefin
            // 
            this.lbldatefin.AutoSize = true;
            this.lbldatefin.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatefin.Location = new System.Drawing.Point(990, 10);
            this.lbldatefin.Name = "lbldatefin";
            this.lbldatefin.Size = new System.Drawing.Size(297, 34);
            this.lbldatefin.TabIndex = 3;
            this.lbldatefin.Text = "Date fin de l\'absence";
            // 
            // lbldebutabs
            // 
            this.lbldebutabs.AutoSize = true;
            this.lbldebutabs.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldebutabs.Location = new System.Drawing.Point(597, 10);
            this.lbldebutabs.Name = "lbldebutabs";
            this.lbldebutabs.Size = new System.Drawing.Size(341, 34);
            this.lbldebutabs.TabIndex = 2;
            this.lbldebutabs.Text = "Date début de l\'absence";
            // 
            // lblPrénom1
            // 
            this.lblPrénom1.AutoSize = true;
            this.lblPrénom1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrénom1.Location = new System.Drawing.Point(306, 10);
            this.lblPrénom1.Name = "lblPrénom1";
            this.lblPrénom1.Size = new System.Drawing.Size(117, 34);
            this.lblPrénom1.TabIndex = 1;
            this.lblPrénom1.Text = "Prénom";
            // 
            // lblNom1
            // 
            this.lblNom1.AutoSize = true;
            this.lblNom1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom1.Location = new System.Drawing.Point(16, 10);
            this.lblNom1.Name = "lblNom1";
            this.lblNom1.Size = new System.Drawing.Size(79, 34);
            this.lblNom1.TabIndex = 0;
            this.lblNom1.Text = "Nom";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bttnretour);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.bttnSupp1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.bttnmodif1);
            this.panel2.Controls.Add(this.bttnAjout1);
            this.panel2.Controls.Add(this.lblMotifs);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.lblPrénom1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.lbldatefin);
            this.panel2.Controls.Add(this.txtPrénom2);
            this.panel2.Controls.Add(this.lbldebutabs);
            this.panel2.Controls.Add(this.lblNom1);
            this.panel2.Controls.Add(this.txtnom2);
            this.panel2.Location = new System.Drawing.Point(-4, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1758, 903);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1717, 635);
            this.dataGridView1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bttnretour;
        private System.Windows.Forms.Button bttnSupp1;
        private System.Windows.Forms.Button bttnAjout1;
        private System.Windows.Forms.Button bttnmodif1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtPrénom2;
        private System.Windows.Forms.TextBox txtnom2;
        private System.Windows.Forms.Label lblMotifs;
        private System.Windows.Forms.Label lbldatefin;
        private System.Windows.Forms.Label lbldebutabs;
        private System.Windows.Forms.Label lblPrénom1;
        private System.Windows.Forms.Label lblNom1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}