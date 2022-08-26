namespace MediatRSample.Application.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade, char sexo)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
    }
}