// método Main - implícito

using HerancaCliente;

Cliente cliente = new Cliente(1, "Ana", "Rua Terezina, 75\n");
cliente.Mostrar();

ClienteFisico clienteFisico = new ClienteFisico(2, "Paulo", "Rua Aracaju, 13", 123,1000);
clienteFisico.Mostrar();

ClienteJuridico clienteJuridico = new ClienteJuridico(3, "Empresa S/A", "Av.Brasil", 123, 000666);
clienteJuridico.Mostrar();