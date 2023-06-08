using System;
class Pessoa
{
    public double peso;

    public double altura;

    public double calculaImc()
    {
        return peso / (altura * altura);
    }

    public void validaImc(double imc)
    {
        string resultado;

        if (imc < 18.5)
        {
            resultado = "ABAIXO DO PESO";
        }
        else if (imc < 24.9)
        {
            resultado = "PESO NORMAL";
        }
        else if (imc <= 29.9)
        {
            resultado = "ACIMA DO PESO";
        }
        else if (imc < 34.9)
        {
            resultado = "OBESIDADE NÍVEL I";
        }
        else if (imc < 39.9)
        {
            resultado = "OBESIDADE NÍVEL II";
        }
        else
        {
            resultado = "OBESIDADE NÍVEL III";
        }

        Console.WriteLine(resultado);
    }
}