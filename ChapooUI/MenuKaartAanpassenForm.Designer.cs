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
            this.lvMenuKaartAanpassen = new System.Windows.Forms.ListView();
            this.btnOpnieuwLaden = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnItemAanpassen = new System.Windows.Forms.Button();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.pnlItemToevoegen = new System.Windows.Forms.Panel();
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
            this.pnlItemAanpassen = new System.Windows.Forms.Panel();
            this.lbltitel = new System.Windows.Forms.Label();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.tbmenukaartitem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbtypeitem = new System.Windows.Forms.TextBox();
            this.lblIDitem = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblOmschrijving = new System.Windows.Forms.Label();
            this.tbprijsitem = new System.Windows.Forms.TextBox();
            this.tbomschrijvingitem = new System.Windows.Forms.TextBox();
            this.cbIsalcoholisch = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.pnlItemToevoegen.SuspendLayout();
            this.pnlItemAanpassen.SuspendLayout();
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
            // lvMenuKaartAanpassen
            // 
            this.lvMenuKaartAanpassen.HideSelection = false;
            this.lvMenuKaartAanpassen.Location = new System.Drawing.Point(32, 176);
            this.lvMenuKaartAanpassen.Name = "lvMenuKaartAanpassen";
            this.lvMenuKaartAanpassen.Size = new System.Drawing.Size(594, 444);
            this.lvMenuKaartAanpassen.TabIndex = 1;
            this.lvMenuKaartAanpassen.UseCompatibleStateImageBehavior = false;
            this.lvMenuKaartAanpassen.View = System.Windows.Forms.View.Details;
            this.lvMenuKaartAanpassen.SelectedIndexChanged += new System.EventHandler(this.lvMenuKaartAanpassen_SelectedIndexChanged);
            // 
            // btnOpnieuwLaden
            // 
            this.btnOpnieuwLaden.Location = new System.Drawing.Point(495, 626);
            this.btnOpnieuwLaden.Name = "btnOpnieuwLaden";
            this.btnOpnieuwLaden.Size = new System.Drawing.Size(131, 28);
            this.btnOpnieuwLaden.TabIndex = 7;
            this.btnOpnieuwLaden.Text = "opnieuw laden";
            this.btnOpnieuwLaden.UseVisualStyleBackColor = true;
            //this.btnOpnieuwLaden.Click += new System.EventHandler(this.btnOpnieuwLaden_Click);                                                //button uitge-commend voor error
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Menu Kaart Aanpassen";
            // 
            // btnItemAanpassen
            // 
            this.btnItemAanpassen.Location = new System.Drawing.Point(448, 142);
            this.btnItemAanpassen.Name = "btnItemAanpassen";
            this.btnItemAanpassen.Size = new System.Drawing.Size(178, 28);
            this.btnItemAanpassen.TabIndex = 11;
            this.btnItemAanpassen.Text = "item aanpassen";
            this.btnItemAanpassen.UseVisualStyleBackColor = true;
            this.btnItemAanpassen.Click += new System.EventHandler(this.btnItemAanpassen_Click);
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
            // pnlItemToevoegen
            // 
            this.pnlItemToevoegen.BackColor = System.Drawing.Color.White;
            this.pnlItemToevoegen.Controls.Add(this.cbIsalcoholisch);
            this.pnlItemToevoegen.Controls.Add(this.btnVoegToe);
            this.pnlItemToevoegen.Controls.Add(this.label6);
            this.pnlItemToevoegen.Controls.Add(this.label5);
            this.pnlItemToevoegen.Controls.Add(this.tbMenu);
            this.pnlItemToevoegen.Controls.Add(this.tbPrijs);
            this.pnlItemToevoegen.Controls.Add(this.label3);
            this.pnlItemToevoegen.Controls.Add(this.tbType);
            this.pnlItemToevoegen.Controls.Add(this.label2);
            this.pnlItemToevoegen.Controls.Add(this.tbOmschrijving);
            this.pnlItemToevoegen.Controls.Add(this.label1);
            this.pnlItemToevoegen.Location = new System.Drawing.Point(647, 176);
            this.pnlItemToevoegen.Name = "pnlItemToevoegen";
            this.pnlItemToevoegen.Size = new System.Drawing.Size(413, 444);
            this.pnlItemToevoegen.TabIndex = 13;
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
            // pnlItemAanpassen
            // 
            this.pnlItemAanpassen.BackColor = System.Drawing.Color.White;
            this.pnlItemAanpassen.Controls.Add(this.lbltitel);
            this.pnlItemAanpassen.Controls.Add(this.btnOpslaan);
            this.pnlItemAanpassen.Controls.Add(this.btnVerwijder);
            this.pnlItemAanpassen.Controls.Add(this.tbmenukaartitem);
            this.pnlItemAanpassen.Controls.Add(this.label7);
            this.pnlItemAanpassen.Controls.Add(this.label8);
            this.pnlItemAanpassen.Controls.Add(this.label9);
            this.pnlItemAanpassen.Controls.Add(this.tbtypeitem);
            this.pnlItemAanpassen.Controls.Add(this.lblIDitem);
            this.pnlItemAanpassen.Controls.Add(this.label10);
            this.pnlItemAanpassen.Controls.Add(this.lblOmschrijving);
            this.pnlItemAanpassen.Controls.Add(this.tbprijsitem);
            this.pnlItemAanpassen.Controls.Add(this.tbomschrijvingitem);
            this.pnlItemAanpassen.Location = new System.Drawing.Point(644, 176);
            this.pnlItemAanpassen.Name = "pnlItemAanpassen";
            this.pnlItemAanpassen.Size = new System.Drawing.Size(413, 444);
            this.pnlItemAanpassen.TabIndex = 14;
            // 
            // lbltitel
            // 
            this.lbltitel.AutoSize = true;
            this.lbltitel.Location = new System.Drawing.Point(9, 7);
            this.lbltitel.Name = "lbltitel";
            this.lbltitel.Size = new System.Drawing.Size(86, 17);
            this.lbltitel.TabIndex = 26;
            this.lbltitel.Text = "omschrijving";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(300, 403);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(113, 42);
            this.btnOpslaan.TabIndex = 25;
            this.btnOpslaan.Text = "Opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(0, 403);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(113, 42);
            this.btnVerwijder.TabIndex = 24;
            this.btnVerwijder.Text = "verwijder Item";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // tbmenukaartitem
            // 
            this.tbmenukaartitem.Location = new System.Drawing.Point(19, 331);
            this.tbmenukaartitem.Name = "tbmenukaartitem";
            this.tbmenukaartitem.Size = new System.Drawing.Size(100, 22);
            this.tbmenukaartitem.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "menu kaart";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "type gerecht";
            // 
            // tbtypeitem
            // 
            this.tbtypeitem.Location = new System.Drawing.Point(16, 265);
            this.tbtypeitem.Name = "tbtypeitem";
            this.tbtypeitem.Size = new System.Drawing.Size(100, 22);
            this.tbtypeitem.TabIndex = 19;
            // 
            // lblIDitem
            // 
            this.lblIDitem.AutoSize = true;
            this.lblIDitem.Location = new System.Drawing.Point(356, 31);
            this.lblIDitem.Name = "lblIDitem";
            this.lblIDitem.Size = new System.Drawing.Size(21, 17);
            this.lblIDitem.TabIndex = 18;
            this.lblIDitem.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "prijs";
            // 
            // lblOmschrijving
            // 
            this.lblOmschrijving.AutoSize = true;
            this.lblOmschrijving.Location = new System.Drawing.Point(16, 98);
            this.lblOmschrijving.Name = "lblOmschrijving";
            this.lblOmschrijving.Size = new System.Drawing.Size(86, 17);
            this.lblOmschrijving.TabIndex = 16;
            this.lblOmschrijving.Text = "omschrijving";
            // 
            // tbprijsitem
            // 
            this.tbprijsitem.Location = new System.Drawing.Point(16, 190);
            this.tbprijsitem.Name = "tbprijsitem";
            this.tbprijsitem.Size = new System.Drawing.Size(100, 22);
            this.tbprijsitem.TabIndex = 15;
            // 
            // tbomschrijvingitem
            // 
            this.tbomschrijvingitem.Location = new System.Drawing.Point(16, 121);
            this.tbomschrijvingitem.Name = "tbomschrijvingitem";
            this.tbomschrijvingitem.Size = new System.Drawing.Size(279, 22);
            this.tbomschrijvingitem.TabIndex = 14;
            // 
            // cbIsalcoholisch
            // 
            this.cbIsalcoholisch.AutoSize = true;
            this.cbIsalcoholisch.Location = new System.Drawing.Point(16, 391);
            this.cbIsalcoholisch.Name = "cbIsalcoholisch";
            this.cbIsalcoholisch.Size = new System.Drawing.Size(101, 21);
            this.cbIsalcoholisch.TabIndex = 27;
            this.cbIsalcoholisch.Text = "Alcoholisch";
            this.cbIsalcoholisch.UseVisualStyleBackColor = true;
            // 
            // MenuKaartAanpassenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1094, 723);
            this.Controls.Add(this.pnlItemAanpassen);
            this.Controls.Add(this.pnlItemToevoegen);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.btnItemAanpassen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOpnieuwLaden);
            this.Controls.Add(this.lvMenuKaartAanpassen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuKaartAanpassenForm";
            this.Text = "MenuKaartAanpassenForm";
            this.Load += new System.EventHandler(this.MenuKaartAanpassenForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlItemToevoegen.ResumeLayout(false);
            this.pnlItemToevoegen.PerformLayout();
            this.pnlItemAanpassen.ResumeLayout(false);
            this.pnlItemAanpassen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ListView lvMenuKaartAanpassen;
        private System.Windows.Forms.Button btnOpnieuwLaden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnItemAanpassen;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Panel pnlItemToevoegen;
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
        private System.Windows.Forms.Panel pnlItemAanpassen;
        private System.Windows.Forms.TextBox tbmenukaartitem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbtypeitem;
        private System.Windows.Forms.Label lblIDitem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblOmschrijving;
        private System.Windows.Forms.TextBox tbprijsitem;
        private System.Windows.Forms.TextBox tbomschrijvingitem;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Label lbltitel;
        private System.Windows.Forms.CheckBox cbIsalcoholisch;
    }
}