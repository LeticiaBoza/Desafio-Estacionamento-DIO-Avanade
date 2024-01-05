namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Write("Digite a placa do veículo para estacionar: ");
            string placaVeiculoAdicionado = Console.ReadLine();
            veiculos.Add(placaVeiculoAdicionado);

            if (true){
                System.Console.Write($"O veículo {placaVeiculoAdicionado} foi adicionado com sucesso! ");
            }else{
                throw new Exception("Houve um problema ao acrescentar um veículo.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo para remover: ");

            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    int horas = int.Parse(Console.ReadLine());
                    decimal valorTotal = precoInicial + precoPorHora * horas; 

                veiculos.Remove(placa);

                Console.Write($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}.");
            }
            else
            {
                Console.Write("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.Write("Os veículos estacionados são:");
                    
                    for (int contador = 0; contador < veiculos.Count ; contador++)
                    {
                        string resultadoDaLista = $" ({contador + 1}) - {veiculos[contador]}";
                        System.Console.WriteLine(resultadoDaLista);
                    }
            }
            else
            {
                Console.Write("Não há veículos estacionados.");
            }
        }
    }
}
