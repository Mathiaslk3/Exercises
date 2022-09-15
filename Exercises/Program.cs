namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ex1 = false;
            bool ex2 = false;
            bool ex3 = false;
            bool ex4 = false;
            bool ex5 = false;
            #region Exercise 1 - String valuses
            while (ex1)
            {
                string Name;
                string Age;

                Console.Write("Indtast dit navn: ");
                Name = Console.ReadLine();

                Console.Write("Indtast din alder: ");
                Age = Console.ReadLine();

                Console.WriteLine("Du har indtastet:");
                Console.WriteLine("Navn: " + Name);
                Console.WriteLine("Alder: " + Age);

                Console.ReadLine();
                Console.Clear();
            }
            #endregion

            #region Exercise 2 - IF/ELSE statements
            while (ex2)
            {
                string Name;
                int Age;
                string rank;
                Console.Write("Indtast dit navn: ");
                Name = Console.ReadLine();

                Console.Write("Indtast din alder: ");
                Age = int.Parse(Console.ReadLine());


                Console.WriteLine("Vil du trækre 10 år fra alderen? (Y)/(N)");
                string removeAge = Console.ReadLine();
                if (removeAge == "Y")
                {
                    int newAge = Age - 10;

                    Console.WriteLine("Hvis du træker 10 år fra" + Age + "så før vi: " + newAge);


                }
                else
                {
                    if (Age <= 12)
                    {

                        rank = "et barn";

                        Console.WriteLine("Du har indtastet:");
                        Console.WriteLine("Navn: " + Name);
                        Console.WriteLine("Alder: " + Age + " og er " + rank);
                    }
                    else if (Age <= 19)
                    {
                        rank = "en teenager";
                        Console.WriteLine("Du har indtastet:");
                        Console.WriteLine("Navn: " + Name);
                        Console.WriteLine("Alder: " + Age + " og er " + rank);
                    }
                    else if (Age <= 25)
                    {
                        rank = "en studerende";
                        Console.WriteLine("Du har indtastet:");
                        Console.WriteLine("Navn: " + Name);
                        Console.WriteLine("Alder: " + Age + " og er " + rank);
                    }
                    else if (Age <= 67)
                    {
                        rank = "i arbejde";
                        Console.WriteLine("Du har indtastet:");
                        Console.WriteLine("Navn: " + Name);
                        Console.WriteLine("Alder: " + Age + " og er " + rank);
                    }
                    else
                    {
                        rank = "en pensionist";
                        Console.WriteLine("Du har indtastet:");
                        Console.WriteLine("Navn: " + Name);
                        Console.WriteLine("Alder: " + Age + " og er " + rank);
                    }
                }



                Console.ReadLine();
                Console.Clear();

            }
            #endregion

            #region Exercise 5 - New Class file and use data from it
            while (ex5)
            {
                
                Console.WriteLine("Hej og velkommen :D");
                Console.WriteLine("Dette er en tidlig version af en lommeregner.");
                Console.WriteLine();
                Console.WriteLine("Vælg en af de nedrestående muligheder:");
                Console.WriteLine();

                Console.WriteLine("1. Plus");
                Console.WriteLine("2. Minus");
                Console.WriteLine("3. Gange");
                Console.WriteLine("4. Divider");

                string input = Console.ReadLine();

                int res;
                int.TryParse(input, out res);

                Calculator cal = new Calculator();

                int input1;
                int input2;

                switch (res)
                {
                    case 1:

                        Console.WriteLine("Du har valgt at pluse tald sammen");
                        Console.WriteLine();
                        Console.WriteLine("Indtast den første værdri: ");

                        input1 = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Indtast den anden værdi værdri: ");

                        input2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Den sammlede værdi af "+ input1 + " + " + input2 + " er: " + cal.Add(input1, input2));

                        break;
                    case 2:
                        Console.WriteLine("Du har valgt at minus nogle tald");
                        Console.WriteLine();
                        Console.WriteLine("Indtast den første værdri: ");

                        input1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Indtast den anden værdi værdri: ");

                        input2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Den sammlede værdi af " + input1 + " - " + input2 + " er: " + cal.Subtract(input1, input2));
                        break;
                    case 3:
                        Console.WriteLine("Du har valgt at gange nogle tald");
                        Console.WriteLine();
                        Console.WriteLine("Indtast den første værdri: ");

                        input1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Indtast den anden værdi værdri: ");

                        input2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Den sammlede værdi af " + input1 + " * " + input2 + " er: " + cal.Subtract(input1, input2));
                        break;
                    case 4:
                        Console.WriteLine("Du har valgt at dividere nogle tald");
                        Console.WriteLine();
                        Console.WriteLine("Indtast den første værdri: ");

                        input1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Indtast den anden værdi værdri: ");

                        input2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Den sammlede værdi af " + input1 + " / " + input2 + " er: " + cal.Subtract(input1, input2));
                        break;
                    default:
                        Console.WriteLine("Invalid value - Try again");
                        break;
                }
                Console.ReadLine();
                Console.Clear();
            }
            #endregion
        }
    }
}