namespace ProjetoIRRF
{
    public class Funcionario
    {
        public double SalarioBruto { get; private set; }

        public Funcionario(double salarioBruto)
        {
            SalarioBruto = salarioBruto;
        }

        public double CalcularINSS()
        {
            if (SalarioBruto <= 1302.00)
                return SalarioBruto * 0.075;
            else if (SalarioBruto <= 2571.29)
                return SalarioBruto * 0.09;
            else if (SalarioBruto <= 3856.94)
                return SalarioBruto * 0.12;
            else
                return SalarioBruto * 0.14;
        }

        public double CalcularSalarioBase()
        {
            return SalarioBruto - CalcularINSS();
        }
    }
}
