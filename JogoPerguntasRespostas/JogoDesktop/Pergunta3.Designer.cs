namespace JogoDesktop
{
    partial class Pergunta3
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
            this.btn1 = new System.Windows.Forms.Button();
            this.lblPergunta3 = new System.Windows.Forms.Label();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(326, 226);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Confirmar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPergunta3
            // 
            this.lblPergunta3.AutoSize = true;
            this.lblPergunta3.Location = new System.Drawing.Point(176, 23);
            this.lblPergunta3.Name = "lblPergunta3";
            this.lblPergunta3.Size = new System.Drawing.Size(35, 13);
            this.lblPergunta3.TabIndex = 1;
            this.lblPergunta3.Text = "label1";
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Location = new System.Drawing.Point(128, 72);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(53, 17);
            this.rdb1.TabIndex = 2;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "Liquid";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(128, 110);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(50, 17);
            this.rdb2.TabIndex = 3;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "Na\'Vi";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(128, 147);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(64, 17);
            this.rdb3.TabIndex = 4;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "EHOME";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Location = new System.Drawing.Point(128, 186);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(57, 17);
            this.rdb4.TabIndex = 5;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "Empire";
            this.rdb4.UseVisualStyleBackColor = true;
            // 
            // Pergunta3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.rdb4);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.lblPergunta3);
            this.Controls.Add(this.btn1);
            this.Name = "Pergunta3";
            this.Text = "Pergunta3";
            this.Load += new System.EventHandler(this.Pergunta3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblPergunta3;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb4;
    }
}