namespace RedisSubscriber
{
    partial class Mensagem
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
            this.TxtHistorico = new System.Windows.Forms.TextBox();
            this.LblHistorico = new System.Windows.Forms.Label();
            this.BtnInscrever = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtHistorico
            // 
            this.TxtHistorico.Enabled = false;
            this.TxtHistorico.Location = new System.Drawing.Point(12, 38);
            this.TxtHistorico.Multiline = true;
            this.TxtHistorico.Name = "TxtHistorico";
            this.TxtHistorico.Size = new System.Drawing.Size(347, 199);
            this.TxtHistorico.TabIndex = 6;
            // 
            // LblHistorico
            // 
            this.LblHistorico.AutoSize = true;
            this.LblHistorico.Location = new System.Drawing.Point(12, 22);
            this.LblHistorico.Name = "LblHistorico";
            this.LblHistorico.Size = new System.Drawing.Size(48, 13);
            this.LblHistorico.TabIndex = 7;
            this.LblHistorico.Text = "Histórico";
            // 
            // BtnInscrever
            // 
            this.BtnInscrever.Location = new System.Drawing.Point(284, 270);
            this.BtnInscrever.Name = "BtnInscrever";
            this.BtnInscrever.Size = new System.Drawing.Size(75, 23);
            this.BtnInscrever.TabIndex = 8;
            this.BtnInscrever.Text = "Inscrever-se";
            this.BtnInscrever.UseVisualStyleBackColor = true;
            this.BtnInscrever.Click += new System.EventHandler(this.BtnInscrever_Click);
            // 
            // Mensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 305);
            this.Controls.Add(this.BtnInscrever);
            this.Controls.Add(this.LblHistorico);
            this.Controls.Add(this.TxtHistorico);
            this.Name = "Mensagem";
            this.Text = "Mensagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHistorico;
        private System.Windows.Forms.Label LblHistorico;
        private System.Windows.Forms.Button BtnInscrever;
    }
}

