
namespace product_filter1
{
    partial class app_option
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
            this.txt_maxlength = new System.Windows.Forms.TextBox();
            this.txt_stringtemplate = new System.Windows.Forms.TextBox();
            this.txt_filepass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.save_appop = new System.Windows.Forms.Button();
            this.txt_incol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_outcol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_maxlength
            // 
            this.txt_maxlength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maxlength.Location = new System.Drawing.Point(174, 157);
            this.txt_maxlength.Name = "txt_maxlength";
            this.txt_maxlength.Size = new System.Drawing.Size(91, 26);
            this.txt_maxlength.TabIndex = 0;
            // 
            // txt_stringtemplate
            // 
            this.txt_stringtemplate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stringtemplate.Location = new System.Drawing.Point(174, 113);
            this.txt_stringtemplate.Name = "txt_stringtemplate";
            this.txt_stringtemplate.Size = new System.Drawing.Size(249, 26);
            this.txt_stringtemplate.TabIndex = 1;
            // 
            // txt_filepass
            // 
            this.txt_filepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filepass.Location = new System.Drawing.Point(174, 201);
            this.txt_filepass.Name = "txt_filepass";
            this.txt_filepass.PasswordChar = '*';
            this.txt_filepass.Size = new System.Drawing.Size(249, 26);
            this.txt_filepass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "string template";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "excel pass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "max_input_length";
            // 
            // save_appop
            // 
            this.save_appop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_appop.Location = new System.Drawing.Point(348, 322);
            this.save_appop.Name = "save_appop";
            this.save_appop.Size = new System.Drawing.Size(107, 37);
            this.save_appop.TabIndex = 6;
            this.save_appop.Text = "SAVE";
            this.save_appop.UseVisualStyleBackColor = true;
            this.save_appop.Click += new System.EventHandler(this.save_appop_Click);
            // 
            // txt_incol
            // 
            this.txt_incol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_incol.Location = new System.Drawing.Point(174, 251);
            this.txt_incol.Multiline = true;
            this.txt_incol.Name = "txt_incol";
            this.txt_incol.Size = new System.Drawing.Size(68, 31);
            this.txt_incol.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "input col";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(269, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "output col";
            // 
            // txt_outcol
            // 
            this.txt_outcol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_outcol.Location = new System.Drawing.Point(367, 250);
            this.txt_outcol.Multiline = true;
            this.txt_outcol.Name = "txt_outcol";
            this.txt_outcol.Size = new System.Drawing.Size(56, 32);
            this.txt_outcol.TabIndex = 9;
            // 
            // app_option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_outcol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_incol);
            this.Controls.Add(this.save_appop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_filepass);
            this.Controls.Add(this.txt_stringtemplate);
            this.Controls.Add(this.txt_maxlength);
            this.Name = "app_option";
            this.Text = "app_option";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.app_option_FormClosed);
            this.Load += new System.EventHandler(this.app_option_Load);
            this.Shown += new System.EventHandler(this.app_option_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_maxlength;
        private System.Windows.Forms.TextBox txt_stringtemplate;
        private System.Windows.Forms.TextBox txt_filepass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save_appop;
        private System.Windows.Forms.TextBox txt_incol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_outcol;
    }
}