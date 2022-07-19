using System.Collections.Generic;

namespace StockMarket
{
    public class Investor
    {
        List<Stock> Portfolio;
        public int Count 
        {
            get { return Portfolio.Count; }  
        }


        private string emailAddress;

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        private decimal moneyToInvest;

        public decimal MoneyToInvest
        {
            get { return moneyToInvest; }
            set { moneyToInvest = value; }
        }

        private string brokerName;

        public string BrokerName
        {
            get { return brokerName; }
            set { brokerName = value; }
        }

        public Investor(string emailAddress, string fullName, decimal moneyToInvest, string brokerName)
        {
            EmailAddress = emailAddress;
            FullName = fullName;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            Portfolio = new List<Stock>();
        }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && )
            {
                Portfolio.Add(stock);
            }

        }
    }
}
