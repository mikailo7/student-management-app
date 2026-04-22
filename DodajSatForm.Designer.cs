namespace PametniSat
{
    partial class DodajSatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajSatForm));
            txtMarka = new TextBox();
            txtCena = new TextBox();
            txtBaterija = new TextBox();
            txtKoraci = new TextBox();
            txtPuls = new TextBox();
            chkSleep = new CheckBox();
            btnSacuvaj = new Button();
            SuspendLayout();
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(53, 63);
            txtMarka.Name = "txtMarka";
            txtMarka.PlaceholderText = "unesite marku";
            txtMarka.Size = new Size(125, 27);
            txtMarka.TabIndex = 0;
            // 
            // txtCena
            // 
            txtCena.Location = new Point(53, 136);
            txtCena.Name = "txtCena";
            txtCena.PlaceholderText = "Unesite cenu";
            txtCena.Size = new Size(125, 27);
            txtCena.TabIndex = 1;
            // 
            // txtBaterija
            // 
            txtBaterija.Location = new Point(53, 205);
            txtBaterija.Name = "txtBaterija";
            txtBaterija.PlaceholderText = "Unesite bateriju";
            txtBaterija.Size = new Size(125, 27);
            txtBaterija.TabIndex = 2;
            // 
            // txtKoraci
            // 
            txtKoraci.Location = new Point(53, 269);
            txtKoraci.Name = "txtKoraci";
            txtKoraci.PlaceholderText = "Unesite korake";
            txtKoraci.Size = new Size(125, 27);
            txtKoraci.TabIndex = 3;
            // 
            // txtPuls
            // 
            txtPuls.Location = new Point(53, 338);
            txtPuls.Name = "txtPuls";
            txtPuls.PlaceholderText = "Puls";
            txtPuls.Size = new Size(125, 27);
            txtPuls.TabIndex = 4;
            // 
            // chkSleep
            // 
            chkSleep.AutoSize = true;
            chkSleep.Location = new Point(243, 63);
            chkSleep.Name = "chkSleep";
            chkSleep.Size = new Size(66, 24);
            chkSleep.TabIndex = 6;
            chkSleep.Text = "sleep";
            chkSleep.UseVisualStyleBackColor = true;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.BackColor = SystemColors.ActiveCaption;
            btnSacuvaj.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSacuvaj.Location = new Point(53, 395);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 43);
            btnSacuvaj.TabIndex = 7;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = false;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // DodajSatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSacuvaj);
            Controls.Add(chkSleep);
            Controls.Add(txtPuls);
            Controls.Add(txtKoraci);
            Controls.Add(txtBaterija);
            Controls.Add(txtCena);
            Controls.Add(txtMarka);
            Name = "DodajSatForm";
            Text = "DodajSatForm";
            Load += DodajSatForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMarka;
        private TextBox txtCena;
        private TextBox txtBaterija;
        private TextBox txtKoraci;
        private TextBox txtPuls;
       
        private CheckBox chkSleep;
        private Button btnSacuvaj;
    }
}