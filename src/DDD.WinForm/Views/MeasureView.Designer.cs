
namespace DDD.WinForm.Views
{
    partial class MeasureView
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
            this.MeasureValueLabel = new System.Windows.Forms.Label();
            this.MeasureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MeasureValueLabel
            // 
            this.MeasureValueLabel.AutoSize = true;
            this.MeasureValueLabel.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MeasureValueLabel.Location = new System.Drawing.Point(12, 9);
            this.MeasureValueLabel.Name = "MeasureValueLabel";
            this.MeasureValueLabel.Size = new System.Drawing.Size(262, 81);
            this.MeasureValueLabel.TabIndex = 0;
            this.MeasureValueLabel.Text = "Measure";
            // 
            // MeasureButton
            // 
            this.MeasureButton.Location = new System.Drawing.Point(12, 409);
            this.MeasureButton.Name = "MeasureButton";
            this.MeasureButton.Size = new System.Drawing.Size(94, 29);
            this.MeasureButton.TabIndex = 1;
            this.MeasureButton.Text = "Measure";
            this.MeasureButton.UseVisualStyleBackColor = true;
            // 
            // MeasureView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MeasureButton);
            this.Controls.Add(this.MeasureValueLabel);
            this.Name = "MeasureView";
            this.Text = "MeasureView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MeasureValueLabel;
        private System.Windows.Forms.Button MeasureButton;
    }
}