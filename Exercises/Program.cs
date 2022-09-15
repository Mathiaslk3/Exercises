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
        }
    }
}