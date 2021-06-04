
namespace Test_Task_2
{
    partial class PutMoneyForm
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
            this.button7 = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.TextBox();
            this.Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(-546, 706);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Screen
            // 
            this.Screen.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Screen.Location = new System.Drawing.Point(145, 12);
            this.Screen.Multiline = true;
            this.Screen.Name = "Screen";
            this.Screen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Screen.Size = new System.Drawing.Size(303, 270);
            this.Screen.TabIndex = 8;
            this.Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Continue
            // 
            this.Continue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Continue.Location = new System.Drawing.Point(397, 327);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(153, 44);
            this.Continue.TabIndex = 9;
            this.Continue.Text = "Продолжить";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // PutMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 383);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.button7);
            this.Name = "PutMoneyForm";
            this.Text = "Внесение наличных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox Screen;
        private System.Windows.Forms.Button Continue;
    }
}