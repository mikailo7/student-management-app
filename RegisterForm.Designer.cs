namespace PametniSat
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            btnRegistruj = new Button();
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnRegistruj
            // 
            btnRegistruj.BackColor = SystemColors.ActiveCaption;
            btnRegistruj.FlatStyle = FlatStyle.Flat;
            btnRegistruj.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistruj.Location = new Point(78, 312);
            btnRegistruj.Margin = new Padding(4, 4, 4, 4);
            btnRegistruj.Name = "btnRegistruj";
            btnRegistruj.Size = new Size(188, 55);
            btnRegistruj.TabIndex = 0;
            btnRegistruj.Text = "Registruj se";
            btnRegistruj.UseVisualStyleBackColor = false;
            btnRegistruj.Click += btnRegistruj_Click;
            // 
            // txtIme
            // 
            txtIme.Location = new Point(78, 105);
            txtIme.Margin = new Padding(4, 4, 4, 4);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(186, 34);
            txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(78, 215);
            txtPrezime.Margin = new Padding(4, 4, 4, 4);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(186, 34);
            txtPrezime.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(78, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 3;
            label1.Text = "Unesite ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(78, 184);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 4;
            label2.Text = "Unesite prezime";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(918, 608);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(btnRegistruj);
            Font = new Font("Segoe Script", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistruj;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private Label label1;
        private Label label2;
    }
}