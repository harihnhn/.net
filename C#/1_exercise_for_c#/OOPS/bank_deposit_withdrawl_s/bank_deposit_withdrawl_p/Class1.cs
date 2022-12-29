using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bank_deposit_withdrawl_p
{
    class bank
    {
        public string name;
        public int balance, id;
        public void show_balance()
        {
            MessageBox.Show(balance.ToString());
        }
    }

    class deposit : bank
    {
        public int dep(int amt)
        {
            return balance += amt;
        }
    }

    class withdrawl : bank
    {
        public int with(int amt)
        {
            return balance -= amt;
        }
    }
}
