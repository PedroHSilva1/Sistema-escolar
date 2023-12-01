
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
            Console.WriteLine("\nO sistema irá ser encerrado. Tem certeza que quer encerrar?(s/n)");
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
            Console.WriteLine("\n1- Verificar suas notas.\n2- Verificar calendário de presenças.\n3- Ver Observações.\n4- Encerrar sistema.");
            escolha = Int32.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Materias materias01 = new Materias("");
                    materias01.Demonstrar();
                    Retornar();

                    break;
                case 2:
                    Presenca presenca01 = new Presenca(6);
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
            Console.WriteLine("\n1- Lançar notas.\n2- Adicionar falta ou presença.\n3- Lançar Observações.\n4- Encerrar sistema.");
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
            Console.WriteLine("\n1- Cadastrar aluno.\n2- Cadastrar Funcionario.\n3- Lançar Observações.\n4- Encerrar sistema.");
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