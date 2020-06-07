namespace Chapoo_PDA_UI
{
    partial class ChapooPDA_BestellingenOpnemenOverzicht
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
            this.btnVerstuur = new System.Windows.Forms.Button();
            this.btnVerwijderOverzicht = new System.Windows.Forms.Button();
            this.lblTafelnummer = new System.Windows.Forms.Label();
            this.pnlOverzicht = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnVerstuur
            // 
            this.btnVerstuur.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.btnVerstuur.Location = new System.Drawing.Point(224, 611);
            this.btnVerstuur.Name = "btnVerstuur";
            this.btnVerstuur.Size = new System.Drawing.Size(259, 57);
            this.btnVerstuur.TabIndex = 1;
            this.btnVerstuur.Text = "Verstuur";
            this.btnVerstuur.UseVisualStyleBackColor = true;
            // 
            // btnVerwijderOverzicht
            // 
            this.btnVerwijderOverzicht.Location = new System.Drawing.Point(617, 53);
            this.btnVerwijderOverzicht.Name = "btnVerwijderOverzicht";
            this.btnVerwijderOverzicht.Size = new System.Drawing.Size(75, 29);
            this.btnVerwijderOverzicht.TabIndex = 2;
            this.btnVerwijderOverzicht.Text = "verwijder";
            this.btnVerwijderOverzicht.UseVisualStyleBackColor = true;
            // 
            // lblTafelnummer
            // 
            this.lblTafelnummer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTafelnummer.AutoSize = true;
            this.lblTafelnummer.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblTafelnummer.ForeColor = System.Drawing.Color.White;
            this.lblTafelnummer.Location = new System.Drawing.Point(254, 9);
            this.lblTafelnummer.Name = "lblTafelnummer";
            this.lblTafelnummer.Size = new System.Drawing.Size(276, 50);
            this.lblTafelnummer.TabIndex = 3;
            this.lblTafelnummer.Text = "[tafelnummer]";
            this.lblTafelnummer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlOverzicht
            // 
            this.pnlOverzicht.BackColor = System.Drawing.Color.White;
            this.pnlOverzicht.Location = new System.Drawing.Point(12, 88);
            this.pnlOverzicht.Name = "pnlOverzicht";
            this.pnlOverzicht.Size = new System.Drawing.Size(680, 517);
            this.pnlOverzicht.TabIndex = 4;
            // 
            // ChapooPDA_BestellingenOpnemenOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.pnlOverzicht);
            this.Controls.Add(this.lblTafelnummer);
            this.Controls.Add(this.btnVerwijderOverzicht);
            this.Controls.Add(this.btnVerstuur);
            this.Name = "ChapooPDA_BestellingenOpnemenOverzicht";
            this.Text = "ChapooPDA_BestellingenOpnemenOverzicht";
            this.Load += new System.EventHandler(this.ChapooPDA_BestellingenOpnemenOverzicht_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerstuur;
        private System.Windows.Forms.Button btnVerwijderOverzicht;
        private System.Windows.Forms.Label lblTafelnummer;
        private System.Windows.Forms.Panel pnlOverzicht;
    }
}