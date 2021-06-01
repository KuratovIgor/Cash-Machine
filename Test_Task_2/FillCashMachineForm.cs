using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test_Task_2
{
    public partial class FillCashMachineForm : Form
    {
        private List<int> _balance = new List<int>(0); //List with money and quntity of money in cash machine

        public FillCashMachineForm()
        {
            InitializeComponent();
            Screen.Text = "Пополнение банкомата\r\n";
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

        private void PutMoney10_Click(object sender, EventArgs e)
        {
            PutMoney(10); //Putting 10 ruble
        }

        private void PutMoney50_Click(object sender, EventArgs e)
        {
            PutMoney(50); //Putting 50 ruble
        }

        private void PutMoney100_Click(object sender, EventArgs e)
        {
            PutMoney(100); //Putting 100 ruble
        }

        private void PutMoney200_Click(object sender, EventArgs e)
        {
            PutMoney(200); //Putting 200 ruble
        }

        private void PutMoney500_Click(object sender, EventArgs e)
        {
            PutMoney(500); //Putting 500 ruble
        }

        private void PutMoney1000_Click(object sender, EventArgs e)
        {
            PutMoney(1000); //Putting 1000 ruble
        }

        private void PutMoney2000_Click(object sender, EventArgs e)
        {
            PutMoney(2000); //Putting 2000 ruble
        }

        private void PutMoney5000_Click(object sender, EventArgs e)
        {
            PutMoney(5000); //Putting 5000 ruble
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
