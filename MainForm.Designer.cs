namespace PametniSat
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridSatovi = new DataGridView();
            btnObrisiSat = new Button();
            btnNapuni = new Button();
            btnKoraci = new Button();
            btnSrce = new Button();
            btnDodajSat = new Button();
            btnPulsHistory = new Button();
            btnDatum = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridSatovi).BeginInit();
            SuspendLayout();
            // 
            // dataGridSatovi
            // 
            dataGridSatovi.AllowUserToOrderColumns = true;
            dataGridSatovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSatovi.Location = new Point(31, 27);
            dataGridSatovi.Name = "dataGridSatovi";
            dataGridSatovi.RowHeadersWidth = 51;
            dataGridSatovi.Size = new Size(733, 241);
            dataGridSatovi.TabIndex = 0;
            // 
            // btnObrisiSat
            // 
            btnObrisiSat.BackColor = SystemColors.ActiveCaption;
            btnObrisiSat.FlatStyle = FlatStyle.Flat;
            btnObrisiSat.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnObrisiSat.Location = new Point(47, 302);
            btnObrisiSat.Name = "btnObrisiSat";
            btnObrisiSat.Size = new Size(94, 40);
            btnObrisiSat.TabIndex = 1;
            btnObrisiSat.Text = "Obrisi";
            btnObrisiSat.UseVisualStyleBackColor = false;
            btnObrisiSat.Click += btnObrisiSat_Click;
            // 
            // btnNapuni
            // 
            btnNapuni.BackColor = SystemColors.ActiveCaption;
            btnNapuni.FlatStyle = FlatStyle.Flat;
            btnNapuni.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNapuni.Location = new Point(47, 348);
            btnNapuni.Name = "btnNapuni";
            btnNapuni.Size = new Size(94, 39);
            btnNapuni.TabIndex = 2;
            btnNapuni.Text = "Napuni";
            btnNapuni.UseVisualStyleBackColor = false;
            btnNapuni.Click += btnNapuni_Click;
            // 
            // btnKoraci
            // 
            btnKoraci.BackColor = SystemColors.ActiveCaption;
            btnKoraci.FlatStyle = FlatStyle.Flat;
            btnKoraci.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnKoraci.Location = new Point(283, 348);
            btnKoraci.Name = "btnKoraci";
            btnKoraci.Size = new Size(152, 39);
            btnKoraci.TabIndex = 3;
            btnKoraci.Text = "Dodaj Korake";
            btnKoraci.UseVisualStyleBackColor = false;
            btnKoraci.Click += btnKoraci_Click;
            // 
            // btnSrce
            // 
            btnSrce.BackColor = SystemColors.ActiveCaption;
            btnSrce.FlatStyle = FlatStyle.Flat;
            btnSrce.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSrce.Location = new Point(165, 348);
            btnSrce.Name = "btnSrce";
            btnSrce.Size = new Size(94, 40);
            btnSrce.TabIndex = 5;
            btnSrce.Text = "Puls";
            btnSrce.UseVisualStyleBackColor = false;
            btnSrce.Click += btnSrce_Click;
            // 
            // btnDodajSat
            // 
            btnDodajSat.BackColor = SystemColors.ActiveCaption;
            btnDodajSat.FlatStyle = FlatStyle.Flat;
            btnDodajSat.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDodajSat.Location = new Point(165, 302);
            btnDodajSat.Name = "btnDodajSat";
            btnDodajSat.Size = new Size(94, 40);
            btnDodajSat.TabIndex = 6;
            btnDodajSat.Text = "Dodaj sat";
            btnDodajSat.UseVisualStyleBackColor = false;
            btnDodajSat.Click += btnDodajSat_Click;
            // 
            // btnPulsHistory
            // 
            btnPulsHistory.BackColor = SystemColors.ActiveCaption;
            btnPulsHistory.FlatStyle = FlatStyle.Flat;
            btnPulsHistory.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPulsHistory.Location = new Point(283, 302);
            btnPulsHistory.Name = "btnPulsHistory";
            btnPulsHistory.Size = new Size(152, 40);
            btnPulsHistory.TabIndex = 7;
            btnPulsHistory.Text = "Istorija pulsa";
            btnPulsHistory.UseVisualStyleBackColor = false;
            btnPulsHistory.Click += btnPulsHistory_Click;
            // 
            // btnDatum
            // 
            btnDatum.BackColor = SystemColors.ActiveCaption;
            btnDatum.FlatStyle = FlatStyle.Flat;
            btnDatum.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatum.Location = new Point(462, 302);
            btnDatum.Name = "btnDatum";
            btnDatum.Size = new Size(193, 40);
            btnDatum.TabIndex = 8;
            btnDatum.Text = "Azuriraj Datum";
            btnDatum.UseVisualStyleBackColor = false;
            btnDatum.Click += btnDatum_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDatum);
            Controls.Add(btnPulsHistory);
            Controls.Add(btnDodajSat);
            Controls.Add(btnSrce);
            Controls.Add(btnKoraci);
            Controls.Add(btnNapuni);
            Controls.Add(btnObrisiSat);
            Controls.Add(dataGridSatovi);
            Name = "MainForm";
            Text = "Glavna Forma";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSatovi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridSatovi;
        private Button btnObrisiSat;
        private Button btnNapuni;
        private Button btnKoraci;
        private Button btnSrce;
        private Button btnDodajSat;
        private Button btnPulsHistory;
        private Button btnDatum;
    }
}
