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
            this.rbDranken = new System.Windows.Forms.RadioButton();
            this.lblTypeGerecht = new System.Windows.Forms.Label();
            this.rbHoofdgerecht = new System.Windows.Forms.RadioButton();
            this.rbNagerecht = new System.Windows.Forms.RadioButton();
            this.rbVoorgerecht = new System.Windows.Forms.RadioButton();
            this.pnlBestellingOpnemen = new System.Windows.Forms.Panel();
            this.btnVoegItemToe = new System.Windows.Forms.Button();
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAantal = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlMenuItemRegistreren.SuspendLayout();
            this.pnlBestellingOpnemen.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddMenuItems
            // 
            this.ddMenuItems.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.ddMenuItems.FormattingEnabled = true;
            this.ddMenuItems.Location = new System.Drawing.Point(94, 223);
            this.ddMenuItems.Name = "ddMenuItems";
            this.ddMenuItems.Size = new System.Drawing.Size(418, 58);
            this.ddMenuItems.TabIndex = 0;
            this.ddMenuItems.SelectedIndexChanged += new System.EventHandler(this.ddMenuItems_SelectedIndexChanged);
            // 
            // lblMenuItem
            // 
            this.lblMenuItem.AutoSize = true;
            this.lblMenuItem.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.lblMenuItem.ForeColor = System.Drawing.Color.White;
            this.lblMenuItem.Location = new System.Drawing.Point(216, 170);
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
            this.pnlMenuItemRegistreren.Controls.Add(this.button1);
            this.pnlMenuItemRegistreren.Controls.Add(this.btnPlus);
            this.pnlMenuItemRegistreren.Controls.Add(this.tbAantal);
            this.pnlMenuItemRegistreren.Controls.Add(this.label1);
            this.pnlMenuItemRegistreren.Controls.Add(this.textBox1);
            this.pnlMenuItemRegistreren.Controls.Add(this.btnVoegItemToe);
            this.pnlMenuItemRegistreren.Controls.Add(this.rbDranken);
            this.pnlMenuItemRegistreren.Controls.Add(this.lblTypeGerecht);
            this.pnlMenuItemRegistreren.Controls.Add(this.rbHoofdgerecht);
            this.pnlMenuItemRegistreren.Controls.Add(this.lblMenuItem);
            this.pnlMenuItemRegistreren.Controls.Add(this.rbNagerecht);
            this.pnlMenuItemRegistreren.Controls.Add(this.ddMenuItems);
            this.pnlMenuItemRegistreren.Controls.Add(this.rbVoorgerecht);
            this.pnlMenuItemRegistreren.Location = new System.Drawing.Point(30, 53);
            this.pnlMenuItemRegistreren.Name = "pnlMenuItemRegistreren";
            this.pnlMenuItemRegistreren.Size = new System.Drawing.Size(625, 526);
            this.pnlMenuItemRegistreren.TabIndex = 3;
            // 
            // rbDranken
            // 
            this.rbDranken.AutoSize = true;
            this.rbDranken.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.rbDranken.ForeColor = System.Drawing.Color.White;
            this.rbDranken.Location = new System.Drawing.Point(344, 97);
            this.rbDranken.Name = "rbDranken";
            this.rbDranken.Size = new System.Drawing.Size(96, 27);
            this.rbDranken.TabIndex = 7;
            this.rbDranken.TabStop = true;
            this.rbDranken.Text = "Dranken";
            this.rbDranken.UseVisualStyleBackColor = true;
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
            // rbHoofdgerecht
            // 
            this.rbHoofdgerecht.AutoSize = true;
            this.rbHoofdgerecht.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.rbHoofdgerecht.ForeColor = System.Drawing.Color.White;
            this.rbHoofdgerecht.Location = new System.Drawing.Point(344, 53);
            this.rbHoofdgerecht.Name = "rbHoofdgerecht";
            this.rbHoofdgerecht.Size = new System.Drawing.Size(140, 27);
            this.rbHoofdgerecht.TabIndex = 6;
            this.rbHoofdgerecht.TabStop = true;
            this.rbHoofdgerecht.Text = "Hoofdgerecht";
            this.rbHoofdgerecht.UseVisualStyleBackColor = true;
            // 
            // rbNagerecht
            // 
            this.rbNagerecht.AutoSize = true;
            this.rbNagerecht.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.rbNagerecht.ForeColor = System.Drawing.Color.White;
            this.rbNagerecht.Location = new System.Drawing.Point(94, 97);
            this.rbNagerecht.Name = "rbNagerecht";
            this.rbNagerecht.Size = new System.Drawing.Size(111, 27);
            this.rbNagerecht.TabIndex = 5;
            this.rbNagerecht.TabStop = true;
            this.rbNagerecht.Text = "Nagerecht";
            this.rbNagerecht.UseVisualStyleBackColor = true;
            // 
            // rbVoorgerecht
            // 
            this.rbVoorgerecht.AutoSize = true;
            this.rbVoorgerecht.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.rbVoorgerecht.ForeColor = System.Drawing.Color.White;
            this.rbVoorgerecht.Location = new System.Drawing.Point(94, 53);
            this.rbVoorgerecht.Name = "rbVoorgerecht";
            this.rbVoorgerecht.Size = new System.Drawing.Size(126, 27);
            this.rbVoorgerecht.TabIndex = 4;
            this.rbVoorgerecht.TabStop = true;
            this.rbVoorgerecht.Text = "Voorgerecht";
            this.rbVoorgerecht.UseVisualStyleBackColor = true;
            // 
            // pnlBestellingOpnemen
            // 
            this.pnlBestellingOpnemen.Controls.Add(this.btnOverzicht);
            this.pnlBestellingOpnemen.Controls.Add(this.lblTafelnummer);
            this.pnlBestellingOpnemen.Controls.Add(this.pnlMenuItemRegistreren);
            this.pnlBestellingOpnemen.Location = new System.Drawing.Point(12, 13);
            this.pnlBestellingOpnemen.Name = "pnlBestellingOpnemen";
            this.pnlBestellingOpnemen.Size = new System.Drawing.Size(680, 656);
            this.pnlBestellingOpnemen.TabIndex = 4;
            // 
            // btnVoegItemToe
            // 
            this.btnVoegItemToe.Location = new System.Drawing.Point(529, 461);
            this.btnVoegItemToe.Name = "btnVoegItemToe";
            this.btnVoegItemToe.Size = new System.Drawing.Size(75, 40);
            this.btnVoegItemToe.TabIndex = 8;
            this.btnVoegItemToe.Text = "Voeg item toe";
            this.btnVoegItemToe.UseVisualStyleBackColor = true;
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.btnOverzicht.Location = new System.Drawing.Point(198, 585);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(273, 57);
            this.btnOverzicht.TabIndex = 4;
            this.btnOverzicht.Text = "Overzicht";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(94, 379);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(418, 57);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aantal:";
            // 
            // tbAantal
            // 
            this.tbAantal.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.tbAantal.Location = new System.Drawing.Point(167, 285);
            this.tbAantal.Name = "tbAantal";
            this.tbAantal.Size = new System.Drawing.Size(22, 29);
            this.tbAantal.TabIndex = 11;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnPlus.ForeColor = System.Drawing.Color.Green;
            this.btnPlus.Location = new System.Drawing.Point(195, 285);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(25, 29);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(225, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button btnVoegItemToe;
        private System.Windows.Forms.Button btnOverzicht;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAantal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPlus;
    }
}