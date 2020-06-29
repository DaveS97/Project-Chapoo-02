namespace Chapoo_PDA_UI
{
    partial class ChapooPDA
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
            this.btnRestaurantOverzicht = new System.Windows.Forms.Button();
            this.btnBestellingOpnemen = new System.Windows.Forms.Button();
            this.btnKlaarstaandeBestellingen = new System.Windows.Forms.Button();
            this.btnAfrekenen = new System.Windows.Forms.Button();
            this.lblBedienernaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRestaurantOverzicht
            // 
            this.btnRestaurantOverzicht.Location = new System.Drawing.Point(96, 142);
            this.btnRestaurantOverzicht.Name = "btnRestaurantOverzicht";
            this.btnRestaurantOverzicht.Size = new System.Drawing.Size(500, 90);
            this.btnRestaurantOverzicht.TabIndex = 0;
            this.btnRestaurantOverzicht.Text = "Restaurant overzicht";
            this.btnRestaurantOverzicht.UseVisualStyleBackColor = true;
            this.btnRestaurantOverzicht.Click += new System.EventHandler(this.btnRestaurantOverzicht_Click);
            // 
            // btnBestellingOpnemen
            // 
            this.btnBestellingOpnemen.Enabled = false;
            this.btnBestellingOpnemen.Location = new System.Drawing.Point(96, 238);
            this.btnBestellingOpnemen.Name = "btnBestellingOpnemen";
            this.btnBestellingOpnemen.Size = new System.Drawing.Size(500, 90);
            this.btnBestellingOpnemen.TabIndex = 1;
            this.btnBestellingOpnemen.Text = "Bestelling opnemen";
            this.btnBestellingOpnemen.UseVisualStyleBackColor = true;
            this.btnBestellingOpnemen.Click += new System.EventHandler(this.btnBestellingOpnemen_Click);
            // 
            // btnKlaarstaandeBestellingen
            // 
            this.btnKlaarstaandeBestellingen.Location = new System.Drawing.Point(96, 334);
            this.btnKlaarstaandeBestellingen.Name = "btnKlaarstaandeBestellingen";
            this.btnKlaarstaandeBestellingen.Size = new System.Drawing.Size(500, 90);
            this.btnKlaarstaandeBestellingen.TabIndex = 2;
            this.btnKlaarstaandeBestellingen.Text = "Klaarstaande bestellingen";
            this.btnKlaarstaandeBestellingen.UseVisualStyleBackColor = true;
            this.btnKlaarstaandeBestellingen.Click += new System.EventHandler(this.btnKlaarstaandeBestellingen_Click);
            // 
            // btnAfrekenen
            // 
            this.btnAfrekenen.Enabled = false;
            this.btnAfrekenen.Location = new System.Drawing.Point(96, 507);
            this.btnAfrekenen.Name = "btnAfrekenen";
            this.btnAfrekenen.Size = new System.Drawing.Size(500, 90);
            this.btnAfrekenen.TabIndex = 3;
            this.btnAfrekenen.Text = "Afrekenen";
            this.btnAfrekenen.UseVisualStyleBackColor = true;
            this.btnAfrekenen.Click += new System.EventHandler(this.btnAfrekenen_Click);
            // 
            // lblBedienernaam
            // 
            this.lblBedienernaam.AutoSize = true;
            this.lblBedienernaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBedienernaam.Location = new System.Drawing.Point(512, 9);
            this.lblBedienernaam.Name = "lblBedienernaam";
            this.lblBedienernaam.Size = new System.Drawing.Size(84, 25);
            this.lblBedienernaam.TabIndex = 4;
            this.lblBedienernaam.Text = "Welkom";
            // 
            // ChapooPDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.lblBedienernaam);
            this.Controls.Add(this.btnAfrekenen);
            this.Controls.Add(this.btnKlaarstaandeBestellingen);
            this.Controls.Add(this.btnBestellingOpnemen);
            this.Controls.Add(this.btnRestaurantOverzicht);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChapooPDA";
            this.Text = "ChapooPDA";
            this.Load += new System.EventHandler(this.ChapooPDA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestaurantOverzicht;
        private System.Windows.Forms.Button btnBestellingOpnemen;
        private System.Windows.Forms.Button btnKlaarstaandeBestellingen;
        private System.Windows.Forms.Button btnAfrekenen;
        private System.Windows.Forms.Label lblBedienernaam;
    }
}

