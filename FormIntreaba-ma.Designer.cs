namespace GoGreen
{
    partial class FormIntreaba_ma
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
            this.tboxIntrebare = new System.Windows.Forms.TextBox();
            this.lblIntrebare = new System.Windows.Forms.Label();
            this.lblRaspuns = new System.Windows.Forms.Label();
            this.btnIntreaba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxIntrebare
            // 
            this.tboxIntrebare.Location = new System.Drawing.Point(193, 110);
            this.tboxIntrebare.Name = "tboxIntrebare";
            this.tboxIntrebare.Size = new System.Drawing.Size(768, 27);
            this.tboxIntrebare.TabIndex = 0;
            // 
            // lblIntrebare
            // 
            this.lblIntrebare.AutoSize = true;
            this.lblIntrebare.Location = new System.Drawing.Point(13, 113);
            this.lblIntrebare.Name = "lblIntrebare";
            this.lblIntrebare.Size = new System.Drawing.Size(136, 19);
            this.lblIntrebare.TabIndex = 1;
            this.lblIntrebare.Text = "Pune o intrebare";
            // 
            // lblRaspuns
            // 
            this.lblRaspuns.Location = new System.Drawing.Point(193, 200);
            this.lblRaspuns.Name = "lblRaspuns";
            this.lblRaspuns.Size = new System.Drawing.Size(768, 262);
            this.lblRaspuns.TabIndex = 2;
            // 
            // btnIntreaba
            // 
            this.btnIntreaba.Location = new System.Drawing.Point(475, 155);
            this.btnIntreaba.Name = "btnIntreaba";
            this.btnIntreaba.Size = new System.Drawing.Size(187, 27);
            this.btnIntreaba.TabIndex = 3;
            this.btnIntreaba.Text = "Intreaba-ma";
            this.btnIntreaba.UseVisualStyleBackColor = true;
            this.btnIntreaba.Click += new System.EventHandler(this.btnIntreaba_ma_Click);
            // 
            // FormIntreaba_ma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnIntreaba);
            this.Controls.Add(this.lblRaspuns);
            this.Controls.Add(this.lblIntrebare);
            this.Controls.Add(this.tboxIntrebare);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormIntreaba_ma";
            this.Text = "FormIntreaba_ma";
            this.Load += new System.EventHandler(this.FormIntreaba_ma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxIntrebare;
        private System.Windows.Forms.Label lblIntrebare;
        private System.Windows.Forms.Label lblRaspuns;
        private System.Windows.Forms.Button btnIntreaba;
    }
}