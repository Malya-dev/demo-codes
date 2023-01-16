namespace Demo
{
    public class oops
    {
        double num1;

        double num2;

        public void Calculate()

        {

            double result = 0;

            int cont;

            do

            {

                System.Console.WriteLine("Enter 1 for Addition, 2 for Subtraction, 3 for Multiplication, 4 for Division");

                int ch = Convert.ToInt16(Console.ReadLine());

                switch (ch)

                {

                    case 1:

                        double sum = 0;

                        double j;

                        Console.WriteLine("How many Numbers do you want to Enter: ");

                        int n = Convert.ToInt32(Console.ReadLine());

                        System.Console.WriteLine("Enter Values: ");

                        for (int i = 0; i < n; i++)

                        {

                            j = Convert.ToDouble(Console.ReadLine());

                            sum += j;

                        }

                        System.Console.WriteLine("Sum = {0}", sum);

                        break;

                    case 2:

                        Console.WriteLine("Enter Two values: ");

                        num1 = Convert.ToDouble(Console.ReadLine());

                        num2 = Convert.ToDouble(Console.ReadLine());

                        result = num1 - num2;

                        Console.WriteLine("Difference : {0}", result);

                        break;

                    case 3:

                        double mult = 1;

                        Console.WriteLine("How many Numbers do you want to Enter: ");

                        n = Convert.ToInt32(Console.ReadLine());

                        System.Console.WriteLine("Enter Values: ");

                        for (int i = 0; i < n; i++)

                        {

                            j = Convert.ToDouble(Console.ReadLine());

                            mult *= j;

                        }

                        System.Console.WriteLine("Multiplication = {0}", mult);

                        break;

                    case 4:

                        Console.WriteLine("Enter Two values: ");

                        num1 = Convert.ToDouble(Console.ReadLine());

                        num2 = Convert.ToDouble(Console.ReadLine());

                        if (num2 == 0)

                        {

                            Console.WriteLine("Non - Divisible by 0");

                        }

                        else

                        {

                            result = num1 / num2;

                            Console.WriteLine("Division : {0}", result);

                        }

                        break;

                    default:

                        System.Console.WriteLine("Invalid Selection");

                        break;

                }

                System.Console.WriteLine("Wish to continue? \nEnter 0 to continue, else exit");

                cont = Convert.ToInt16(Console.ReadLine());

            } while (cont == 0);

        }

    }
}