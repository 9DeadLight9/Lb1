using System;
namespace Laba_1
{
    
    class Adress //Task 1
    {
         private string index;
         private string country;
         private string city;
         private string street;
         private string house;
         private string apartment;

         public string Index
         {
             get { return index; }
             set { index = value; }
         }
         public string Country 
         {
             get { return country; }
             set { country = value; }
         }
         public string City
         {
             get { return city; }
             set { city = value; }
         }
         public string Street
         {
             get { return street; }
             set { street = value; }
         } 
         public string House 
         {
             get { return house ; }
             set { house  = value; }
         }  
         public string Apartment
         {
             get { return apartment; }
             set { apartment = value; }
         }
         
    }

    class Converter//2
    {
        private double usd1;
        private double eur2;
        private double pln3;
        public Converter( double usd, double eur, double pln )
        {
            usd1 = usd;
            eur2 = eur;
            pln3 = pln;
        }

        public double ConvertertoGRN(double sumaingrn, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return sumaingrn * usd1;
                case "eur":
                    return sumaingrn * eur2;
                case "pln":
                    return sumaingrn * pln3;
                default:
                    throw new AggregateException("Wrong currency");
                
            }
        }
        public double ConverterfromGRN(double sumaingrn, string currency)
        {
            switch (currency.ToLower())
            {
                case "usd":
                    return sumaingrn / usd1;
                case "eur":
                    return sumaingrn / eur2;
                case "pln":
                    return sumaingrn / pln3;
                default:
                    throw new AggregateException("Wrong currency");
                
            }
        }
    }
    public class Employee//3
    {
        private string прізвище1;
        private string імя1;
        private string посада1;
        private int стаж1;
        private double оклад1;

        public Employee(string прізвище, string імя)
        {
            прізвище1 = прізвище;
            імя1 = імя;
        }

        public void ВведітьПосаду(string посада)
        {
            посада1 = посада;
        }

        public void ВведітьСтаж(int стаж)
        {
            стаж1 = стаж;
        }

        public void РозрахуватиОклад()
        {
            
            if (посада1 == "менеджер")
            {
                оклад1 = 30000 + (стаж1 * 1000);
            }
            else if (посада1 == "розробник")
            {
                оклад1 = 40000 + (стаж1 * 1500);
            }
            else
            {
                оклад1 = 25000 + (стаж1 * 800);
            }
        }

        public double РозрахуватиПодатковийЗбір()
        {
            
            double податок = оклад1 * 0.15; // Податок 15% від окладу
            return податок;
        }

        public void ВивестиІнформацію()
        {
            Console.WriteLine("Інформація про співробітника:");
            Console.WriteLine("Прізвище: " + прізвище1);
            Console.WriteLine("Ім'я: " + імя1);
            Console.WriteLine("Посада: " + посада1);
            Console.WriteLine("Оклад: " + оклад1 + " грн");
            Console.WriteLine("Податковий збір: " + РозрахуватиПодатковийЗбір() + " грн");
        }
    }

    class User//4
    {
        private string login;
        private string name;
        private string surname;
        private int age;
        private string data;

        public User(string login, string name, string surname, int age, string data)
        {
            this.login = login;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.data = data;

        }

        public void information()
        {
            Console.WriteLine("Your information");
            Console.WriteLine("Your login is " + login);
            Console.WriteLine($"Your fullname  is  {name} {surname}");
            Console.WriteLine($"Your age is {age}" );
            Console.WriteLine("Data of enter to site " + data);
            
        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1
            /*
            Adress myAdress = new Adress();
            Console.WriteLine("Enter information about your location");
            Console.WriteLine("Enter your Index");
            myAdress.Index = Console.ReadLine();
            Console.WriteLine("Enter your Country");
            myAdress.Country = Console.ReadLine();
            Console.WriteLine("Enter your City");
            myAdress.City = Console.ReadLine();
            Console.WriteLine("Enter your Street");
            myAdress.Street = Console.ReadLine();
            Console.WriteLine("Enter your House");
            myAdress.House = Console.ReadLine();
            Console.WriteLine("Enter your Apartment");
            myAdress.Apartment = Console.ReadLine();;
        
            Console.WriteLine("Індекс: " + myAdress.Index);
            Console.WriteLine("Країна: " + myAdress.Country);
            Console.WriteLine("Місто: " + myAdress.City);
            Console.WriteLine("Вулиця: " + myAdress.Street);
            Console.WriteLine("Будинок: " + myAdress.House);
            Console.WriteLine("Квартира: " + myAdress.Apartment);
            */
            //Task 2
            /*
            Console.WriteLine("Enter course of currency (USD,EUR,PLN)");
            double usd = double.Parse(Console.ReadLine());
            double eur = double.Parse(Console.ReadLine());
            double pln = double.Parse(Console.ReadLine());
            Converter converter = new Converter(usd, eur, pln);
            Console.WriteLine("Enter which operation you need 1 - is from grn to other currency or 2 - other currency to grn");
            int operation = int.Parse(Console.ReadLine());

            if (operation == 1)
            {
                Console.WriteLine("Enter your sum in grn");
                double sumaingrn = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter code of currency you need(USD EUR PLN)");
                string currency = Console.ReadLine();
                double result = converter.ConvertertoGRN(sumaingrn, currency);
                Console.Write($"Here your operation {result} {currency} ");
            }
            else if (operation == 2)
            {
                Console.WriteLine("Enter your sum in other currency");
                double sumainothercurrency = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter code of currency  you need(USD EUR PLN)");
                string currency = Console.ReadLine();
                double result = converter.ConverterfromGRN(sumainothercurrency, currency);
                Console.Write($"Your course {result} UAH");
            }
            else
            {
                Console.WriteLine("Wrong operation");
            }
            */
            //Task 3
            /*
            Console.WriteLine("Введіть прізвище співробітника:");
            string прізвище = Console.ReadLine();
        
            Console.WriteLine("Введіть ім'я співробітника:");
            string ім_я = Console.ReadLine();

            Employee співробітник = new Employee(прізвище, ім_я);

            Console.WriteLine("Введіть посаду співробітника:");
            string посада = Console.ReadLine();
            співробітник.ВведітьПосаду(посада);

            Console.WriteLine("Введіть стаж співробітника (в роках):");
            int стаж = int.Parse(Console.ReadLine());
            співробітник.ВведітьСтаж(стаж);

            співробітник.РозрахуватиОклад();
            співробітник.ВивестиІнформацію();
            */
            //Task 4
            /*
            Console.WriteLine("Hello write information about you to sign in your account");
            Console.WriteLine("Enter your login");
            string login = Console.ReadLine();
            Console.WriteLine("Enter your first name");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter when you login to site");
            string data = Console.ReadLine();
            User user = new User(login, firstname, lastname, age,data);
            user.information();
            Console.ReadLine();
            */
        }
    }
}