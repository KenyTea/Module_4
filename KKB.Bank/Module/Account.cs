using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.Bank.Module
{
    class Account
    {
        public Account()
        {
            ListCard = new List<Card>();
            //Balans = 0;
        }
        public DateTime CteateDay { get; set; }
        public DateTime CliseDay { get; set; }
        public string AccountNumber { get; set; }
        public double Balans { get; set; } = 0;

        public List<Card> ListCard;

        public void PrintCardInfo()
        {
            foreach (Card item in ListCard)
            {
                string info = string.Format("{0}\t ({1}) - {2}", item.GetCardNumber(), item.Cardtype, item.ExpDate);

                Console.WriteLine(info);
              
            }
        }
    }
}
