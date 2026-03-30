namespace Jokenpo.ConsoleApp
{
    static class CheckResultado
    {
        public static void ResultadoDoJogo(string? decisaoDoJogador, string escolhaComputador)
        {

            if (decisaoDoJogador == escolhaComputador)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine($"Sua escolha foi {decisaoDoJogador} a escolha do computador foi {escolhaComputador}");
                Console.WriteLine("------------------------------------------------------------------------------------");

                Console.WriteLine("O jogo foi empatado entao será resetado");
                Console.WriteLine("Precione ENTER para proceguir...");
                Console.ReadLine();

                Console.ResetColor();
            }
            else if (decisaoDoJogador == "Papel" && escolhaComputador == "Pedra" ||
                    decisaoDoJogador == "Pedra" && escolhaComputador == "Tesoura" ||
                    decisaoDoJogador == "Tesoura" && escolhaComputador == "Papel")

            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine($"Sua escolha foi {decisaoDoJogador} a escolha do computador foi {escolhaComputador}");
                Console.WriteLine("------------------------------------------------------------------------------------");

                Console.WriteLine("Você venceu");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("------------------------------------------------------------------------------------");
                Console.WriteLine($"Sua escolha foi {decisaoDoJogador} a escolha do computador foi {escolhaComputador}");
                Console.WriteLine("------------------------------------------------------------------------------------");

                Console.WriteLine("O computador venceu");
                Console.ResetColor();
            }
            Console.WriteLine("");
        }
    }
}