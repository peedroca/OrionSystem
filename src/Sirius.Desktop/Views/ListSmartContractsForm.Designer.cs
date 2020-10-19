namespace Sirius.Desktop.Views
{
    partial class ListSmartContractsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSmartContractsForm));
            this.smartContractsDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createContractButton = new System.Windows.Forms.Button();
            this.consultContractButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.companyContractTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.smartContractsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // smartContractsDataGridView
            // 
            this.smartContractsDataGridView.AllowUserToAddRows = false;
            this.smartContractsDataGridView.AllowUserToDeleteRows = false;
            this.smartContractsDataGridView.AllowUserToResizeColumns = false;
            this.smartContractsDataGridView.AllowUserToResizeRows = false;
            this.smartContractsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.smartContractsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.smartContractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.smartContractsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.smartContractsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.smartContractsDataGridView.Location = new System.Drawing.Point(13, 43);
            this.smartContractsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.smartContractsDataGridView.Name = "smartContractsDataGridView";
            this.smartContractsDataGridView.RowHeadersVisible = false;
            this.smartContractsDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartContractsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.smartContractsDataGridView.RowTemplate.Height = 28;
            this.smartContractsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.smartContractsDataGridView.Size = new System.Drawing.Size(602, 284);
            this.smartContractsDataGridView.TabIndex = 1;
            this.smartContractsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.smartContractsDataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Title";
            this.Column1.HeaderText = "Título";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Value";
            this.Column2.HeaderText = "Valor";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // createContractButton
            // 
            this.createContractButton.ForeColor = System.Drawing.Color.Black;
            this.createContractButton.Image = ((System.Drawing.Image)(resources.GetObject("createContractButton.Image")));
            this.createContractButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createContractButton.Location = new System.Drawing.Point(451, 335);
            this.createContractButton.Margin = new System.Windows.Forms.Padding(4);
            this.createContractButton.Name = "createContractButton";
            this.createContractButton.Size = new System.Drawing.Size(164, 64);
            this.createContractButton.TabIndex = 2;
            this.createContractButton.Text = "Novo";
            this.createContractButton.UseVisualStyleBackColor = true;
            this.createContractButton.Click += new System.EventHandler(this.createContractButton_Click);
            // 
            // consultContractButton
            // 
            this.consultContractButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.consultContractButton.Image = ((System.Drawing.Image)(resources.GetObject("consultContractButton.Image")));
            this.consultContractButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.consultContractButton.Location = new System.Drawing.Point(287, 335);
            this.consultContractButton.Margin = new System.Windows.Forms.Padding(4);
            this.consultContractButton.Name = "consultContractButton";
            this.consultContractButton.Size = new System.Drawing.Size(156, 64);
            this.consultContractButton.TabIndex = 3;
            this.consultContractButton.Text = "Consultar";
            this.consultContractButton.UseVisualStyleBackColor = true;
            this.consultContractButton.Click += new System.EventHandler(this.consultContractButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contratos da Empresa:";
            // 
            // companyContractTextBox
            // 
            this.companyContractTextBox.Enabled = false;
            this.companyContractTextBox.Location = new System.Drawing.Point(188, 10);
            this.companyContractTextBox.Name = "companyContractTextBox";
            this.companyContractTextBox.Size = new System.Drawing.Size(275, 26);
            this.companyContractTextBox.TabIndex = 5;
            this.companyContractTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ListSmartContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(628, 408);
            this.Controls.Add(this.companyContractTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consultContractButton);
            this.Controls.Add(this.createContractButton);
            this.Controls.Add(this.smartContractsDataGridView);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ListSmartContractsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contratos Inteligentes";
            this.Load += new System.EventHandler(this.ListSmartContractsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smartContractsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView smartContractsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button createContractButton;
        private System.Windows.Forms.Button consultContractButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyContractTextBox;
    }
}