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
            this.saveUserButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Usuário";
            // 
            // nameUserTextBox
            // 
            this.nameUserTextBox.Location = new System.Drawing.Point(15, 90);
            this.nameUserTextBox.Name = "nameUserTextBox";
            this.nameUserTextBox.Size = new System.Drawing.Size(341, 26);
            this.nameUserTextBox.TabIndex = 1;
            // 
            // saveUserButton
            // 
            this.saveUserButton.Image = ((System.Drawing.Image)(resources.GetObject("saveUserButton.Image")));
            this.saveUserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveUserButton.Location = new System.Drawing.Point(224, 190);
            this.saveUserButton.Name = "saveUserButton";
            this.saveUserButton.Size = new System.Drawing.Size(132, 52);
            this.saveUserButton.TabIndex = 11;
            this.saveUserButton.Text = "      Cadastrar";
            this.saveUserButton.UseVisualStyleBackColor = true;
            this.saveUserButton.Click += new System.EventHandler(this.saveUserButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "E-Mail";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(12, 152);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(341, 26);
            this.emailTextBox.TabIndex = 13;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(15, 30);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(341, 26);
            this.fullNameTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nome Completo";
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(376, 257);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveUserButton);
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
        private System.Windows.Forms.Button saveUserButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label4;
    }
}