
class Pessoa
{
    //atributos
    public string nome;
    public string cpf;
    public int idade;
    public string email;

    public void mostrarDados()
    {
        System.Console.WriteLine($"Olá {nome}, você tem {idade} anos! O email cadastrado é {email}.");
    }

}