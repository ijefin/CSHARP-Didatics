class Imposto
{
    public virtual void valeAlimentacao(double salario)
    {
        System.Console.WriteLine($"Desconto normal VA: {salario * 0.1}");
    }
    public virtual void valeTransporte(double salario)
    {
        System.Console.WriteLine($"Desconto normal VT: {salario * 0.06}");
    }
}