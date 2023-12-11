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
            Console.WriteLine("Boas vindas ao sistema CodeTree, faça o login");
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