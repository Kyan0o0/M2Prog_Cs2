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
            }
                internal void Vraag1()
                {
                    Console.WriteLine("als deze in je kont zou gaan, Zou je dan nog leven?");
                    string antwoord = Console.ReadLine();

                    Console.WriteLine(antwoord);
                }
    }