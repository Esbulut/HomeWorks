using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3
{
    class CustomerManager
    {
        public void Add(CustomerInformation customerInformation) 
        {
            Console.WriteLine(customerInformation.Id+" "+"Eklendi.");
        
        }
        public void Uploaded(CustomerInformation customerInformation)
        {
            Console.WriteLine(customerInformation.Name + customerInformation.SurName + " " + "Yüklendi.");
        }
        public void Completed(CustomerInformation customerInformation)
        {
            Console.WriteLine(customerInformation.Age + " " + "Tamamlandı.");
        }
            

    }
}
