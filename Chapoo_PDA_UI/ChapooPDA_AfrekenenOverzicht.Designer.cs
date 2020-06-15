namespace Chapoo_PDA_UI
{
    partial class ChapooPDA_AfrekenenOverzicht
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
            this.btnVerstuurRekening = new System.Windows.Forms.Button();
            this.pnlAfrekenenOverzicht = new System.Windows.Forms.Panel();
            this.lvRekeningOverzicht = new System.Windows.Forms.ListView();
            this.tbFooi = new System.Windows.Forms.TextBox();
            this.lblTotaalPrijs = new System.Windows.Forms.Label();
            this.pnlAfrekenenOverzicht.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerstuurRekening
            // 
            this.btnVerstuurRekening.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerstuurRekening.Location = new System.Drawing.Point(181, 600);
            this.btnVerstuurRekening.Name = "btnVerstuurRekening";
            this.btnVerstuurRekening.Size = new System.Drawing.Size(321, 69);
            this.btnVerstuurRekening.TabIndex = 1;
            this.btnVerstuurRekening.Text = "Doorsturen naar kassa";
            this.btnVerstuurRekening.UseVisualStyleBackColor = true;
            this.btnVerstuurRekening.Click += new System.EventHandler(this.btnVerstuurRekening_Click);
            // 
            // pnlAfrekenenOverzicht
            // 
            this.pnlAfrekenenOverzicht.Controls.Add(this.lblTotaalPrijs);
            this.pnlAfrekenenOverzicht.Controls.Add(this.tbFooi);
            this.pnlAfrekenenOverzicht.Controls.Add(this.lvRekeningOverzicht);
            this.pnlAfrekenenOverzicht.Location = new System.Drawing.Point(12, 12);
            this.pnlAfrekenenOverzicht.Name = "pnlAfrekenenOverzicht";
            this.pnlAfrekenenOverzicht.Size = new System.Drawing.Size(680, 582);
            this.pnlAfrekenenOverzicht.TabIndex = 2;
            // 
            // lvRekeningOverzicht
            // 
            this.lvRekeningOverzicht.HideSelection = false;
            this.lvRekeningOverzicht.Location = new System.Drawing.Point(71, 22);
            this.lvRekeningOverzicht.Name = "lvRekeningOverzicht";
            this.lvRekeningOverzicht.Size = new System.Drawing.Size(526, 457);
            this.lvRekeningOverzicht.TabIndex = 0;
            this.lvRekeningOverzicht.UseCompatibleStateImageBehavior = false;
            this.lvRekeningOverzicht.View = System.Windows.Forms.View.Details;
            // 
            // tbFooi
            // 
            this.tbFooi.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.tbFooi.Location = new System.Drawing.Point(71, 486);
            this.tbFooi.Name = "tbFooi";
            this.tbFooi.Size = new System.Drawing.Size(169, 40);
            this.tbFooi.TabIndex = 1;
            // 
            // lblTotaalPrijs
            // 
            this.lblTotaalPrijs.AutoSize = true;
            this.lblTotaalPrijs.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.lblTotaalPrijs.Location = new System.Drawing.Point(350, 549);
            this.lblTotaalPrijs.Name = "lblTotaalPrijs";
            this.lblTotaalPrijs.Size = new System.Drawing.Size(194, 33);
            this.lblTotaalPrijs.TabIndex = 2;
            this.lblTotaalPrijs.Text = "Totaal Prijs: €";
            // 
            // ChapooPDA_AfrekenenOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.pnlAfrekenenOverzicht);
            this.Controls.Add(this.btnVerstuurRekening);
            this.Name = "ChapooPDA_AfrekenenOverzicht";
            this.Text = "ChapooPDA_AfrekenenOverzicht";
            this.pnlAfrekenenOverzicht.ResumeLayout(false);
            this.pnlAfrekenenOverzicht.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVerstuurRekening;
        private System.Windows.Forms.Panel pnlAfrekenenOverzicht;
        private System.Windows.Forms.ListView lvRekeningOverzicht;
        private System.Windows.Forms.TextBox tbFooi;
        private System.Windows.Forms.Label lblTotaalPrijs;
    }
}