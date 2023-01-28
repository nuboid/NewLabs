namespace CodeLab_Demo1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Asyn/Await CodeLab_Demo1");
            SomeMethod1();
            Console.WriteLine();
            Console.WriteLine("Thanks.");

        }
                        
        private static void SomeMethod1()
        {
            Console.WriteLine("Hit a key.");
            var key = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("You did hit the key " + key.KeyChar);

        }

        private static async void SomeMethod2()
        {
            Console.WriteLine("Hit a key.");
            var key = Console.ReadKey();
            var textInFile = await File.ReadAllTextAsync("SomeFile.txt");
            Console.WriteLine();
            Console.WriteLine("You did hit the key " + key.KeyChar);

        }

        private static async Task SomeMethod3()
        {
            Console.WriteLine("Hit a key.");
            var key = Console.ReadKey();
            var textInFile = await File.ReadAllTextAsync("SomeFile.txt");
            Console.WriteLine();
            Console.WriteLine("You did hit the key " + key.KeyChar);

        }
    }
}