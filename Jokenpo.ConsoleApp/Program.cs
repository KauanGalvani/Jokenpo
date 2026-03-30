using System.Security.Cryptography;

namespace Jokenpo.ConsoleApp
{
    class Program
    {

        static string? CabecalhoEscolha()
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
                    case "1": return "Papel";
                    case "2": return "Pedra";
                    case "3": return "Tesoura";
                    default:
                        Console.WriteLine("escolha uma opção valida. ");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                }
            }

        }

        static string EscolhaDoComputador()
        {
            string[] jokenpoPC = ["Pedra", "Papel", "Tesoura"];

            int indiceAleaorio = RandomNumberGenerator.GetInt32(jokenpoPC.Length); //aqui gera a escolha do Computador.
            string escolhaPC = jokenpoPC[indiceAleaorio];
            return escolhaPC;
        }

        static void ResultadoDoJogo(string? decisaoDoJogador, string escolhaComputador)
        {
            if (decisaoDoJogador == escolhaComputador)
            {
                Console.WriteLine("O jogo foi empatado entao será resetado");
                Console.WriteLine("Precione ENTER para proceguir...");
                Console.ReadLine();
            }
            else if (decisaoDoJogador == "Papel" && escolhaComputador == "Pedra" ||
                    decisaoDoJogador == "Pedra" && escolhaComputador == "Tesoura" ||
                    decisaoDoJogador == "Tesoura" && escolhaComputador == "Papel")

            {
                Console.WriteLine("Você venceu");
            }
            else
            {
                Console.WriteLine("O computador venceu");
            }
            Console.WriteLine("");
        }

        static bool DevContinuar()
        {
            Console.WriteLine("Deseja jogar novamente? (S/N)");
            string? devContinuar = Console.ReadLine()?.ToUpper();

            if (devContinuar != "S")
            {
                Console.WriteLine("Você esta fechando o jogo obrigado por jogar...");
                Console.WriteLine("Pressione ENTER para sair...");
                Console.ReadLine();
                return false;
            }
            else
            {
                Console.Clear();
                return true;
            }
        }
        static void Main(string[] args)
        {

            while (true)
            {
                string? decisaoDoJogador = CabecalhoEscolha();

                string escolhaComputador = EscolhaDoComputador();

                ResultadoDoJogo(decisaoDoJogador, escolhaComputador);

                if (!DevContinuar()) break;
                else continue;
            }
        }
    }
}