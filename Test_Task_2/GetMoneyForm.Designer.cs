
namespace Test_Task_2
{
    partial class GetMoneyForm
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
            this.Request = new System.Windows.Forms.Label();
            this.SumMoney = new System.Windows.Forms.TextBox();
            this.DifferentSumma = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Request
            // 
            this.Request.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Request.Location = new System.Drawing.Point(22, 25);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(718, 40);
            this.Request.TabIndex = 20;
            this.Request.Text = "Выберите сумму";
            this.Request.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SumMoney
            // 
            this.SumMoney.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SumMoney.Location = new System.Drawing.Point(22, 68);
            this.SumMoney.Multiline = true;
            this.SumMoney.Name = "SumMoney";
            this.SumMoney.Size = new System.Drawing.Size(718, 151);
            this.SumMoney.TabIndex = 21;
            this.SumMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SumMoney.Visible = false;
            // 
            // DifferentSumma
            // 
            this.DifferentSumma.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DifferentSumma.Location = new System.Drawing.Point(12, 252);
            this.DifferentSumma.Name = "DifferentSumma";
            this.DifferentSumma.Size = new System.Drawing.Size(183, 52);
            this.DifferentSumma.TabIndex = 1;
            this.DifferentSumma.Text = "Своя сумма";
            this.DifferentSumma.UseVisualStyleBackColor = true;
            this.DifferentSumma.Click += new System.EventHandler(this.DifferentSumma_Click);
            // 
            // Next
            // 
            this.Next.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Next.Location = new System.Drawing.Point(574, 252);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(183, 52);
            this.Next.TabIndex = 2;
            this.Next.Text = "Далее";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Visible = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // GetMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 327);
            this.Controls.Add(this.SumMoney);
            this.Controls.Add(this.Request);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.DifferentSumma);
            this.Name = "GetMoneyForm";
            this.Text = "Снятие наличных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Request;
        private System.Windows.Forms.TextBox SumMoney;
        private System.Windows.Forms.Button DifferentSumma;
        private System.Windows.Forms.Button Next;
    }
}