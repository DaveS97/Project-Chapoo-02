namespace Chapoo_PDA_UI
{
    partial class ChapooPDA_AfrekenenMenu
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
            this.tbTafelnummerAfrekenen = new System.Windows.Forms.TextBox();
            this.lblTafelnummer = new System.Windows.Forms.Label();
            this.btnPresenteerRekening = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbTafelnummerAfrekenen
            // 
            this.tbTafelnummerAfrekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTafelnummerAfrekenen.Location = new System.Drawing.Point(305, 351);
            this.tbTafelnummerAfrekenen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTafelnummerAfrekenen.Name = "tbTafelnummerAfrekenen";
            this.tbTafelnummerAfrekenen.Size = new System.Drawing.Size(316, 98);
            this.tbTafelnummerAfrekenen.TabIndex = 0;
            // 
            // lblTafelnummer
            // 
            this.lblTafelnummer.AutoSize = true;
            this.lblTafelnummer.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTafelnummer.ForeColor = System.Drawing.Color.White;
            this.lblTafelnummer.Location = new System.Drawing.Point(293, 286);
            this.lblTafelnummer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTafelnummer.Name = "lblTafelnummer";
            this.lblTafelnummer.Size = new System.Drawing.Size(318, 62);
            this.lblTafelnummer.TabIndex = 1;
            this.lblTafelnummer.Text = "Tafelnummer";
            // 
            // btnPresenteerRekening
            // 
            this.btnPresenteerRekening.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresenteerRekening.Location = new System.Drawing.Point(210, 457);
            this.btnPresenteerRekening.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPresenteerRekening.Name = "btnPresenteerRekening";
            this.btnPresenteerRekening.Size = new System.Drawing.Size(507, 123);
            this.btnPresenteerRekening.TabIndex = 2;
            this.btnPresenteerRekening.Text = "Presenteer rekening";
            this.btnPresenteerRekening.UseVisualStyleBackColor = true;
            this.btnPresenteerRekening.Click += new System.EventHandler(this.btnPresenteerRekening_Click);
            // 
            // ChapooPDA_AfrekenenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(939, 838);
            this.Controls.Add(this.btnPresenteerRekening);
            this.Controls.Add(this.lblTafelnummer);
            this.Controls.Add(this.tbTafelnummerAfrekenen);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChapooPDA_AfrekenenMenu";
            this.Text = "ChapooPDA_AfrekenenMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTafelnummerAfrekenen;
        private System.Windows.Forms.Label lblTafelnummer;
        private System.Windows.Forms.Button btnPresenteerRekening;
    }
}