class Math
{

    public static string mensagem = "Atributos estáticos nos permitem trabalhar sem instânciar objetos.";
    public static void soma(int a, int b)
    {
        System.Console.WriteLine(a + b);
    }
    public static void multiplica(int a, int b)
    {
        System.Console.WriteLine(a * b);
    }
    public static void divide(int a, int b)
    {
        System.Console.WriteLine(a / b);
    }
    public static void subtrai(int a, int b)
    {
        System.Console.WriteLine(a - b);
    }
}