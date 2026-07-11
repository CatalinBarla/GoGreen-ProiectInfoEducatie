namespace GoGreen
{
    partial class FormCalculatorCaloriiInstructiuni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculatorCaloriiInstructiuni));
            this.lblInstructiuni = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlText = new System.Windows.Forms.Panel();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstructiuni
            // 
            this.lblInstructiuni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructiuni.ForeColor = System.Drawing.Color.Black;
            this.lblInstructiuni.Location = new System.Drawing.Point(32, 80);
            this.lblInstructiuni.Name = "lblInstructiuni";
            this.lblInstructiuni.Size = new System.Drawing.Size(645, 287);
            this.lblInstructiuni.TabIndex = 0;
            this.lblInstructiuni.Text = resources.GetString("lblInstructiuni.Text");
            this.lblInstructiuni.Click += new System.EventHandler(this.lblInstructiuni_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.ForeColor = System.Drawing.Color.Black;
            this.lblTitlu.Location = new System.Drawing.Point(31, 30);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(135, 28);
            this.lblTitlu.TabIndex = 1;
            this.lblTitlu.Text = "Instrucțiuni";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Honeydew;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Black;
            this.btnOk.Location = new System.Drawing.Point(259, 357);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(211, 47);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pnlText
            // 
            this.pnlText.BackColor = System.Drawing.Color.LightGreen;
            this.pnlText.Controls.Add(this.btnOk);
            this.pnlText.Controls.Add(this.lblTitlu);
            this.pnlText.Controls.Add(this.lblInstructiuni);
            this.pnlText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlText.Location = new System.Drawing.Point(0, 0);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(742, 450);
            this.pnlText.TabIndex = 1;
            // 
            // FormCalculatorCaloriiInstructiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.pnlText);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FormCalculatorCaloriiInstructiuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorCaloriiInstructiuni";
            this.Load += new System.EventHandler(this.FormCalculatorCaloriiInstructiuni_Load);
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInstructiuni;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel pnlText;
    }
}