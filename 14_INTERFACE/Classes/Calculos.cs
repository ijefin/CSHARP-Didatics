using System;

class Calculos : IPadrao
{
    public void somar(int n1, int n2)
    {
        System.Console.WriteLine(n1 + n2);
    }
    public void subtrair(int n1, int n2)
    {
        System.Console.WriteLine(n1 - n2);
    }
}