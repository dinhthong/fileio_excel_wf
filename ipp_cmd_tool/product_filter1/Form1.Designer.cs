﻿namespace product_filter1
{
    partial class ipp_cmd_tool
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
            this.txt_filepath = new System.Windows.Forms.TextBox();
            this.btn_select_file = new System.Windows.Forms.Button();
            this.txt_input_serial = new System.Windows.Forms.TextBox();
            this.txt_show = new System.Windows.Forms.TextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.lb_kq = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.btn_opensetting = new System.Windows.Forms.Button();
            this.btn_readfile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txt_filepath
            // 
            this.txt_filepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filepath.Location = new System.Drawing.Point(12, 40);
            this.txt_filepath.Name = "txt_filepath";
            this.txt_filepath.Size = new System.Drawing.Size(551, 26);
            this.txt_filepath.TabIndex = 6;
            // 
            // btn_select_file
            // 
            this.btn_select_file.Location = new System.Drawing.Point(589, 43);
            this.btn_select_file.Name = "btn_select_file";
            this.btn_select_file.Size = new System.Drawing.Size(75, 23);
            this.btn_select_file.TabIndex = 7;
            this.btn_select_file.Text = "...";
            this.btn_select_file.UseVisualStyleBackColor = true;
            this.btn_select_file.Click += new System.EventHandler(this.btn_select_file_Click);
            // 
            // txt_input_serial
            // 
            this.txt_input_serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input_serial.Location = new System.Drawing.Point(44, 93);
            this.txt_input_serial.MaxLength = 10;
            this.txt_input_serial.Name = "txt_input_serial";
            this.txt_input_serial.Size = new System.Drawing.Size(407, 35);
            this.txt_input_serial.TabIndex = 8;
            this.txt_input_serial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_input_serial_KeyDown);
            // 
            // txt_show
            // 
            this.txt_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_show.Location = new System.Drawing.Point(22, 179);
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(551, 31);
            this.txt_show.TabIndex = 9;
            // 
            // btn_read
            // 
            this.btn_read.Enabled = false;
            this.btn_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_read.Location = new System.Drawing.Point(559, 103);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(95, 36);
            this.btn_read.TabIndex = 10;
            this.btn_read.Text = "Read INPUT";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy.Location = new System.Drawing.Point(589, 179);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(113, 31);
            this.btn_copy.TabIndex = 11;
            this.btn_copy.Text = "Cut CMD";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // lb_kq
            // 
            this.lb_kq.AutoSize = true;
            this.lb_kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kq.Location = new System.Drawing.Point(89, 151);
            this.lb_kq.Name = "lb_kq";
            this.lb_kq.Size = new System.Drawing.Size(132, 25);
            this.lb_kq.TabIndex = 14;
            this.lb_kq.Text = "ket qua read";
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(47, 224);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(75, 29);
            this.lb_status.TabIndex = 15;
            this.lb_status.Text = "status";
            // 
            // btn_opensetting
            // 
            this.btn_opensetting.Location = new System.Drawing.Point(819, 328);
            this.btn_opensetting.Name = "btn_opensetting";
            this.btn_opensetting.Size = new System.Drawing.Size(26, 20);
            this.btn_opensetting.TabIndex = 18;
            this.btn_opensetting.Text = "ST";
            this.btn_opensetting.UseVisualStyleBackColor = true;
            this.btn_opensetting.Click += new System.EventHandler(this.btn_opensetting_Click);
            // 
            // btn_readfile
            // 
            this.btn_readfile.Location = new System.Drawing.Point(683, 43);
            this.btn_readfile.Name = "btn_readfile";
            this.btn_readfile.Size = new System.Drawing.Size(75, 23);
            this.btn_readfile.TabIndex = 19;
            this.btn_readfile.Text = "READ FILE";
            this.btn_readfile.UseVisualStyleBackColor = true;
            this.btn_readfile.Click += new System.EventHandler(this.btn_readfile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ipp_cmd_tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 256);
            this.Controls.Add(this.btn_readfile);
            this.Controls.Add(this.btn_opensetting);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lb_kq);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.txt_show);
            this.Controls.Add(this.txt_input_serial);
            this.Controls.Add(this.btn_select_file);
            this.Controls.Add(this.txt_filepath);
            this.Name = "ipp_cmd_tool";
            this.Text = "ipphone command tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.ipp_cmd_tool_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_filepath;
        private System.Windows.Forms.Button btn_select_file;
        private System.Windows.Forms.TextBox txt_input_serial;
        private System.Windows.Forms.TextBox txt_show;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Label lb_kq;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button btn_opensetting;
        private System.Windows.Forms.Button btn_readfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

