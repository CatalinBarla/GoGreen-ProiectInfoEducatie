namespace GoGreen
{
    partial class FormAfis
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
            this.btnIncarcaImagine = new System.Windows.Forms.Button();
            this.pbOriginalImage = new System.Windows.Forms.PictureBox();
            this.btnSalveazaAfis = new System.Windows.Forms.Button();
            this.pbAfis = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxRaza = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncarcaImagine
            // 
            this.btnIncarcaImagine.Location = new System.Drawing.Point(12, 311);
            this.btnIncarcaImagine.Name = "btnIncarcaImagine";
            this.btnIncarcaImagine.Size = new System.Drawing.Size(373, 32);
            this.btnIncarcaImagine.TabIndex = 0;
            this.btnIncarcaImagine.Text = "Incarcă Imagine";
            this.btnIncarcaImagine.UseVisualStyleBackColor = true;
            this.btnIncarcaImagine.Click += new System.EventHandler(this.btnIncarcaImagine_Click);
            // 
            // pbOriginalImage
            // 
            this.pbOriginalImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbOriginalImage.Location = new System.Drawing.Point(12, 12);
            this.pbOriginalImage.Name = "pbOriginalImage";
            this.pbOriginalImage.Size = new System.Drawing.Size(373, 293);
            this.pbOriginalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOriginalImage.TabIndex = 1;
            this.pbOriginalImage.TabStop = false;
            this.pbOriginalImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbOriginalImage_MouseClick);
            // 
            // btnSalveazaAfis
            // 
            this.btnSalveazaAfis.Location = new System.Drawing.Point(615, 311);
            this.btnSalveazaAfis.Name = "btnSalveazaAfis";
            this.btnSalveazaAfis.Size = new System.Drawing.Size(373, 32);
            this.btnSalveazaAfis.TabIndex = 2;
            this.btnSalveazaAfis.Text = "Salvează Afis";
            this.btnSalveazaAfis.UseVisualStyleBackColor = true;
            this.btnSalveazaAfis.Click += new System.EventHandler(this.btnSalveazaAfis_Click);
            // 
            // pbAfis
            // 
            this.pbAfis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbAfis.Location = new System.Drawing.Point(615, 12);
            this.pbAfis.Name = "pbAfis";
            this.pbAfis.Size = new System.Drawing.Size(373, 293);
            this.pbAfis.TabIndex = 3;
            this.pbAfis.TabStop = false;
            this.pbAfis.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbAfis_MouseClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Patrat",
            "Cerc"});
            this.comboBox1.Location = new System.Drawing.Point(391, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 27);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Raza (px)";
            // 
            // tboxRaza
            // 
            this.tboxRaza.Location = new System.Drawing.Point(480, 114);
            this.tboxRaza.Name = "tboxRaza";
            this.tboxRaza.Size = new System.Drawing.Size(129, 27);
            this.tboxRaza.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Setează raza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbPreview
            // 
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPreview.Location = new System.Drawing.Point(365, 349);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(274, 221);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreview.TabIndex = 8;
            this.pbPreview.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "Setează Scaleul";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(504, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 27);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "ScaleX,Y (%)";
            // 
            // FormAfis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbPreview);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tboxRaza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pbAfis);
            this.Controls.Add(this.btnSalveazaAfis);
            this.Controls.Add(this.pbOriginalImage);
            this.Controls.Add(this.btnIncarcaImagine);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAfis";
            this.Text = "FormAfis";
            this.Load += new System.EventHandler(this.FormAfis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAfis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncarcaImagine;
        private System.Windows.Forms.PictureBox pbOriginalImage;
        private System.Windows.Forms.Button btnSalveazaAfis;
        private System.Windows.Forms.PictureBox pbAfis;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxRaza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}