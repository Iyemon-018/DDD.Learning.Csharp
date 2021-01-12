
namespace DDD.WinForm.Views
{
    partial class LatestView
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
            this.SuspendLayout();
            // 
            // MeasureValueLabel
            // 
            this.MeasureValueLabel.AutoSize = true;
            this.MeasureValueLabel.Font = new System.Drawing.Font("Yu Gothic UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MeasureValueLabel.Location = new System.Drawing.Point(0, 0);
            this.MeasureValueLabel.Name = "MeasureValueLabel";
            this.MeasureValueLabel.Size = new System.Drawing.Size(194, 81);
            this.MeasureValueLabel.TabIndex = 0;
            this.MeasureValueLabel.Text = "label1";
            // 
            // LatestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MeasureValueLabel);
            this.Name = "LatestView";
            this.Text = "LatestView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MeasureValueLabel;
    }
}