namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Veuillez entrer votre nom : ");
            string nomUtilisateur = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello, {0}!", nomUtilisateur);
            Console.ReadLine();
        }
    }
}