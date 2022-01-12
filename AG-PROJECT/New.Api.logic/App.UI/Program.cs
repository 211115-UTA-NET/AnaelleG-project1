using Farmer.Api.Dtos;


namespace Farmer.Api.App.UI
{


    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("**************************************************************");
            Console.WriteLine("************* Welcome to Anna Farmer's Market ****************");
            Console.WriteLine("**************************************************************");












            Console.Write("Please identify the Store Location. \r\n" +
          " [1] for Azalea Park Default Store \r\n" +
          " [2] for Winter Park \r\n" +
          " [3] for Altamonte Springs  \r\n");

            Console.Write("Press an option between 1 to 3: ");
            string? store = Console.ReadLine();

            if (store == "1")
            {
                Console.WriteLine("Azalea Park : 100 Kasey Drive,Orlando,FL 32807 ");
            }
                
            else if (store == "2")
                
            {
                Console.WriteLine("Winter Park : 234 N. Park Avenue ,Winter Park,FL 32789 ");
            }
            else if (store == "3")
            {
                Console.WriteLine("Altamonte Springs :8579 E. Altamonte Drive ,Altamonte Springs,FL 32801 ");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

          
           }

        }

    }

