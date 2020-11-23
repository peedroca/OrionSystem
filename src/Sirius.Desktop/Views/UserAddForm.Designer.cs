namespace Sirius.Desktop.Views
{
    partial class UserAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.nameUserTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordUserTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveUserButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.idUserTextBox = new System.Windows.Forms.TextBox();
            this.typeAccessComboBox = new System.Windows.Forms.ComboBox();
            this.typeUserComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Usuário";
            // 
            // nameUserTextBox
            // 
            this.nameUserTextBox.Location = new System.Drawing.Point(15, 44);
            this.nameUserTextBox.Name = "nameUserTextBox";
            this.nameUserTextBox.Size = new System.Drawing.Size(341, 26);
            this.nameUserTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha do Usuário";
            // 
            // passwordUserTextBox
            // 
            this.passwordUserTextBox.Location = new System.Drawing.Point(15, 103);
            this.passwordUserTextBox.Name = "passwordUserTextBox";
            this.passwordUserTextBox.Size = new System.Drawing.Size(341, 26);
            this.passwordUserTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo de Acesso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(242, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo de Usuário";
            // 
            // saveUserButton
            // 
            this.saveUserButton.Image = ((System.Drawing.Image)(resources.GetObject("saveUserButton.Image")));
            this.saveUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveUserButton.Location = new System.Drawing.Point(234, 278);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(132, 52);
            this.saveUserButton.TabIndex = 11;
            this.saveUserButton.Text = "      Cadastrar";
            this.saveUserButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Id Usuário";
            // 
            // idUserTextBox
            // 
            this.idUserTextBox.Location = new System.Drawing.Point(15, 162);
            this.idUserTextBox.Name = "idUserTextBox";
            this.idUserTextBox.Size = new System.Drawing.Size(115, 26);
            this.idUserTextBox.TabIndex = 13;
            // 
            // typeAccessComboBox
            // 
            this.typeAccessComboBox.Enabled = false;
            this.typeAccessComboBox.FormattingEnabled = true;
            this.typeAccessComboBox.Items.AddRange(new object[] {
            "Administrador",
            "Comum"});
            this.typeAccessComboBox.Location = new System.Drawing.Point(17, 231);
            this.typeAccessComboBox.Name = "typeAccessComboBox";
            this.typeAccessComboBox.Size = new System.Drawing.Size(121, 26);
            this.typeAccessComboBox.TabIndex = 14;
            // 
            // typeUserComboBox
            // 
            this.typeUserComboBox.Enabled = false;
            this.typeUserComboBox.FormattingEnabled = true;
            this.typeUserComboBox.Items.AddRange(new object[] {
            "Empresa",
            "Cliente",
            "Funcionario"});
            this.typeUserComboBox.Location = new System.Drawing.Point(245, 231);
            this.typeUserComboBox.Name = "typeUserComboBox";
            this.typeUserComboBox.Size = new System.Drawing.Size(121, 26);
            this.typeUserComboBox.TabIndex = 15;
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(376, 349);
            this.Controls.Add(this.typeUserComboBox);
            this.Controls.Add(this.typeAccessComboBox);
            this.Controls.Add(this.idUserTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveUserButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordUserTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameUserTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "UserAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Usuário";
            this.Load += new System.EventHandler(this.UserAddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameUserTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordUserTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idUserTextBox;
        private System.Windows.Forms.ComboBox typeAccessComboBox;
        private System.Windows.Forms.ComboBox typeUserComboBox;
    }
}