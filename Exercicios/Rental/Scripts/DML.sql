  
Use M_Rental;
GO

INSERT INTO Empresa(nomeEmpresa)
VALUES ('Localiza');
GO

INSERT INTO Cliente(nomeCliente, sobrenomeCliente, CPF)
VALUES ('Lucas', 'Medina', '87512289212'), ('Claudio', 'Santos', '84751728634');
GO

INSERT INTO Marca(nomeMarca)
VALUES ('Ford'), ('Fiat'), ('Chevrolet');
GO

INSERT INTO Modelo(idMarca, nomeModelo, anoLancamento)
VALUES (3, 'Camaro', '2020-12-06'), (1, 'Ecosport', '2020-05-21'), (2, 'Mobi', '2019-01-19');
GO

INSERT INTO Veiculo(idEmpresa, idModelo, corVeiculo)
VALUES (1, 1, 'Branco'), (1, 2, 'Preto'), (1, 3, 'Cinza');
GO

INSERT INTO Aluguel(IdVeiculo, IdCliente, DataRetirada, DataDevolucao)
VALUES (1, 1, '2021-08-03', '2021-08-10'), (2, 2, '2021-08-28', '2021-08-31');
GO
