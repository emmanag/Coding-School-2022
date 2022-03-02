namespace Session_2b_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Hello Manos!");

            //2
            int x = 6;
            int y = 3;
            int sum = x + y;
            int div = x / y;
            Console.WriteLine(sum);
            Console.WriteLine(div);

            //3
            Console.WriteLine(-1 + 5 * 6);
            Console.WriteLine(14 + (-3 * 6) / 7);
            Console.WriteLine(2 + (13 / 6) * 6 * Math.Sqrt(7));
            Console.WriteLine(38*(5 % 7));
            Console.WriteLine(((Math.Pow(6, 4) + Math.Pow(5, 7) / (9 % 4))));

            //4
            int age = 20;
            string gender = "female";
            Console.WriteLine($"the gender is  {gender}  and you look younger than {age}");

            //5

            int seconds = 45678;
            Console.WriteLine($"the minutes are {(seconds/60)} the hours are {(seconds/3600)} the days are {(seconds/86400)} the years are {(seconds/31536000)}") ;

            //6
            int Seconds = 45678;
            TimeSpan Interval = TimeSpan.FromSeconds(seconds);

            //7
            int celcius = 10; double fahrenheit = (celcius * (9 / 5) + 32); double kelvin = (celcius + 273.15); 
            Console.WriteLine($"The Fahrenheit is {fahrenheit} The Kelvin is {kelvin} ");
        }
    }
}
