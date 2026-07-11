namespace GoGreen
{
    partial class FormSignUp
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
            this.tboxNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxParola = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.chkAfiseazaParola = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tboxNume
            // 
            this.tboxNume.Location = new System.Drawing.Point(410, 147);
            this.tboxNume.Name = "tboxNume";
            this.tboxNume.Size = new System.Drawing.Size(396, 33);
            this.tboxNume.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume Complet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // tboxEmail
            // 
            this.tboxEmail.Location = new System.Drawing.Point(410, 214);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(396, 33);
            this.tboxEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parola";
            // 
            // tboxParola
            // 
            this.tboxParola.Location = new System.Drawing.Point(410, 288);
            this.tboxParola.Name = "tboxParola";
            this.tboxParola.PasswordChar = '*';
            this.tboxParola.Size = new System.Drawing.Size(396, 33);
            this.tboxParola.TabIndex = 4;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(198, 386);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(608, 39);
            this.btnSignUp.TabIndex = 6;
            this.btnSignUp.Text = "Creeaza cont";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // chkAfiseazaParola
            // 
            this.chkAfiseazaParola.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAfiseazaParola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAfiseazaParola.Font = new System.Drawing.Font("Century Gothic", 7.75F, System.Drawing.FontStyle.Bold);
            this.chkAfiseazaParola.Location = new System.Drawing.Point(771, 291);
            this.chkAfiseazaParola.Name = "chkAfiseazaParola";
            this.chkAfiseazaParola.Size = new System.Drawing.Size(25, 25);
            this.chkAfiseazaParola.TabIndex = 7;
            this.chkAfiseazaParola.Text = "🙈";
            this.chkAfiseazaParola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAfiseazaParola.UseVisualStyleBackColor = true;
            this.chkAfiseazaParola.CheckedChanged += new System.EventHandler(this.chkAfiseazaParola_CheckedChanged);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.chkAfiseazaParola);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxParola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxNume);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormSignUp";
            this.Text = "FormSignUp";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxParola;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.CheckBox chkAfiseazaParola;
    }
}