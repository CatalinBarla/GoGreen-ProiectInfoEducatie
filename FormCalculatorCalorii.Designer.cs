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
            this.pnlFereastra = new System.Windows.Forms.Panel();
            this.btnIesire = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReseteaza = new System.Windows.Forms.Button();
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnInstructiuni = new System.Windows.Forms.Button();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.pnlFereastra.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFereastra
            // 
            this.pnlFereastra.Controls.Add(this.btnIesire);
            this.pnlFereastra.Controls.Add(this.panel1);
            this.pnlFereastra.Controls.Add(this.btnInstructiuni);
            this.pnlFereastra.Controls.Add(this.lblTitlu);
            this.pnlFereastra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFereastra.Location = new System.Drawing.Point(0, 0);
            this.pnlFereastra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFereastra.Name = "pnlFereastra";
            this.pnlFereastra.Size = new System.Drawing.Size(984, 561);
            this.pnlFereastra.TabIndex = 0;
            // 
            // btnIesire
            // 
            this.btnIesire.BackColor = System.Drawing.Color.LightGreen;
            this.btnIesire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIesire.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIesire.Location = new System.Drawing.Point(13, 501);
            this.btnIesire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(163, 41);
            this.btnIesire.TabIndex = 3;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.btnReseteaza);
            this.panel1.Controls.Add(this.btnCalculeazaCalorii);
            this.panel1.Controls.Add(this.lblRezultat);
            this.panel1.Controls.Add(this.txtVarsta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtInaltime);
            this.panel1.Controls.Add(this.lblInaltime);
            this.panel1.Controls.Add(this.lblActivitate);
            this.panel1.Controls.Add(this.cbActivitate);
            this.panel1.Controls.Add(this.txtKg);
            this.panel1.Controls.Add(this.lblKg);
            this.panel1.Controls.Add(this.lblGen);
            this.panel1.Controls.Add(this.cbGen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(13, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 396);
            this.panel1.TabIndex = 2;
            // 
            // btnReseteaza
            // 
            this.btnReseteaza.BackColor = System.Drawing.Color.Honeydew;
            this.btnReseteaza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReseteaza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReseteaza.Location = new System.Drawing.Point(508, 272);
            this.btnReseteaza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReseteaza.Name = "btnReseteaza";
            this.btnReseteaza.Size = new System.Drawing.Size(238, 47);
            this.btnReseteaza.TabIndex = 10;
            this.btnReseteaza.Text = "Resetează";
            this.btnReseteaza.UseVisualStyleBackColor = false;
            this.btnReseteaza.Click += new System.EventHandler(this.btnReseteaza_Click);
            // 
            // btnCalculeazaCalorii
            // 
            this.btnCalculeazaCalorii.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalculeazaCalorii.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculeazaCalorii.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculeazaCalorii.Location = new System.Drawing.Point(488, 187);
            this.btnCalculeazaCalorii.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculeazaCalorii.Name = "btnCalculeazaCalorii";
            this.btnCalculeazaCalorii.Size = new System.Drawing.Size(277, 77);
            this.btnCalculeazaCalorii.TabIndex = 4;
            this.btnCalculeazaCalorii.Text = "Calculează calorii";
            this.btnCalculeazaCalorii.UseVisualStyleBackColor = false;
            this.btnCalculeazaCalorii.Click += new System.EventHandler(this.btnCalculeazaCalorii_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.BackColor = System.Drawing.Color.PaleGreen;
            this.lblRezultat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRezultat.Location = new System.Drawing.Point(420, 84);
            this.lblRezultat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(405, 61);
            this.lblRezultat.TabIndex = 4;
            this.lblRezultat.Text = "  Rata metabolismului bazal:";
            this.lblRezultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVarsta
            // 
            this.txtVarsta.Location = new System.Drawing.Point(67, 75);
            this.txtVarsta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(266, 27);
            this.txtVarsta.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Vârstă";
            // 
            // txtInaltime
            // 
            this.txtInaltime.Location = new System.Drawing.Point(67, 237);
            this.txtInaltime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInaltime.Name = "txtInaltime";
            this.txtInaltime.Size = new System.Drawing.Size(266, 27);
            this.txtInaltime.TabIndex = 7;
            // 
            // lblInaltime
            // 
            this.lblInaltime.AutoSize = true;
            this.lblInaltime.BackColor = System.Drawing.Color.LightGreen;
            this.lblInaltime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInaltime.Location = new System.Drawing.Point(49, 214);
            this.lblInaltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInaltime.Name = "lblInaltime";
            this.lblInaltime.Size = new System.Drawing.Size(114, 19);
            this.lblInaltime.TabIndex = 6;
            this.lblInaltime.Text = "Inaltime (cm)";
            // 
            // lblActivitate
            // 
            this.lblActivitate.AutoSize = true;
            this.lblActivitate.BackColor = System.Drawing.Color.LightGreen;
            this.lblActivitate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivitate.Location = new System.Drawing.Point(49, 268);
            this.lblActivitate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivitate.Name = "lblActivitate";
            this.lblActivitate.Size = new System.Drawing.Size(81, 19);
            this.lblActivitate.TabIndex = 5;
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
            this.cbActivitate.Location = new System.Drawing.Point(67, 291);
            this.cbActivitate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbActivitate.Name = "cbActivitate";
            this.cbActivitate.Size = new System.Drawing.Size(266, 27);
            this.cbActivitate.TabIndex = 4;
            // 
            // txtKg
            // 
            this.txtKg.Location = new System.Drawing.Point(67, 183);
            this.txtKg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(266, 27);
            this.txtKg.TabIndex = 3;
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.BackColor = System.Drawing.Color.LightGreen;
            this.lblKg.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKg.Location = new System.Drawing.Point(49, 160);
            this.lblKg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(124, 19);
            this.lblKg.TabIndex = 2;
            this.lblKg.Text = "Greutatea (Kg)";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.BackColor = System.Drawing.Color.LightGreen;
            this.lblGen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.Location = new System.Drawing.Point(49, 106);
            this.lblGen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(56, 19);
            this.lblGen.TabIndex = 1;
            this.lblGen.Text = "Genul";
            // 
            // cbGen
            // 
            this.cbGen.FormattingEnabled = true;
            this.cbGen.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cbGen.Location = new System.Drawing.Point(67, 129);
            this.cbGen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGen.Name = "cbGen";
            this.cbGen.Size = new System.Drawing.Size(266, 27);
            this.cbGen.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(479, 127);
            this.label3.TabIndex = 4;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInstructiuni
            // 
            this.btnInstructiuni.BackColor = System.Drawing.Color.LightGreen;
            this.btnInstructiuni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInstructiuni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructiuni.Location = new System.Drawing.Point(799, 501);
            this.btnInstructiuni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInstructiuni.Name = "btnInstructiuni";
            this.btnInstructiuni.Size = new System.Drawing.Size(163, 41);
            this.btnInstructiuni.TabIndex = 1;
            this.btnInstructiuni.Text = "Instructiuni";
            this.btnInstructiuni.UseVisualStyleBackColor = false;
            this.btnInstructiuni.Click += new System.EventHandler(this.btnInstructiuni_Click);
            // 
            // lblTitlu
            // 
            this.lblTitlu.BackColor = System.Drawing.Color.LightGreen;
            this.lblTitlu.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(291, 9);
            this.lblTitlu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(386, 66);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Calculator Calorii";
            this.lblTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCalculatorCalorii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlFereastra);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCalculatorCalorii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalculatorCalorii";
            this.Load += new System.EventHandler(this.FormCalculatorCalorii_Load);
            this.pnlFereastra.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFereastra;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnInstructiuni;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.ComboBox cbGen;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.TextBox txtInaltime;
        private System.Windows.Forms.Label lblInaltime;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculeazaCalorii;
        private System.Windows.Forms.Label lblActivitate;
        private System.Windows.Forms.ComboBox cbActivitate;
        private System.Windows.Forms.Button btnReseteaza;
    }
}