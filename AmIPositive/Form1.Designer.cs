
namespace AmIPositive
{
    partial class Form1
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
            this.integerLabel = new System.Windows.Forms.Label();
            this.integerInput = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.posNegOutput = new System.Windows.Forms.Label();
            this.divideOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // integerLabel
            // 
            this.integerLabel.AutoSize = true;
            this.integerLabel.Location = new System.Drawing.Point(136, 74);
            this.integerLabel.Name = "integerLabel";
            this.integerLabel.Size = new System.Drawing.Size(212, 32);
            this.integerLabel.TabIndex = 0;
            this.integerLabel.Text = "Input an integer";
            // 
            // integerInput
            // 
            this.integerInput.Location = new System.Drawing.Point(449, 74);
            this.integerInput.Name = "integerInput";
            this.integerInput.Size = new System.Drawing.Size(100, 38);
            this.integerInput.TabIndex = 1;
            // 
            // enterButton
            // 
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.enterButton.Location = new System.Drawing.Point(449, 155);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(100, 61);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // posNegOutput
            // 
            this.posNegOutput.Location = new System.Drawing.Point(136, 250);
            this.posNegOutput.Name = "posNegOutput";
            this.posNegOutput.Size = new System.Drawing.Size(517, 33);
            this.posNegOutput.TabIndex = 3;
            // 
            // divideOutput
            // 
            this.divideOutput.Location = new System.Drawing.Point(136, 308);
            this.divideOutput.Name = "divideOutput";
            this.divideOutput.Size = new System.Drawing.Size(517, 33);
            this.divideOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.divideOutput);
            this.Controls.Add(this.posNegOutput);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.integerInput);
            this.Controls.Add(this.integerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label integerLabel;
        private System.Windows.Forms.TextBox integerInput;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label posNegOutput;
        private System.Windows.Forms.Label divideOutput;
    }
}

