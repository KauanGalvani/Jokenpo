namespace Jokenpo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Jogo pedra, pale e tesoura");
                Console.WriteLine("-----------------------------");

                Console.WriteLine("");

                Console.WriteLine("---------------------------------");
                Console.WriteLine("(1) - para jogar PAPEL");
                Console.WriteLine("(2) - para jogar PEDRA");
                Console.WriteLine("(3) - para jogar TESOURA");
                Console.WriteLine("---------------------------------");

                Console.Write("Escolha qual sua opção para jogar: ");
                string? escolhaJogador = Console.ReadLine();

                switch (escolhaJogador)
                {
                    case "1":
                        escolhaJogador = "Papel";
                        break;
                    case "2":
                        escolhaJogador = "Pedra";
                        break;
                    case "3":
                        escolhaJogador = "Tesoura";
                        break;
                    default:
                        Console.WriteLine("escolha uma opção valida. ");
                        continue;
                }

            }
        }
    }
}