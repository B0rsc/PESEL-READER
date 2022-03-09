
namespace pesel_projekt
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Sprawdz = new System.Windows.Forms.Button();
            this.data_urodzenia = new System.Windows.Forms.Label();
            this.plec = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wprowadź PESEL:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Location = new System.Drawing.Point(179, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonEnter);
            // 
            // Sprawdz
            // 
            this.Sprawdz.Location = new System.Drawing.Point(327, 64);
            this.Sprawdz.Name = "Sprawdz";
            this.Sprawdz.Size = new System.Drawing.Size(91, 23);
            this.Sprawdz.TabIndex = 2;
            this.Sprawdz.Text = "Sprawdź";
            this.Sprawdz.UseVisualStyleBackColor = true;
            this.Sprawdz.Click += new System.EventHandler(this.Sprawdz_Click);
            // 
            // data_urodzenia
            // 
            this.data_urodzenia.AutoSize = true;
            this.data_urodzenia.Location = new System.Drawing.Point(12, 123);
            this.data_urodzenia.Name = "data_urodzenia";
            this.data_urodzenia.Size = new System.Drawing.Size(105, 17);
            this.data_urodzenia.TabIndex = 3;
            this.data_urodzenia.Text = "Data urodzenia";
            // 
            // plec
            // 
            this.plec.AutoSize = true;
            this.plec.Location = new System.Drawing.Point(12, 168);
            this.plec.Name = "plec";
            this.plec.Size = new System.Drawing.Size(35, 17);
            this.plec.TabIndex = 4;
            this.plec.Text = "Płeć";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(154, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "PESEL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plec);
            this.Controls.Add(this.data_urodzenia);
            this.Controls.Add(this.Sprawdz);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Sprawdz;
        private System.Windows.Forms.Label data_urodzenia;
        private System.Windows.Forms.Label plec;
        private System.Windows.Forms.Label label2;
    }
}

