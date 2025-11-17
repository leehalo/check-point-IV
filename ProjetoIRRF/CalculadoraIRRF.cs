namespace ProjetoIRRF
{
    public static class CalculadoraIRRF
    {
        public static double CalcularIRRF(Funcionario f)
        {
            double salarioBase = f.CalcularSalarioBase();
            double aliquota = TabelaIRRF.GetAliquota(salarioBase);
            double deducao = TabelaIRRF.GetDeducao(salarioBase);

            return salarioBase * aliquota - deducao;
        }
    }
}
