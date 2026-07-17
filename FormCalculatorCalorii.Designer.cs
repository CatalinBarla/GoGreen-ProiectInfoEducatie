namespace GoGreen
{
    partial class FormCalculatorCalorii
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
            this.btnReseteaza = new System.Windows.Forms.Button();
            this.btnInstructiuni = new System.Windows.Forms.Button();
            this.btnCalculeazaCalorii = new System.Windows.Forms.Button();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInaltime = new System.Windows.Forms.TextBox();
            this.lblInaltime = new System.Windows.Forms.Label();
            this.lblActivitate = new System.Windows.Forms.Label();
            this.cbActivitate = new System.Windows.Forms.ComboBox();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.lblKg = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.cbGen = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnReseteaza
            // 
            this.btnReseteaza.BackColor = System.Drawing.Color.Honeydew;
            this.btnReseteaza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReseteaza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReseteaza.Location = new System.Drawing.Point(553, 340);
            this.btnReseteaza.Margin = new System.Windows.Forms.Padding(4);
            this.btnReseteaza.Name = "btnReseteaza";
            this.btnReseteaza.Size = new System.Drawing.Size(238, 47);
            this.btnReseteaza.TabIndex = 25;
            this.btnReseteaza.Text = "Resetează";
            this.btnReseteaza.UseVisualStyleBackColor = false;
            this.btnReseteaza.Click += new System.EventHandler(this.btnReseteaza_Click);
            // 
            // btnInstructiuni
            // 
            this.btnInstructiuni.BackColor = System.Drawing.Color.LightGreen;
            this.btnInstructiuni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInstructiuni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructiuni.Location = new System.Drawing.Point(592, 401);
            this.btnInstructiuni.Margin = new System.Windows.Forms.Padding(4);
            this.btnInstructiuni.Name = "btnInstructiuni";
            this.btnInstructiuni.Size = new System.Drawing.Size(163, 41);
            this.btnInstructiuni.TabIndex = 12;
            this.btnInstructiuni.Text = "Instructiuni";
            this.btnInstructiuni.UseVisualStyleBackColor = false;
            this.btnInstructiuni.Click += new System.EventHandler(this.btnInstructiuni_Click);
            // 
            // btnCalculeazaCalorii
            // 
            this.btnCalculeazaCalorii.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalculeazaCalorii.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculeazaCalorii.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculeazaCalorii.Location = new System.Drawing.Point(536, 233);
            this.btnCalculeazaCalorii.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculeazaCalorii.Name = "btnCalculeazaCalorii";
            this.btnCalculeazaCalorii.Size = new System.Drawing.Size(277, 77);
            this.btnCalculeazaCalorii.TabIndex = 16;
            this.btnCalculeazaCalorii.Text = "Calculează calorii";
            this.btnCalculeazaCalorii.UseVisualStyleBackColor = false;
            this.btnCalculeazaCalorii.Click += new System.EventHandler(this.btnCalculeazaCalorii_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.BackColor = System.Drawing.Color.PaleGreen;
            this.lblRezultat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultat.Location = new System.Drawing.Point(471, 144);
            this.lblRezultat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(405, 61);
            this.lblRezultat.TabIndex = 17;
            this.lblRezultat.Text = "  Rata metabolismului bazal:";
            this.lblRezultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(121, 163);
            this.txtVarsta.Margin = new System.Windows.Forms.Padding(4);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(266, 27);
            this.txtVarsta.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Vârstă";
            // 
            // txtInaltime
            // 
            this.txtInaltime.Location = new System.Drawing.Point(122, 350);
            this.txtInaltime.Margin = new System.Windows.Forms.Padding(4);
            this.txtInaltime.Name = "txtInaltime";
            this.txtInaltime.Size = new System.Drawing.Size(266, 27);
            this.txtInaltime.TabIndex = 22;
            // 
            // lblInaltime
            // 
            this.lblInaltime.AutoSize = true;
            this.lblInaltime.BackColor = System.Drawing.Color.LightGreen;
            this.lblInaltime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInaltime.Location = new System.Drawing.Point(104, 327);
            this.lblInaltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInaltime.Name = "lblInaltime";
            this.lblInaltime.Size = new System.Drawing.Size(114, 19);
            this.lblInaltime.TabIndex = 21;
            this.lblInaltime.Text = "Inaltime (cm)";
            // 
            // lblActivitate
            // 
            this.lblActivitate.AutoSize = true;
            this.lblActivitate.BackColor = System.Drawing.Color.LightGreen;
            this.lblActivitate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivitate.Location = new System.Drawing.Point(104, 387);
            this.lblActivitate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivitate.Name = "lblActivitate";
            this.lblActivitate.Size = new System.Drawing.Size(81, 19);
            this.lblActivitate.TabIndex = 20;
            this.lblActivitate.Text = "Activitate";
            // 
            // cbActivitate
            // 
            this.cbActivitate.FormattingEnabled = true;
            this.cbActivitate.Items.AddRange(new object[] {
            "Sedentar: puțin exercițiu sau deloc",
            "Ușor: exercițiu timp de 1-3 ori pe săptămână",
            "Moderat: exercițiu timp de 3-4 ori pe săptămână",
            "Activ: exercițiu zilnic sau 3-4 ori pe săptămână de exercițiu intens",
            "Foarte activ: exercițiu intens de 6-7 ori pe săptămână",
            "Extra activ: exercițiu zilnic foarte intens"});
            this.cbActivitate.Location = new System.Drawing.Point(122, 410);
            this.cbActivitate.Margin = new System.Windows.Forms.Padding(4);
            this.cbActivitate.Name = "cbActivitate";
            this.cbActivitate.Size = new System.Drawing.Size(266, 27);
            this.cbActivitate.TabIndex = 18;
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(122, 286);
            this.txtKg.Margin = new System.Windows.Forms.Padding(4);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(266, 27);
            this.txtKg.TabIndex = 15;
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.BackColor = System.Drawing.Color.LightGreen;
            this.lblKg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.Location = new System.Drawing.Point(104, 263);
            this.lblKg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(124, 19);
            this.lblKg.TabIndex = 14;
            this.lblKg.Text = "Greutatea (Kg)";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.BackColor = System.Drawing.Color.LightGreen;
            this.lblGen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.Location = new System.Drawing.Point(104, 203);
            this.lblGen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(56, 19);
            this.lblGen.TabIndex = 13;
            this.lblGen.Text = "Genul";
            // 
            // cbGen
            // 
            this.cbGen.FormattingEnabled = true;
            this.cbGen.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cbGen.Location = new System.Drawing.Point(122, 226);
            this.cbGen.Margin = new System.Windows.Forms.Padding(4);
            this.cbGen.Name = "cbGen";
            this.cbGen.Size = new System.Drawing.Size(266, 27);
            this.cbGen.TabIndex = 11;
            // 
            // FormCalculatorCalorii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnReseteaza);
            this.Controls.Add(this.btnInstructiuni);
            this.Controls.Add(this.btnCalculeazaCalorii);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.txtVarsta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInaltime);
            this.Controls.Add(this.lblInaltime);
            this.Controls.Add(this.lblActivitate);
            this.Controls.Add(this.cbActivitate);
            this.Controls.Add(this.txtKg);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.cbGen);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCalculatorCalorii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalculatorCalorii";
            this.Load += new System.EventHandler(this.FormCalculatorCalorii_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReseteaza;
        private System.Windows.Forms.Button btnInstructiuni;
        private System.Windows.Forms.Button btnCalculeazaCalorii;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInaltime;
        private System.Windows.Forms.Label lblInaltime;
        private System.Windows.Forms.Label lblActivitate;
        private System.Windows.Forms.ComboBox cbActivitate;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.ComboBox cbGen;
    }
}