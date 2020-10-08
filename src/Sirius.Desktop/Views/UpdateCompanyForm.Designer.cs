namespace Sirius.Desktop.Views
{
    partial class UpdateCompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCompanyForm));
            this.telefoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cnpjTextBox = new System.Windows.Forms.MaskedTextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nickNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.cnpjLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fantasiaTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.razaoSocialTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inactiveCheckBox = new System.Windows.Forms.CheckBox();
            this.blockedCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(15, 192);
            this.telefoneTextBox.Mask = "(99) 9999-9999";
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(287, 26);
            this.telefoneTextBox.TabIndex = 27;
            this.telefoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.Location = new System.Drawing.Point(15, 31);
            this.cnpjTextBox.Mask = "99.999.999/9999-99";
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(287, 26);
            this.cnpjTextBox.TabIndex = 18;
            this.cnpjTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Red;
            this.emailLabel.Location = new System.Drawing.Point(71, 230);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 14);
            this.emailLabel.TabIndex = 29;
            this.emailLabel.Text = "label6";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneLabel.Location = new System.Drawing.Point(78, 173);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(35, 14);
            this.phoneLabel.TabIndex = 26;
            this.phoneLabel.Text = "label6";
            // 
            // nickNameLabel
            // 
            this.nickNameLabel.AutoSize = true;
            this.nickNameLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickNameLabel.ForeColor = System.Drawing.Color.Red;
            this.nickNameLabel.Location = new System.Drawing.Point(87, 120);
            this.nickNameLabel.Name = "nickNameLabel";
            this.nickNameLabel.Size = new System.Drawing.Size(35, 14);
            this.nickNameLabel.TabIndex = 23;
            this.nickNameLabel.Text = "label6";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Red;
            this.nameLabel.Location = new System.Drawing.Point(117, 67);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 14);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "label6";
            // 
            // cnpjLabel
            // 
            this.cnpjLabel.AutoSize = true;
            this.cnpjLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnpjLabel.ForeColor = System.Drawing.Color.Red;
            this.cnpjLabel.Location = new System.Drawing.Point(68, 12);
            this.cnpjLabel.Name = "cnpjLabel";
            this.cnpjLabel.Size = new System.Drawing.Size(35, 14);
            this.cnpjLabel.TabIndex = 17;
            this.cnpjLabel.Text = "label6";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(199, 279);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 36);
            this.saveButton.TabIndex = 31;
            this.saveButton.Text = "Salvar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(15, 247);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(287, 26);
            this.emailTextBox.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "E-mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefone ";
            // 
            // fantasiaTextBox
            // 
            this.fantasiaTextBox.Location = new System.Drawing.Point(15, 138);
            this.fantasiaTextBox.Name = "fantasiaTextBox";
            this.fantasiaTextBox.Size = new System.Drawing.Size(287, 26);
            this.fantasiaTextBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fantasia";
            // 
            // razaoSocialTextBox
            // 
            this.razaoSocialTextBox.Location = new System.Drawing.Point(15, 84);
            this.razaoSocialTextBox.Name = "razaoSocialTextBox";
            this.razaoSocialTextBox.Size = new System.Drawing.Size(287, 26);
            this.razaoSocialTextBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Razão Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "CNPJ";
            // 
            // inactiveCheckBox
            // 
            this.inactiveCheckBox.AutoSize = true;
            this.inactiveCheckBox.Location = new System.Drawing.Point(15, 279);
            this.inactiveCheckBox.Name = "inactiveCheckBox";
            this.inactiveCheckBox.Size = new System.Drawing.Size(89, 22);
            this.inactiveCheckBox.TabIndex = 32;
            this.inactiveCheckBox.Text = "Inativado";
            this.inactiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // blockedCheckBox
            // 
            this.blockedCheckBox.AutoSize = true;
            this.blockedCheckBox.Location = new System.Drawing.Point(15, 307);
            this.blockedCheckBox.Name = "blockedCheckBox";
            this.blockedCheckBox.Size = new System.Drawing.Size(103, 22);
            this.blockedCheckBox.TabIndex = 33;
            this.blockedCheckBox.Text = "Bloqueado";
            this.blockedCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdateCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 336);
            this.Controls.Add(this.blockedCheckBox);
            this.Controls.Add(this.inactiveCheckBox);
            this.Controls.Add(this.telefoneTextBox);
            this.Controls.Add(this.cnpjTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.nickNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cnpjLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fantasiaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.razaoSocialTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "UpdateCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Empresa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox telefoneTextBox;
        private System.Windows.Forms.MaskedTextBox cnpjTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nickNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label cnpjLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fantasiaTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox razaoSocialTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox inactiveCheckBox;
        private System.Windows.Forms.CheckBox blockedCheckBox;
    }
}