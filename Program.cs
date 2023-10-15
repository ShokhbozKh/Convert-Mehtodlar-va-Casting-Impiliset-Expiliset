namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inpiliset va expiliset casting casting");
            int num1 = 12;
            double num2 = 123.32;
            int num3 = (int)num2;
            double num4 = num1;
            int number = 1;
            Console.WriteLine("Convert methodlari");
            Console.WriteLine(Convert.ToBoolean(number));//Convert
            Console.WriteLine(Convert.ToBoolean(number-1));
            Convert.ToInt16((int)number);
            int a = 43;
            string text = "1234";
            int b =Convert.ToInt32(text);//Convert sinifining static methodlari
            Console.WriteLine(b);
            Console.WriteLine(Convert.ToChar((char)num2));// expiliset casting
            char c = Convert.ToChar(a);
            Console.WriteLine(c);


            Console.WriteLine("Max va Min qiymatlar");
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine("Musbat sonlari");
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine("Matnlar uchun chegara mavjud emas");
            Console.WriteLine("MAtnning bush bulishi methodi Empty");
            Console.WriteLine(string.Empty);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(num4.GetType());
            Console.WriteLine(num2.GetType());
            Console.WriteLine(num3.GetTypeCode());
            Console.WriteLine(num4.GetTypeCode());
            Console.WriteLine(num2.TryFormat);
            Console.WriteLine(num1.GetTypeCode());


        }
    }
}