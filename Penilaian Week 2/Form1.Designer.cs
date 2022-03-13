
namespace Penilaian_Week_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonProses = new System.Windows.Forms.Button();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.LabelDuplicate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Data:";
            // 
            // ButtonProses
            // 
            this.ButtonProses.Location = new System.Drawing.Point(15, 82);
            this.ButtonProses.Name = "ButtonProses";
            this.ButtonProses.Size = new System.Drawing.Size(94, 29);
            this.ButtonProses.TabIndex = 1;
            this.ButtonProses.Text = "Proses";
            this.ButtonProses.UseVisualStyleBackColor = true;
            this.ButtonProses.Click += new System.EventHandler(this.ButtonProses_Click);
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(15, 32);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(327, 27);
            this.TextBoxInput.TabIndex = 2;
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelOutput.Location = new System.Drawing.Point(12, 130);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(107, 35);
            this.LabelOutput.TabIndex = 3;
            this.LabelOutput.Text = "[EMPTY]";
            // 
            // LabelDuplicate
            // 
            this.LabelDuplicate.AutoSize = true;
            this.LabelDuplicate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDuplicate.Location = new System.Drawing.Point(15, 130);
            this.LabelDuplicate.Name = "LabelDuplicate";
            this.LabelDuplicate.Size = new System.Drawing.Size(107, 35);
            this.LabelDuplicate.TabIndex = 4;
            this.LabelDuplicate.Text = "[EMPTY]";
            this.LabelDuplicate.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 185);
            this.Controls.Add(this.LabelDuplicate);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.ButtonProses);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonProses;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.Label LabelDuplicate;
    }
}

