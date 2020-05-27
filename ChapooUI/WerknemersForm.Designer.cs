namespace ChapooUI
{
    partial class WerknemersForm
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
            this.msp_WerknemersForm = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mts_HomeWerknemersForm = new System.Windows.Forms.ToolStripMenuItem();
            this.klantenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lv_Werknemers = new System.Windows.Forms.ListView();
            this.btnAanpassen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.msp_WerknemersForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msp_WerknemersForm
            // 
            this.msp_WerknemersForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.msp_WerknemersForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msp_WerknemersForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.klantenToolStripMenuItem1});
            this.msp_WerknemersForm.Location = new System.Drawing.Point(0, 0);
            this.msp_WerknemersForm.Name = "msp_WerknemersForm";
            this.msp_WerknemersForm.Size = new System.Drawing.Size(1039, 30);
            this.msp_WerknemersForm.TabIndex = 1;
            this.msp_WerknemersForm.Text = "menuStrip1";
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.HomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mts_HomeWerknemersForm});
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.HomeToolStripMenuItem.Text = "Home";
            // 
            // mts_HomeWerknemersForm
            // 
            this.mts_HomeWerknemersForm.Name = "mts_HomeWerknemersForm";
            this.mts_HomeWerknemersForm.Size = new System.Drawing.Size(224, 26);
            this.mts_HomeWerknemersForm.Text = "Home";
            this.mts_HomeWerknemersForm.Click += new System.EventHandler(this.mts_HomeWerknemersForm_Click);
            // 
            // klantenToolStripMenuItem1
            // 
            this.klantenToolStripMenuItem1.BackColor = System.Drawing.Color.White;
            this.klantenToolStripMenuItem1.Name = "klantenToolStripMenuItem1";
            this.klantenToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.klantenToolStripMenuItem1.Text = "Restaurant Overzicht";
            // 
            // lv_Werknemers
            // 
            this.lv_Werknemers.HideSelection = false;
            this.lv_Werknemers.Location = new System.Drawing.Point(29, 108);
            this.lv_Werknemers.Name = "lv_Werknemers";
            this.lv_Werknemers.Size = new System.Drawing.Size(518, 501);
            this.lv_Werknemers.TabIndex = 2;
            this.lv_Werknemers.UseCompatibleStateImageBehavior = false;
            this.lv_Werknemers.View = System.Windows.Forms.View.Details;
            this.lv_Werknemers.SelectedIndexChanged += new System.EventHandler(this.lv_Werknemers_SelectedIndexChanged);
            // 
            // btnAanpassen
            // 
            this.btnAanpassen.Location = new System.Drawing.Point(0, 0);
            this.btnAanpassen.Name = "btnAanpassen";
            this.btnAanpassen.Size = new System.Drawing.Size(181, 41);
            this.btnAanpassen.TabIndex = 3;
            this.btnAanpassen.Text = "aanpassen";
            this.btnAanpassen.UseVisualStyleBackColor = true;
            this.btnAanpassen.Click += new System.EventHandler(this.btnAanpassen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tbNaam);
            this.panel1.Controls.Add(this.btnOpslaan);
            this.panel1.Controls.Add(this.btnVerwijder);
            this.panel1.Controls.Add(this.btnAanpassen);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(584, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 288);
            this.panel1.TabIndex = 4;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(252, 57);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 25);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Werknemers";
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(0, 240);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 48);
            this.btnVerwijder.TabIndex = 3;
            this.btnVerwijder.Text = "verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(326, 240);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(75, 48);
            this.btnOpslaan.TabIndex = 4;
            this.btnOpslaan.Text = "opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(17, 57);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(134, 22);
            this.tbNaam.TabIndex = 5;
            this.tbNaam.Text = "Naam";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ophalen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WerknemersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1039, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lv_Werknemers);
            this.Controls.Add(this.msp_WerknemersForm);
            this.Name = "WerknemersForm";
            this.Text = "Werknemers";
            this.Load += new System.EventHandler(this.WerknemersForm_Load);
            this.msp_WerknemersForm.ResumeLayout(false);
            this.msp_WerknemersForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msp_WerknemersForm;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mts_HomeWerknemersForm;
        private System.Windows.Forms.ToolStripMenuItem klantenToolStripMenuItem1;
        private System.Windows.Forms.ListView lv_Werknemers;
        private System.Windows.Forms.Button btnAanpassen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Button button1;
    }
}