class Program
{
    static void Main(string[] args)
    {
        //First problem
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if ((j == 0 || j == 4) && i != 4 || (i == 4 && j > 0 && j < 4))
                {
                    Console.Write('U');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }

        //Second problem
        Console.Write("Введите число палиндром: ");
        string numberStr = Console.ReadLine();

        if (IsPalindrome(numberStr))
        {
            Console.WriteLine("Палиндромом");
        }
        else
        {
            Console.WriteLine("Не палиндром");
        }

        //Third problem
        Console.Write("Введите число разварот: ");
        int number1 = int.Parse(Console.ReadLine());
        int reversed = Return_Reverse(number1);
        Console.WriteLine($"{number1} {reversed}");


        //Fourth problem 
        int height = int.Parse(Console.ReadLine());
        Console.Write("Введите число для высоты ромба: ");

        // Top qisim
        for (int i = 1; i <= height; i++)
        {
            for (int j = 1; j <= height - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // Bottom qisim
        for (int i = height - 1; i >= 1; i--)
        {
            for (int j = 1; j <= height - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

    }

    public static bool IsPalindrome(string number)
    {
        int left = 0;
        int right = number.Length - 1;

        while (left < right)
        {
            if (number[left] != number[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }


    public static int Return_Reverse(int number)
    {
        int reverse = 0;

        while (number != 0)
        {
            int digit = number % 10;
            reverse = reverse * 10 + digit;
            number /= 10;
        }

        return reverse;
    }

}