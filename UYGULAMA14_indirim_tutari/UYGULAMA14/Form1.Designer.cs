
namespace UYGULAMA14
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonyuzde10 = new System.Windows.Forms.Button();
            this.buttonyuzde25 = new System.Windows.Forms.Button();
            this.buttonyuzde50 = new System.Windows.Forms.Button();
            this.buttonyuzde75 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "etiket fiyati:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(159, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // buttonyuzde10
            // 
            this.buttonyuzde10.Location = new System.Drawing.Point(44, 101);
            this.buttonyuzde10.Name = "buttonyuzde10";
            this.buttonyuzde10.Size = new System.Drawing.Size(75, 58);
            this.buttonyuzde10.TabIndex = 2;
            this.buttonyuzde10.Text = "yüzde 10 indirim";
            this.buttonyuzde10.UseVisualStyleBackColor = true;
            this.buttonyuzde10.Click += new System.EventHandler(this.buttonyuzde10_Click);
            // 
            // buttonyuzde25
            // 
            this.buttonyuzde25.Location = new System.Drawing.Point(125, 101);
            this.buttonyuzde25.Name = "buttonyuzde25";
            this.buttonyuzde25.Size = new System.Drawing.Size(75, 58);
            this.buttonyuzde25.TabIndex = 3;
            this.buttonyuzde25.Text = "yüzde 25 indirim";
            this.buttonyuzde25.UseVisualStyleBackColor = true;
            this.buttonyuzde25.Click += new System.EventHandler(this.buttonyuzde25_Click);
            // 
            // buttonyuzde50
            // 
            this.buttonyuzde50.Location = new System.Drawing.Point(206, 101);
            this.buttonyuzde50.Name = "buttonyuzde50";
            this.buttonyuzde50.Size = new System.Drawing.Size(75, 58);
            this.buttonyuzde50.TabIndex = 4;
            this.buttonyuzde50.Text = "yüzde 50 indirim";
            this.buttonyuzde50.UseVisualStyleBackColor = true;
            this.buttonyuzde50.Click += new System.EventHandler(this.buttonyuzde50_Click);
            // 
            // buttonyuzde75
            // 
            this.buttonyuzde75.Location = new System.Drawing.Point(287, 101);
            this.buttonyuzde75.Name = "buttonyuzde75";
            this.buttonyuzde75.Size = new System.Drawing.Size(75, 58);
            this.buttonyuzde75.TabIndex = 5;
            this.buttonyuzde75.Text = "yüzde 75 indirim";
            this.buttonyuzde75.UseVisualStyleBackColor = true;
            this.buttonyuzde75.Click += new System.EventHandler(this.buttonyuzde75_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "indirim fiyati:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonyuzde75);
            this.Controls.Add(this.buttonyuzde50);
            this.Controls.Add(this.buttonyuzde25);
            this.Controls.Add(this.buttonyuzde10);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonyuzde10;
        private System.Windows.Forms.Button buttonyuzde25;
        private System.Windows.Forms.Button buttonyuzde50;
        private System.Windows.Forms.Button buttonyuzde75;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

