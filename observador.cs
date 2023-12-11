class Observador
    {
        private List<string> observacoes = new List<string>(); 
        
        public void VerObserv()
        {
            Console.Clear();
            Console.WriteLine("Observações:");

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
            Console.Clear();
            Console.WriteLine("--Adicionar Observação--");
            Console.WriteLine("\nDigite a Observação a ser adicionada:");

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