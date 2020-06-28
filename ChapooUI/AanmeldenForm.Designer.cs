namespace ChapooUI
{
    partial class AanmeldenForm
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
            this.tbPin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAanmelden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPin
            // 
            this.tbPin.Location = new System.Drawing.Point(445, 117);
            this.tbPin.Multiline = true;
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(265, 35);
            this.tbPin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "PIN";
            // 
            // btnAanmelden
            // 
            this.btnAanmelden.Location = new System.Drawing.Point(595, 158);
            this.btnAanmelden.Name = "btnAanmelden";
            this.btnAanmelden.Size = new System.Drawing.Size(115, 36);
            this.btnAanmelden.TabIndex = 2;
            this.btnAanmelden.Text = "Aanmelden";
            this.btnAanmelden.UseVisualStyleBackColor = true;
            this.btnAanmelden.Click += new System.EventHandler(this.btnAanmelden_Click);
            // 
            // AanmeldenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1154, 450);
            this.Controls.Add(this.btnAanmelden);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPin);
            this.Name = "AanmeldenForm";
            this.Text = "AanmeldenForm";
            this.Load += new System.EventHandler(this.AanmeldenForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAanmelden;
    }
}