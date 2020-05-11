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
            this.msp_WerknemersForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // msp_WerknemersForm
            // 
            this.msp_WerknemersForm.BackColor = System.Drawing.Color.DarkBlue;
            this.msp_WerknemersForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msp_WerknemersForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.klantenToolStripMenuItem1});
            this.msp_WerknemersForm.Location = new System.Drawing.Point(0, 0);
            this.msp_WerknemersForm.Name = "msp_WerknemersForm";
            this.msp_WerknemersForm.Size = new System.Drawing.Size(1039, 28);
            this.msp_WerknemersForm.TabIndex = 1;
            this.msp_WerknemersForm.Text = "menuStrip1";
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.HomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mts_HomeWerknemersForm});
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
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
            this.klantenToolStripMenuItem1.Size = new System.Drawing.Size(159, 24);
            this.klantenToolStripMenuItem1.Text = "Restaurant Overzicht";
            // 
            // lv_Werknemers
            // 
            this.lv_Werknemers.HideSelection = false;
            this.lv_Werknemers.Location = new System.Drawing.Point(53, 89);
            this.lv_Werknemers.Name = "lv_Werknemers";
            this.lv_Werknemers.Size = new System.Drawing.Size(280, 319);
            this.lv_Werknemers.TabIndex = 2;
            this.lv_Werknemers.UseCompatibleStateImageBehavior = false;
            this.lv_Werknemers.View = System.Windows.Forms.View.Details;
            // 
            // WerknemersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1039, 550);
            this.Controls.Add(this.lv_Werknemers);
            this.Controls.Add(this.msp_WerknemersForm);
            this.Name = "WerknemersForm";
            this.Text = "Werknemers";
            this.msp_WerknemersForm.ResumeLayout(false);
            this.msp_WerknemersForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msp_WerknemersForm;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mts_HomeWerknemersForm;
        private System.Windows.Forms.ToolStripMenuItem klantenToolStripMenuItem1;
        private System.Windows.Forms.ListView lv_Werknemers;
    }
}