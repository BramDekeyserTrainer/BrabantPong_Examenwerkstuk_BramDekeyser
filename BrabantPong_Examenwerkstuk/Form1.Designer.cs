namespace BrabantPong_Examenwerkstuk
{
    partial class formBrabantPong
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBrabantPongTitel = new System.Windows.Forms.Label();
            this.mstrpDataLijst = new System.Windows.Forms.MenuStrip();
            this.spelersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strpitem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.btnInformatie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mstrpDataLijst.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBrabantPongTitel
            // 
            this.lblBrabantPongTitel.AutoSize = true;
            this.lblBrabantPongTitel.Location = new System.Drawing.Point(310, 23);
            this.lblBrabantPongTitel.Name = "lblBrabantPongTitel";
            this.lblBrabantPongTitel.Size = new System.Drawing.Size(94, 20);
            this.lblBrabantPongTitel.TabIndex = 0;
            this.lblBrabantPongTitel.Text = "BrabantPong";
            // 
            // mstrpDataLijst
            // 
            this.mstrpDataLijst.Dock = System.Windows.Forms.DockStyle.None;
            this.mstrpDataLijst.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mstrpDataLijst.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spelersToolStripMenuItem});
            this.mstrpDataLijst.Location = new System.Drawing.Point(57, 68);
            this.mstrpDataLijst.Name = "mstrpDataLijst";
            this.mstrpDataLijst.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.mstrpDataLijst.Size = new System.Drawing.Size(79, 30);
            this.mstrpDataLijst.TabIndex = 1;
            this.mstrpDataLijst.Text = "menuStrip1";
            // 
            // spelersToolStripMenuItem
            // 
            this.spelersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpitem1});
            this.spelersToolStripMenuItem.Name = "spelersToolStripMenuItem";
            this.spelersToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.spelersToolStripMenuItem.Text = "Spelers";
            this.spelersToolStripMenuItem.Click += new System.EventHandler(this.spelersToolStripMenuItem_Click);
            // 
            // strpitem1
            // 
            this.strpitem1.Name = "strpitem1";
            this.strpitem1.Size = new System.Drawing.Size(224, 26);
            this.strpitem1.Text = "Test Persoon";
            this.strpitem1.Click += new System.EventHandler(this.strpitem1_Click);
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAfsluiten.Location = new System.Drawing.Point(0, 654);
            this.btnAfsluiten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(732, 49);
            this.btnAfsluiten.TabIndex = 2;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // btnInformatie
            // 
            this.btnInformatie.Location = new System.Drawing.Point(541, 67);
            this.btnInformatie.Name = "btnInformatie";
            this.btnInformatie.Size = new System.Drawing.Size(125, 30);
            this.btnInformatie.TabIndex = 4;
            this.btnInformatie.Text = "Informatie";
            this.btnInformatie.UseVisualStyleBackColor = true;
            this.btnInformatie.Click += new System.EventHandler(this.btnInformatie_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clubs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formBrabantPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInformatie);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.lblBrabantPongTitel);
            this.Controls.Add(this.mstrpDataLijst);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstrpDataLijst;
            this.MaximumSize = new System.Drawing.Size(750, 750);
            this.MinimumSize = new System.Drawing.Size(750, 750);
            this.Name = "formBrabantPong";
            this.Text = "BrabantPong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mstrpDataLijst.ResumeLayout(false);
            this.mstrpDataLijst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBrabantPongTitel;
        private MenuStrip mstrpDataLijst;
        private ToolStripMenuItem spelersToolStripMenuItem;
        private ToolStripMenuItem strpitem1;
        private Button btnAfsluiten;
        private Button btnInformatie;
        private Button button1;
    }
}