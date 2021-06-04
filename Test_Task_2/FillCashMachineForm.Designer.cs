
namespace Test_Task_2
{
    partial class FillCashMachineForm
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
            this.Screen = new System.Windows.Forms.TextBox();
            this.Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Screen.Location = new System.Drawing.Point(144, 12);
            this.Screen.Multiline = true;
            this.Screen.Name = "Screen";
            this.Screen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Screen.Size = new System.Drawing.Size(303, 270);
            this.Screen.TabIndex = 0;
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
            // FillCashMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 383);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.Screen);
            this.Name = "FillCashMachineForm";
            this.Text = "Пополнение банкомата";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Screen;
        private System.Windows.Forms.Button Continue;
    }
}