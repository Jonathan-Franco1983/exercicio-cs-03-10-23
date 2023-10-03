using System;

class Program
{
    class calc
    {
        // Método para somar dois números inteiros
        public static int Somar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }
    }

    static void Main()
    {
        objCadastro cadastro = new objCadastro();

        Console.WriteLine("Digite seu nome: ");
        cadastro.nome = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome: ");
        cadastro.sobreNome = Console.ReadLine();

        Console.WriteLine("Digite seu CPF: ");
        cadastro.CPF = Console.ReadLine();

        Console.WriteLine("Digite seu Endereço: ");
        cadastro.Endereco = Console.ReadLine();

        Console.WriteLine("Digite seu número da casa: ");
        cadastro.numCasa = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Nome: {cadastro.nome} {cadastro.sobreNome}");
        Console.WriteLine($"CPF: {cadastro.CPF}");
        Console.WriteLine($"End: {cadastro.Endereco}");
        Console.WriteLine($"N°: {cadastro.numCasa}");

        Console.WriteLine("------------------------------");

        Console.WriteLine("Digite um numero:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite outro numero:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        int somaInt = calc.Somar(numero1, numero2);
        Console.WriteLine("Soma de inteiros: " + somaInt);

        Console.ReadKey();
    }
}

class objCadastro
{
    public string nome { get; set; }
    public string sobreNome { get; set; }
    public string CPF { get; set; }
    public string Endereco { get; set; }
    public int numCasa { get; set; }
}
