namespace ReadExcel
{
    partial class main
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
            this.txt_show = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_show
            // 
            this.txt_show.Location = new System.Drawing.Point(31, 12);
            this.txt_show.Multiline = true;
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(449, 325);
            this.txt_show.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_show);
            this.Name = "main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_show;
        private System.Windows.Forms.Button button1;
    }
}

