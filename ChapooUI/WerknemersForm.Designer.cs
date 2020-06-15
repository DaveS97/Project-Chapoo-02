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
            this.lv_Werknemers = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPinAanpassenWerknemer = new System.Windows.Forms.TextBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlToevoegen = new System.Windows.Forms.Panel();
            this.cbIs_Actief = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPinToevoegen = new System.Windows.Forms.TextBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTypeToevoegen = new System.Windows.Forms.TextBox();
            this.tbNaamToevoegen = new System.Windows.Forms.TextBox();
            this.btnWerknemerToevoegen = new System.Windows.Forms.Button();
            this.msp_WerknemersForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlToevoegen.SuspendLayout();
            this.SuspendLayout();
            // 
            // msp_WerknemersForm
            // 
            this.msp_WerknemersForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.msp_WerknemersForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msp_WerknemersForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem});
            this.msp_WerknemersForm.Location = new System.Drawing.Point(0, 0);
            this.msp_WerknemersForm.Name = "msp_WerknemersForm";
            this.msp_WerknemersForm.Size = new System.Drawing.Size(1039, 28);
            this.msp_WerknemersForm.TabIndex = 1;
            this.msp_WerknemersForm.Text = "menuStrip1";
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.HomeToolStripMenuItem.Text = "Home";
            this.HomeToolStripMenuItem.Click += new System.EventHandler(this.HomeToolStripMenuItem_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbPinAanpassenWerknemer);
            this.panel1.Controls.Add(this.tbNaam);
            this.panel1.Controls.Add(this.btnOpslaan);
            this.panel1.Controls.Add(this.btnVerwijder);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Location = new System.Drawing.Point(585, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 250);
            this.panel1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "PIN";
            // 
            // tbPinAanpassenWerknemer
            // 
            this.tbPinAanpassenWerknemer.Location = new System.Drawing.Point(17, 118);
            this.tbPinAanpassenWerknemer.Name = "tbPinAanpassenWerknemer";
            this.tbPinAanpassenWerknemer.Size = new System.Drawing.Size(103, 22);
            this.tbPinAanpassenWerknemer.TabIndex = 6;
            this.tbPinAanpassenWerknemer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(17, 57);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(134, 22);
            this.tbNaam.TabIndex = 5;
            this.tbNaam.Text = "Naam";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(299, 199);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(102, 48);
            this.btnOpslaan.TabIndex = 4;
            this.btnOpslaan.Text = "opslaan";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(0, 199);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(196, 48);
            this.btnVerwijder.TabIndex = 3;
            this.btnVerwijder.Text = "werknemer verwijderen";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
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
            this.label1.Size = new System.Drawing.Size(299, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "personeel aanpassen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "opnieuw laden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlToevoegen
            // 
            this.pnlToevoegen.BackColor = System.Drawing.Color.White;
            this.pnlToevoegen.Controls.Add(this.cbIs_Actief);
            this.pnlToevoegen.Controls.Add(this.label5);
            this.pnlToevoegen.Controls.Add(this.tbPinToevoegen);
            this.pnlToevoegen.Controls.Add(this.btnVoegToe);
            this.pnlToevoegen.Controls.Add(this.label4);
            this.pnlToevoegen.Controls.Add(this.label3);
            this.pnlToevoegen.Controls.Add(this.label2);
            this.pnlToevoegen.Controls.Add(this.tbTypeToevoegen);
            this.pnlToevoegen.Controls.Add(this.tbNaamToevoegen);
            this.pnlToevoegen.Location = new System.Drawing.Point(574, 359);
            this.pnlToevoegen.Name = "pnlToevoegen";
            this.pnlToevoegen.Size = new System.Drawing.Size(412, 250);
            this.pnlToevoegen.TabIndex = 7;
            // 
            // cbIs_Actief
            // 
            this.cbIs_Actief.AutoSize = true;
            this.cbIs_Actief.Location = new System.Drawing.Point(211, 57);
            this.cbIs_Actief.Name = "cbIs_Actief";
            this.cbIs_Actief.Size = new System.Drawing.Size(79, 21);
            this.cbIs_Actief.TabIndex = 9;
            this.cbIs_Actief.Text = "is Actief";
            this.cbIs_Actief.UseVisualStyleBackColor = true;
            this.cbIs_Actief.CheckedChanged += new System.EventHandler(this.cbIs_Actief_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "PIN";
            // 
            // tbPinToevoegen
            // 
            this.tbPinToevoegen.Location = new System.Drawing.Point(26, 182);
            this.tbPinToevoegen.Name = "tbPinToevoegen";
            this.tbPinToevoegen.Size = new System.Drawing.Size(100, 22);
            this.tbPinToevoegen.TabIndex = 7;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(283, 216);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(129, 34);
            this.btnVoegToe.TabIndex = 6;
            this.btnVoegToe.Text = "Voeg Toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Werknemer Toevoegen";
            // 
            // tbTypeToevoegen
            // 
            this.tbTypeToevoegen.Location = new System.Drawing.Point(26, 113);
            this.tbTypeToevoegen.Name = "tbTypeToevoegen";
            this.tbTypeToevoegen.Size = new System.Drawing.Size(100, 22);
            this.tbTypeToevoegen.TabIndex = 2;
            // 
            // tbNaamToevoegen
            // 
            this.tbNaamToevoegen.Location = new System.Drawing.Point(26, 57);
            this.tbNaamToevoegen.Name = "tbNaamToevoegen";
            this.tbNaamToevoegen.Size = new System.Drawing.Size(100, 22);
            this.tbNaamToevoegen.TabIndex = 1;
            // 
            // btnWerknemerToevoegen
            // 
            this.btnWerknemerToevoegen.Location = new System.Drawing.Point(165, 615);
            this.btnWerknemerToevoegen.Name = "btnWerknemerToevoegen";
            this.btnWerknemerToevoegen.Size = new System.Drawing.Size(202, 33);
            this.btnWerknemerToevoegen.TabIndex = 8;
            this.btnWerknemerToevoegen.Text = "Werknemer Toevoegen";
            this.btnWerknemerToevoegen.UseVisualStyleBackColor = true;
            this.btnWerknemerToevoegen.Click += new System.EventHandler(this.btnWerknemerToevoegen_Click);
            // 
            // WerknemersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1039, 660);
            this.Controls.Add(this.btnWerknemerToevoegen);
            this.Controls.Add(this.pnlToevoegen);
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
            this.pnlToevoegen.ResumeLayout(false);
            this.pnlToevoegen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msp_WerknemersForm;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ListView lv_Werknemers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlToevoegen;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTypeToevoegen;
        private System.Windows.Forms.TextBox tbNaamToevoegen;
        private System.Windows.Forms.Button btnWerknemerToevoegen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPinToevoegen;
        private System.Windows.Forms.CheckBox cbIs_Actief;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPinAanpassenWerknemer;
    }
}