namespace StockMarket
{
    public class Stock
    {
        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        private string directorar;


        public string Directorar
        {
            get { return directorar; }
            set { directorar = value; }
        }
        private decimal pricePerShare;

        public decimal PricePerShare
        {
            get { return pricePerShare; }
            set { pricePerShare = value; }
        }
        private int totalNumberOfShares;

        public int TotalNumberOfShares
        {
            get { return totalNumberOfShares; }
            set { totalNumberOfShares = value; }
        }
        private decimal marketCapitalization;

        public decimal MarketCapitalization
        {
            get { return marketCapitalization; }
            set { marketCapitalization = value; }
        }

        public Stock(string companyName, string directorar, decimal pricePerShare, int totalNumberOfShares)
        {
            this.CompanyName = companyName;
            this.Directorar = directorar;
            this.PricePerShare = pricePerShare;
            this.TotalNumberOfShares = totalNumberOfShares;
            this.MarketCapitalization = this.PricePerShare * this.TotalNumberOfShares;
        }

        public override string ToString()
        {
            return $"Company: {this.CompanyName}\n" +
                $"Director: {this.Directorar}\n" +
                $"Price per share: ${this.PricePerShare}\n" +
                $"Market capitalization: ${this.MarketCapitalization}";
        }
    }
}
