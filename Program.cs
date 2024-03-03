using System;

namespace atividade3
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Caro aluno digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a terceira nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            double resultado = mediaAluno(nota1 , nota2 , nota3);

            if (resultado >= 60)
            {
                Console.WriteLine($"Parabens aluno : {nome}, você foi aprovado e sua pontuação foi: {resultado}");

            }
            else
            {
                double nota = 60 - resultado;
                Console.WriteLine($"Reprovado e faltou : {nota} pontos");
            }
        }

        public static double mediaAluno(double nota1, double nota2, double nota3)
        {
        double peso1 = 0.3;
        double peso2 = 0.3;
        double peso3 = 0.35;

    double resultado = (peso1 * nota1 + peso2 * nota2 + peso3 * nota3) / (peso1 + peso2 + peso3);
    return resultado;
            return resultado;
        }
    }
}
