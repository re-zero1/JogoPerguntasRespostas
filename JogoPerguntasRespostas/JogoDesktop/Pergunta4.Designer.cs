namespace JogoDesktop
{
    partial class Pergunta4
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
            this.lblPergunta4 = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblPergunta4
            // 
            this.lblPergunta4.AutoSize = true;
            this.lblPergunta4.Location = new System.Drawing.Point(44, 29);
            this.lblPergunta4.Name = "lblPergunta4";
            this.lblPergunta4.Size = new System.Drawing.Size(35, 13);
            this.lblPergunta4.TabIndex = 0;
            this.lblPergunta4.Text = "label1";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(320, 215);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "Confirma";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(123, 76);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(111, 17);
            this.rdb1.TabIndex = 2;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Shingeki no kyojin";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(123, 111);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(62, 17);
            this.rdb2.TabIndex = 3;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Another";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(123, 150);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(88, 17);
            this.rdb3.TabIndex = 4;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "Akame ga kill";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Location = new System.Drawing.Point(123, 185);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(92, 17);
            this.rdb4.TabIndex = 5;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "Ao no exorcist";
            this.rdb4.UseVisualStyleBackColor = true;
            // 
            // Pergunta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.rdb4);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblPergunta4);
            this.Name = "Pergunta4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta4";
            this.Load += new System.EventHandler(this.Pergunta4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPergunta4;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb4;
    }
}