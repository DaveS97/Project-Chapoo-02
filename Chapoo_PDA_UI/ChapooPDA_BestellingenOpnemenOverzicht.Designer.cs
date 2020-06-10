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
            this.lblVoorgerechten = new System.Windows.Forms.Label();
            this.lblHoofdgerechten = new System.Windows.Forms.Label();
            this.lblNagerechten = new System.Windows.Forms.Label();
            this.lblDranken = new System.Windows.Forms.Label();
            this.lvVoorgerechten = new System.Windows.Forms.ListView();
            this.lvHoofdgerechten = new System.Windows.Forms.ListView();
            this.lvNagerechten = new System.Windows.Forms.ListView();
            this.lvDranken = new System.Windows.Forms.ListView();
            this.pnlOverzicht.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerstuur
            // 
            this.btnVerstuur.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.btnVerstuur.Location = new System.Drawing.Point(299, 752);
            this.btnVerstuur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerstuur.Name = "btnVerstuur";
            this.btnVerstuur.Size = new System.Drawing.Size(345, 70);
            this.btnVerstuur.TabIndex = 1;
            this.btnVerstuur.Text = "Verstuur";
            this.btnVerstuur.UseVisualStyleBackColor = true;
            this.btnVerstuur.Click += new System.EventHandler(this.btnVerstuur_Click);
            // 
            // btnVerwijderOverzicht
            // 
            this.btnVerwijderOverzicht.Location = new System.Drawing.Point(823, 65);
            this.btnVerwijderOverzicht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerwijderOverzicht.Name = "btnVerwijderOverzicht";
            this.btnVerwijderOverzicht.Size = new System.Drawing.Size(100, 36);
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
            this.lblTafelnummer.Location = new System.Drawing.Point(339, 11);
            this.lblTafelnummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTafelnummer.Name = "lblTafelnummer";
            this.lblTafelnummer.Size = new System.Drawing.Size(346, 62);
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
            this.pnlOverzicht.Location = new System.Drawing.Point(16, 108);
            this.pnlOverzicht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOverzicht.Name = "pnlOverzicht";
            this.pnlOverzicht.Size = new System.Drawing.Size(907, 636);
            this.pnlOverzicht.TabIndex = 4;
            // 
            // lblVoorgerechten
            // 
            this.lblVoorgerechten.AutoSize = true;
            this.lblVoorgerechten.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblVoorgerechten.Location = new System.Drawing.Point(67, 0);
            this.lblVoorgerechten.Name = "lblVoorgerechten";
            this.lblVoorgerechten.Size = new System.Drawing.Size(263, 47);
            this.lblVoorgerechten.TabIndex = 0;
            this.lblVoorgerechten.Text = "Voorgerechten";
            // 
            // lblHoofdgerechten
            // 
            this.lblHoofdgerechten.AutoSize = true;
            this.lblHoofdgerechten.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblHoofdgerechten.Location = new System.Drawing.Point(67, 163);
            this.lblHoofdgerechten.Name = "lblHoofdgerechten";
            this.lblHoofdgerechten.Size = new System.Drawing.Size(289, 47);
            this.lblHoofdgerechten.TabIndex = 1;
            this.lblHoofdgerechten.Text = "Hoofdgerechten";
            // 
            // lblNagerechten
            // 
            this.lblNagerechten.AutoSize = true;
            this.lblNagerechten.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblNagerechten.Location = new System.Drawing.Point(67, 317);
            this.lblNagerechten.Name = "lblNagerechten";
            this.lblNagerechten.Size = new System.Drawing.Size(233, 47);
            this.lblNagerechten.TabIndex = 2;
            this.lblNagerechten.Text = "Nagerechten";
            // 
            // lblDranken
            // 
            this.lblDranken.AutoSize = true;
            this.lblDranken.Font = new System.Drawing.Font("Segoe UI", 20.75F, System.Drawing.FontStyle.Bold);
            this.lblDranken.Location = new System.Drawing.Point(67, 482);
            this.lblDranken.Name = "lblDranken";
            this.lblDranken.Size = new System.Drawing.Size(160, 47);
            this.lblDranken.TabIndex = 3;
            this.lblDranken.Text = "Dranken";
            // 
            // lvVoorgerechten
            // 
            this.lvVoorgerechten.Location = new System.Drawing.Point(75, 51);
            this.lvVoorgerechten.Name = "lvVoorgerechten";
            this.lvVoorgerechten.Size = new System.Drawing.Size(594, 109);
            this.lvVoorgerechten.TabIndex = 4;
            this.lvVoorgerechten.UseCompatibleStateImageBehavior = false;
            this.lvVoorgerechten.View = System.Windows.Forms.View.Details;
            // 
            // lvHoofdgerechten
            // 
            this.lvHoofdgerechten.Location = new System.Drawing.Point(75, 213);
            this.lvHoofdgerechten.Name = "lvHoofdgerechten";
            this.lvHoofdgerechten.Size = new System.Drawing.Size(594, 110);
            this.lvHoofdgerechten.TabIndex = 5;
            this.lvHoofdgerechten.UseCompatibleStateImageBehavior = false;
            this.lvHoofdgerechten.View = System.Windows.Forms.View.Details;
            // 
            // lvNagerechten
            // 
            this.lvNagerechten.Location = new System.Drawing.Point(75, 367);
            this.lvNagerechten.Name = "lvNagerechten";
            this.lvNagerechten.Size = new System.Drawing.Size(594, 112);
            this.lvNagerechten.TabIndex = 6;
            this.lvNagerechten.UseCompatibleStateImageBehavior = false;
            this.lvNagerechten.View = System.Windows.Forms.View.Details;
            // 
            // lvDranken
            // 
            this.lvDranken.Location = new System.Drawing.Point(75, 532);
            this.lvDranken.Name = "lvDranken";
            this.lvDranken.Size = new System.Drawing.Size(594, 105);
            this.lvDranken.TabIndex = 7;
            this.lvDranken.UseCompatibleStateImageBehavior = false;
            this.lvDranken.View = System.Windows.Forms.View.Details;
            // 
            // ChapooPDA_BestellingenOpnemenOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(939, 838);
            this.Controls.Add(this.pnlOverzicht);
            this.Controls.Add(this.lblTafelnummer);
            this.Controls.Add(this.btnVerwijderOverzicht);
            this.Controls.Add(this.btnVerstuur);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnVerwijderOverzicht;
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