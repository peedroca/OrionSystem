namespace Sirius.Desktop.Views
{
    partial class SmartContractForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartContractForm));
            this.backSContractsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backSContractsButton
            // 
            this.backSContractsButton.Location = new System.Drawing.Point(12, 12);
            this.backSContractsButton.Name = "backSContractsButton";
            this.backSContractsButton.Size = new System.Drawing.Size(117, 55);
            this.backSContractsButton.TabIndex = 0;
            this.backSContractsButton.Text = "Voltar";
            this.backSContractsButton.UseVisualStyleBackColor = true;
            this.backSContractsButton.Click += new System.EventHandler(this.backSContractsButton_Click);
            // 
            // SmartContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 505);
            this.Controls.Add(this.backSContractsButton);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SmartContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contratos Inteligentes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backSContractsButton;
    }
}