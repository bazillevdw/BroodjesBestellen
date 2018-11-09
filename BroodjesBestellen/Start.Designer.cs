namespace BroodjesBestellen
{
    partial class Start
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBestellen = new System.Windows.Forms.Button();
            this.BtnBestellingKijken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wat wilt u doen?";
            // 
            // BtnBestellen
            // 
            this.BtnBestellen.Location = new System.Drawing.Point(82, 119);
            this.BtnBestellen.Name = "BtnBestellen";
            this.BtnBestellen.Size = new System.Drawing.Size(130, 21);
            this.BtnBestellen.TabIndex = 1;
            this.BtnBestellen.Text = "Broodjes bestellen";
            this.BtnBestellen.UseVisualStyleBackColor = true;
            this.BtnBestellen.Click += new System.EventHandler(this.BtnBestellen_Click);
            // 
            // BtnBestellingKijken
            // 
            this.BtnBestellingKijken.Location = new System.Drawing.Point(82, 146);
            this.BtnBestellingKijken.Name = "BtnBestellingKijken";
            this.BtnBestellingKijken.Size = new System.Drawing.Size(130, 21);
            this.BtnBestellingKijken.TabIndex = 2;
            this.BtnBestellingKijken.Text = "Bestellingen bekijken";
            this.BtnBestellingKijken.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BroodjesBestellen.Properties.Resources._815ddaa33301e6f9ff8e00d45ff4f63f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(309, 348);
            this.Controls.Add(this.BtnBestellingKijken);
            this.Controls.Add(this.BtnBestellen);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBestellen;
        private System.Windows.Forms.Button BtnBestellingKijken;
    }
}