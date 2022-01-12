namespace Farmer.Api
{


    public class Order


    {
        /// <summary>
        /// all In the order table sql
        /// </summary>


        //store location =loacation
        public string Location { get; set; }
        public string ProductName { get; set; }
        public int QtyofProduct { get; set; }
        public string Date { get; set; }

        public Order(string location, string productName, int qtyofProduct, string date)
        {

            Location = location;
            ProductName = productName;
            QtyofProduct = qtyofProduct;
            Date = date;

        }
    }
}