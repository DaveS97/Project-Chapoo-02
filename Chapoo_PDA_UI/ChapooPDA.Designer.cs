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
            this.SuspendLayout();
            // 
            // btnRestaurantOverzicht
            // 
            this.btnRestaurantOverzicht.Location = new System.Drawing.Point(128, 175);
            this.btnRestaurantOverzicht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestaurantOverzicht.Name = "btnRestaurantOverzicht";
            this.btnRestaurantOverzicht.Size = new System.Drawing.Size(667, 111);
            this.btnRestaurantOverzicht.TabIndex = 0;
            this.btnRestaurantOverzicht.Text = "Restaurant overzicht";
            this.btnRestaurantOverzicht.UseVisualStyleBackColor = true;
            this.btnRestaurantOverzicht.Click += new System.EventHandler(this.btnRestaurantOverzicht_Click);
            // 
            // btnBestellingOpnemen
            // 
            this.btnBestellingOpnemen.Location = new System.Drawing.Point(128, 293);
            this.btnBestellingOpnemen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBestellingOpnemen.Name = "btnBestellingOpnemen";
            this.btnBestellingOpnemen.Size = new System.Drawing.Size(667, 111);
            this.btnBestellingOpnemen.TabIndex = 1;
            this.btnBestellingOpnemen.Text = "Bestelling opnemen";
            this.btnBestellingOpnemen.UseVisualStyleBackColor = true;
            this.btnBestellingOpnemen.Click += new System.EventHandler(this.btnBestellingOpnemen_Click);
            // 
            // btnKlaarstaandeBestellingen
            // 
            this.btnKlaarstaandeBestellingen.Location = new System.Drawing.Point(128, 411);
            this.btnKlaarstaandeBestellingen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKlaarstaandeBestellingen.Name = "btnKlaarstaandeBestellingen";
            this.btnKlaarstaandeBestellingen.Size = new System.Drawing.Size(667, 111);
            this.btnKlaarstaandeBestellingen.TabIndex = 2;
            this.btnKlaarstaandeBestellingen.Text = "Klaarstaande bestellingen";
            this.btnKlaarstaandeBestellingen.UseVisualStyleBackColor = true;
            this.btnKlaarstaandeBestellingen.Click += new System.EventHandler(this.btnKlaarstaandeBestellingen_Click);
            // 
            // btnAfrekenen
            // 
            this.btnAfrekenen.Location = new System.Drawing.Point(128, 624);
            this.btnAfrekenen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAfrekenen.Name = "btnAfrekenen";
            this.btnAfrekenen.Size = new System.Drawing.Size(667, 111);
            this.btnAfrekenen.TabIndex = 3;
            this.btnAfrekenen.Text = "Afrekenen";
            this.btnAfrekenen.UseVisualStyleBackColor = true;
            this.btnAfrekenen.Click += new System.EventHandler(this.btnAfrekenen_Click);
            // 
            // ChapooPDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(939, 838);
            this.Controls.Add(this.btnAfrekenen);
            this.Controls.Add(this.btnKlaarstaandeBestellingen);
            this.Controls.Add(this.btnBestellingOpnemen);
            this.Controls.Add(this.btnRestaurantOverzicht);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChapooPDA";
            this.Text = "ChapooPDA";
            this.Load += new System.EventHandler(this.ChapooPDA_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestaurantOverzicht;
        private System.Windows.Forms.Button btnBestellingOpnemen;
        private System.Windows.Forms.Button btnKlaarstaandeBestellingen;
        private System.Windows.Forms.Button btnAfrekenen;
    }
}

