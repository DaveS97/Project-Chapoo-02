namespace Chapoo_PDA_UI
{
    partial class ChapooPDA_BestellingOpnemenRegistreren
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
            this.ddMenuItems = new System.Windows.Forms.ComboBox();
            this.lblMenuItem = new System.Windows.Forms.Label();
            this.lblTafelnummer = new System.Windows.Forms.Label();
            this.pnlMenuItemRegistreren = new System.Windows.Forms.Panel();
            this.lblTypeGerecht = new System.Windows.Forms.Label();
            this.pnlBestellingOpnemen = new System.Windows.Forms.Panel();
            this.rbVoorgerecht = new System.Windows.Forms.RadioButton();
            this.rbNagerecht = new System.Windows.Forms.RadioButton();
            this.rbHoofdgerecht = new System.Windows.Forms.RadioButton();
            this.rbDranken = new System.Windows.Forms.RadioButton();
            this.pnlMenuItemRegistreren.SuspendLayout();
            this.pnlBestellingOpnemen.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddMenuItems
            // 
            this.ddMenuItems.FormattingEnabled = true;
            this.ddMenuItems.Location = new System.Drawing.Point(109, 223);
            this.ddMenuItems.Name = "ddMenuItems";
            this.ddMenuItems.Size = new System.Drawing.Size(361, 21);
            this.ddMenuItems.TabIndex = 0;
            // 
            // lblMenuItem
            // 
            this.lblMenuItem.AutoSize = true;
            this.lblMenuItem.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblMenuItem.ForeColor = System.Drawing.Color.White;
            this.lblMenuItem.Location = new System.Drawing.Point(192, 170);
            this.lblMenuItem.Name = "lblMenuItem";
            this.lblMenuItem.Size = new System.Drawing.Size(210, 50);
            this.lblMenuItem.TabIndex = 1;
            this.lblMenuItem.Text = "Menu item";
            this.lblMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTafelnummer
            // 
            this.lblTafelnummer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTafelnummer.AutoSize = true;
            this.lblTafelnummer.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblTafelnummer.ForeColor = System.Drawing.Color.White;
            this.lblTafelnummer.Location = new System.Drawing.Point(267, 0);
            this.lblTafelnummer.Name = "lblTafelnummer";
            this.lblTafelnummer.Size = new System.Drawing.Size(276, 50);
            this.lblTafelnummer.TabIndex = 2;
            this.lblTafelnummer.Text = "[tafelnummer]";
            this.lblTafelnummer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlMenuItemRegistreren
            // 
            this.pnlMenuItemRegistreren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuItemRegistreren.Controls.Add(this.lblTypeGerecht);
            this.pnlMenuItemRegistreren.Controls.Add(this.lblMenuItem);
            this.pnlMenuItemRegistreren.Controls.Add(this.ddMenuItems);
            this.pnlMenuItemRegistreren.Location = new System.Drawing.Point(30, 176);
            this.pnlMenuItemRegistreren.Name = "pnlMenuItemRegistreren";
            this.pnlMenuItemRegistreren.Size = new System.Drawing.Size(625, 403);
            this.pnlMenuItemRegistreren.TabIndex = 3;
            // 
            // lblTypeGerecht
            // 
            this.lblTypeGerecht.AutoSize = true;
            this.lblTypeGerecht.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblTypeGerecht.ForeColor = System.Drawing.Color.White;
            this.lblTypeGerecht.Location = new System.Drawing.Point(179, 0);
            this.lblTypeGerecht.Name = "lblTypeGerecht";
            this.lblTypeGerecht.Size = new System.Drawing.Size(247, 50);
            this.lblTypeGerecht.TabIndex = 2;
            this.lblTypeGerecht.Text = "Type gerecht";
            this.lblTypeGerecht.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlBestellingOpnemen
            // 
            this.pnlBestellingOpnemen.Controls.Add(this.rbDranken);
            this.pnlBestellingOpnemen.Controls.Add(this.rbHoofdgerecht);
            this.pnlBestellingOpnemen.Controls.Add(this.rbNagerecht);
            this.pnlBestellingOpnemen.Controls.Add(this.rbVoorgerecht);
            this.pnlBestellingOpnemen.Controls.Add(this.lblTafelnummer);
            this.pnlBestellingOpnemen.Controls.Add(this.pnlMenuItemRegistreren);
            this.pnlBestellingOpnemen.Location = new System.Drawing.Point(12, 13);
            this.pnlBestellingOpnemen.Name = "pnlBestellingOpnemen";
            this.pnlBestellingOpnemen.Size = new System.Drawing.Size(680, 656);
            this.pnlBestellingOpnemen.TabIndex = 4;
            // 
            // rbVoorgerecht
            // 
            this.rbVoorgerecht.AutoSize = true;
            this.rbVoorgerecht.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.rbVoorgerecht.ForeColor = System.Drawing.Color.White;
            this.rbVoorgerecht.Location = new System.Drawing.Point(140, 63);
            this.rbVoorgerecht.Name = "rbVoorgerecht";
            this.rbVoorgerecht.Size = new System.Drawing.Size(126, 27);
            this.rbVoorgerecht.TabIndex = 4;
            this.rbVoorgerecht.TabStop = true;
            this.rbVoorgerecht.Text = "Voorgerecht";
            this.rbVoorgerecht.UseVisualStyleBackColor = true;
            // 
            // rbNagerecht
            // 
            this.rbNagerecht.AutoSize = true;
            this.rbNagerecht.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.rbNagerecht.ForeColor = System.Drawing.Color.White;
            this.rbNagerecht.Location = new System.Drawing.Point(140, 116);
            this.rbNagerecht.Name = "rbNagerecht";
            this.rbNagerecht.Size = new System.Drawing.Size(111, 27);
            this.rbNagerecht.TabIndex = 5;
            this.rbNagerecht.TabStop = true;
            this.rbNagerecht.Text = "Nagerecht";
            this.rbNagerecht.UseVisualStyleBackColor = true;
            // 
            // rbHoofdgerecht
            // 
            this.rbHoofdgerecht.AutoSize = true;
            this.rbHoofdgerecht.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.rbHoofdgerecht.ForeColor = System.Drawing.Color.White;
            this.rbHoofdgerecht.Location = new System.Drawing.Point(375, 63);
            this.rbHoofdgerecht.Name = "rbHoofdgerecht";
            this.rbHoofdgerecht.Size = new System.Drawing.Size(140, 27);
            this.rbHoofdgerecht.TabIndex = 6;
            this.rbHoofdgerecht.TabStop = true;
            this.rbHoofdgerecht.Text = "Hoofdgerecht";
            this.rbHoofdgerecht.UseVisualStyleBackColor = true;
            // 
            // rbDranken
            // 
            this.rbDranken.AutoSize = true;
            this.rbDranken.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.rbDranken.ForeColor = System.Drawing.Color.White;
            this.rbDranken.Location = new System.Drawing.Point(375, 116);
            this.rbDranken.Name = "rbDranken";
            this.rbDranken.Size = new System.Drawing.Size(96, 27);
            this.rbDranken.TabIndex = 7;
            this.rbDranken.TabStop = true;
            this.rbDranken.Text = "Dranken";
            this.rbDranken.UseVisualStyleBackColor = true;
            // 
            // ChapooPDA_BestellingOpnemenRegistreren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.pnlBestellingOpnemen);
            this.Name = "ChapooPDA_BestellingOpnemenRegistreren";
            this.Text = "ChapooPDA_BestellingOpnemenRegistreren";
            this.Load += new System.EventHandler(this.ChapooPDA_BestellingOpnemenRegistreren_Load);
            this.pnlMenuItemRegistreren.ResumeLayout(false);
            this.pnlMenuItemRegistreren.PerformLayout();
            this.pnlBestellingOpnemen.ResumeLayout(false);
            this.pnlBestellingOpnemen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddMenuItems;
        private System.Windows.Forms.Label lblMenuItem;
        private System.Windows.Forms.Label lblTafelnummer;
        private System.Windows.Forms.Panel pnlMenuItemRegistreren;
        private System.Windows.Forms.Label lblTypeGerecht;
        private System.Windows.Forms.Panel pnlBestellingOpnemen;
        private System.Windows.Forms.RadioButton rbVoorgerecht;
        private System.Windows.Forms.RadioButton rbDranken;
        private System.Windows.Forms.RadioButton rbHoofdgerecht;
        private System.Windows.Forms.RadioButton rbNagerecht;
    }
}