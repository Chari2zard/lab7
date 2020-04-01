namespace lab7
{
    partial class Form2
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
            this.showTxtFile = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showTxtFile
            // 
            this.showTxtFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showTxtFile.Location = new System.Drawing.Point(0, 3);
            this.showTxtFile.Multiline = true;
            this.showTxtFile.Name = "showTxtFile";
            this.showTxtFile.Size = new System.Drawing.Size(406, 93);
            this.showTxtFile.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(406, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 132);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.showTxtFile);
            this.Name = "Form2";
            this.Text = "Вміст файлу log.txt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox showTxtFile;
        private System.Windows.Forms.Button button2;
    }
}