namespace PametniSat
{
    partial class PulsHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PulsHistoryForm));
            dataGridPuls = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridPuls).BeginInit();
            SuspendLayout();
            // 
            // dataGridPuls
            // 
            dataGridPuls.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPuls.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPuls.Location = new Point(34, 29);
            dataGridPuls.Name = "dataGridPuls";
            dataGridPuls.RowHeadersWidth = 51;
            dataGridPuls.Size = new Size(466, 245);
            dataGridPuls.TabIndex = 0;
            // 
            // PulsHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridPuls);
            Name = "PulsHistoryForm";
            Text = "PulsHistoryForm";
            Load += PulsHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPuls).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridPuls;
    }
}