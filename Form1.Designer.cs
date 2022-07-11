
namespace LabelTextBoxButtonTest
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
            this.displayPasswordButton = new System.Windows.Forms.Button();
            this.displayPasswordLabel = new System.Windows.Forms.Label();
            this.inputPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayPasswordButton
            // 
            this.displayPasswordButton.Location = new System.Drawing.Point(347, 259);
            this.displayPasswordButton.Name = "displayPasswordButton";
            this.displayPasswordButton.Size = new System.Drawing.Size(97, 23);
            this.displayPasswordButton.TabIndex = 0;
            this.displayPasswordButton.Text = "Show Me";
            this.displayPasswordButton.UseVisualStyleBackColor = true;
            this.displayPasswordButton.Click += new System.EventHandler(this.displayPasswordButton_Click);
            // 
            // displayPasswordLabel
            // 
            this.displayPasswordLabel.AutoSize = true;
            this.displayPasswordLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.displayPasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.displayPasswordLabel.Location = new System.Drawing.Point(347, 200);
            this.displayPasswordLabel.MaximumSize = new System.Drawing.Size(97, 23);
            this.displayPasswordLabel.MinimumSize = new System.Drawing.Size(97, 23);
            this.displayPasswordLabel.Name = "displayPasswordLabel";
            this.displayPasswordLabel.Size = new System.Drawing.Size(97, 23);
            this.displayPasswordLabel.TabIndex = 1;
            this.displayPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputPasswordTextBox
            // 
            this.inputPasswordTextBox.Location = new System.Drawing.Point(347, 143);
            this.inputPasswordTextBox.Name = "inputPasswordTextBox";
            this.inputPasswordTextBox.Size = new System.Drawing.Size(100, 23);
            this.inputPasswordTextBox.TabIndex = 2;
            this.inputPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputPasswordTextBox);
            this.Controls.Add(this.displayPasswordLabel);
            this.Controls.Add(this.displayPasswordButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button displayPasswordButton;
        private System.Windows.Forms.Label displayPasswordLabel;
        private System.Windows.Forms.TextBox inputPasswordTextBox;
    }
}

