
namespace newReadExcel
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
            this.read = new System.Windows.Forms.Button();
            this.txt_show = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_show2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_filedir = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(504, 267);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(126, 53);
            this.read.TabIndex = 0;
            this.read.Text = "READ";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // txt_show
            // 
            this.txt_show.Location = new System.Drawing.Point(33, 208);
            this.txt_show.Multiline = true;
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(310, 57);
            this.txt_show.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Read_MAC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(85, 283);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(70, 61);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(186, 35);
            this.txt_input.TabIndex = 4;
            // 
            // txt_show2
            // 
            this.txt_show2.Location = new System.Drawing.Point(504, 61);
            this.txt_show2.Multiline = true;
            this.txt_show2.Name = "txt_show2";
            this.txt_show2.Size = new System.Drawing.Size(178, 35);
            this.txt_show2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Input";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txt_filedir
            // 
            this.txt_filedir.Location = new System.Drawing.Point(70, 12);
            this.txt_filedir.Name = "txt_filedir";
            this.txt_filedir.Size = new System.Drawing.Size(463, 23);
            this.txt_filedir.TabIndex = 7;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(555, 12);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 8;
            this.btn_browse.Text = "...DIR";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txt_filedir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_show2);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_show);
            this.Controls.Add(this.read);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button read;
        private System.Windows.Forms.TextBox txt_show;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_show2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_filedir;
        private System.Windows.Forms.Button btn_browse;
    }
}

