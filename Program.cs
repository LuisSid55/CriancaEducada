using System;

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            String Opnião;
        Console.WriteLine();
        Console.WriteLine("--Criança Educada--");
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Qual sua opinião sobre quem não faz as tarefas? ");
        Console.ResetColor();
            Opnião = Console.ReadLine();
                { // ---Mudanças
                Opnião = Opnião.Replace("chato", "#@$%*!&");
                Opnião = Opnião.Replace("chata", "#@$%*!&");
                Opnião = Opnião.Replace("bobo", "#@$%*!&");
                Opnião = Opnião.Replace("boba", "#@$%*!&");
                Opnião = Opnião.Replace("feio", "#@$%*!&");
                Opnião = Opnião.Replace("feia", "#@$%*!&");
                Opnião = Opnião.Replace("boboca", "#@$%*!&");
                Opnião = Opnião.Replace("bocó", "#@$%*!&");
                Opnião = Opnião.Replace("tonto", "#@$%*!&");
                Opnião = Opnião.Replace("tonta", "#@$%*!&");
                Opnião = Opnião.Replace("palerma", "#@$%*!&");
                Opnião = Opnião.Replace("paspalho", "#@$%*!&");
                Opnião = Opnião.Replace("paspalha", "#@$%*!&");
                Opnião = Opnião.Replace("tantã", "#@$%*!&");
                Opnião = Opnião.Replace("panaca", "#@$%*!&");
                Opnião = Opnião.Replace("pentelho", "#@$%*!&");
                Opnião = Opnião.Replace("pentelha", "#@$%*!&");
                Opnião = Opnião.Replace("burro", "#@$%*!&");
                Opnião = Opnião.Replace("burra", "#@$%*!&");
                Opnião = Opnião.Replace("besta", "#@$%*!&");
                Opnião = Opnião.Replace("otário", "#@$%*!&");
                Opnião = Opnião.Replace("otária", "#@$%*!&");
                Opnião = Opnião.Replace("idiota", "#@$%*!&");
                Opnião = Opnião.Replace("trouxa", "#@$%*!&");
                Opnião = Opnião.Replace("vagabundo", "#@$%*!&");
                Opnião = Opnião.Replace("vagabunda", "#@$%*!&");
                Opnião = Opnião.Replace("cabeça oca", "#@$%*!&");
                Opnião = Opnião.Replace("estupido", "#@$%*!&");
                Opnião = Opnião.Replace("estupida", "#@$%*!&");
                }
        Console.WriteLine();           
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Eu sou uma criança educada, eu diria: ");
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine(Opnião);
        Console.WriteLine();
        }
    }
}
