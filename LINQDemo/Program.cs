using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    internal class Program
    {
        static void Code1()
        {
            Action<string> greet = name => Console.WriteLine("Hello " + name);

            greet("Sambit");


            Action<int, int, int> Calculate = (prin, rate, yrs) =>
            {
                double interest = (prin * rate * yrs) / 100;
                Console.WriteLine(interest);


            };

            Calculate(1000, 10, 10);

            Func<int, int, int, decimal> CalculateInterest = (prin, rate, yrs) =>
            {
                decimal interestValue = (prin * rate * yrs) / 100;

                return interestValue;

            };

            decimal interestVal = CalculateInterest(1000, 10, 10);
            Console.WriteLine(interestVal);


            Predicate<int> CheckEvenOrOdd = no => {
                if (no % 2 == 0) return true;
                else return false;

            };

            bool ans = CheckEvenOrOdd(101);
            if (ans)
            {
                Console.WriteLine("ITs even");
            }
            else
            {
                Console.WriteLine("ITs Odd");
            }



        }


        static void Main(string[] args)
        {



            List<CustomerDetails> details = new List<CustomerDetails>();
            details.Add(new CustomerDetails {Custid=1,CustName="Akshay",City="Mumbai" });
            details.Add(new CustomerDetails { Custid = 2, CustName = "Jivan", City = "Mumbai" }); 
            details.Add(new CustomerDetails { Custid = 3, CustName = "Amruta", City = "Pune" });
            details.Add(new CustomerDetails { Custid = 4, CustName = "Ashu", City = "Bangalore" });

            //find all the customer who are from Mumbai
            List<CustomerDetails> allCustomersInMumbai=details.FindAll(c => c.City == "Mumbai");

            //Print all details of customer
            allCustomersInMumbai.ForEach(c1 => 
            {
                Console.WriteLine(c1.Custid); 
                Console.WriteLine(c1.CustName); 
                Console.WriteLine(c1.City); 
            });
            Console.WriteLine("--------------------Select uses Func-----------------");

            //Find the customer whose name is Ashu
            IEnumerable<bool> mycustDet = details.Select(cdet => cdet.CustName == "Ashu");
            foreach (var item in mycustDet)
            {
                Console.WriteLine(item);  
            }

            Console.WriteLine("Using First or default");
            var data = details.Select(cdet => cdet.CustName == "Ashu").LastOrDefault();
            Console.WriteLine(data);






            //Print only custid
            //allCustomersInMumbai.ForEach(c1 =>

            //    Console.WriteLine(c1.Custid)
            //   );






            //    List<CustomerDetails> Custdetails = new List<CustomerDetails>() {
            //    new CustomerDetails { Custid = 1, CustName = "Akshay", City = "Mumbai" },
            //new CustomerDetails { Custid = 2, CustName = "Jivan", City = "Mumbai" },
            //   new CustomerDetails { Custid = 3, CustName = "Amruta", City = "Pune" },
            //   new CustomerDetails { Custid = 4, CustName = "Ashu", City = "Bangalore" }
            //        };




            //Code1();
            //Announcement();

            //void Announcement()//local function
            //{
            //    Console.WriteLine("Today unext asessemtn at 5.30pm");
            //}

            Console.ReadLine();




        }
    }
}
