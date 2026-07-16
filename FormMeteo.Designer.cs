namespace GoGreen
{
    partial class FormMeteo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeteo));
            this.cmbLista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOras = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblPresiune = new System.Windows.Forms.Label();
            this.lblUmiditate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.wbHarta = new System.Windows.Forms.WebBrowser();
            this.btniesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbLista
            // 
            this.cmbLista.FormattingEnabled = true;
            this.cmbLista.Location = new System.Drawing.Point(212, 46);
            this.cmbLista.Name = "cmbLista";
            this.cmbLista.Size = new System.Drawing.Size(183, 21);
            this.cmbLista.TabIndex = 0;
            this.cmbLista.SelectedIndexChanged += new System.EventHandler(this.cmbLista_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectează localitatea:";
            // 
            // lblOras
            // 
            this.lblOras.AutoSize = true;
            this.lblOras.BackColor = System.Drawing.Color.Transparent;
            this.lblOras.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOras.Location = new System.Drawing.Point(227, 120);
            this.lblOras.Name = "lblOras";
            this.lblOras.Size = new System.Drawing.Size(0, 25);
            this.lblOras.TabIndex = 2;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperatura.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatura.Location = new System.Drawing.Point(227, 204);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(0, 25);
            this.lblTemperatura.TabIndex = 3;
            // 
            // lblPresiune
            // 
            this.lblPresiune.AutoSize = true;
            this.lblPresiune.BackColor = System.Drawing.Color.Transparent;
            this.lblPresiune.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresiune.Location = new System.Drawing.Point(227, 284);
            this.lblPresiune.Name = "lblPresiune";
            this.lblPresiune.Size = new System.Drawing.Size(0, 25);
            this.lblPresiune.TabIndex = 4;
            // 
            // lblUmiditate
            // 
            this.lblUmiditate.AutoSize = true;
            this.lblUmiditate.BackColor = System.Drawing.Color.Transparent;
            this.lblUmiditate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUmiditate.Location = new System.Drawing.Point(227, 365);
            this.lblUmiditate.Name = "lblUmiditate";
            this.lblUmiditate.Size = new System.Drawing.Size(0, 25);
            this.lblUmiditate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Umiditate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Presiune";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Temperatură";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Oraș";
            // 
            // wbHarta
            // 
            this.wbHarta.Location = new System.Drawing.Point(462, 46);
            this.wbHarta.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbHarta.Name = "wbHarta";
            this.wbHarta.Size = new System.Drawing.Size(800, 635);
            this.wbHarta.TabIndex = 6;
            // 
            // btniesire
            // 
            this.btniesire.BackColor = System.Drawing.Color.White;
            this.btniesire.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniesire.Location = new System.Drawing.Point(25, 648);
            this.btniesire.Name = "btniesire";
            this.btniesire.Size = new System.Drawing.Size(370, 33);
            this.btniesire.TabIndex = 11;
            this.btniesire.Text = "Ieșire";
            this.btniesire.UseVisualStyleBackColor = false;
            this.btniesire.Click += new System.EventHandler(this.btniesire_Click);
            // 
            // FormMeteo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btniesire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wbHarta);
            this.Controls.Add(this.lblUmiditate);
            this.Controls.Add(this.lblPresiune);
            this.Controls.Add(this.lblTemperatura);
            this.Controls.Add(this.lblOras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMeteo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMeteo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOras;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblPresiune;
        private System.Windows.Forms.Label lblUmiditate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.WebBrowser wbHarta;
        private System.Windows.Forms.Button btniesire;
    }
}