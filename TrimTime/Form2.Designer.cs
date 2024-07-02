
namespace TrimTime
{
    partial class REGform
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PW_inputreg = new System.Windows.Forms.TextBox();
            this.UN_inputreg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EM_inputreg = new System.Windows.Forms.TextBox();
            this.REGISTER_btn = new System.Windows.Forms.Button();
            this.BACK_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(786, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME TO TRIMTIME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(145, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "PASSWORD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(145, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "USERNAME:";
            // 
            // PW_inputreg
            // 
            this.PW_inputreg.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PW_inputreg.Location = new System.Drawing.Point(308, 214);
            this.PW_inputreg.Name = "PW_inputreg";
            this.PW_inputreg.PasswordChar = '*';
            this.PW_inputreg.Size = new System.Drawing.Size(271, 35);
            this.PW_inputreg.TabIndex = 7;
            // 
            // UN_inputreg
            // 
            this.UN_inputreg.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UN_inputreg.Location = new System.Drawing.Point(308, 165);
            this.UN_inputreg.Name = "UN_inputreg";
            this.UN_inputreg.Size = new System.Drawing.Size(271, 35);
            this.UN_inputreg.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(145, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "EMAIL:";
            // 
            // EM_inputreg
            // 
            this.EM_inputreg.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EM_inputreg.Location = new System.Drawing.Point(308, 258);
            this.EM_inputreg.Name = "EM_inputreg";
            this.EM_inputreg.Size = new System.Drawing.Size(271, 35);
            this.EM_inputreg.TabIndex = 10;
            // 
            // REGISTER_btn
            // 
            this.REGISTER_btn.BackColor = System.Drawing.Color.Transparent;
            this.REGISTER_btn.Location = new System.Drawing.Point(634, 186);
            this.REGISTER_btn.Name = "REGISTER_btn";
            this.REGISTER_btn.Size = new System.Drawing.Size(110, 35);
            this.REGISTER_btn.TabIndex = 12;
            this.REGISTER_btn.Text = "REGISTER";
            this.REGISTER_btn.UseVisualStyleBackColor = false;
            this.REGISTER_btn.Click += new System.EventHandler(this.REGISTER_btn_Click);
            // 
            // BACK_btn
            // 
            this.BACK_btn.Location = new System.Drawing.Point(634, 248);
            this.BACK_btn.Name = "BACK_btn";
            this.BACK_btn.Size = new System.Drawing.Size(110, 35);
            this.BACK_btn.TabIndex = 13;
            this.BACK_btn.Text = "BACK";
            this.BACK_btn.UseVisualStyleBackColor = true;
            this.BACK_btn.Click += new System.EventHandler(this.BACK_btn_Click);
            // 
            // REGform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrimTime.Properties.Resources.MAINbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 381);
            this.Controls.Add(this.BACK_btn);
            this.Controls.Add(this.REGISTER_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EM_inputreg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PW_inputreg);
            this.Controls.Add(this.UN_inputreg);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "REGform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrimTime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PW_inputreg;
        private System.Windows.Forms.TextBox UN_inputreg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EM_inputreg;
        private System.Windows.Forms.Button REGISTER_btn;
        private System.Windows.Forms.Button BACK_btn;
    }
}