
namespace LR10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.l_pass = new System.Windows.Forms.Label();
            this.l_login = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.MaskedTextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.b_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Войдите в систему";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_pass
            // 
            this.l_pass.AutoSize = true;
            this.l_pass.Location = new System.Drawing.Point(114, 81);
            this.l_pass.Name = "l_pass";
            this.l_pass.Size = new System.Drawing.Size(48, 13);
            this.l_pass.TabIndex = 1;
            this.l_pass.Text = "Пароль:";
            // 
            // l_login
            // 
            this.l_login.AutoSize = true;
            this.l_login.Location = new System.Drawing.Point(114, 42);
            this.l_login.Name = "l_login";
            this.l_login.Size = new System.Drawing.Size(41, 13);
            this.l_login.TabIndex = 2;
            this.l_login.Text = "Логин:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(117, 97);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 3;
            this.tb_password.Text = "admin";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(117, 58);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(100, 20);
            this.tb_login.TabIndex = 4;
            this.tb_login.Text = "admin";
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(117, 123);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(100, 23);
            this.b_login.TabIndex = 5;
            this.b_login.Text = "Войти";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 152);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.l_login);
            this.Controls.Add(this.l_pass);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_pass;
        private System.Windows.Forms.Label l_login;
        private System.Windows.Forms.MaskedTextBox tb_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Button b_login;
    }
}

