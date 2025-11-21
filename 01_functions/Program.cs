namespace _01_functions;
    internal class Program
    {
            static void Main(string[] args)
            {
                Program program = new Program();
                program.Run(); // We hebben een variable gemaakt voor de class program. De function die we gebruiken heet Run();. De return type van de function is nu nog niks omdat, de function nog niet aangemaakt is.
            }

            internal void Run()
            {
                Console.WriteLine("...");
                Vraag1();
                Vraag2();
                Vraag3();
                Vraag4();
                Vraag5();
            }
                internal void Vraag1()
                {
                    Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
                    string antwoord = Console.ReadLine();

                    Console.WriteLine(antwoord);
                }
                internal void Vraag2()
                {
                    Console.WriteLine("Why do round pizzas come in square boxes?");
                    string antwoord = Console.ReadLine();

                    Console.WriteLine(antwoord);
                }          
                internal void Vraag3()
                {
                    Console.WriteLine("What would you do if you won a million dollars?");
                    string antwoord = Console.ReadLine();

                    Console.WriteLine(antwoord);
                }          
                internal void Vraag4()
                {
                    Console.WriteLine("What is the worst game you played but that you liked anyway?");
                    string antwoord = Console.ReadLine();

                    Console.WriteLine(antwoord);
                }          
                internal void Vraag5()
                {
                    Console.WriteLine("Who would win gojo or sukuna?");
                    string antwoord = Console.ReadLine();

                    Console.WriteLine(antwoord);
                }          
    }