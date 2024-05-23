using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Inicializa a lista de hóspedes
List<Pessoa> listaHospedes = new List<Pessoa>();

// Adiciona novos hóspedes à lista
Pessoa hospede1 = new Pessoa(nome: "Hóspede 1");
Pessoa hospede2 = new Pessoa(nome: "Hóspede 2");

listaHospedes.Add(hospede1);
listaHospedes.Add(hospede2);

// Define a suíte a ser reservada
Suite suiteSelecionada = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma reserva e associa a suíte e os hóspedes
Reserva novaReserva = new Reserva(diasReservados: 5);
novaReserva.CadastrarSuite(suiteSelecionada);
novaReserva.CadastrarHospedes(listaHospedes);

// Mostra a quantidade de hóspedes e o custo da diária
Console.WriteLine($"Número de hóspedes: {novaReserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Preço da diária: {novaReserva.CalcularValorDiaria()}");
