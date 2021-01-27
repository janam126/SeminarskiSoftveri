namespace Klijent.Forme
{
    partial class FrmZakazivanjeTermina
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVremeTermina = new System.Windows.Forms.TextBox();
            this.txtDanTermina = new System.Windows.Forms.TextBox();
            this.cmbGrupa = new System.Windows.Forms.ComboBox();
            this.cmbTrener = new System.Windows.Forms.ComboBox();
            this.dgvPrikazi = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSacuvaj.Location = new System.Drawing.Point(466, 155);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(171, 40);
            this.btnSacuvaj.TabIndex = 0;
            this.btnSacuvaj.Text = "Sacuvaj termine";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dan temrina";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vreme termina";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Grupa";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Trener";
            // 
            // txtVremeTermina
            // 
            this.txtVremeTermina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVremeTermina.Location = new System.Drawing.Point(149, 78);
            this.txtVremeTermina.Name = "txtVremeTermina";
            this.txtVremeTermina.Size = new System.Drawing.Size(154, 22);
            this.txtVremeTermina.TabIndex = 2;
            // 
            // txtDanTermina
            // 
            this.txtDanTermina.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDanTermina.Location = new System.Drawing.Point(149, 29);
            this.txtDanTermina.Name = "txtDanTermina";
            this.txtDanTermina.Size = new System.Drawing.Size(154, 22);
            this.txtDanTermina.TabIndex = 2;
            // 
            // cmbGrupa
            // 
            this.cmbGrupa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbGrupa.FormattingEnabled = true;
            this.cmbGrupa.Location = new System.Drawing.Point(149, 126);
            this.cmbGrupa.Name = "cmbGrupa";
            this.cmbGrupa.Size = new System.Drawing.Size(154, 24);
            this.cmbGrupa.TabIndex = 3;
            // 
            // cmbTrener
            // 
            this.cmbTrener.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTrener.FormattingEnabled = true;
            this.cmbTrener.Location = new System.Drawing.Point(149, 175);
            this.cmbTrener.Name = "cmbTrener";
            this.cmbTrener.Size = new System.Drawing.Size(154, 24);
            this.cmbTrener.TabIndex = 3;
            // 
            // dgvPrikazi
            // 
            this.dgvPrikazi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvPrikazi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrikazi.Location = new System.Drawing.Point(42, 234);
            this.dgvPrikazi.Name = "dgvPrikazi";
            this.dgvPrikazi.RowHeadersWidth = 51;
            this.dgvPrikazi.RowTemplate.Height = 24;
            this.dgvPrikazi.Size = new System.Drawing.Size(705, 150);
            this.dgvPrikazi.TabIndex = 4;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.Location = new System.Drawing.Point(466, 81);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(171, 40);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj termin";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // FrmZakazivanjeTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPrikazi);
            this.Controls.Add(this.cmbTrener);
            this.Controls.Add(this.cmbGrupa);
            this.Controls.Add(this.txtDanTermina);
            this.Controls.Add(this.txtVremeTermina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnSacuvaj);
            this.Name = "FrmZakazivanjeTermina";
            this.Text = "FrmZakazivanjeTermina";
            this.Load += new System.EventHandler(this.FrmZakazivanjeTermina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrikazi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVremeTermina;
        private System.Windows.Forms.TextBox txtDanTermina;
        private System.Windows.Forms.ComboBox cmbGrupa;
        private System.Windows.Forms.ComboBox cmbTrener;
        private System.Windows.Forms.DataGridView dgvPrikazi;
        private System.Windows.Forms.Button btnDodaj;
    }
}