namespace ChapooUI
{
    partial class MenuKaartAanpassenForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvDrank = new System.Windows.Forms.ListView();
            this.btnDrankOphalen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMenu = new System.Windows.Forms.TextBox();
            this.tbPrijs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOmschrijving = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1094, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.homeToolStripMenuItem.Text = "home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // lvDrank
            // 
            this.lvDrank.HideSelection = false;
            this.lvDrank.Location = new System.Drawing.Point(32, 176);
            this.lvDrank.Name = "lvDrank";
            this.lvDrank.Size = new System.Drawing.Size(594, 444);
            this.lvDrank.TabIndex = 1;
            this.lvDrank.UseCompatibleStateImageBehavior = false;
            this.lvDrank.View = System.Windows.Forms.View.Details;
            // 
            // btnDrankOphalen
            // 
            this.btnDrankOphalen.Location = new System.Drawing.Point(495, 626);
            this.btnDrankOphalen.Name = "btnDrankOphalen";
            this.btnDrankOphalen.Size = new System.Drawing.Size(131, 28);
            this.btnDrankOphalen.TabIndex = 7;
            this.btnDrankOphalen.Text = "opnieuw laden";
            this.btnDrankOphalen.UseVisualStyleBackColor = true;
            this.btnDrankOphalen.Click += new System.EventHandler(this.btnDrankOphalen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "MenuKaart Aanpassen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "item aanpassen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(32, 142);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(172, 28);
            this.btnToevoegen.TabIndex = 12;
            this.btnToevoegen.Text = "Item Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnVoegToe);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbMenu);
            this.panel1.Controls.Add(this.tbPrijs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbOmschrijving);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(647, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 444);
            this.panel1.TabIndex = 13;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(322, 405);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(91, 39);
            this.btnVoegToe.TabIndex = 9;
            this.btnVoegToe.Text = "voeg toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "menu Kaart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "prijs";
            // 
            // tbMenu
            // 
            this.tbMenu.Location = new System.Drawing.Point(16, 324);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.Size = new System.Drawing.Size(100, 22);
            this.tbMenu.TabIndex = 6;
            // 
            // tbPrijs
            // 
            this.tbPrijs.Location = new System.Drawing.Point(16, 251);
            this.tbPrijs.Name = "tbPrijs";
            this.tbPrijs.Size = new System.Drawing.Size(100, 22);
            this.tbPrijs.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "type gerecht";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(16, 183);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(138, 22);
            this.tbType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "omschrijving";
            // 
            // tbOmschrijving
            // 
            this.tbOmschrijving.Location = new System.Drawing.Point(16, 102);
            this.tbOmschrijving.Name = "tbOmschrijving";
            this.tbOmschrijving.Size = new System.Drawing.Size(223, 22);
            this.tbOmschrijving.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item toevoegen";
            // 
            // MenuKaartAanpassenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1094, 723);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDrankOphalen);
            this.Controls.Add(this.lvDrank);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuKaartAanpassenForm";
            this.Text = "MenuKaartAanpassenForm";
            this.Load += new System.EventHandler(this.MenuKaartAanpassenForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ListView lvDrank;
        private System.Windows.Forms.Button btnDrankOphalen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMenu;
        private System.Windows.Forms.TextBox tbPrijs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOmschrijving;
        private System.Windows.Forms.Label label1;
    }
}