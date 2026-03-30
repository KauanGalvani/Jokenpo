using System.Security.Cryptography;

namespace Jokenpo.ConsoleApp
{
    class Program
    {

        static string? Cabecalho()
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

            return Console.ReadLine();
        }

        static string Escolha(string escolha)
        {
            while (true)
            {
                switch (escolha)
                {
                    case "1": escolha = "Papel"; break;
                    case "2": escolha = "Pedra"; break;
                    case "3": escolha = "Tesoura"; break;
                    default:
                        Console.WriteLine("escolha uma opção valida. ");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                }
                return escolha;
            }  
        }
        static void Main(string[] args)
        {

            while (true)
            {

                string? escolhaJogador = Cabecalho();

                string jogadorDecisao = Escolha(escolhaJogador);

                string[] jokenpoPC = ["Pedra", "Papel", "Tesoura"];

                int indiceAleaorio = RandomNumberGenerator.GetInt32(jokenpoPC.Length); //aqui gera a escolha do Computador.
                string escolhaPC = jokenpoPC[indiceAleaorio];

                if (escolhaJogador == escolhaPC)
                {
                    Console.WriteLine("O jogo foi empatado entao será resetado");
                    Console.WriteLine("Precione ENTER para proceguir...");
                    Console.ReadLine();
                    continue;
                }
                else if (escolhaJogador == "Papel" && escolhaPC == "Pedra" ||
                        escolhaJogador == "Pedra" && escolhaPC == "Tesoura" ||
                        escolhaJogador == "Tesoura" && escolhaPC == "Papel")

                {
                    Console.WriteLine("Você venceu");
                }
                else
                {
                    Console.WriteLine("O computador venceu");
                }

                Console.WriteLine("");

                Console.WriteLine("Deseja jogar novamente? (S/N)");
                string? devContinuar = Console.ReadLine()?.ToUpper();

                if (devContinuar != "S")
                {
                    Console.WriteLine("Você esta fechando o jogo obrigado por jogar...");
                    Console.WriteLine("Pressione ENTER para sair...");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.Clear();
                    continue;
                }

            }
        }
    }
}