namespace Sirius.Desktop.Views
{
    partial class AnalyzeClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalyzeClientForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.birthDateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fristNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.physicalPersonPhoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cnpjMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nickNameTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.approvedButton = new System.Windows.Forms.Button();
            this.disapprovedButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.birthDateMaskedTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cpfMaskedTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lastNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fristNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(716, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pessoa Física";
            // 
            // birthDateMaskedTextBox
            // 
            this.birthDateMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.birthDateMaskedTextBox.Enabled = false;
            this.birthDateMaskedTextBox.Location = new System.Drawing.Point(306, 105);
            this.birthDateMaskedTextBox.Mask = "00/00/0000";
            this.birthDateMaskedTextBox.Name = "birthDateMaskedTextBox";
            this.birthDateMaskedTextBox.Size = new System.Drawing.Size(396, 26);
            this.birthDateMaskedTextBox.TabIndex = 77;
            this.birthDateMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthDateMaskedTextBox.ValidatingType = typeof(System.DateTime);
            this.birthDateMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.birthDateMaskedTextBox_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(303, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 76;
            this.label4.Text = "Data de Nascimento";
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cpfMaskedTextBox.Enabled = false;
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(10, 105);
            this.cpfMaskedTextBox.Mask = "999.999.999-99";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(287, 26);
            this.cpfMaskedTextBox.TabIndex = 75;
            this.cpfMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cpfMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cpfMaskedTextBox_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 74;
            this.label3.Text = "CPF";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(306, 46);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(396, 26);
            this.lastNameTextBox.TabIndex = 73;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.lastNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(303, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Segundo Nome";
            // 
            // fristNameTextBox
            // 
            this.fristNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fristNameTextBox.Enabled = false;
            this.fristNameTextBox.Location = new System.Drawing.Point(10, 46);
            this.fristNameTextBox.Name = "fristNameTextBox";
            this.fristNameTextBox.Size = new System.Drawing.Size(287, 26);
            this.fristNameTextBox.TabIndex = 71;
            this.fristNameTextBox.TextChanged += new System.EventHandler(this.fristNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro Nome";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Location = new System.Drawing.Point(10, 44);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(496, 26);
            this.emailTextBox.TabIndex = 81;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 80;
            this.label6.Text = "E-Mail";
            // 
            // physicalPersonPhoneMaskedTextBox
            // 
            this.physicalPersonPhoneMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.physicalPersonPhoneMaskedTextBox.Enabled = false;
            this.physicalPersonPhoneMaskedTextBox.Location = new System.Drawing.Point(512, 44);
            this.physicalPersonPhoneMaskedTextBox.Mask = "99999-9999";
            this.physicalPersonPhoneMaskedTextBox.Name = "physicalPersonPhoneMaskedTextBox";
            this.physicalPersonPhoneMaskedTextBox.Size = new System.Drawing.Size(190, 26);
            this.physicalPersonPhoneMaskedTextBox.TabIndex = 79;
            this.physicalPersonPhoneMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.physicalPersonPhoneMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.physicalPersonPhoneMaskedTextBox_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(509, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 78;
            this.label5.Text = "Telefone";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cnpjMaskedTextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nickNameTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(18, 194);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(716, 95);
            this.groupBox2.TabIndex = 82;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pessoa Jurídica";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cnpjMaskedTextBox
            // 
            this.cnpjMaskedTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cnpjMaskedTextBox.Enabled = false;
            this.cnpjMaskedTextBox.Location = new System.Drawing.Point(528, 50);
            this.cnpjMaskedTextBox.Mask = "99.999.999/9999-99";
            this.cnpjMaskedTextBox.Name = "cnpjMaskedTextBox";
            this.cnpjMaskedTextBox.Size = new System.Drawing.Size(174, 26);
            this.cnpjMaskedTextBox.TabIndex = 75;
            this.cnpjMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(525, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 18);
            this.label10.TabIndex = 74;
            this.label10.Text = "CNPJ";
            // 
            // nickNameTextBox
            // 
            this.nickNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nickNameTextBox.Enabled = false;
            this.nickNameTextBox.Location = new System.Drawing.Point(10, 50);
            this.nickNameTextBox.Name = "nickNameTextBox";
            this.nickNameTextBox.Size = new System.Drawing.Size(512, 26);
            this.nickNameTextBox.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(7, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Razão Social";
            // 
            // approvedButton
            // 
            this.approvedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.approvedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.approvedButton.Image = ((System.Drawing.Image)(resources.GetObject("approvedButton.Image")));
            this.approvedButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.approvedButton.Location = new System.Drawing.Point(582, 434);
            this.approvedButton.Name = "approvedButton";
            this.approvedButton.Size = new System.Drawing.Size(152, 46);
            this.approvedButton.TabIndex = 83;
            this.approvedButton.Text = "Aprovar";
            this.approvedButton.UseVisualStyleBackColor = true;
            this.approvedButton.Click += new System.EventHandler(this.approvedButton_Click);
            // 
            // disapprovedButton
            // 
            this.disapprovedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.disapprovedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disapprovedButton.Image = ((System.Drawing.Image)(resources.GetObject("disapprovedButton.Image")));
            this.disapprovedButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disapprovedButton.Location = new System.Drawing.Point(424, 434);
            this.disapprovedButton.Name = "disapprovedButton";
            this.disapprovedButton.Size = new System.Drawing.Size(152, 46);
            this.disapprovedButton.TabIndex = 84;
            this.disapprovedButton.Text = "Reprovar";
            this.disapprovedButton.UseVisualStyleBackColor = true;
            this.disapprovedButton.Click += new System.EventHandler(this.disapprovedButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.emailTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.physicalPersonPhoneMaskedTextBox);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(18, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(716, 95);
            this.groupBox3.TabIndex = 85;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contatos";
            // 
            // AnalyzeClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(746, 525);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.disapprovedButton);
            this.Controls.Add(this.approvedButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AnalyzeClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analize de Clientes";
            this.Load += new System.EventHandler(this.AnalyzeClientForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fristNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox physicalPersonPhoneMaskedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox birthDateMaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox cnpjMaskedTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nickNameTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button approvedButton;
        private System.Windows.Forms.Button disapprovedButton;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}