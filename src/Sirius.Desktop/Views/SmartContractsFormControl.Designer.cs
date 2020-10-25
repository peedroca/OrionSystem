namespace Sirius.Desktop.Views
{
    partial class SmartContractsFormControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartContractsFormControl));
            this.smartContractGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createContractButton = new System.Windows.Forms.Button();
            this.consultContractButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.smartContractGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // smartContractGridView
            // 
            this.smartContractGridView.AllowUserToAddRows = false;
            this.smartContractGridView.AllowUserToDeleteRows = false;
            this.smartContractGridView.AllowUserToResizeColumns = false;
            this.smartContractGridView.AllowUserToResizeRows = false;
            this.smartContractGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.smartContractGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.contractorColumn,
            this.Column1,
            this.Column2});
            this.smartContractGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.smartContractGridView.Location = new System.Drawing.Point(13, 73);
            this.smartContractGridView.Name = "smartContractGridView";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartContractGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.smartContractGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.smartContractGridView.Size = new System.Drawing.Size(829, 348);
            this.smartContractGridView.TabIndex = 0;
            // 
            // idColumn
            // 
            this.idColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "ID Contrato";
            this.idColumn.MinimumWidth = 3;
            this.idColumn.Name = "idColumn";
            // 
            // contractorColumn
            // 
            this.contractorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contractorColumn.DataPropertyName = "CompanyModel";
            this.contractorColumn.HeaderText = "Contratante";
            this.contractorColumn.MinimumWidth = 8;
            this.contractorColumn.Name = "contractorColumn";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Title";
            this.Column1.HeaderText = "Titulo";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Value";
            this.Column2.HeaderText = "Valor";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // createContractButton
            // 
            this.createContractButton.Image = ((System.Drawing.Image)(resources.GetObject("createContractButton.Image")));
            this.createContractButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createContractButton.Location = new System.Drawing.Point(699, 427);
            this.createContractButton.Name = "createContractButton";
            this.createContractButton.Size = new System.Drawing.Size(143, 46);
            this.createContractButton.TabIndex = 1;
            this.createContractButton.Text = "   Novo";
            this.createContractButton.UseVisualStyleBackColor = true;
            this.createContractButton.Click += new System.EventHandler(this.createContractButton_Click);
            // 
            // consultContractButton
            // 
            this.consultContractButton.Image = ((System.Drawing.Image)(resources.GetObject("consultContractButton.Image")));
            this.consultContractButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultContractButton.Location = new System.Drawing.Point(550, 427);
            this.consultContractButton.Name = "consultContractButton";
            this.consultContractButton.Size = new System.Drawing.Size(143, 46);
            this.consultContractButton.TabIndex = 2;
            this.consultContractButton.Text = "   Consultar";
            this.consultContractButton.UseVisualStyleBackColor = true;
            this.consultContractButton.Click += new System.EventHandler(this.consultContractButton_Click);
            // 
            // SmartContractsFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
            this.Controls.Add(this.consultContractButton);
            this.Controls.Add(this.createContractButton);
            this.Controls.Add(this.smartContractGridView);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SmartContractsFormControl";
            this.Size = new System.Drawing.Size(856, 489);
            this.Load += new System.EventHandler(this.SmartContractsFormControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smartContractGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView smartContractGridView;
        private System.Windows.Forms.Button createContractButton;
        private System.Windows.Forms.Button consultContractButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
