using System;
using System.Collections.Generic;

namespace ExercicioRevisao
{
    class Empresa
    {
        private List<Funcionario> _funcionarios = new List<Funcionario>();
        public string Nome {get; set;}

        public Empresa()
        {

        }

        public Empresa(string nome)
        {
            Nome = nome;
        }
        
        public void ContratarFuncionario(int id, string nome, double salario)
        {
            _funcionarios.Add(new Funcionario(id, nome, salario));
        }

        public void DispensarFuncionario(int id)
        {
            _funcionarios.RemoveAll(func => func.Id == id);        
        }

        public bool FuncionarioExiste(int id)
        {
            Funcionario funcionarioBuscado = _funcionarios.Find(func => func.Id == id);
            bool existe = funcionarioBuscado != null;
            return existe;
        }

        public void AumentarSalario(int id, double porcentagem)
        {
            _funcionarios.Find(func => func.Id == id).AumentarSalario(porcentagem);
        }

        public double MediaSalarial()
        {
            if(_funcionarios.Count == 0)
            {
                return 0;
            }

            double totalSalarios = 0;
            foreach(Funcionario func in _funcionarios)
            {
                totalSalarios += func.Salario;
            }

            return totalSalarios / _funcionarios.Count;
        }

        public void ListarFuncionarios()
        {
            foreach(Funcionario func in _funcionarios)
            {
                Console.WriteLine(func);
            }
        }
    }
}