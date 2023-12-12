namespace BasicCRUDMohammad
{
    partial class LogIn
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
            this.loginbtn = new System.Windows.Forms.Button();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.userpassbox = new System.Windows.Forms.TextBox();
            this.logcancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbtn.Location = new System.Drawing.Point(90, 300);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(113, 43);
            this.loginbtn.TabIndex = 2;
            this.loginbtn.Text = "LOG IN";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(90, 136);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(278, 39);
            this.usernamebox.TabIndex = 0;
            // 
            // userpassbox
            // 
            this.userpassbox.Location = new System.Drawing.Point(90, 235);
            this.userpassbox.Name = "userpassbox";
            this.userpassbox.PasswordChar = '*';
            this.userpassbox.Size = new System.Drawing.Size(278, 39);
            this.userpassbox.TabIndex = 1;
            // 
            // logcancel
            // 
            this.logcancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.logcancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.logcancel.FlatAppearance.BorderSize = 0;
            this.logcancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logcancel.Location = new System.Drawing.Point(233, 300);
            this.logcancel.Name = "logcancel";
            this.logcancel.Size = new System.Drawing.Size(135, 43);
            this.logcancel.TabIndex = 3;
            this.logcancel.Text = "CANCEL";
            this.logcancel.UseVisualStyleBackColor = false;
            this.logcancel.Click += new System.EventHandler(this.logcancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 54);
            this.label3.TabIndex = 6;
            this.label3.Text = "Basic CRUD Sytem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "All Rights Reserved 2023 - A.S.M";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(454, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "________________________________________";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 443);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logcancel);
            this.Controls.Add(this.userpassbox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.loginbtn);
            this.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic CRUD Student Name Log";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogIn_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.TextBox userpassbox;
        private System.Windows.Forms.Button logcancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

