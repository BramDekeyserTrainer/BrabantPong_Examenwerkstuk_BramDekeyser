namespace BrabantPong_Examenwerkstuk
{
    partial class formSpelerKaart
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
            this.btnKeerTerug = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.lblKlassement = new System.Windows.Forms.Label();
            this.lblELO = new System.Windows.Forms.Label();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKeerTerug
            // 
            this.btnKeerTerug.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKeerTerug.Location = new System.Drawing.Point(0, 0);
            this.btnKeerTerug.Name = "btnKeerTerug";
            this.btnKeerTerug.Size = new System.Drawing.Size(800, 39);
            this.btnKeerTerug.TabIndex = 2;
            this.btnKeerTerug.Text = "Keer terug";
            this.btnKeerTerug.UseVisualStyleBackColor = true;
            this.btnKeerTerug.Click += new System.EventHandler(this.btnKeerTerug_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(149, 194);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 20);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender: ";
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.Location = new System.Drawing.Point(149, 237);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(46, 20);
            this.lblClub.TabIndex = 4;
            this.lblClub.Text = "Club: ";
            // 
            // lblKlassement
            // 
            this.lblKlassement.AutoSize = true;
            this.lblKlassement.Location = new System.Drawing.Point(406, 194);
            this.lblKlassement.Name = "lblKlassement";
            this.lblKlassement.Size = new System.Drawing.Size(91, 20);
            this.lblKlassement.TabIndex = 6;
            this.lblKlassement.Text = "Klassement: ";
            // 
            // lblELO
            // 
            this.lblELO.AutoSize = true;
            this.lblELO.Location = new System.Drawing.Point(406, 237);
            this.lblELO.Name = "lblELO";
            this.lblELO.Size = new System.Drawing.Size(88, 20);
            this.lblELO.TabIndex = 7;
            this.lblELO.Text = "ELO-Punten:";
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAfsluiten.Location = new System.Drawing.Point(0, 408);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(800, 43);
            this.btnAfsluiten.TabIndex = 13;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // formSpelerKaart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.lblELO);
            this.Controls.Add(this.lblKlassement);
            this.Controls.Add(this.lblClub);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnKeerTerug);
            this.Name = "formSpelerKaart";
            this.Text = "SpelerKaart";
            this.Load += new System.EventHandler(this.formSpelerKaart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnKeerTerug;
        private Label lblGender;
        private Label lblClub;
        private Label lblKlassement;
        private Label lblELO;
        private Button btnAfsluiten;
    }
}