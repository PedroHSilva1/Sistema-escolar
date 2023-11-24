using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Sistema
{
    internal abstract class Cadastro
    {
        public string nome { get; set; }
        public double idade { get; set; }
        private string cpf { get; set; }
        public string contato { get; set; }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public abstract void Cadastrar();

        public void DefinirCpf()
        {
            Console.WriteLine("\nDigite o CPF");
            cpf = Console.ReadLine();
        }

    }

    internal class CadastroAluno : Cadastro
    {
        public string serie { get; set; }
        public string turno { get; set; }
        public string turma { get; set; }
        public string nivel { get; set; }
        
        public override void Cadastrar() 
        {
            
            Console.Clear();
            Console.WriteLine("Iniciando cadastro para alunos");
            Console.WriteLine("\nInsira o nome do aluno");
            this.nome = Console.ReadLine();
            Console.WriteLine("\nInsira a idade de "+ this.nome);
            this.idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nPossue cpf? (s/n)");
            string confirmacao = Console.ReadLine();
        
            if (confirmacao == "s")
            {
              DefinirCpf();
            }

            Console.WriteLine("\nDigite um número para contato");
            this.contato = Console.ReadLine();
            Console.WriteLine("\nDigite a Série do aluno");
            this.serie = Console.ReadLine();
            Console.WriteLine("\nDigite o nível do aluno");
            this.nivel = Console.ReadLine();
            Console.WriteLine("\nDigite o turno do aluno");
            this.turno = Console.ReadLine();
            Console.WriteLine("\nDigite a turma do aluno");
            this.turma = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Confirme as informações do aluno!");
            Console.WriteLine("\nNome: " + this.nome);
            Console.WriteLine("Idade: " + this.idade);
            Console.WriteLine("CPF: " + this.Cpf);
            Console.WriteLine("Contato: "+ this.contato);
            Console.WriteLine("Série: " + this.serie + "° ano " +this.nivel);
            Console.WriteLine("Turno: " + this.turno);
            Console.WriteLine("Turma: " + this.turma);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           CadastroAluno cadastroAluno = new CadastroAluno();
           cadastroAluno.Cadastrar();
        }
    }
}