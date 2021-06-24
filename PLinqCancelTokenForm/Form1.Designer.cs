namespace PLinqCancelTokenForm
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
            this.btn_Baslat = new System.Windows.Forms.Button();
            this.bnt_Bitir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Baslat
            // 
            this.btn_Baslat.Location = new System.Drawing.Point(25, 28);
            this.btn_Baslat.Name = "btn_Baslat";
            this.btn_Baslat.Size = new System.Drawing.Size(75, 23);
            this.btn_Baslat.TabIndex = 0;
            this.btn_Baslat.Text = "Başlat";
            this.btn_Baslat.UseVisualStyleBackColor = true;
            this.btn_Baslat.Click += new System.EventHandler(this.btn_Baslat_Click);
            // 
            // bnt_Bitir
            // 
            this.bnt_Bitir.Location = new System.Drawing.Point(151, 28);
            this.bnt_Bitir.Name = "bnt_Bitir";
            this.bnt_Bitir.Size = new System.Drawing.Size(75, 23);
            this.bnt_Bitir.TabIndex = 0;
            this.bnt_Bitir.Text = "Bitir";
            this.bnt_Bitir.UseVisualStyleBackColor = true;
            this.bnt_Bitir.Click += new System.EventHandler(this.bnt_Bitir_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(25, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 340);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bnt_Bitir);
            this.Controls.Add(this.btn_Baslat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Baslat;
        private System.Windows.Forms.Button bnt_Bitir;
        private System.Windows.Forms.ListBox listBox1;
    }
}

