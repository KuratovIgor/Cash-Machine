using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CashMachine_Lib;

namespace Test_Task_2
{
    public partial class FillCashMachineForm : Form
    {
        private List<int> _balance = new List<int>(0); //List with money and quntity of money in cash machine
        private CashMachine bankomat;

        public FillCashMachineForm(CashMachine machine)
        {
            InitializeComponent();
            bankomat = machine;
            Screen.Text = "Пополнение банкомата\r\n";
            CreateButtons();
        }

        private void CreateButtons()
        {
            int top = 12;
            int left = 12;

            foreach (int key in bankomat.banknotes.Keys)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                button.Width = 80;
                button.Height = 40;
                button.Text = Convert.ToString(key);
                button.BringToFront();
                button.Name = "PutMoney" + key;
                button.Click += Nominal_Click;
                button.Font = new Font(Font.FontFamily, 15);
                this.Controls.Add(button);

                top += button.Height + 5;
            }
        }

        private void Nominal_Click(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;
            PutMoney(Convert.ToInt32(button.Text));
        }

        private void PutMoney(int nominal) //Putting money in cash machine
        {
            _balance.Add(nominal);  //Add money in list of money 
            Screen.Text += $"{nominal}\r\n";
        }

        public List<int> GetBalance() //Getting list with money
        {
            return _balance;
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
