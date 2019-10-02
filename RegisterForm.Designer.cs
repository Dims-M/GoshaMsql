namespace GoshaMsql
{
    partial class RegisterForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SaveRegButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ExitRegButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.userRegEmail = new System.Windows.Forms.TextBox();
            this.clearFildGerForm = new MaterialSkin.Controls.MaterialFlatButton();
            this.passUserFild = new System.Windows.Forms.TextBox();
            this.NamTtextBox = new System.Windows.Forms.TextBox();
            this.nameRegFormLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ComentReTtextBox = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 96);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(64, 24);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Логин";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 178);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(86, 24);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "ПАРОЛЬ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 222);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(82, 24);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "EMAIL@";
            // 
            // SaveRegButton
            // 
            this.SaveRegButton.AutoSize = true;
            this.SaveRegButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveRegButton.Depth = 0;
            this.SaveRegButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SaveRegButton.Location = new System.Drawing.Point(16, 382);
            this.SaveRegButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveRegButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveRegButton.Name = "SaveRegButton";
            this.SaveRegButton.Primary = false;
            this.SaveRegButton.Size = new System.Drawing.Size(115, 36);
            this.SaveRegButton.TabIndex = 4;
            this.SaveRegButton.Text = "Сохранить";
            this.SaveRegButton.UseVisualStyleBackColor = true;
            this.SaveRegButton.Click += new System.EventHandler(this.SaveRegButton_Click);
            // 
            // ExitRegButton
            // 
            this.ExitRegButton.AutoSize = true;
            this.ExitRegButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitRegButton.Depth = 0;
            this.ExitRegButton.Location = new System.Drawing.Point(372, 382);
            this.ExitRegButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExitRegButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitRegButton.Name = "ExitRegButton";
            this.ExitRegButton.Primary = false;
            this.ExitRegButton.Size = new System.Drawing.Size(74, 36);
            this.ExitRegButton.TabIndex = 5;
            this.ExitRegButton.Text = "Выход";
            this.ExitRegButton.UseVisualStyleBackColor = true;
            this.ExitRegButton.Click += new System.EventHandler(this.ExitRegButton_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(239, 98);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(168, 22);
            this.textBoxUser.TabIndex = 6;
            this.textBoxUser.Enter += new System.EventHandler(this.TextBoxUser_Enter);
            this.textBoxUser.Leave += new System.EventHandler(this.TextBoxUser_Leave);
            // 
            // userRegEmail
            // 
            this.userRegEmail.Location = new System.Drawing.Point(239, 224);
            this.userRegEmail.Name = "userRegEmail";
            this.userRegEmail.Size = new System.Drawing.Size(168, 22);
            this.userRegEmail.TabIndex = 8;
            this.userRegEmail.Enter += new System.EventHandler(this.UserRegEmail_Enter);
            this.userRegEmail.Leave += new System.EventHandler(this.UserRegEmail_Leave);
            // 
            // clearFildGerForm
            // 
            this.clearFildGerForm.AutoSize = true;
            this.clearFildGerForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearFildGerForm.Depth = 0;
            this.clearFildGerForm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clearFildGerForm.Location = new System.Drawing.Point(247, 309);
            this.clearFildGerForm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearFildGerForm.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearFildGerForm.Name = "clearFildGerForm";
            this.clearFildGerForm.Primary = false;
            this.clearFildGerForm.Size = new System.Drawing.Size(160, 36);
            this.clearFildGerForm.TabIndex = 9;
            this.clearFildGerForm.Text = "Очистить поля.";
            this.clearFildGerForm.UseVisualStyleBackColor = true;
            this.clearFildGerForm.Click += new System.EventHandler(this.ClearFildGerForm_Click);
            // 
            // passUserFild
            // 
            this.passUserFild.Location = new System.Drawing.Point(239, 178);
            this.passUserFild.Name = "passUserFild";
            this.passUserFild.PasswordChar = '*';
            this.passUserFild.Size = new System.Drawing.Size(168, 22);
            this.passUserFild.TabIndex = 7;
            this.passUserFild.Enter += new System.EventHandler(this.PassUserFild_Enter);
            this.passUserFild.Leave += new System.EventHandler(this.PassUserFild_Leave);
            // 
            // NamTtextBox
            // 
            this.NamTtextBox.Location = new System.Drawing.Point(239, 137);
            this.NamTtextBox.Name = "NamTtextBox";
            this.NamTtextBox.Size = new System.Drawing.Size(168, 22);
            this.NamTtextBox.TabIndex = 10;
            this.NamTtextBox.Enter += new System.EventHandler(this.NamTtextBox_Enter);
            // 
            // nameRegFormLabel
            // 
            this.nameRegFormLabel.AutoSize = true;
            this.nameRegFormLabel.Depth = 0;
            this.nameRegFormLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.nameRegFormLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameRegFormLabel.Location = new System.Drawing.Point(12, 135);
            this.nameRegFormLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameRegFormLabel.Name = "nameRegFormLabel";
            this.nameRegFormLabel.Size = new System.Drawing.Size(53, 24);
            this.nameRegFormLabel.TabIndex = 11;
            this.nameRegFormLabel.Text = "ИМЯ";
            // 
            // ComentReTtextBox
            // 
            this.ComentReTtextBox.Location = new System.Drawing.Point(239, 261);
            this.ComentReTtextBox.Name = "ComentReTtextBox";
            this.ComentReTtextBox.Size = new System.Drawing.Size(168, 22);
            this.ComentReTtextBox.TabIndex = 12;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 261);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(120, 24);
            this.materialLabel4.TabIndex = 13;
            this.materialLabel4.Text = "Коментарий";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 433);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.ComentReTtextBox);
            this.Controls.Add(this.nameRegFormLabel);
            this.Controls.Add(this.NamTtextBox);
            this.Controls.Add(this.clearFildGerForm);
            this.Controls.Add(this.userRegEmail);
            this.Controls.Add(this.passUserFild);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.ExitRegButton);
            this.Controls.Add(this.SaveRegButton);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "РЕГИСТРАЦИЯ НОВОГО ПОЛЬЗОВАТЕЛЯ";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.Enter += new System.EventHandler(this.RegisterForm_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton SaveRegButton;
        private MaterialSkin.Controls.MaterialFlatButton ExitRegButton;
        public System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox userRegEmail;
        private MaterialSkin.Controls.MaterialFlatButton clearFildGerForm;
        private System.Windows.Forms.TextBox passUserFild;
        private System.Windows.Forms.TextBox NamTtextBox;
        private MaterialSkin.Controls.MaterialLabel nameRegFormLabel;
        private System.Windows.Forms.TextBox ComentReTtextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}