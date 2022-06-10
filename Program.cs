// See https://aka.ms/new-console-template for more information
class Program
{

            static void Main(string[] args)
            {
                PrintRangeHightoLow(1000, -1000);

                NumbersByThree();

                AreNumbersEqual(1);

                OddorEven(1);

                IsnumberPositive(1);

                LegalVotingAge(1);
            }


    public static void NumbersByThree()
    {
        for (int a =3; a<=999; a+=3)
        {
            Console.WriteLine(a);
        }




    }
    public static void PrintRangeHightoLow(int ceiling, int floor )
    {
        for (int i = ceiling; i>=floor; i--)
        {
            Console.WriteLine(i);
        }
      


    }
    public static void AreNumbersEqual(int number)
    {
        Console.WriteLine("Give me two numbers and i will tell if they are equal or not");
        number = int.Parse(Console.ReadLine());
        int number1 = int.Parse(Console.ReadLine());
        if (number == number1)
        {

            Console.WriteLine("numbers are equal");
        }
        else
        {
            Console.WriteLine("the number are not equal");
        }
    }

    public static void LegalVotingAge(int userAge)
    {
        Console.WriteLine("Welcome to our voting website, you must be 18 or over to participate.");
        Console.WriteLine("Enter your age");
        var legalAge = 18;
        userAge = int.Parse(Console.ReadLine());
        if (userAge >= legalAge)
        {

            Console.WriteLine("you are able to vote");
        }
        else
        {
            Console.WriteLine("try again in a few years");
        }


    }



    public static void IsnumberPositive(int number)
    {
        Console.WriteLine("Give me a number and i will tell if its positive or negative");
        number = int.Parse(Console.ReadLine());
        if (number >= 0)
        {

            Console.WriteLine("the number is positive");
        }
        else
        {
            Console.WriteLine("the number is Negative");
        }


    }


  public static void OddorEven(int number)
  {
        Console.WriteLine("Give me a number and i will tell if its even or odd");
        number = int.Parse(Console.ReadLine());
        if (number % 2 != 0)
        {

            Console.WriteLine("the number is odd");
        }
        else
        {
            Console.WriteLine("the number is even");
        }


  }






}   










