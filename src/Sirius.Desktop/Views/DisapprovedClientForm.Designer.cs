namespace Sirius.Desktop.Views
{
    partial class DisapprovedClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisapprovedClientForm));
            this.label1 = new System.Windows.Forms.Label();
            this.resonDisapprovedRichTextBox = new System.Windows.Forms.RichTextBox();
            this.resonDisapprovedButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.costomerTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descreva o Motivo da Reprovação";
            // 
            // resonDisapprovedRichTextBox
            // 
            this.resonDisapprovedRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resonDisapprovedRichTextBox.Location = new System.Drawing.Point(15, 74);
            this.resonDisapprovedRichTextBox.Name = "resonDisapprovedRichTextBox";
            this.resonDisapprovedRichTextBox.Size = new System.Drawing.Size(726, 202);
            this.resonDisapprovedRichTextBox.TabIndex = 1;
            this.resonDisapprovedRichTextBox.Text = "";
            // 
            // resonDisapprovedButton
            // 
            this.resonDisapprovedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resonDisapprovedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resonDisapprovedButton.Image = ((System.Drawing.Image)(resources.GetObject("resonDisapprovedButton.Image")));
            this.resonDisapprovedButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resonDisapprovedButton.Location = new System.Drawing.Point(594, 287);
            this.resonDisapprovedButton.Name = "resonDisapprovedButton";
            this.resonDisapprovedButton.Size = new System.Drawing.Size(143, 46);
            this.resonDisapprovedButton.TabIndex = 85;
            this.resonDisapprovedButton.Text = "   Confirmar";
            this.resonDisapprovedButton.UseVisualStyleBackColor = true;
            this.resonDisapprovedButton.Click += new System.EventHandler(this.resonDisapprovedButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 86;
            this.label2.Text = "Cliente: ";
            // 
            // costomerTextBox
            // 
            this.costomerTextBox.Enabled = false;
            this.costomerTextBox.Location = new System.Drawing.Point(72, 14);
            this.costomerTextBox.Name = "costomerTextBox";
            this.costomerTextBox.Size = new System.Drawing.Size(284, 26);
            this.costomerTextBox.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(362, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 88;
            this.label3.Text = "label3";
            // 
            // DisapprovedClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(749, 345);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.costomerTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resonDisapprovedButton);
            this.Controls.Add(this.resonDisapprovedRichTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DisapprovedClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motivo da Reprovação";
            this.Load += new System.EventHandler(this.DisapprovedClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox resonDisapprovedRichTextBox;
        private System.Windows.Forms.Button resonDisapprovedButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costomerTextBox;
        private System.Windows.Forms.Label label3;
    }
}