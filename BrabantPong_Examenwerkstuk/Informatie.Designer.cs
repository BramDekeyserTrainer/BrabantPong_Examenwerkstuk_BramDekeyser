namespace BrabantPong_Examenwerkstuk
{
    partial class formInformatie
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
            this.lblInformatie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInformatie
            // 
            this.lblInformatie.AutoSize = true;
            this.lblInformatie.Location = new System.Drawing.Point(12, 9);
            this.lblInformatie.Name = "lblInformatie";
            this.lblInformatie.Size = new System.Drawing.Size(0, 20);
            this.lblInformatie.TabIndex = 0;
            // 
            // formInformatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 703);
            this.Controls.Add(this.lblInformatie);
            this.MaximumSize = new System.Drawing.Size(700, 750);
            this.MinimumSize = new System.Drawing.Size(700, 750);
            this.Name = "formInformatie";
            this.Text = "Informatie";
            this.Load += new System.EventHandler(this.formInformatie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInformatie;
    }
}