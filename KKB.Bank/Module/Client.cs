using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.Bank.Module
{
    public class Client
    {
        public Client()
        {
            ListAccount = new List<Account>();
        }
        private string FoolName_;

       
        public string FoolName
        {
            get
            {
                return FoolName_;
            }
            set
            {
                if (value.Length == 12)
                {
                    FoolName_ = value;
                }
                else
                {
                    throw new Exception("Incorrect inserted IIN");
                }
            }
        }
        private string IIN_;
        public string IIN
        {
            get
            {
                return IIN_;
            }
            set
            {
                if (value.Length == 12)
                {
                    IIN_ = value;
                }
                else
                {
                    throw new Exception("Incorrect inserted IIN");
                }
            }
        }

        public DateTime DoB { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        List<Account> ListAccount;

       public void ClientOnfoPrint()
        {
            Console.WriteLine("{0}\n {1}\n {2}\n {3]", FoolName, IIN, Login, PhoneNumber);
        }
    }
}
