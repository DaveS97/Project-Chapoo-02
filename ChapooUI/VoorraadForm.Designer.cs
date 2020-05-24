namespace ChapooUI
{
    partial class VoorraadForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblVoorraad = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurantOverzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barOverzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keukenOverzichtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afrekenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beheerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voorraadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voorraadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menukaartOptiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.werknemersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RBLunch = new System.Windows.Forms.RadioButton();
            this.RBDinner = new System.Windows.Forms.RadioButton();
            this.RBDranken = new System.Windows.Forms.RadioButton();
            this.lblFlter = new System.Windows.Forms.Label();
            this.pnlVoorraad = new System.Windows.Forms.Panel();
            this.lvVoorraad = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.tbAantal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlVoorraad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVoorraad
            // 
            this.lblVoorraad.AutoSize = true;
            this.lblVoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoorraad.Location = new System.Drawing.Point(327, 37);
            this.lblVoorraad.Name = "lblVoorraad";
            this.lblVoorraad.Size = new System.Drawing.Size(139, 36);
            this.lblVoorraad.TabIndex = 1;
            this.lblVoorraad.Text = "Voorraad";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.restaurantOverzichtToolStripMenuItem,
            this.barOverzichtToolStripMenuItem,
            this.keukenOverzichtToolStripMenuItem,
            this.afrekenenToolStripMenuItem,
            this.beheerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // restaurantOverzichtToolStripMenuItem
            // 
            this.restaurantOverzichtToolStripMenuItem.Name = "restaurantOverzichtToolStripMenuItem";
            this.restaurantOverzichtToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.restaurantOverzichtToolStripMenuItem.Text = "restaurant overzicht";
            // 
            // barOverzichtToolStripMenuItem
            // 
            this.barOverzichtToolStripMenuItem.Name = "barOverzichtToolStripMenuItem";
            this.barOverzichtToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.barOverzichtToolStripMenuItem.Text = "bar overzicht";
            // 
            // keukenOverzichtToolStripMenuItem
            // 
            this.keukenOverzichtToolStripMenuItem.Name = "keukenOverzichtToolStripMenuItem";
            this.keukenOverzichtToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.keukenOverzichtToolStripMenuItem.Text = "keuken overzicht";
            this.keukenOverzichtToolStripMenuItem.Click += new System.EventHandler(this.keukenOverzichtToolStripMenuItem_Click);
            // 
            // afrekenenToolStripMenuItem
            // 
            this.afrekenenToolStripMenuItem.Name = "afrekenenToolStripMenuItem";
            this.afrekenenToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.afrekenenToolStripMenuItem.Text = "afrekenen";
            // 
            // beheerToolStripMenuItem
            // 
            this.beheerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voorraadToolStripMenuItem,
            this.voorraadToolStripMenuItem1,
            this.menukaartOptiesToolStripMenuItem,
            this.werknemersToolStripMenuItem});
            this.beheerToolStripMenuItem.Name = "beheerToolStripMenuItem";
            this.beheerToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.beheerToolStripMenuItem.Text = "beheer";
            // 
            // voorraadToolStripMenuItem
            // 
            this.voorraadToolStripMenuItem.Name = "voorraadToolStripMenuItem";
            this.voorraadToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.voorraadToolStripMenuItem.Text = "inkomsten";
            // 
            // voorraadToolStripMenuItem1
            // 
            this.voorraadToolStripMenuItem1.Name = "voorraadToolStripMenuItem1";
            this.voorraadToolStripMenuItem1.Size = new System.Drawing.Size(207, 26);
            this.voorraadToolStripMenuItem1.Text = "voorraad";
            // 
            // menukaartOptiesToolStripMenuItem
            // 
            this.menukaartOptiesToolStripMenuItem.Name = "menukaartOptiesToolStripMenuItem";
            this.menukaartOptiesToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.menukaartOptiesToolStripMenuItem.Text = "menukaart opties";
            // 
            // werknemersToolStripMenuItem
            // 
            this.werknemersToolStripMenuItem.Name = "werknemersToolStripMenuItem";
            this.werknemersToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.werknemersToolStripMenuItem.Text = "Werknemers";
            // 
            // RBLunch
            // 
            this.RBLunch.AutoSize = true;
            this.RBLunch.Location = new System.Drawing.Point(612, 152);
            this.RBLunch.Name = "RBLunch";
            this.RBLunch.Size = new System.Drawing.Size(99, 21);
            this.RBLunch.TabIndex = 6;
            this.RBLunch.TabStop = true;
            this.RBLunch.Text = "lunch kaart";
            this.RBLunch.UseVisualStyleBackColor = true;
            // 
            // RBDinner
            // 
            this.RBDinner.AutoSize = true;
            this.RBDinner.Location = new System.Drawing.Point(612, 197);
            this.RBDinner.Name = "RBDinner";
            this.RBDinner.Size = new System.Drawing.Size(105, 21);
            this.RBDinner.TabIndex = 7;
            this.RBDinner.TabStop = true;
            this.RBDinner.Text = "dinner kaart";
            this.RBDinner.UseVisualStyleBackColor = true;
            // 
            // RBDranken
            // 
            this.RBDranken.AutoSize = true;
            this.RBDranken.Location = new System.Drawing.Point(612, 243);
            this.RBDranken.Name = "RBDranken";
            this.RBDranken.Size = new System.Drawing.Size(117, 21);
            this.RBDranken.TabIndex = 8;
            this.RBDranken.TabStop = true;
            this.RBDranken.Text = "dranken kaart";
            this.RBDranken.UseVisualStyleBackColor = true;
            // 
            // lblFlter
            // 
            this.lblFlter.AutoSize = true;
            this.lblFlter.Location = new System.Drawing.Point(609, 109);
            this.lblFlter.Name = "lblFlter";
            this.lblFlter.Size = new System.Drawing.Size(55, 17);
            this.lblFlter.TabIndex = 9;
            this.lblFlter.Text = "FILTER";
            // 
            // pnlVoorraad
            // 
            this.pnlVoorraad.BackColor = System.Drawing.Color.White;
            this.pnlVoorraad.Controls.Add(this.button2);
            this.pnlVoorraad.Controls.Add(this.tbAantal);
            this.pnlVoorraad.Controls.Add(this.lblOmschrijving);
            this.pnlVoorraad.Location = new System.Drawing.Point(612, 392);
            this.pnlVoorraad.Name = "pnlVoorraad";
            this.pnlVoorraad.Size = new System.Drawing.Size(428, 191);
            this.pnlVoorraad.TabIndex = 10;
            // 
            // lvVoorraad
            // 
            this.lvVoorraad.HideSelection = false;
            this.lvVoorraad.Location = new System.Drawing.Point(12, 109);
            this.lvVoorraad.MultiSelect = false;
            this.lvVoorraad.Name = "lvVoorraad";
            this.lvVoorraad.Size = new System.Drawing.Size(571, 474);
            this.lvVoorraad.TabIndex = 11;
            this.lvVoorraad.UseCompatibleStateImageBehavior = false;
            this.lvVoorraad.View = System.Windows.Forms.View.Details;
            this.lvVoorraad.SelectedIndexChanged += new System.EventHandler(this.lvVoorraad_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(759, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "view";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Location = new System.Drawing.Point(0, 4);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(24, 17);
            this.lblOmschrijving.TabIndex = 0;
            this.lblOmschrijving.Text = "....";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(612, 353);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 33);
            this.button4.TabIndex = 13;
            this.button4.Text = "change";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbAantal
            // 
            this.tbAantal.Location = new System.Drawing.Point(115, 79);
            this.tbAantal.Name = "tbAantal";
            this.tbAantal.Size = new System.Drawing.Size(100, 22);
            this.tbAantal.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(331, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VoorraadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1080, 644);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvVoorraad);
            this.Controls.Add(this.pnlVoorraad);
            this.Controls.Add(this.lblFlter);
            this.Controls.Add(this.RBDranken);
            this.Controls.Add(this.RBDinner);
            this.Controls.Add(this.RBLunch);
            this.Controls.Add(this.lblVoorraad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VoorraadForm";
            this.Text = "VoorraadForm";
            this.Load += new System.EventHandler(this.VoorraadForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlVoorraad.ResumeLayout(false);
            this.pnlVoorraad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblVoorraad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurantOverzichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barOverzichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keukenOverzichtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afrekenenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beheerToolStripMenuItem;
        private System.Windows.Forms.RadioButton RBLunch;
        private System.Windows.Forms.RadioButton RBDinner;
        private System.Windows.Forms.RadioButton RBDranken;
        private System.Windows.Forms.ToolStripMenuItem voorraadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voorraadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menukaartOptiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem werknemersToolStripMenuItem;
        private System.Windows.Forms.Label lblFlter;
        private System.Windows.Forms.Panel pnlVoorraad;
        private System.Windows.Forms.ListView lvVoorraad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbAantal;
        private System.Windows.Forms.Button button2;
    }
}