namespace Farmer.Api
{
    public class Product
    {

        // might need it for later
       // int productID { get; }
        string ProductName { get; set; }

        //  public string PriceAmount { get; }


        //string price (might include but unsure)
        public Product(string productname )
        {
            ProductName = productname;
            // PriceAmount= price;
           // PriceAmount = price.ToString();
        }
    }
}
