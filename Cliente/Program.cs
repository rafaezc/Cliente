using System;

namespace Cliente
{
    class Program
    {
        class Cliente
        {

            public String nome;
            public String rg;
            public String cpf;
            public DateTime dataNascimento;
            public DateTime dataAtual;
            public decimal salario;

            public string Nome
            {
                get
                {
                    return nome;
                }
                set
                {
                    nome = value;
                }
            }

            public DateTime DataNascimento
            {
                get
                {
                    return dataNascimento;
                }
                set
                {
                    dataNascimento = value;
                }
            }

            public DateTime DataAtual
            {
                get
                {
                    return dataAtual;
                }
                set
                {
                    dataAtual = value;
                }
            }

            public String Rg
            {
                get
                {
                    return rg;
                }
                set
                {
                    rg = value;
                }
            }

            public String Cpf
            {
                get
                {
                    return cpf;
                }
                set
                {
                    cpf = value;
                }
            }

            public decimal Salario
            {
                get
                {
                    return salario;
                }
                set
                {
                    salario = value;
                }
            }

            public void Impressao()
            {
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("RG: " + rg);
                Console.WriteLine("CPF: " + cpf);
                Console.WriteLine("Data de Nascimento: " + dataNascimento.ToShortDateString());
                Console.WriteLine("Idade: " + CalcularIdade() + "anos");
                Console.WriteLine("Limite: R$ " + AvaliaCredito());
            }

            public int CalcularIdade()
            {
                int idade = DateTime.Today.Year - dataNascimento.Year;
                return idade;
            }

            public decimal AvaliaCredito()
            {
                decimal limite = Decimal.Round((salario * 0.3M) * (CalcularIdade() * 0.1M), 2);
                return limite;
            }
        }
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            c.nome = "Brian Jones";
            c.dataNascimento = new DateTime(1993, 3, 8);
            c.rg = "0235676-74";
            c.cpf = "023.651.656-12";
            c.salario = 1436;
            c.Impressao();
      

            Console.ReadKey();
        }
    }
}
