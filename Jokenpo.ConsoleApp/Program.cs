namespace Jokenpo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string? decisaoDoJogador = Jogadores.CabecalhoEscolhaJoador();

                string escolhaComputador = Jogadores.EscolhaDoComputador();

                CheckResultado.ResultadoDoJogo(decisaoDoJogador, escolhaComputador);

                if (!DevContinuar()) break;
                else continue;
            }
        }
        static bool DevContinuar()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; //mudar a cor no console para amarelo.
                Console.WriteLine("Deseja jogar novamente? (S/N)");
                string? devContinuar = Console.ReadLine()?.ToUpper();

                if (string.IsNullOrEmpty(devContinuar))
                {
                    Console.WriteLine("Digite um valor conforme foi pedido!! ");
                    continue;
                }
                else
                {
                    Console.ResetColor(); //reseta ao padrão

                    if (devContinuar != "S")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("");
                        Console.WriteLine("Você esta fechando o jogo obrigado por jogar...");
                        Console.WriteLine("Pressione ENTER para sair...");
                        Console.ReadLine();
                        Console.ResetColor();
                        return false;
                    }
                    else
                    {
                        Console.Clear();
                        return true;
                    }
                }
            }
        }
    }
}