
namespace WinFormCalcul
{
    partial class FrmCalculAvancé
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
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValeur2 = new System.Windows.Forms.TextBox();
            this.txtValeur1 = new System.Windows.Forms.TextBox();
            this.BtnFact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightGreen;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(592, 297);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 38);
            this.button8.TabIndex = 31;
            this.button8.Text = "Retour";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Brown;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(592, 359);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 38);
            this.button5.TabIndex = 30;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(617, 79);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 24);
            this.result.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Result :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Valeur 2 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Valeur 1:";
            // 
            // txtValeur2
            // 
            this.txtValeur2.Location = new System.Drawing.Point(193, 103);
            this.txtValeur2.Name = "txtValeur2";
            this.txtValeur2.Size = new System.Drawing.Size(100, 20);
            this.txtValeur2.TabIndex = 21;
            // 
            // txtValeur1
            // 
            this.txtValeur1.Location = new System.Drawing.Point(193, 54);
            this.txtValeur1.Name = "txtValeur1";
            this.txtValeur1.Size = new System.Drawing.Size(100, 20);
            this.txtValeur1.TabIndex = 20;
            // 
            // BtnFact
            // 
            this.BtnFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFact.Location = new System.Drawing.Point(193, 205);
            this.BtnFact.Name = "BtnFact";
            this.BtnFact.Size = new System.Drawing.Size(117, 38);
            this.BtnFact.TabIndex = 19;
            this.BtnFact.Text = "Factoriel";
            this.BtnFact.UseVisualStyleBackColor = true;
            this.BtnFact.Click += new System.EventHandler(this.BtnFact_Click);
            // 
            // FrmCalculAvancé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValeur2);
            this.Controls.Add(this.txtValeur1);
            this.Controls.Add(this.BtnFact);
            this.Name = "FrmCalculAvancé";
            this.Text = "FrmCalculAvancé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValeur2;
        private System.Windows.Forms.TextBox txtValeur1;
        private System.Windows.Forms.Button BtnFact;
    }
}