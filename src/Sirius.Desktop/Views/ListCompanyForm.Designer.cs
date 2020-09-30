namespace Sirius.Desktop.Views
{
    partial class ListCompanyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.companiesDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.inactivButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.razaoSocialTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cnpjTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.backCompanyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.companiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // companiesDataGridView
            // 
            this.companiesDataGridView.AllowUserToAddRows = false;
            this.companiesDataGridView.AllowUserToDeleteRows = false;
            this.companiesDataGridView.AllowUserToResizeColumns = false;
            this.companiesDataGridView.AllowUserToResizeRows = false;
            this.companiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.companiesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.companiesDataGridView.Location = new System.Drawing.Point(12, 85);
            this.companiesDataGridView.Name = "companiesDataGridView";
            this.companiesDataGridView.RowHeadersVisible = false;
            this.companiesDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companiesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.companiesDataGridView.RowTemplate.Height = 28;
            this.companiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.companiesDataGridView.Size = new System.Drawing.Size(989, 364);
            this.companiesDataGridView.TabIndex = 0;
            this.companiesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.companiesDataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Razão Social";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Nickname";
            this.Column2.HeaderText = "Fantasia";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CNPJ";
            this.Column3.HeaderText = "CNPJ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Phone";
            this.Column4.HeaderText = "Telefone";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "E-Mail";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 180;
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(858, 455);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(143, 46);
            this.newButton.TabIndex = 1;
            this.newButton.Text = "Novo";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(709, 455);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(143, 46);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Editar";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // inactivButton
            // 
            this.inactivButton.Location = new System.Drawing.Point(411, 455);
            this.inactivButton.Name = "inactivButton";
            this.inactivButton.Size = new System.Drawing.Size(143, 46);
            this.inactivButton.TabIndex = 3;
            this.inactivButton.Text = "Bloquear";
            this.inactivButton.UseVisualStyleBackColor = true;
            this.inactivButton.Click += new System.EventHandler(this.inactivButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(560, 455);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(143, 46);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Deletar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // razaoSocialTextBox
            // 
            this.razaoSocialTextBox.Location = new System.Drawing.Point(209, 31);
            this.razaoSocialTextBox.Name = "razaoSocialTextBox";
            this.razaoSocialTextBox.Size = new System.Drawing.Size(287, 26);
            this.razaoSocialTextBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Razão Social";
            // 
            // cnpjTextBox
            // 
            this.cnpjTextBox.Location = new System.Drawing.Point(502, 30);
            this.cnpjTextBox.Mask = "99.999.999/9999-99";
            this.cnpjTextBox.Name = "cnpjTextBox";
            this.cnpjTextBox.Size = new System.Drawing.Size(287, 26);
            this.cnpjTextBox.TabIndex = 25;
            this.cnpjTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(499, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "CNPJ";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(858, 30);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(102, 26);
            this.filterButton.TabIndex = 26;
            this.filterButton.Text = "Filtrar";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // backCompanyButton
            // 
            this.backCompanyButton.Location = new System.Drawing.Point(12, 9);
            this.backCompanyButton.Name = "backCompanyButton";
            this.backCompanyButton.Size = new System.Drawing.Size(113, 56);
            this.backCompanyButton.TabIndex = 27;
            this.backCompanyButton.Text = "Voltar";
            this.backCompanyButton.UseVisualStyleBackColor = true;
            this.backCompanyButton.Click += new System.EventHandler(this.backCompanyButton_Click);
            // 
            // ListCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 505);
            this.Controls.Add(this.backCompanyButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.cnpjTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.razaoSocialTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.inactivButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.companiesDataGridView);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "ListCompanyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Empresas";
            this.Load += new System.EventHandler(this.ListCompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.companiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView companiesDataGridView;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button inactivButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox razaoSocialTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox cnpjTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button backCompanyButton;
    }
}