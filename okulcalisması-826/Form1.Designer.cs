namespace okulcalisması_826
{
    partial class Form1
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
            this.btnOgrenciEkleFrom = new System.Windows.Forms.Button();
            this.btnTumOgrencilerFrom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciEkleFrom
            // 
            this.btnOgrenciEkleFrom.Location = new System.Drawing.Point(57, 29);
            this.btnOgrenciEkleFrom.Name = "btnOgrenciEkleFrom";
            this.btnOgrenciEkleFrom.Size = new System.Drawing.Size(160, 142);
            this.btnOgrenciEkleFrom.TabIndex = 0;
            this.btnOgrenciEkleFrom.Text = "öğrenci ekle";
            this.btnOgrenciEkleFrom.UseVisualStyleBackColor = true;
            this.btnOgrenciEkleFrom.Click += new System.EventHandler(this.btnOgrenciEkleFrom_Click);
            // 
            // btnTumOgrencilerFrom
            // 
            this.btnTumOgrencilerFrom.Location = new System.Drawing.Point(57, 194);
            this.btnTumOgrencilerFrom.Name = "btnTumOgrencilerFrom";
            this.btnTumOgrencilerFrom.Size = new System.Drawing.Size(160, 134);
            this.btnTumOgrencilerFrom.TabIndex = 1;
            this.btnTumOgrencilerFrom.Text = "tüm öğrenciler";
            this.btnTumOgrencilerFrom.UseVisualStyleBackColor = true;
            this.btnTumOgrencilerFrom.Click += new System.EventHandler(this.btnTumOgrencilerFrom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTumOgrencilerFrom);
            this.Controls.Add(this.btnOgrenciEkleFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciEkleFrom;
        private System.Windows.Forms.Button btnTumOgrencilerFrom;
    }
}

