using System;

namespace ProjetoIRRF
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(3000.00);

            double inss = funcionario.CalcularINSS();
            double salarioBase = funcionario.CalcularSalarioBase();
            double irrf = CalculadoraIRRF.CalcularIRRF(funcionario);

            Console.WriteLine($"Salário Bruto: {funcionario.SalarioBruto:F2}");
            Console.WriteLine($"INSS: {inss:F2}");
            Console.WriteLine($"Salário Base: {salarioBase:F2}");
            Console.WriteLine($"IRRF: {irrf:F2}");
        }
    }
}
