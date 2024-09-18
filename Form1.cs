using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountsApp
{
    public partial class frmAccounts : Form
    {
        private List<Account> accounts = new List<Account>();
        private Account searchAccount;
        public frmAccounts()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try 
            {
                Account newAccount;
                if (rbtnChecking.Checked)
                {
                    newAccount = new CheckingAccount(Convert.ToInt32(txtAccount.Text),
                        txtClient.Text,
                        Convert.ToDouble(txtBalance.Text),
                        Convert.ToDouble(txtWithdraw.Text));
                }
                else
                {
                    newAccount = new SavingsAccount(Convert.ToInt32(txtAccount.Text),
                        txtClient.Text,
                        Convert.ToDouble(txtBalance.Text),
                        Convert.ToDouble(txtInterest.Text));
                }

                accounts.Add(newAccount);
                ClearFields();

                MessageBox.Show($"The Total Number of Accounts is: {accounts.Count}");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void rbtnChecking_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnChecking.Checked) //this covers both cases as one being checked means the other is unchecked
            {
                txtWithdraw.Enabled = true;
                txtInterest.Enabled = false;
            } 
            else
            {
                txtWithdraw.Enabled = false;
                txtInterest.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearFields();
            searchAccount = null;

            foreach (Account account in accounts)
            {
                if (account.Number == Convert.ToInt32(txtSearch.Text))
                {
                    searchAccount = account;
                }
            }

            try 
            {
                txtAccount.Text = searchAccount.Number.ToString();
                txtClient.Text = searchAccount.Name;
                txtBalance.Text = searchAccount.Balance.ToString();

                if (searchAccount.GetType() == typeof(CheckingAccount))
                {
                    txtWithdraw.Text = ((CheckingAccount)searchAccount).Limit.ToString();

                    rbtnChecking.Checked = true;
                }
                else if (searchAccount.GetType() == typeof(SavingsAccount))
                {
                    txtInterest.Text = ((SavingsAccount)searchAccount).Interest.ToString();

                    rbtnSavings.Checked = true;
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Account Not Found");
            }

            
            
        }

        private void ClearFields()
        {
            txtAccount.Text = "";
            txtClient.Text = "";
            txtBalance.Text = "";
            txtWithdraw.Text = "";
            txtInterest.Text = "";
        }
    }
}
