namespace GoGreen
{
    partial class FormCarbon
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
            this.txtElectricity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtElectricity
            // 
            this.txtElectricity.Location = new System.Drawing.Point(459, 98);
            this.txtElectricity.Name = "txtElectricity";
            this.txtElectricity.Size = new System.Drawing.Size(397, 27);
            this.txtElectricity.TabIndex = 0;
            this.txtElectricity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElectricity_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consum energie electrica (kWh/luna)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consum gaz natural (kWh/luna sau m³/luna)";
            // 
            // txtGas
            // 
            this.txtGas.Location = new System.Drawing.Point(459, 161);
            this.txtGas.Name = "txtGas";
            this.txtGas.Size = new System.Drawing.Size(397, 27);
            this.txtGas.TabIndex = 2;
            this.txtGas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElectricity_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kilometri parcursi cu masina pe luna";
            // 
            // txtCar
            // 
            this.txtCar.Location = new System.Drawing.Point(459, 225);
            this.txtCar.Name = "txtCar";
            this.txtCar.Size = new System.Drawing.Size(397, 27);
            this.txtCar.TabIndex = 4;
            this.txtCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtElectricity_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rezultat:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(167, 362);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 19);
            this.lblResult.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(536, 281);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(255, 50);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculeaza";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // FormCarbon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtElectricity);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCarbon";
            this.Text = "FormCarbon";
            this.Load += new System.EventHandler(this.FormCarbon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElectricity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
    }
}