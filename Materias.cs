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
            string confirma = "s";
            do
            {
            Console.WriteLine("--Incrementador de notas--");
            Console.WriteLine("\nDigite a unidade desejada: (1 ou 2)");
            int unidade = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nSelecione o tipo de nota: \n\n1- Teste\n2- Trabalho\n3- Prova");
            int tipoNota = Int32.Parse(Console.ReadLine());
            
            if (unidade < 1 || unidade > 2 || tipoNota < 1 || tipoNota > 3)
            {
                Console.WriteLine("Unidade ou tipo de nota inválido");
                AddNota();
            }
            Console.WriteLine("\nInsira a nota:");
            double nota = Int32.Parse(Console.ReadLine());
            Notas[unidade - 1, tipoNota - 1] = nota;
           
            Console.WriteLine("\nDeseja adicionar mais alguma nota?(S/N)");
            confirma = Console.ReadLine();
            } while (confirma == "s"|| confirma == "S");
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