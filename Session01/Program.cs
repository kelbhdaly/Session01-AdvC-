using Session01.Test;

namespace Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics & SWap

            //int a = 10, b = 20;
            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");

            //Helper<int>.Swap(ref a, ref b);

            //Console.WriteLine($"B = {b}");
            //Console.WriteLine($"A = {a}");


            //decimal L = 10.20M, M = 20.10M;

            //Console.WriteLine($"L = {L}"); //10.20
            //Console.WriteLine($"M = {M}"); //20.10

            //Helper<Decimal>.Swap(ref M, ref L);

            //Console.WriteLine($"L = {L}"); //20.10
            //Console.WriteLine($"M = {M}"); //10.20


            //Point point01 = new Point(10, 20);
            //Point point02 = new Point(100, 200);

            //Console.WriteLine($"Point 01 = {point01}");//(10 , 20)
            //Console.WriteLine($"Point 02 = {point02}");//(100 , 200)

            //Helper<Point>.Swap(ref point02, ref point01);

            //Console.WriteLine($"Point 01 = {point01}"); //(100 , 200)
            //Console.WriteLine($"Point 02 = {point02}"); //(10 , 20) 
            #endregion



            #region LinnerSearch


            //int[] arr = { 2, 4, 5, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19,50 };
            ////Console.WriteLine($" Index = {Helper<int>.LinerSearch(arr, 100)}"); 
            //Employee employee01 = new Employee(10 , "Khaled", 10000);
            //Employee employee02 = new Employee(10 , "Khaled" , 10000);

            //if(employee01 .Equals( employee02))
            //    Console.WriteLine("EQUAL");
            //else
            //    Console.WriteLine("NOT EQUAL");
            //Employee[] employees =
            //{
            //    new(10,"khaled" , 20000) ,
            //    new(20,"May" , 10000) ,
            //    new(30,"Omar" , 9000) ,
            //    new(40,"Ali" , 3000) ,
            //    new(50,"Ahmed" , 220000) ,

            //};

            //Employee employee01 = new(30, "Omar", 9000);

            //Console.WriteLine($"Index = {Helper<Employee>.LinerSearch(employees , employee01)}");
            #endregion



            #region Equality And GetHashCode
            //Employee employee01 = new Employee(10, "Khaled", 10000);
            //Employee employee02 = new Employee(10, "Khaled", 10000);

            //if (employee01.Equals(employee02))
            //    Console.WriteLine("EQUAL");
            //else
            //    Console.WriteLine("NOT EQUAL");

            //Console.WriteLine($"Hash Code Of Employee 01 = {employee01.GetHashCode()}");
            //Console.WriteLine($"Hash Code Of Employee 02 = {employee02.GetHashCode()}");
            #endregion


            #region Is && As Operators

            //Employee employee01 = new Employee(10 , "khaled" , 1000);
            //Employee employee02 = new Employee(10 , "khaled" , 1000);

            //Console.WriteLine(employee01.Equals(employee02)); 
            #endregion

            #region Equatabale

            //Employee[] employees =
            //{
            //    new(10,"khaled" , 20000) ,
            //    new(20,"May" , 10000) ,
            //    new(30,"Omar" , 9000) ,
            //    new(40,"Ali" , 3000) ,
            //    new(50,"Ahmed" , 220000) ,
            //};


            //Employee emp = new Employee(30, "ali", 9000);
            //int Result = Helper<Employee>.LinerSearch(employees , emp ,new EmployeeNameEqualityComparer());

            //Console.WriteLine($"Index = {Result}"); 
            #endregion

            #region Test

            #region Test01

            //int[] number = { 1, 2, 3 };
            //Console.WriteLine(Search<int>.Search02(number, 5)); 
            #endregion


            #region Test02
            //Emp emp01 = new Emp(10, "Ali", 20000);
            //Emp emp02 = new Emp(10, "Ali", 20000);

            //Console.WriteLine(emp01.Equals( emp02));

            //Console.WriteLine($"Hash Code Emp01 = {emp01.GetHashCode()}");
            //Console.WriteLine($"Hash Code Emp02 = {emp02.GetHashCode()}"); 
            #endregion

            #region Test03
            // Emp[] emps =
            // {
            //     new(10 , "Ali" , 2000),
            //     new(20 , "Mohamed" , 2000),
            //     new(30 , "Ali" , 2000),
            //     new(40 , "khaled" , 2000),
            // };

            // Emp emp = new(20, "Mohamed", 2000);
            //int Result= Search<Emp>.Search02(emps, emp, new Comparer());
            // Console.WriteLine(Result); 
            #endregion



            #endregion

            #region BubbleSort

            //int[] numbers = { 3, 8, 10, 6, 7, 30, 40 };



            Employee[] employees =
            {
                new(10,"khaled" , 20000) ,
                new(20,"May" , 10000) ,
                new(30,"Omar" , 9000) ,
                new(40,"Ali" , 3000) ,
                new(50,"Ahmed" , 220000) ,
            };

            Helper<Employee>.BubbleSort(employees, new EmployeeNameComparer());
            foreach (Employee item in employees)
            {
                Console.WriteLine(item);

            }

            #endregion
        }
    }
}
