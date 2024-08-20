namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        // a.Verilmish ededin menfi ve ya musbet oldugunu tapan algorithm


        int num = 7;
        if (num > 0)
        {
            Console.WriteLine("müsbet");
        }
        else
        {
            Console.WriteLine("menfi");
        }



        int num2 = -7;
        if (num < 0)
        {
            Console.WriteLine("menfi");
        }
        else
        {
            Console.WriteLine("musbet");
        }



        //b.Verilmish ededin hem 3 - e hem de 7 - e tam bolunub bolunmediyini tapan algorithm


        int num3 = 21;
        if (num3 % 3==0 && num3 % 7==0)   
        {
            Console.WriteLine("tam bolunur");
        }
        else
        {
            Console.WriteLine("tam bolunmur");
        }

    }
}
