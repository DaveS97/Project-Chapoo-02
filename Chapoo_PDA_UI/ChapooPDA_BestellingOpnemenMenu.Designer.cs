namespace Chapoo_PDA_UI
{
    partial class ChapooPDA_BestellingOpnemenMenu
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
            this.lblTafelnummer = new System.Windows.Forms.Label();
            this.tbTafelnummerBestellingOpnemen = new System.Windows.Forms.TextBox();
            this.btnNaarBestelling = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTafelnummer
            // 
            this.lblTafelnummer.AutoSize = true;
            this.lblTafelnummer.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTafelnummer.ForeColor = System.Drawing.Color.White;
            this.lblTafelnummer.Location = new System.Drawing.Point(214, 254);
            this.lblTafelnummer.Name = "lblTafelnummer";
            this.lblTafelnummer.Size = new System.Drawing.Size(253, 50);
            this.lblTafelnummer.TabIndex = 2;
            this.lblTafelnummer.Text = "Tafelnummer";
            // 
            // tbTafelnummerBestellingOpnemen
            // 
            this.tbTafelnummerBestellingOpnemen.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTafelnummerBestellingOpnemen.Location = new System.Drawing.Point(223, 307);
            this.tbTafelnummerBestellingOpnemen.Name = "tbTafelnummerBestellingOpnemen";
            this.tbTafelnummerBestellingOpnemen.Size = new System.Drawing.Size(238, 80);
            this.tbTafelnummerBestellingOpnemen.TabIndex = 3;
            this.tbTafelnummerBestellingOpnemen.TextChanged += new System.EventHandler(this.tbTafelnummerBestellingOpnemen_TextChanged);
            // 
            // btnNaarBestelling
            // 
            this.btnNaarBestelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNaarBestelling.Location = new System.Drawing.Point(139, 393);
            this.btnNaarBestelling.Name = "btnNaarBestelling";
            this.btnNaarBestelling.Size = new System.Drawing.Size(399, 100);
            this.btnNaarBestelling.TabIndex = 4;
            this.btnNaarBestelling.Text = "Verder naar bestelling";
            this.btnNaarBestelling.UseVisualStyleBackColor = true;
            this.btnNaarBestelling.Click += new System.EventHandler(this.btnNaarBestelling_Click);
            // 
            // ChapooPDA_BestellingOpnemenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.btnNaarBestelling);
            this.Controls.Add(this.tbTafelnummerBestellingOpnemen);
            this.Controls.Add(this.lblTafelnummer);
            this.Name = "ChapooPDA_BestellingOpnemenMenu";
            this.Text = "ChapooPDA_BestellingOpnemenMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTafelnummer;
        private System.Windows.Forms.TextBox tbTafelnummerBestellingOpnemen;
        private System.Windows.Forms.Button btnNaarBestelling;
    }
}