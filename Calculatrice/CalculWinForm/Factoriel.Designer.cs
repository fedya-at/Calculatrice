
namespace CalculWinForm
{
    partial class Factoriel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblRes = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.TxtN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(106, 52);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(589, 94);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factoriel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnQuitter);
            this.groupBox2.Controls.Add(this.BtnBack);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.BtnCalc);
            this.groupBox2.Controls.Add(this.TxtN);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(113, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(582, 229);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(314, 159);
            this.BtnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(119, 49);
            this.BtnQuitter.TabIndex = 5;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(130, 159);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(119, 49);
            this.BtnBack.TabIndex = 4;
            this.BtnBack.Text = "Retour";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LblRes);
            this.groupBox3.Location = new System.Drawing.Point(90, 113);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(394, 29);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // LblRes
            // 
            this.LblRes.AutoSize = true;
            this.LblRes.Location = new System.Drawing.Point(158, 11);
            this.LblRes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRes.Name = "LblRes";
            this.LblRes.Size = new System.Drawing.Size(50, 13);
            this.LblRes.TabIndex = 0;
            this.LblRes.Text = "Factoriel ";
            this.LblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(364, 36);
            this.BtnCalc.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(119, 49);
            this.BtnCalc.TabIndex = 2;
            this.BtnCalc.Text = "Calculer";
            this.BtnCalc.UseVisualStyleBackColor = true;
            // 
            // TxtN
            // 
            this.TxtN.Location = new System.Drawing.Point(90, 67);
            this.TxtN.Margin = new System.Windows.Forms.Padding(2);
            this.TxtN.Name = "TxtN";
            this.TxtN.Size = new System.Drawing.Size(122, 20);
            this.TxtN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Donner un entier positif: ";
            // 
            // Factoriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Factoriel";
            this.Text = "Factoriel";
            this.Load += new System.EventHandler(this.Factoriel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblRes;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.TextBox TxtN;
        private System.Windows.Forms.Label label2;
    }
}