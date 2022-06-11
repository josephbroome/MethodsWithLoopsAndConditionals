// See https://aka.ms/new-console-template for more information
class Program
{

            static void Main(string[] args)
    {
            //PrintRangeHightoLow(1000, -1000);

            //NumbersByThree();

            // AreNumbersEqual();

            //OddorEven();

            // IsnumberPositive();

            //LegalVotingAge();

            //Rangecheck();

        var y= new List<int>();

        for(int i=0; i<=12; i++)
        {
            y.Add(i);
            
        var x = 5;

        Console.Write(x *= 3);
        Console.WriteLine(y[i]);
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
    public static void AreNumbersEqual()
    {
        bool numbersEqual;
        
        
        Console.WriteLine("Give me two numbers and i will tell if they are equal or not");
        int number = int.Parse(Console.ReadLine());
        int number1 = int.Parse(Console.ReadLine());
        if (number == number1)
        {

            Console.WriteLine($"{number} and {number1} are equal");
            numbersEqual = true;
        }
        else
        {
            Console.WriteLine($"{number} and {number1} are not equal");
        
            numbersEqual= false;    
        }
    }

    public static void LegalVotingAge()
    {
        bool legalVote; 
        
        
        Console.WriteLine("Welcome to our voting website, you must be 18 or over to participate.");
        Console.WriteLine("Enter your age");
        int legalAge = 18;
        int userAge = int.Parse(Console.ReadLine());
        if (userAge >= legalAge)
        {

            Console.WriteLine("you are able to vote");
            legalVote=true;
        }
        else
        {
            Console.WriteLine("try again in a few years");
            legalVote = false;
        
        }


    }



    public static void IsnumberPositive()
    {
        bool positiveNumber;
        Console.WriteLine("Give me a number and i will tell if its positive or negative");
        int number = int.Parse(Console.ReadLine());
        if (number >= 0)
        {

            Console.WriteLine($"{number} is positive");
            positiveNumber = true;
        }
        else
        {
            Console.WriteLine($"{number} is Negative");
        
            positiveNumber=false;
        }


       

    }

    public static void Rangecheck()

    {
        bool inRange;
        
        do
        { 
            Console.WriteLine("Give me a number and i will tell if its between -10 and 10 ");
            int userNumber = int.Parse(Console.ReadLine());
        


                if (userNumber >= -10 && userNumber <= 10)
                {
                    Console.WriteLine($"{userNumber} is in range");
                    inRange = true;
                }
                else
                {   
                    Console.WriteLine($"{userNumber} is not range");
                    inRange= false;
                }



        } while (inRange==false);

    

    }




    
  public static void OddorEven()
  {
        bool oddEven;
        
        Console.WriteLine("Give me a number and i will tell if its even or odd");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 != 0)
        {

            Console.WriteLine($"{number} is odd");
            oddEven = true; 
        }
        else
        {
            Console.WriteLine($"{number} is even");
            oddEven = false;
        
        }


  }



 public static void MultiplicatonTable(int x)
    {

        

    }


}   










