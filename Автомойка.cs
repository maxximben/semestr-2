using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication21
{
    public delegate void WashDelegate(Car car);


    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();

            CarWash carwash = new CarWash();

            WashDelegate washdelegate = carwash.wash;


            Car car1 = new Car(2020, "Toyota", false);
            Car car2 = new Car(2019, "Honda", false);
            Car car3 = new Car(2017, "Ford", true);


            garage.addCar(car1);
            garage.addCar(car2);
            garage.addCar(car3);


            for (int i = 0; i < garage.cars.Count; i++)
            {
                Console.WriteLine("До мытья:");
                garage.showCar(garage.cars[i]);

                washdelegate(garage.cars[i]);

                Console.WriteLine("После мытья: ");
                garage.showCar(garage.cars[i]);
            }
        }
    }


    public class Car
    {
        public string Model;
        public int Year;
        public bool IsClean;

        public Car(int year, string model, bool isClean)
        {
            Year = year;
            Model = model;
            IsClean = isClean;
        }
    }

    public class Garage
    {
        public List<Car> cars;

        public Garage()
        {
            cars = new List<Car>();
        }

        public void addCar(Car car)
        {
            cars.Add(car);
        }

        public void showCar(Car car)
        {
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Year);
            Console.WriteLine(car.IsClean);
            Console.WriteLine();
        }
    }

    public class CarWash
    {
        public void wash(Car car)
        {
            car.IsClean = true;
        }
    }
}
