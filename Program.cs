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

    public abstract class Retorno
    {
        public int escolha;
        public string confirma;

        public abstract void Usuario();

        public void Retornar()
        {
            Console.WriteLine("\nDeseja acessar outra aba?(s/n)");
            confirma = Console.ReadLine();
            if (confirma == "s" || confirma == "S")
            {
                Usuario();
            }
            if (confirma == "n" || confirma == "N")
            {
                Sair();
            }

        }
        public void Sair()
        {
            Console.Clear();
            Console.WriteLine("\nO sistema irá ser encerrado. Tem certeza que quer encerrar?(s/n");
            confirma = Console.ReadLine();
            if (confirma == "s" || confirma == "S")
            {
                Console.WriteLine("\nAté mais!");
                Environment.Exit(0);
            }
            else if (confirma == "n" || confirma == "N")
            {
                Usuario();
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("Opção inválida");
                Sair();
                
            }
            

        }
    }

    class Aluno:Retorno
    {

        public override void Usuario() {
            
            
            Console.Clear();
            Console.WriteLine("Boas vindas ao portal do aluno!");
            Console.WriteLine("Selecione a opção para a função desejada:");
            Console.WriteLine("\n1- Verificar suas notas.\n2- Verificar calendário de presenças.\n3-Ver Observações.\n4-Encerrar sistema.");
            escolha = Int32.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Materias materias01 = new Materias("");
                    materias01.Demonstrar();
                    Retornar();

                    break;
                case 2:
                    Presenca presenca01 = new Presenca(1);
                    presenca01.demo();
                    Retornar();
                    
                    break;
                case 3:
                    Observador observador01 = new Observador();
                    observador01.VerObserv();
                    Retornar();
                    break;

                case 4:
                    Sair();
                    break;
                default:
                    Usuario();
                    break;
            }

        }

    }

    class Professor:Retorno
    {
        public override void Usuario()
        {

            Console.Clear();
            Console.WriteLine("Boas vindas ao portal do professor!");
            Console.WriteLine("Selecione a opção para a função desejada:");
            Console.WriteLine("\n1- Lançar notas.\n2- Adicionar falta ou presença.\n3-lançar Observações.\n4-Encerrar sistema.");
            escolha = Int32.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Materias materias01 = new Materias("");
                    materias01.AddNota();
                    Retornar();
                    
                    break;
                case 2:
                    Presenca presenca01 = new Presenca(1);
                    Console.Clear();
                    Console.WriteLine("Presença");
                    Console.WriteLine("\nSelecione o que você deseja\n\n1- Adicionar presença.\n2- Adicionar falta.\n3- Adicionar falta justificada.\n4- Encerrar sistema");
                    escolha = Int32.Parse(Console.ReadLine());

                    switch (escolha)
                    {
                        case 1:
                            presenca01.MarcarPresencaM();
                            Retornar();
                            break;
                        case 2:
                            presenca01.MarcarFaltaM();
                            Retornar();
                            break;
                        case 3:
                            presenca01.MarcarEspecialM();
                            Retornar();
                            break;
                        case 4:
                            Sair();
                            break;
                        default:
                            Console.WriteLine("Opçao invalida");
                            Retornar();
                            break;
                    }
                    Retornar();

                    break;
                case 3:
                    Observador observador01 = new Observador();
                    observador01.AddObserv();
                    Retornar();
                    break;
                case 4:
                    Sair();
                    break;
                default:
                    Usuario();
                    break;
            }

        }


    }

    class Coordenador : Retorno
    {

        public override void Usuario()
        {


            Console.Clear();
            Console.WriteLine("Boas vindas ao portal do Coordenador!");
            Console.WriteLine("Selecione a opção para a função desejada:");
            Console.WriteLine("\n1- Cadastrar aluno.\n2- Cadastrar Funcionario.\n3-Lançar Observações.\n4-Encerrar sistema.");
            escolha = Int32.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    CadastroAluno cadastroAluno = new CadastroAluno();
                    cadastroAluno.Cadastrar();
                    Retornar();

                    break;
                case 2:
                    CadastroFuncionario cadastroFuncionario = new CadastroFuncionario();
                    cadastroFuncionario.Cadastrar();
                    Retornar();

                    break;
                case 3:
                    Observador observador01 = new Observador();
                    observador01.AddObserv();
                    Retornar();
                    break;

                case 4:
                    Sair();
                    break;
                default:
                    Usuario();
                    break;
            }

        }

    }

    class Login
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
                Aluno aluno01 = new Aluno();
                aluno01.Usuario();
            }
            else
            if (confUser == nomeCoor && confPassw == senhaCoor)
            {
                Console.Clear();
                Console.WriteLine("Boas vindas Coordenador(a)");
                Coordenador coordenador01 = new Coordenador();
                coordenador01.Usuario();
                
            }
            else
            if (confUser == nomeProf && confPassw == senhaProf)
            {

                Console.Clear();
                Console.WriteLine("Boas vindas Professor(a)");
                Professor professor01 = new Professor();
                professor01.Usuario();

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

            Console.WriteLine("Notas de " + Nome + ":");
            
            for (int unidade = 0; unidade < 2; unidade++)
            {
                Console.WriteLine("Unidade " + (unidade + 1) + ":");
                for (int tipoNota = 0; tipoNota < 3; tipoNota++)
                {
                    string nomeNota = PegarNomeNota(tipoNota);
                    Console.WriteLine($"{nomeNota}: {Notas[unidade, tipoNota]}");
                }
                Console.WriteLine();
            }

        }

        public void AddNota()
        {
            /*Adicionar um DO WHILE para perguntar por mais notas*/
            Console.Clear();
            Console.WriteLine("\nIncrementador de nota");
            Console.WriteLine("\nDigite a unidade desejada: (1 ou 2)");
            int unidade = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Selecione o tipo de nota: \n\n1-Teste\n2-Trabalho\nProva");
            int tipoNota = Int32.Parse(Console.ReadLine());
            
            if (unidade < 1 || unidade > 2 || tipoNota < 1 || tipoNota > 3)
            {
                Console.WriteLine("Unidade ou tipo de nota inválido");
                AddNota();
            }
            Console.WriteLine("Insira a nota:");
            double nota = Int32.Parse(Console.ReadLine());
            Notas[unidade - 1, tipoNota - 1] = nota;
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
            matematica.Notas[0, 0] = 5.5; 
            matematica.Notas[0, 1] = 7.5; 
            matematica.Notas[0, 2] = 10.0; 

            matematica.Notas[1, 0] = 8.5; 
            matematica.Notas[1, 1] = 3.5; 
            matematica.Notas[1, 2] = 10.0; 

            matematica.VerNotas();


        }


    }

    class Presenca
    {
        private int[,] matrizPresenca; 
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

        public void MarcarPresencaM()
        {
            Console.WriteLine("Insira o dia da presença:");
            int dia = Int32.Parse(Console.ReadLine());
            MarcarPresenca(dia);
        }

        public void MarcarFalta(int dia)
        {
            MarcarPouF(dia, 2);
        }
        public void MarcarFaltaM()
        {
            Console.WriteLine("Insira o dia da falta:");
            int dia = Int32.Parse(Console.ReadLine());
            MarcarFalta(dia);
        }

        public void MarcarEspecial(int dia)
        {
            MarcarPouF(dia, 3);
        }

        public void MarcarEspecialM()
        {
            Console.WriteLine("Insira o dia da falta justificada:");
            int dia = Int32.Parse(Console.ReadLine());
            MarcarEspecial(dia);
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
            double porcentagemPresenca = (double)totalPresenca / (diasUteis - ausencias) * 100;

            Console.WriteLine($"\nTotal de presenças: {totalPresenca}");
            Console.WriteLine($"Total de faltas: {totalFalta}");
            Console.WriteLine($"Total de faltas especiais: {totalEspecial}");
            Console.WriteLine($"Porcentagem de presença: {porcentagemPresenca}%");
            return porcentagemPresenca;
        }

        public void ListasDeFaltas()
        {
            Console.WriteLine("\nDias de falta sem justificativa:");

            for (int dia = 0; dia < diasUteis; dia++)
            {
                if (matrizPresenca[dia, 1] > 0)
                {
                    Console.WriteLine($"dia {dia + 1}");
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

    class Observador
    {
        private List<string> observacoes = new List<string>(); 
        
        public void VerObserv()
        {
            Console.WriteLine("\nObservações:");

            if (observacoes.Count == 0)
            {
                Console.WriteLine("Nenhuma observação disponível.");
            }
            else
            {
                for (int i = 0; i < observacoes.Count; i++)
                {
                    Console.WriteLine($"{i+1}: {observacoes[i]}");
                }
            }
            
        }

        public void AddObserv()
        {
            Console.WriteLine("\nAdicionar Observação:");
            Console.WriteLine("Digite a Observação:");

            string novaObservacao = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(novaObservacao))
            {
                observacoes.Add(novaObservacao);
                Console.WriteLine("\nObservação adicionada com sucesso");
            }
            else
            {
                Console.WriteLine("Observação inválida. Não foi adicionada!");
            }
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();
            login.Logar();
        }
    }
}