namespace Sirius.Desktop.Views
{
    partial class ClientFormControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientFormControl));
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterButton = new System.Windows.Forms.Button();
            this.idCustomerTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fristNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.analyzesButton = new System.Windows.Forms.Button();
            this.ConsultCostomerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AllowUserToAddRows = false;
            this.clientDataGridView.AllowUserToDeleteRows = false;
            this.clientDataGridView.AllowUserToResizeColumns = false;
            this.clientDataGridView.AllowUserToResizeRows = false;
            this.clientDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.clientDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.clientDataGridView.Location = new System.Drawing.Point(12, 75);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.RowHeadersVisible = false;
            this.clientDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clientDataGridView.RowTemplate.Height = 28;
            this.clientDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientDataGridView.Size = new System.Drawing.Size(829, 318);
            this.clientDataGridView.TabIndex = 60;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "FristName";
            this.Column1.HeaderText = "Nome";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "LastName";
            this.Column2.HeaderText = "Sobrenome";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CPF";
            this.Column3.HeaderText = "CPF";
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
            // filterButton
            // 
            this.filterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterButton.Image = ((System.Drawing.Image)(resources.GetObject("filterButton.Image")));
            this.filterButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filterButton.Location = new System.Drawing.Point(696, 22);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(143, 48);
            this.filterButton.TabIndex = 73;
            this.filterButton.Text = "Filtrar";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // idCustomerTextBox
            // 
            this.idCustomerTextBox.Location = new System.Drawing.Point(313, 34);
            this.idCustomerTextBox.Name = "idCustomerTextBox";
            this.idCustomerTextBox.Size = new System.Drawing.Size(73, 26);
            this.idCustomerTextBox.TabIndex = 72;
            this.idCustomerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(310, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 71;
            this.label1.Text = "ID Cliente";
            // 
            // fristNameTextBox
            // 
            this.fristNameTextBox.Location = new System.Drawing.Point(20, 34);
            this.fristNameTextBox.Name = "fristNameTextBox";
            this.fristNameTextBox.Size = new System.Drawing.Size(287, 26);
            this.fristNameTextBox.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 69;
            this.label2.Text = "Nome";
            // 
            // analyzesButton
            // 
            this.analyzesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.analyzesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.analyzesButton.Image = ((System.Drawing.Image)(resources.GetObject("analyzesButton.Image")));
            this.analyzesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.analyzesButton.Location = new System.Drawing.Point(696, 415);
            this.analyzesButton.Name = "analyzesButton";
            this.analyzesButton.Size = new System.Drawing.Size(143, 46);
            this.analyzesButton.TabIndex = 74;
            this.analyzesButton.Text = "Analisar";
            this.analyzesButton.UseVisualStyleBackColor = true;
            this.analyzesButton.Click += new System.EventHandler(this.analyzesButton_Click);
            // 
            // ConsultCostomerButton
            // 
            this.ConsultCostomerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultCostomerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConsultCostomerButton.Image = ((System.Drawing.Image)(resources.GetObject("ConsultCostomerButton.Image")));
            this.ConsultCostomerButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultCostomerButton.Location = new System.Drawing.Point(547, 415);
            this.ConsultCostomerButton.Name = "ConsultCostomerButton";
            this.ConsultCostomerButton.Size = new System.Drawing.Size(143, 46);
            this.ConsultCostomerButton.TabIndex = 75;
            this.ConsultCostomerButton.Text = "Consultar";
            this.ConsultCostomerButton.UseVisualStyleBackColor = true;
            this.ConsultCostomerButton.Click += new System.EventHandler(this.ConsultCostomerButton_Click);
            // 
            // ClientFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
            this.Controls.Add(this.ConsultCostomerButton);
            this.Controls.Add(this.analyzesButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.idCustomerTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fristNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clientDataGridView);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientFormControl";
            this.Size = new System.Drawing.Size(856, 489);
            this.Load += new System.EventHandler(this.ClientFormControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.MaskedTextBox idCustomerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fristNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button analyzesButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button ConsultCostomerButton;
    }
}
