using System.Globalization;
using System.Security.Cryptography.X509Certificates;

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
            Console.WriteLine("\nInsira a idade de " + this.nome);
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
            Console.WriteLine("Contato: " + this.contato);
            Console.WriteLine("Série: " + this.serie + "° ano " + this.nivel);
            Console.WriteLine("Turno: " + this.turno);
            Console.WriteLine("Turma: " + this.turma);

            Console.WriteLine("\nAs informações estão corretas?(s/n)");
            confirmacao = Console.ReadLine();
            if (confirmacao != "s")
            {
                Cadastrar();
            }
            else
            {
                Console.WriteLine("\nCadastro Realizado!");
            }

        }
    }

    internal class CadastroFuncionario : Cadastro
    {

        public string funcao { get; set; }
        public string materia { get; set; }


        public override void Cadastrar()
        {
            Console.Clear();
            Console.WriteLine("Iniciando cadastro para funcionario");
            Console.WriteLine("\nInsira o nome do funcionario");
            this.nome = Console.ReadLine();

            Console.WriteLine("\nInsira a idade de " + this.nome);
            this.idade = Int32.Parse(Console.ReadLine());
            DefinirCpf();
            Console.WriteLine("\nDigite um número para contato");
            this.contato = Console.ReadLine();
            Console.WriteLine("\nselecione a funcao a ser exercida: 1- coordenação. 2- Professor");
            int selecao = Int32.Parse(Console.ReadLine());

            switch (selecao)
            {
                case 1:
                    this.funcao = "Coordenador";
                    break;
                case 2:
                    this.funcao = "Professor";
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            if (this.funcao == "Professor")
            {
                Console.WriteLine("\nInsira a matéria a exercer:");
                this.materia = Console.ReadLine();
            }

            Console.Clear();

            Console.WriteLine("Confirme as informações do funcionario!");
            Console.WriteLine("\nNome: " + this.nome);
            Console.WriteLine("Idade: " + this.idade);
            Console.WriteLine("CPF: " + this.Cpf);
            Console.WriteLine("Contato: " + this.contato);
            Console.WriteLine("Função: " + this.funcao);
            if (this.funcao == "Professor")
            {
                Console.WriteLine("Matéria(s): " + this.materia);
            }

            Console.WriteLine("\nAs informações estão corretas?(s/n)");
            string confirmacao = Console.ReadLine();
            if (confirmacao != "s")
            {
                Cadastrar();
            }
            else
            {
                Console.WriteLine("\nCadastro Realizado!");
            }
            
        }

    }

    class LoginWIP
    {
        private string nomeAluno = "aluno";
        private string senhaAluno = "111";
        private string nomeCoor = "adm";
        private string senhaCoor = "222";
        private string nomeProf = "prof";
        private string senhaProf = "333";
        public string confUser { get; set; }
        public string confPassw { get; set; }

        public void Logar()
        {
            Console.WriteLine("Bem vindo ao sistema CodeTree, faça o login");
            Console.WriteLine("\nInsira o seu nome de usuário:");
            confUser = Console.ReadLine();
            Console.WriteLine("\nInsira sua senha:");
            confPassw = Console.ReadLine();

            if (confUser == nomeAluno && confPassw == senhaAluno)
            {
                Console.Clear();
                Console.WriteLine("Boas vindas " + nomeAluno);
                /* aqui haverá VerNotas;;, Ver Calendario, VerObservacoes, VerPresenças;;*/
            }else 
            if (confUser == nomeCoor && confPassw == senhaCoor)
            {
                Console.Clear();
                Console.WriteLine("Boas vindas Coordenador(a)");
                /* aq haverá Cadastro de alunos e funcionarios;;, LançarObservacoes, AjustarCalendario*/
            }else
            if (confUser == nomeProf && confPassw == senhaProf)
            {
                
                Console.Clear();
                Console.WriteLine("Boas vindas Professor(a)");
                /*Aq haverá MarcarPresença;;, LançarObservacoes,AdcionarNota;;*/
            }
             else
             {
                Console.Clear();
                Console.WriteLine("Login ou senha incorretos, Tente novamente.\n");
                Logar();
             }

        }

    }

    class Materias
    {
        public string Nome { get; set; }
        public double[,] Notas { get; } = new double[2, 3];

        public Materias(string nome)
        {
            Nome = nome;
        }



        public void VerNotas()
        {
            Console.Clear();
            
            Console.WriteLine("Notas de "+Nome+":");
            /*trocar semestre para unidade*/
            for (int semestre = 0; semestre < 2; semestre++)
            {
                Console.WriteLine("Semestre " + (semestre + 1) + ":");
                for (int tipoNota = 0; tipoNota <3; tipoNota++)
                {
                    string nomeNota = PegarNomeNota(tipoNota);
                    Console.WriteLine($"{nomeNota}: {Notas[semestre, tipoNota]}");
                }
                Console.WriteLine();
            }

        }

        public void AddNota(int semestre,int tipoNota,double nota)
        {
            if (semestre <1||semestre>2 ||tipoNota<1 ||tipoNota>3)
            {
                Console.WriteLine("Semestre ou tipo de nota inválido");
                return;
            }
            Notas[semestre - 1, tipoNota - 1] = nota;
        }

        private string PegarNomeNota(int tipoNota)
        {
            switch (tipoNota)
            {
                case 0:
                    return "Teste";
                case 1:
                    return "Trabalho";
                case 2:
                    return "Prova";
                default:
                    return "Desconhecido";
            }
        }

        public void Demonstrar()
        {
            Materias matematica = new Materias("matemática");
            matematica.AddNota(1, 1, 5.5);
            matematica.AddNota(1, 2, 7.5);
            matematica.AddNota(1, 3, 10);
            matematica.AddNota(2, 1, 8.5);
            matematica.AddNota(2, 2, 3.5);
            matematica.AddNota(2,3, 10);

            matematica.VerNotas();

             
        }


    }

    class Presenca
    {
        private int[,] matrizPresenca; /*1- presente, 2- falta, 3-especial*/
        private int diasUteis;

        public Presenca(int diasUteis)
        {
            this.matrizPresenca = new int[diasUteis, 3];
            this.diasUteis = diasUteis;
        }

        public void MarcarPresenca(int dia)
        {
            MarcarPouF(dia, 1);
        }
        public void MarcarFalta(int dia)
        {
            MarcarPouF(dia, 2);
        }
        public void MarcarEspecial(int dia)
        {
            MarcarPouF(dia, 3);
        }

        private void MarcarPouF(int dia, int tipo)
        {
            if (dia >= 1 && dia <= diasUteis)
            {
                matrizPresenca[dia - 1, tipo - 1]++;
                Console.WriteLine($"Dia {dia}: {(tipo == 1 ? "Presente" : "Falta")}");
            }
            else
            {
                Console.WriteLine("Dia inválido");
            }
        }

        public double PorcentagemPresenca()
        {
            int totalPresenca = 0;

            for (int dia = 0; dia < diasUteis; dia++)
            {
                totalPresenca += matrizPresenca[dia, 0];
            }

            int totalFalta = 0;

            for (int dia = 0; dia < diasUteis; dia++)
            {
                totalFalta += matrizPresenca[dia, 1];
            }
            int totalEspecial = 0;

            for (int dia = 0; dia < diasUteis; dia++)
            {
                totalEspecial += matrizPresenca[dia, 2];
            }

            int ausencias = totalFalta - totalEspecial;
            double porcentagemPresenca = (double)totalPresenca / (diasUteis - ausencias ) * 100;

            Console.WriteLine($"\nTotal de presenças: {totalPresenca}");
            Console.WriteLine($"Total de faltas: {totalFalta}");
            Console.WriteLine($"Total de faltas especiais: {totalEspecial}");
            Console.WriteLine($"Porcentagem de presença: {porcentagemPresenca}%");
            return porcentagemPresenca;
        }

        public void ListasDeFaltas()
        {
            Console.WriteLine("\nDias de falta:");

            for (int dia = 0; dia < diasUteis; dia++)
            {
                if (matrizPresenca[dia,1]>0)
                {
                    Console.WriteLine($"dia {dia+1}");
                }
            }
        }

        public void demo()
        {
            Console.Clear();
            Presenca presenca = new Presenca(6);
            presenca.MarcarPresenca(1);
            presenca.MarcarFalta(2);
            presenca.MarcarEspecial(3);
            presenca.MarcarFalta(4);
            presenca.MarcarPresenca(5);
            presenca.MarcarPresenca(6);

            double porcentagemPresenca = presenca.PorcentagemPresenca();

            presenca.ListasDeFaltas();
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Presenca presenca = new Presenca(20);
            presenca.demo();
        }
    }
}
