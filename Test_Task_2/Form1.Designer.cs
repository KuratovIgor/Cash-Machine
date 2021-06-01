
namespace Test_Task_2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.OK = new System.Windows.Forms.Button();

            this.Continue = new System.Windows.Forms.Button();
            this.Request = new System.Windows.Forms.Label();
            this.PasteCard = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.TextBox();
            this.GetMoney = new System.Windows.Forms.Button();
            this.ShowStatus = new System.Windows.Forms.Button();
            this.PutMoney = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.FillCashMachine = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            this.MainPanel.Controls.Add(this.OK);
            this.MainPanel.Controls.Add(this.Continue);
            this.MainPanel.Controls.Add(this.Request);
            this.MainPanel.Controls.Add(this.PasteCard);
            this.MainPanel.Controls.Add(this.Screen);
            this.MainPanel.Location = new System.Drawing.Point(12, 85);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(776, 326);
            this.MainPanel.TabIndex = 0;
            this.OK.Location = new System.Drawing.Point(18, 232);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(81, 50);
            this.OK.TabIndex = 15;
            this.OK.Text = "Ok";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Visible = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);

            this.Continue.Location = new System.Drawing.Point(561, 232);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(200, 50);
            this.Continue.TabIndex = 14;
            this.Continue.Text = "Продолжить";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // Request
            // 
            this.Request.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Request.Location = new System.Drawing.Point(18, 15);
            this.Request.Name = "Request";
            this.Request.Size = new System.Drawing.Size(743, 38);
            this.Request.TabIndex = 9;
            this.Request.Text = "Вставьте карточку";
            this.Request.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasteCard
            // 
            this.PasteCard.Location = new System.Drawing.Point(632, 288);
            this.PasteCard.Name = "PasteCard";
            this.PasteCard.Size = new System.Drawing.Size(144, 35);
            this.PasteCard.TabIndex = 1;
            this.PasteCard.Text = "Вставить карточку";
            this.PasteCard.UseVisualStyleBackColor = true;
            this.PasteCard.Click += new System.EventHandler(this.PasteCard_Click);
            // 
            // Screen
            // 
            this.Screen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Screen.Location = new System.Drawing.Point(18, 56);
            this.Screen.Multiline = true;
            this.Screen.Name = "Screen";
            this.Screen.ReadOnly = true;
            this.Screen.Size = new System.Drawing.Size(743, 151);
            this.Screen.TabIndex = 0;
            this.Screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GetMoney
            // 
            this.GetMoney.Location = new System.Drawing.Point(12, 434);
            this.GetMoney.Name = "GetMoney";
            this.GetMoney.Size = new System.Drawing.Size(200, 50);
            this.GetMoney.TabIndex = 1;
            this.GetMoney.Text = "Снять наличные";
            this.GetMoney.UseVisualStyleBackColor = true;
            this.GetMoney.Visible = false;
            this.GetMoney.Click += new System.EventHandler(this.GetMoney_Click);
            // 
            // ShowStatus
            // 
            this.ShowStatus.Location = new System.Drawing.Point(297, 434);
            this.ShowStatus.Name = "ShowStatus";
            this.ShowStatus.Size = new System.Drawing.Size(200, 50);
            this.ShowStatus.TabIndex = 2;
            this.ShowStatus.Text = "Статус";
            this.ShowStatus.UseVisualStyleBackColor = true;
            this.ShowStatus.Visible = false;
            this.ShowStatus.Click += new System.EventHandler(this.ShowStatus_Click);
            // 
            // PutMoney
            // 
            this.PutMoney.Location = new System.Drawing.Point(588, 434);
            this.PutMoney.Name = "PutMoney";
            this.PutMoney.Size = new System.Drawing.Size(200, 50);
            this.PutMoney.TabIndex = 3;
            this.PutMoney.Text = "Внести наличные";
            this.PutMoney.UseVisualStyleBackColor = true;
            this.PutMoney.Visible = false;
            this.PutMoney.Click += new System.EventHandler(this.PutMoney_Click);
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(625, 12);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(163, 35);
            this.Finish.TabIndex = 4;
            this.Finish.Text = "Закончить работу";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // FillCashMachine
            // 
            this.FillCashMachine.Location = new System.Drawing.Point(12, 12);
            this.FillCashMachine.Name = "FillCashMachine";
            this.FillCashMachine.Size = new System.Drawing.Size(163, 35);
            this.FillCashMachine.TabIndex = 5;
            this.FillCashMachine.Text = "Пополнить банкомат";
            this.FillCashMachine.UseVisualStyleBackColor = true;
            this.FillCashMachine.Click += new System.EventHandler(this.FillCashMachine_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.FillCashMachine);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.PutMoney);
            this.Controls.Add(this.ShowStatus);
            this.Controls.Add(this.GetMoney);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "Банкомат";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button GetMoney;
        private System.Windows.Forms.Button ShowStatus;
        private System.Windows.Forms.Button PutMoney;
        private System.Windows.Forms.Button PasteCard;
        private System.Windows.Forms.Label Request;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Button FillCashMachine;
        public System.Windows.Forms.TextBox Screen;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button OK;
    }
}

