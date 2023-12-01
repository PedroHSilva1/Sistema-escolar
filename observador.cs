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
            Console.WriteLine("\n--Adicionar Observação--");
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