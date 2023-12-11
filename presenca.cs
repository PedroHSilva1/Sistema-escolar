using System.Numerics;

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
            Console.Clear();
            Console.WriteLine("\nInsira o dia da presença:");
            int dia = Int32.Parse(Console.ReadLine());
            MarcarPresenca(dia);
        }

        public void MarcarFalta(int dia)
        {
            MarcarPouF(dia, 2);
        }
        public void MarcarFaltaM()
        {
            Console.Clear();
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
            Console.Clear();
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