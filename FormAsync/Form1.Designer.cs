namespace FormAsync
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richtxt = new System.Windows.Forms.RichTextBox();
            this.txtsayac = new System.Windows.Forms.TextBox();
            this.richTxt2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Saydır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richtxt
            // 
            this.richtxt.Location = new System.Drawing.Point(26, 72);
            this.richtxt.Name = "richtxt";
            this.richtxt.Size = new System.Drawing.Size(192, 172);
            this.richtxt.TabIndex = 2;
            this.richtxt.Text = "";
            // 
            // txtsayac
            // 
            this.txtsayac.Location = new System.Drawing.Point(287, 72);
            this.txtsayac.Name = "txtsayac";
            this.txtsayac.Size = new System.Drawing.Size(152, 22);
            this.txtsayac.TabIndex = 3;
            // 
            // richTxt2
            // 
            this.richTxt2.Location = new System.Drawing.Point(593, 72);
            this.richTxt2.Name = "richTxt2";
            this.richTxt2.Size = new System.Drawing.Size(142, 172);
            this.richTxt2.TabIndex = 4;
            this.richTxt2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTxt2);
            this.Controls.Add(this.txtsayac);
            this.Controls.Add(this.richtxt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richtxt;
        private System.Windows.Forms.TextBox txtsayac;
        private System.Windows.Forms.RichTextBox richTxt2;
    }
}

