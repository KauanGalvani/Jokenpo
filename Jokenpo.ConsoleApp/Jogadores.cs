using System.Security.Cryptography;

namespace Jokenpo.ConsoleApp
{
    static class Jogadores
    {
        public static string? CabecalhoEscolhaJoador()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow; //mudar a cor no console para amarelo.
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Jogo pedra, pale e tesoura");
                Console.WriteLine("-----------------------------");

                Console.WriteLine("");

                Console.WriteLine("---------------------------------");
                Console.WriteLine("(1) - para jogar PAPEL");
                Console.WriteLine("(2) - para jogar PEDRA");
                Console.WriteLine("(3) - para jogar TESOURA");
                Console.WriteLine("---------------------------------");
                Console.ResetColor(); //reseta ao padrao

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
        public static string EscolhaDoComputador()
        {
            string[] jokenpoPC = ["Pedra", "Papel", "Tesoura"];

            int indiceAleaorio = RandomNumberGenerator.GetInt32(jokenpoPC.Length); //aqui gera a escolha do Computador.
            string escolhaPC = jokenpoPC[indiceAleaorio];
            return escolhaPC;
        }
    }
}