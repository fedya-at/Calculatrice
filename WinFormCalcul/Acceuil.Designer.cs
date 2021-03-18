
namespace WinFormCalcul
{
    partial class Acceuil
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculAvance = new System.Windows.Forms.Button();
            this.BtnCalculBasic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Brown;
            this.btnExit.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(233, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(335, 78);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculAvance
            // 
            this.btnCalculAvance.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCalculAvance.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalculAvance.Location = new System.Drawing.Point(233, 179);
            this.btnCalculAvance.Name = "btnCalculAvance";
            this.btnCalculAvance.Size = new System.Drawing.Size(335, 75);
            this.btnCalculAvance.TabIndex = 4;
            this.btnCalculAvance.Text = "Calcul Avancé";
            this.btnCalculAvance.UseVisualStyleBackColor = false;
            this.btnCalculAvance.Click += new System.EventHandler(this.btnCalculAvance_Click);
            // 
            // BtnCalculBasic
            // 
            this.BtnCalculBasic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCalculBasic.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCalculBasic.Location = new System.Drawing.Point(233, 104);
            this.BtnCalculBasic.Name = "BtnCalculBasic";
            this.BtnCalculBasic.Size = new System.Drawing.Size(335, 69);
            this.BtnCalculBasic.TabIndex = 3;
            this.BtnCalculBasic.Text = "Calcul Basic";
            this.BtnCalculBasic.UseVisualStyleBackColor = false;
            this.BtnCalculBasic.Click += new System.EventHandler(this.BtnCalculBasic_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculAvance);
            this.Controls.Add(this.BtnCalculBasic);
            this.Name = "Acceuil";
            this.Text = "Acceuil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculAvance;
        private System.Windows.Forms.Button BtnCalculBasic;
    }
}