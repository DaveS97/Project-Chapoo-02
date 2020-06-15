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
            this.lbl_Betalingswijze = new System.Windows.Forms.Label();
            this.cb_Contant = new System.Windows.Forms.CheckBox();
            this.cb_Digitaal = new System.Windows.Forms.CheckBox();
            this.lbl_Fooi = new System.Windows.Forms.Label();
            this.txtbx_Fooi = new System.Windows.Forms.TextBox();
            this.pnlAfrekenenOverzicht.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerstuurRekening
            // 
            this.btnVerstuurRekening.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerstuurRekening.Location = new System.Drawing.Point(185, 600);
            this.btnVerstuurRekening.Name = "btnVerstuurRekening";
            this.btnVerstuurRekening.Size = new System.Drawing.Size(321, 69);
            this.btnVerstuurRekening.TabIndex = 1;
            this.btnVerstuurRekening.Text = "Doorsturen naar kassa";
            this.btnVerstuurRekening.UseVisualStyleBackColor = true;
            this.btnVerstuurRekening.Click += new System.EventHandler(this.btnVerstuurRekening_Click);
            // 
            // pnlAfrekenenOverzicht
            // 
            this.pnlAfrekenenOverzicht.Controls.Add(this.txtbx_Fooi);
            this.pnlAfrekenenOverzicht.Controls.Add(this.lbl_Fooi);
            this.pnlAfrekenenOverzicht.Controls.Add(this.cb_Contant);
            this.pnlAfrekenenOverzicht.Controls.Add(this.cb_Digitaal);
            this.pnlAfrekenenOverzicht.Controls.Add(this.lbl_Betalingswijze);
            this.pnlAfrekenenOverzicht.Controls.Add(this.lvRekeningOverzicht);
            this.pnlAfrekenenOverzicht.Location = new System.Drawing.Point(12, 12);
            this.pnlAfrekenenOverzicht.Name = "pnlAfrekenenOverzicht";
            this.pnlAfrekenenOverzicht.Size = new System.Drawing.Size(680, 582);
            this.pnlAfrekenenOverzicht.TabIndex = 2;
            // 
            // lvRekeningOverzicht
            // 
            this.lvRekeningOverzicht.HideSelection = false;
            this.lvRekeningOverzicht.Location = new System.Drawing.Point(0, 0);
            this.lvRekeningOverzicht.Name = "lvRekeningOverzicht";
            this.lvRekeningOverzicht.Size = new System.Drawing.Size(680, 514);
            this.lvRekeningOverzicht.TabIndex = 0;
            this.lvRekeningOverzicht.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Betalingswijze
            // 
            this.lbl_Betalingswijze.AutoSize = true;
            this.lbl_Betalingswijze.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Betalingswijze.ForeColor = System.Drawing.Color.White;
            this.lbl_Betalingswijze.Location = new System.Drawing.Point(121, 527);
            this.lbl_Betalingswijze.Name = "lbl_Betalingswijze";
            this.lbl_Betalingswijze.Size = new System.Drawing.Size(142, 25);
            this.lbl_Betalingswijze.TabIndex = 3;
            this.lbl_Betalingswijze.Text = "Betalingswijze:";
            this.lbl_Betalingswijze.Click += new System.EventHandler(this.lbl_Betalingswijze_Click);
            // 
            // cb_Contant
            // 
            this.cb_Contant.AutoSize = true;
            this.cb_Contant.ForeColor = System.Drawing.Color.White;
            this.cb_Contant.Location = new System.Drawing.Point(269, 527);
            this.cb_Contant.Name = "cb_Contant";
            this.cb_Contant.Size = new System.Drawing.Size(63, 17);
            this.cb_Contant.TabIndex = 3;
            this.cb_Contant.Text = "Contant";
            this.cb_Contant.UseVisualStyleBackColor = true;
            // 
            // cb_Digitaal
            // 
            this.cb_Digitaal.AutoSize = true;
            this.cb_Digitaal.ForeColor = System.Drawing.Color.White;
            this.cb_Digitaal.Location = new System.Drawing.Point(269, 550);
            this.cb_Digitaal.Name = "cb_Digitaal";
            this.cb_Digitaal.Size = new System.Drawing.Size(61, 17);
            this.cb_Digitaal.TabIndex = 4;
            this.cb_Digitaal.Text = "Digitaal";
            this.cb_Digitaal.UseVisualStyleBackColor = true;
            // 
            // lbl_Fooi
            // 
            this.lbl_Fooi.AutoSize = true;
            this.lbl_Fooi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fooi.ForeColor = System.Drawing.Color.White;
            this.lbl_Fooi.Location = new System.Drawing.Point(388, 526);
            this.lbl_Fooi.Name = "lbl_Fooi";
            this.lbl_Fooi.Size = new System.Drawing.Size(56, 25);
            this.lbl_Fooi.TabIndex = 5;
            this.lbl_Fooi.Text = "Fooi:";
            // 
            // txtbx_Fooi
            // 
            this.txtbx_Fooi.Location = new System.Drawing.Point(450, 532);
            this.txtbx_Fooi.Name = "txtbx_Fooi";
            this.txtbx_Fooi.Size = new System.Drawing.Size(108, 20);
            this.txtbx_Fooi.TabIndex = 6;
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
        private System.Windows.Forms.Label lbl_Betalingswijze;
        private System.Windows.Forms.TextBox txtbx_Fooi;
        private System.Windows.Forms.Label lbl_Fooi;
        private System.Windows.Forms.CheckBox cb_Contant;
        private System.Windows.Forms.CheckBox cb_Digitaal;
    }
}