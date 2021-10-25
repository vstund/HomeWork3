using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone = new Phone();
            phone.phoneBrand = "Samsung";
            phone.phoneModel = "Galaxy S21 Ultra";
            phone.phoneHeight = 10.20;
            phone.phoneWidth = 5.20;

            var car = new Car();
            car.brand = "Volvo XC60";
            car.numberPlate = "KB1234";
           
            Console.WriteLine($"Man ir {phone.phoneBrand} ražotais telefons {phone.phoneModel}. Tā augstums ir {phone.phoneHeight} cm un platums {phone.phoneWidth} cm.");
            Console.WriteLine($"Auto {car.brand} ar numura zīmi {car.numberPlate} prot uztaurēt: {car.carBeep()}");
        }
    }
}

