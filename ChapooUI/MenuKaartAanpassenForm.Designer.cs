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
            this.lvLunch = new System.Windows.Forms.ListView();
            this.lvDinner = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDrankOphalen = new System.Windows.Forms.Button();
            this.btnLunchOphalen = new System.Windows.Forms.Button();
            this.btnDinnerOphalen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
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
            this.lvDrank.Location = new System.Drawing.Point(25, 239);
            this.lvDrank.Name = "lvDrank";
            this.lvDrank.Size = new System.Drawing.Size(313, 444);
            this.lvDrank.TabIndex = 1;
            this.lvDrank.UseCompatibleStateImageBehavior = false;
            this.lvDrank.View = System.Windows.Forms.View.Details;
            // 
            // lvLunch
            // 
            this.lvLunch.HideSelection = false;
            this.lvLunch.Location = new System.Drawing.Point(373, 239);
            this.lvLunch.Name = "lvLunch";
            this.lvLunch.Size = new System.Drawing.Size(313, 444);
            this.lvLunch.TabIndex = 2;
            this.lvLunch.UseCompatibleStateImageBehavior = false;
            this.lvLunch.View = System.Windows.Forms.View.Details;
            // 
            // lvDinner
            // 
            this.lvDinner.HideSelection = false;
            this.lvDinner.Location = new System.Drawing.Point(722, 239);
            this.lvDinner.Name = "lvDinner";
            this.lvDinner.Size = new System.Drawing.Size(313, 444);
            this.lvDinner.TabIndex = 3;
            this.lvDinner.UseCompatibleStateImageBehavior = false;
            this.lvDinner.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dranken Kaart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lunch Kaart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(719, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dinner Kaart";
            // 
            // btnDrankOphalen
            // 
            this.btnDrankOphalen.Location = new System.Drawing.Point(234, 205);
            this.btnDrankOphalen.Name = "btnDrankOphalen";
            this.btnDrankOphalen.Size = new System.Drawing.Size(104, 28);
            this.btnDrankOphalen.TabIndex = 7;
            this.btnDrankOphalen.Text = "ophalen";
            this.btnDrankOphalen.UseVisualStyleBackColor = true;
            this.btnDrankOphalen.Click += new System.EventHandler(this.btnDrankOphalen_Click);
            // 
            // btnLunchOphalen
            // 
            this.btnLunchOphalen.Location = new System.Drawing.Point(582, 205);
            this.btnLunchOphalen.Name = "btnLunchOphalen";
            this.btnLunchOphalen.Size = new System.Drawing.Size(104, 28);
            this.btnLunchOphalen.TabIndex = 8;
            this.btnLunchOphalen.Text = "ophalen";
            this.btnLunchOphalen.UseVisualStyleBackColor = true;
            this.btnLunchOphalen.Click += new System.EventHandler(this.btnLunchOphalen_Click);
            // 
            // btnDinnerOphalen
            // 
            this.btnDinnerOphalen.Location = new System.Drawing.Point(931, 205);
            this.btnDinnerOphalen.Name = "btnDinnerOphalen";
            this.btnDinnerOphalen.Size = new System.Drawing.Size(104, 28);
            this.btnDinnerOphalen.TabIndex = 9;
            this.btnDinnerOphalen.Text = "ophalen";
            this.btnDinnerOphalen.UseVisualStyleBackColor = true;
            this.btnDinnerOphalen.Click += new System.EventHandler(this.btnDinnerOphalen_Click);
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
            this.button1.Location = new System.Drawing.Point(263, 689);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(960, 689);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MenuKaartAanpassenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1067, 723);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDinnerOphalen);
            this.Controls.Add(this.btnLunchOphalen);
            this.Controls.Add(this.btnDrankOphalen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvDinner);
            this.Controls.Add(this.lvLunch);
            this.Controls.Add(this.lvDrank);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuKaartAanpassenForm";
            this.Text = "MenuKaartAanpassenForm";
            this.Load += new System.EventHandler(this.MenuKaartAanpassenForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ListView lvDrank;
        private System.Windows.Forms.ListView lvLunch;
        private System.Windows.Forms.ListView lvDinner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDrankOphalen;
        private System.Windows.Forms.Button btnLunchOphalen;
        private System.Windows.Forms.Button btnDinnerOphalen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}