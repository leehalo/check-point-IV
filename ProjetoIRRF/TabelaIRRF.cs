namespace ProjetoIRRF
{
    public static class TabelaIRRF
    {
        public static double GetAliquota(double salarioBase)
        {
            if (salarioBase <= 1903.98) return 0.0;
            if (salarioBase <= 2826.65) return 0.075;
            if (salarioBase <= 3751.05) return 0.15;
            if (salarioBase <= 4664.68) return 0.225;
            return 0.275;
        }

        public static double GetDeducao(double salarioBase)
        {
            if (salarioBase <= 1903.98) return 0.0;
            if (salarioBase <= 2826.65) return 142.80;
            if (salarioBase <= 3751.05) return 354.80;
            if (salarioBase <= 4664.68) return 636.13;
            return 869.36;
        }
    }
}
