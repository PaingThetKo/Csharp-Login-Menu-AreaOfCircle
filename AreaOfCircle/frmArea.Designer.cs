namespace AreaOfCircle
{
    partial class frmArea
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
            lblRadius = new Label();
            lalArea = new Label();
            txtRadius = new TextBox();
            txtArea = new TextBox();
            btnCalculator = new Button();
            SuspendLayout();
            // 
            // lblRadius
            // 
            lblRadius.AutoSize = true;
            lblRadius.Location = new Point(12, 34);
            lblRadius.Name = "lblRadius";
            lblRadius.Size = new Size(93, 20);
            lblRadius.TabIndex = 0;
            lblRadius.Text = "Radius (mm)";
            // 
            // lalArea
            // 
            lalArea.AutoSize = true;
            lalArea.Location = new Point(12, 89);
            lalArea.Name = "lalArea";
            lalArea.Size = new Size(99, 20);
            lalArea.TabIndex = 1;
            lalArea.Text = "Area (sq mm)";
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(153, 31);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(186, 27);
            txtRadius.TabIndex = 2;
            txtRadius.KeyDown += txtRadius_KeyDown;
            // 
            // txtArea
            // 
            txtArea.Enabled = false;
            txtArea.Location = new Point(153, 86);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(186, 27);
            txtArea.TabIndex = 3;
            // 
            // btnCalculator
            // 
            btnCalculator.Location = new Point(153, 142);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(186, 29);
            btnCalculator.TabIndex = 4;
            btnCalculator.Text = "Calculate Area";
            btnCalculator.UseVisualStyleBackColor = true;
            btnCalculator.Click += btnCalculator_Click;
            // 
            // frmArea
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 231);
            Controls.Add(btnCalculator);
            Controls.Add(txtArea);
            Controls.Add(txtRadius);
            Controls.Add(lalArea);
            Controls.Add(lblRadius);
            Name = "frmArea";
            Text = "Calculator: Area of Circle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRadius;
        private Label lalArea;
        private TextBox txtRadius;
        private TextBox txtArea;
        private Button btnCalculator;
    }
}
