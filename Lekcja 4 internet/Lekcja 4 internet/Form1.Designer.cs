
namespace Lekcja_4_internet
{
    partial class Form1
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
            this.btnPrzelicz = new System.Windows.Forms.Button();
            this.txtMbity = new System.Windows.Forms.TextBox();
            this.txtMBajty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrzelicz
            // 
            this.btnPrzelicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrzelicz.Location = new System.Drawing.Point(276, 208);
            this.btnPrzelicz.Name = "btnPrzelicz";
            this.btnPrzelicz.Size = new System.Drawing.Size(90, 36);
            this.btnPrzelicz.TabIndex = 0;
            this.btnPrzelicz.Text = "Przelicz";
            this.btnPrzelicz.UseVisualStyleBackColor = true;
            this.btnPrzelicz.Click += new System.EventHandler(this.btnPrzelicz_Click);
            // 
            // txtMbity
            // 
            this.txtMbity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMbity.Location = new System.Drawing.Point(98, 92);
            this.txtMbity.Name = "txtMbity";
            this.txtMbity.Size = new System.Drawing.Size(100, 30);
            this.txtMbity.TabIndex = 1;
            // 
            // txtMBajty
            // 
            this.txtMBajty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMBajty.Location = new System.Drawing.Point(98, 208);
            this.txtMBajty.Name = "txtMBajty";
            this.txtMBajty.Size = new System.Drawing.Size(100, 30);
            this.txtMBajty.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Prędkość internetu w Megabitach na sek [Mbs]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prędkość internetu w Megabajtach na sek [MBs]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMBajty);
            this.Controls.Add(this.txtMbity);
            this.Controls.Add(this.btnPrzelicz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrzelicz;
        private System.Windows.Forms.TextBox txtMbity;
        private System.Windows.Forms.TextBox txtMBajty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

