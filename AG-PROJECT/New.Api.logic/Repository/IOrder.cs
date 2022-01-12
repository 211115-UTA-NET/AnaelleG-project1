using Farmer.Api;


namespace Farmer.Api.Repository
    
{
    public interface IOrder



    //public string Location { get; set; }
    //public string ProductName { get; set; }
    //public int QtyofProduct { get; set; }
    //public string Date { get; set; }


    {
        List<Task<int>>GetAllOrderAmount(int QtyofProduct, int DateTime);
      

    }
}
