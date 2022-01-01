using System.Globalization;

namespace ExercicioRevisao
{
    class Funcionario
    {
        public int Id {get; private set;}
        public string Nome {get; set;}
        public double Salario {get; private set;}

        public Funcionario()
        {

        }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentarSalario(double porcentagemAumento)
        {
            Salario += Salario * porcentagemAumento;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", R$" + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}