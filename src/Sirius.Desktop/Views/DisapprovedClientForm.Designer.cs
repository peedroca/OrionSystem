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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
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
            this.resonDisapprovedRichTextBox.Location = new System.Drawing.Point(15, 30);
            this.resonDisapprovedRichTextBox.Name = "resonDisapprovedRichTextBox";
            this.resonDisapprovedRichTextBox.Size = new System.Drawing.Size(726, 197);
            this.resonDisapprovedRichTextBox.TabIndex = 1;
            this.resonDisapprovedRichTextBox.Text = "";
            // 
            // resonDisapprovedButton
            // 
            this.resonDisapprovedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resonDisapprovedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resonDisapprovedButton.Image = ((System.Drawing.Image)(resources.GetObject("resonDisapprovedButton.Image")));
            this.resonDisapprovedButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resonDisapprovedButton.Location = new System.Drawing.Point(594, 238);
            this.resonDisapprovedButton.Name = "resonDisapprovedButton";
            this.resonDisapprovedButton.Size = new System.Drawing.Size(143, 46);
            this.resonDisapprovedButton.TabIndex = 85;
            this.resonDisapprovedButton.Text = "   Confirmar";
            this.resonDisapprovedButton.UseVisualStyleBackColor = true;
            // 
            // DisapprovedClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
            this.ClientSize = new System.Drawing.Size(749, 296);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox resonDisapprovedRichTextBox;
        private System.Windows.Forms.Button resonDisapprovedButton;
    }
}