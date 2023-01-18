namespace WinFormsApp1
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARKAADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İLAÇKODU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALIŞTUTARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SATIŞMİKTARI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STOK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALIŞTARİHİ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGKKARŞILAMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MARKAADI,
            this.İLAÇKODU,
            this.ALIŞTUTARI,
            this.SATIŞMİKTARI,
            this.STOK,
            this.ALIŞTARİHİ,
            this.SGKKARŞILAMA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // MARKAADI
            // 
            this.MARKAADI.DataPropertyName = "MarkaAdi";
            this.MARKAADI.HeaderText = "MARKA ADI";
            this.MARKAADI.Name = "MARKAADI";
            // 
            // İLAÇKODU
            // 
            this.İLAÇKODU.DataPropertyName = "IlacKodu";
            this.İLAÇKODU.HeaderText = "İLAÇ KODU";
            this.İLAÇKODU.Name = "İLAÇKODU";
            // 
            // ALIŞTUTARI
            // 
            this.ALIŞTUTARI.DataPropertyName = "AlisTutari";
            this.ALIŞTUTARI.HeaderText = "ALIŞ TUTARI";
            this.ALIŞTUTARI.Name = "ALIŞTUTARI";
            // 
            // SATIŞMİKTARI
            // 
            this.SATIŞMİKTARI.DataPropertyName = "SatisMiktari";
            this.SATIŞMİKTARI.HeaderText = "SATIŞ MİKTARI";
            this.SATIŞMİKTARI.Name = "SATIŞMİKTARI";
            // 
            // STOK
            // 
            this.STOK.DataPropertyName = "Stok";
            this.STOK.HeaderText = "STOK";
            this.STOK.Name = "STOK";
            this.STOK.Width = 50;
            // 
            // ALIŞTARİHİ
            // 
            this.ALIŞTARİHİ.DataPropertyName = "AlisTarihi";
            this.ALIŞTARİHİ.HeaderText = "ALIŞ TARİHİ";
            this.ALIŞTARİHİ.Name = "ALIŞTARİHİ";
            this.ALIŞTARİHİ.Width = 135;
            // 
            // SGKKARŞILAMA
            // 
            this.SGKKARŞILAMA.DataPropertyName = "SGKKarsilama";
            this.SGKKARŞILAMA.HeaderText = "SGK KARŞILAMA";
            this.SGKKARŞILAMA.Name = "SGKKARŞILAMA";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn MARKAADI;
        private DataGridViewTextBoxColumn İLAÇKODU;
        private DataGridViewTextBoxColumn ALIŞTUTARI;
        private DataGridViewTextBoxColumn SATIŞMİKTARI;
        private DataGridViewTextBoxColumn STOK;
        private DataGridViewTextBoxColumn ALIŞTARİHİ;
        private DataGridViewTextBoxColumn SGKKARŞILAMA;
    }
}