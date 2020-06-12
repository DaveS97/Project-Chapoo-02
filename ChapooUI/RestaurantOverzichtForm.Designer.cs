namespace ChapooUI
{
    partial class RestaurantOverzichtForm
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
            this.MS1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MS1I_Home = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_RO = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_BO = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_KO = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Beheer = new System.Windows.Forms.ToolStripMenuItem();
            this.MS1I_Inkomsten = new System.Windows.Forms.ToolStripMenuItem();
            this.MS1I_Voorraad = new System.Windows.Forms.ToolStripMenuItem();
            this.MS1I_MenuKaartOpties = new System.Windows.Forms.ToolStripMenuItem();
            this.MS1I_Werknemers = new System.Windows.Forms.ToolStripMenuItem();
            this.afmeldenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listview_TafelOverzicht = new System.Windows.Forms.ListView();
            this.MS1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS1
            // 
            this.MS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.MS1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MS1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.MS_RO,
            this.MS_BO,
            this.MS_KO,
            this.MS_Beheer,
            this.afmeldenToolStripMenuItem});
            this.MS1.Location = new System.Drawing.Point(0, 0);
            this.MS1.Name = "MS1";
            this.MS1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MS1.Size = new System.Drawing.Size(1045, 24);
            this.MS1.TabIndex = 1;
            this.MS1.Text = "menuStrip1";
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.HomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS1I_Home});
            this.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.HomeToolStripMenuItem.Text = "Home";
            // 
            // MS1I_Home
            // 
            this.MS1I_Home.Name = "MS1I_Home";
            this.MS1I_Home.Size = new System.Drawing.Size(107, 22);
            this.MS1I_Home.Text = "Home";
            // 
            // MS_RO
            // 
            this.MS_RO.BackColor = System.Drawing.Color.White;
            this.MS_RO.ForeColor = System.Drawing.Color.Black;
            this.MS_RO.Name = "MS_RO";
            this.MS_RO.Size = new System.Drawing.Size(128, 20);
            this.MS_RO.Text = "Restaurant Overzicht";
            // 
            // MS_BO
            // 
            this.MS_BO.BackColor = System.Drawing.Color.White;
            this.MS_BO.Name = "MS_BO";
            this.MS_BO.Size = new System.Drawing.Size(89, 20);
            this.MS_BO.Text = "Bar Overzicht";
            // 
            // MS_KO
            // 
            this.MS_KO.BackColor = System.Drawing.Color.White;
            this.MS_KO.Name = "MS_KO";
            this.MS_KO.Size = new System.Drawing.Size(111, 20);
            this.MS_KO.Text = "Keuken Overzicht";
            // 
            // MS_Beheer
            // 
            this.MS_Beheer.BackColor = System.Drawing.Color.White;
            this.MS_Beheer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS1I_Inkomsten,
            this.MS1I_Voorraad,
            this.MS1I_MenuKaartOpties,
            this.MS1I_Werknemers});
            this.MS_Beheer.Name = "MS_Beheer";
            this.MS_Beheer.Size = new System.Drawing.Size(55, 20);
            this.MS_Beheer.Text = "Beheer";
            // 
            // MS1I_Inkomsten
            // 
            this.MS1I_Inkomsten.Name = "MS1I_Inkomsten";
            this.MS1I_Inkomsten.Size = new System.Drawing.Size(192, 22);
            this.MS1I_Inkomsten.Text = "Inkomsten";
            // 
            // MS1I_Voorraad
            // 
            this.MS1I_Voorraad.Name = "MS1I_Voorraad";
            this.MS1I_Voorraad.Size = new System.Drawing.Size(192, 22);
            this.MS1I_Voorraad.Text = "Voorraad";
            // 
            // MS1I_MenuKaartOpties
            // 
            this.MS1I_MenuKaartOpties.Name = "MS1I_MenuKaartOpties";
            this.MS1I_MenuKaartOpties.Size = new System.Drawing.Size(192, 22);
            this.MS1I_MenuKaartOpties.Text = "Menu kaart aanpassen";
            // 
            // MS1I_Werknemers
            // 
            this.MS1I_Werknemers.Name = "MS1I_Werknemers";
            this.MS1I_Werknemers.Size = new System.Drawing.Size(192, 22);
            this.MS1I_Werknemers.Text = "Werknemers";
            // 
            // afmeldenToolStripMenuItem
            // 
            this.afmeldenToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.afmeldenToolStripMenuItem.Name = "afmeldenToolStripMenuItem";
            this.afmeldenToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.afmeldenToolStripMenuItem.Text = "afmelden";
            // 
            // listview_TafelOverzicht
            // 
            this.listview_TafelOverzicht.HideSelection = false;
            this.listview_TafelOverzicht.Location = new System.Drawing.Point(22, 41);
            this.listview_TafelOverzicht.Name = "listview_TafelOverzicht";
            this.listview_TafelOverzicht.Size = new System.Drawing.Size(442, 490);
            this.listview_TafelOverzicht.TabIndex = 2;
            this.listview_TafelOverzicht.UseCompatibleStateImageBehavior = false;
            // 
            // RestaurantOverzichtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1045, 543);
            this.Controls.Add(this.listview_TafelOverzicht);
            this.Controls.Add(this.MS1);
            this.Name = "RestaurantOverzichtForm";
            this.Text = "RestaurantOverzichtForm";
            this.MS1.ResumeLayout(false);
            this.MS1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MS1I_Home;
        private System.Windows.Forms.ToolStripMenuItem MS_RO;
        private System.Windows.Forms.ToolStripMenuItem MS_BO;
        private System.Windows.Forms.ToolStripMenuItem MS_KO;
        private System.Windows.Forms.ToolStripMenuItem MS_Beheer;
        private System.Windows.Forms.ToolStripMenuItem MS1I_Inkomsten;
        private System.Windows.Forms.ToolStripMenuItem MS1I_Voorraad;
        private System.Windows.Forms.ToolStripMenuItem MS1I_MenuKaartOpties;
        private System.Windows.Forms.ToolStripMenuItem MS1I_Werknemers;
        private System.Windows.Forms.ToolStripMenuItem afmeldenToolStripMenuItem;
        private System.Windows.Forms.ListView listview_TafelOverzicht;
    }
}