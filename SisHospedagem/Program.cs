using System.Text;
using SisHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

#region CasoTeste01
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
#endregion

#region CasoTeste02
Pessoa p3 = new Pessoa(nome: "Hóspede 3");

hospedes.Add(p3);

Reserva reserva2 = new Reserva(diasReservados: 7);
reserva2.CadastrarSuite(suite);
reserva2.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva2.CalcularValorDiaria()}");
#endregion