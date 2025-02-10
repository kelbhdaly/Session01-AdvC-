namespace Session01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics

            int a = 10, b = 20;
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");

            Helper<int>.Swap(ref a, ref b);

            Console.WriteLine($"B = {b}");
            Console.WriteLine($"A = {a}");


            decimal L = 10.20M, M = 20.10M;

            Console.WriteLine($"L = {L}"); //10.20
            Console.WriteLine($"M = {M}"); //20.10

            Helper<Decimal>.Swap(ref M, ref L);

            Console.WriteLine($"L = {L}"); //20.10
            Console.WriteLine($"M = {M}"); //10.20


            Point point01 = new Point(10, 20);
            Point point02 = new Point(100, 200);

            Console.WriteLine($"Point 01 = {point01}");//(10 , 20)
            Console.WriteLine($"Point 02 = {point02}");//(100 , 200)

            Helper<Point>.Swap(ref point02, ref point01);

            Console.WriteLine($"Point 01 = {point01}"); //(100 , 200)
            Console.WriteLine($"Point 02 = {point02}"); //(10 , 20) 
            #endregion

        }
    }
}
