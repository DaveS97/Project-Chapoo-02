namespace Chapoo_PDA_UI
{
    partial class AanmeldenPDAForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAanmelden = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPin
            // 
            this.tbPin.Location = new System.Drawing.Point(80, 227);
            this.tbPin.Multiline = true;
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(297, 31);
            this.tbPin.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnAanmelden);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbPin);
            this.panel1.Location = new System.Drawing.Point(249, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 379);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aanmelden";
            // 
            // btnAanmelden
            // 
            this.btnAanmelden.Location = new System.Drawing.Point(80, 287);
            this.btnAanmelden.Name = "btnAanmelden";
            this.btnAanmelden.Size = new System.Drawing.Size(297, 52);
            this.btnAanmelden.TabIndex = 2;
            this.btnAanmelden.Text = "Aanmelden";
            this.btnAanmelden.UseVisualStyleBackColor = true;
            this.btnAanmelden.Click += new System.EventHandler(this.btnAanmelden_Click);
            // 
            // AanmeldenPDAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(939, 838);
            this.Controls.Add(this.panel1);
            this.Name = "AanmeldenPDAForm";
            this.Text = "AanmeldenForm";
            this.Load += new System.EventHandler(this.AanmeldenForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAanmelden;
        private System.Windows.Forms.Label label1;
    }
}