using System;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerInformation customerInformation1 = new CustomerInformation();
            customerInformation1.Id = "2545";
            customerInformation1.Name = "Esra";
            customerInformation1.SurName = "Bulut";
            customerInformation1.Age = 26;

            Console.WriteLine(customerInformation1.Id+" "+customerInformation1.Name+" "+customerInformation1.SurName+" "+customerInformation1.Age);

            CustomerManager customerManager = new CustomerManager();
            customerManager.Uploaded(customerInformation1);
            customerManager.Add(customerInformation1);
            customerManager.Completed(customerInformation1);
        }
    }
}
