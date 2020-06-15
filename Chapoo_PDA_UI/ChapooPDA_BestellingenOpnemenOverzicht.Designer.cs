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
            this.btnVerwijderUitOverzicht = new System.Windows.Forms.Button();
            this.lblTafelnummer = new System.Windows.Forms.Label();
            this.pnlOverzicht = new System.Windows.Forms.Panel();
            this.lvDranken = new System.Windows.Forms.ListView();
            this.lvNagerechten = new System.Windows.Forms.ListView();
            this.lvHoofdgerechten = new System.Windows.Forms.ListView();
            this.lvVoorgerechten = new System.Windows.Forms.ListView();
            this.lblDranken = new System.Windows.Forms.Label();
            this.lblNagerechten = new System.Windows.Forms.Label();
            this.lblHoofdgerechten = new System.Windows.Forms.Label();
            this.lblVoorgerechten = new System.Windows.Forms.Label();
            this.pnlOverzicht.SuspendLayout();
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
            this.btnVerstuur.Click += new System.EventHandler(this.btnVerstuur_Click);
            // 
            // btnVerwijderUitOverzicht
            // 
            this.btnVerwijderUitOverzicht.Location = new System.Drawing.Point(617, 53);
            this.btnVerwijderUitOverzicht.Name = "btnVerwijderUitOverzicht";
            this.btnVerwijderUitOverzicht.Size = new System.Drawing.Size(75, 29);
            this.btnVerwijderUitOverzicht.TabIndex = 2;
            this.btnVerwijderUitOverzicht.Text = "verwijder";
            this.btnVerwijderUitOverzicht.UseVisualStyleBackColor = true;
            this.btnVerwijderUitOverzicht.Click += new System.EventHandler(this.btnVerwijderUitOverzicht_Click);
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
            this.pnlOverzicht.Controls.Add(this.lvDranken);
            this.pnlOverzicht.Controls.Add(this.lvNagerechten);
            this.pnlOverzicht.Controls.Add(this.lvHoofdgerechten);
            this.pnlOverzicht.Controls.Add(this.lvVoorgerechten);
            this.pnlOverzicht.Controls.Add(this.lblDranken);
            this.pnlOverzicht.Controls.Add(this.lblNagerechten);
            this.pnlOverzicht.Controls.Add(this.lblHoofdgerechten);
            this.pnlOverzicht.Controls.Add(this.lblVoorgerechten);
            this.pnlOverzicht.Location = new System.Drawing.Point(12, 88);
            this.pnlOverzicht.Name = "pnlOverzicht";
            this.pnlOverzicht.Size = new System.Drawing.Size(680, 517);
            this.pnlOverzicht.TabIndex = 4;
            // 
            // lvDranken
            // 
            this.lvDranken.HideSelection = false;
            this.lvDranken.Location = new System.Drawing.Point(56, 432);
            this.lvDranken.Margin = new System.Windows.Forms.Padding(2);
            this.lvDranken.Name = "lvDranken";
            this.lvDranken.Size = new System.Drawing.Size(446, 86);
            this.lvDranken.TabIndex = 7;
            this.lvDranken.UseCompatibleStateImageBehavior = false;
            this.lvDranken.View = System.Windows.Forms.View.Details;
            // 
            // lvNagerechten
            // 
            this.lvNagerechten.HideSelection = false;
            this.lvNagerechten.Location = new System.Drawing.Point(56, 298);
            this.lvNagerechten.Margin = new System.Windows.Forms.Padding(2);
            this.lvNagerechten.Name = "lvNagerechten";
            this.lvNagerechten.Size = new System.Drawing.Size(446, 92);
            this.lvNagerechten.TabIndex = 6;
            this.lvNagerechten.UseCompatibleStateImageBehavior = false;
            this.lvNagerechten.View = System.Windows.Forms.View.Details;
            // 
            // lvHoofdgerechten
            // 
            this.lvHoofdgerechten.HideSelection = false;
            this.lvHoofdgerechten.Location = new System.Drawing.Point(56, 173);
            this.lvHoofdgerechten.Margin = new System.Windows.Forms.Padding(2);
            this.lvHoofdgerechten.Name = "lvHoofdgerechten";
            this.lvHoofdgerechten.Size = new System.Drawing.Size(446, 90);
            this.lvHoofdgerechten.TabIndex = 5;
            this.lvHoofdgerechten.UseCompatibleStateImageBehavior = false;
            this.lvHoofdgerechten.View = System.Windows.Forms.View.Details;
            // 
            // lvVoorgerechten
            // 
            this.lvVoorgerechten.HideSelection = false;
            this.lvVoorgerechten.Location = new System.Drawing.Point(56, 41);
            this.lvVoorgerechten.Margin = new System.Windows.Forms.Padding(2);
            this.lvVoorgerechten.Name = "lvVoorgerechten";
            this.lvVoorgerechten.Size = new System.Drawing.Size(446, 89);
            this.lvVoorgerechten.TabIndex = 4;
            this.lvVoorgerechten.UseCompatibleStateImageBehavior = false;
            this.lvVoorgerechten.View = System.Windows.Forms.View.Details;
            // 
            // lblDranken
            // 
            this.lblDranken.AutoSize = true;
            this.lblDranken.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblDranken.Location = new System.Drawing.Point(50, 392);
            this.lblDranken.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDranken.Name = "lblDranken";
            this.lblDranken.Size = new System.Drawing.Size(129, 38);
            this.lblDranken.TabIndex = 3;
            this.lblDranken.Text = "Dranken";
            // 
            // lblNagerechten
            // 
            this.lblNagerechten.AutoSize = true;
            this.lblNagerechten.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblNagerechten.Location = new System.Drawing.Point(50, 258);
            this.lblNagerechten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNagerechten.Name = "lblNagerechten";
            this.lblNagerechten.Size = new System.Drawing.Size(185, 38);
            this.lblNagerechten.TabIndex = 2;
            this.lblNagerechten.Text = "Nagerechten";
            // 
            // lblHoofdgerechten
            // 
            this.lblHoofdgerechten.AutoSize = true;
            this.lblHoofdgerechten.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblHoofdgerechten.Location = new System.Drawing.Point(50, 132);
            this.lblHoofdgerechten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoofdgerechten.Name = "lblHoofdgerechten";
            this.lblHoofdgerechten.Size = new System.Drawing.Size(231, 38);
            this.lblHoofdgerechten.TabIndex = 1;
            this.lblHoofdgerechten.Text = "Hoofdgerechten";
            // 
            // lblVoorgerechten
            // 
            this.lblVoorgerechten.AutoSize = true;
            this.lblVoorgerechten.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblVoorgerechten.Location = new System.Drawing.Point(50, 0);
            this.lblVoorgerechten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVoorgerechten.Name = "lblVoorgerechten";
            this.lblVoorgerechten.Size = new System.Drawing.Size(210, 38);
            this.lblVoorgerechten.TabIndex = 0;
            this.lblVoorgerechten.Text = "Voorgerechten";
            // 
            // ChapooPDA_BestellingenOpnemenOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.pnlOverzicht);
            this.Controls.Add(this.lblTafelnummer);
            this.Controls.Add(this.btnVerwijderUitOverzicht);
            this.Controls.Add(this.btnVerstuur);
            this.Name = "ChapooPDA_BestellingenOpnemenOverzicht";
            this.Text = "ChapooPDA_BestellingenOpnemenOverzicht";
            this.Load += new System.EventHandler(this.ChapooPDA_BestellingenOpnemenOverzicht_Load);
            this.pnlOverzicht.ResumeLayout(false);
            this.pnlOverzicht.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVerstuur;
        private System.Windows.Forms.Button btnVerwijderUitOverzicht;
        private System.Windows.Forms.Label lblTafelnummer;
        private System.Windows.Forms.Panel pnlOverzicht;
        private System.Windows.Forms.Label lblHoofdgerechten;
        private System.Windows.Forms.Label lblVoorgerechten;
        private System.Windows.Forms.Label lblDranken;
        private System.Windows.Forms.Label lblNagerechten;
        private System.Windows.Forms.ListView lvDranken;
        private System.Windows.Forms.ListView lvNagerechten;
        private System.Windows.Forms.ListView lvHoofdgerechten;
        private System.Windows.Forms.ListView lvVoorgerechten;
    }
}