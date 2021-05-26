
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_show2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_filedir = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.lb_out_stt = new System.Windows.Forms.Label();
            this.btn_copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(227, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Read_MAC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_input.Location = new System.Drawing.Point(12, 64);
            this.txt_input.MaxLength = 10;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(209, 43);
            this.txt_input.TabIndex = 4;
            this.txt_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_input_KeyDown);
            // 
            // txt_show2
            // 
            this.txt_show2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_show2.Location = new System.Drawing.Point(344, 67);
            this.txt_show2.Multiline = true;
            this.txt_show2.Name = "txt_show2";
            this.txt_show2.Size = new System.Drawing.Size(489, 32);
            this.txt_show2.TabIndex = 5;
            this.txt_show2.TextChanged += new System.EventHandler(this.txt_show2_TextChanged);
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
            // lb_out_stt
            // 
            this.lb_out_stt.AutoSize = true;
            this.lb_out_stt.Location = new System.Drawing.Point(504, 40);
            this.lb_out_stt.Name = "lb_out_stt";
            this.lb_out_stt.Size = new System.Drawing.Size(13, 15);
            this.lb_out_stt.TabIndex = 9;
            this.lb_out_stt.Text = "..";
            // 
            // btn_copy
            // 
            this.btn_copy.Enabled = false;
            this.btn_copy.Location = new System.Drawing.Point(839, 70);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 32);
            this.btn_copy.TabIndex = 10;
            this.btn_copy.Text = "Cut";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 132);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.lb_out_stt);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txt_filedir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_show2);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_show2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_filedir;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label lb_out_stt;
        private System.Windows.Forms.Button btn_copy;
    }
}

