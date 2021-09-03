USE M_Rental;
GO

SELECT * FROM Empresa;
GO

SELECT * FROM Cliente;
GO

SELECT * FROM Marca;
GO

SELECT * FROM Modelo;
GO

SELECT * FROM Veiculo;
GO

SELECT * FROM Aluguel;
GO

SELECT dataRetirada, dataDevolucao, nomeCliente, sobrenomeCliente, nomeModelo
FROM Aluguel
LEFT JOIN Cliente
ON Aluguel.idCliente = Cliente.idCliente
LEFT JOIN Veiculo
ON Aluguel.idVeiculo = Veiculo.idVeiculo
LEFT JOIN Modelo
ON Veiculo.idModelo = Modelo.idModelo;
GO

SELECT nomeCliente, sobrenomeCliente, dataRetirada, dataDevolucao, nomeModelo
FROM Aluguel
RIGHT JOIN Cliente
ON Aluguel.idCliente = Cliente.idCliente
LEFT JOIN Veiculo
ON Aluguel.idVeiculo = Veiculo.idVeiculo
LEFT JOIN Modelo
ON Veiculo.idModelo = Modelo.idModelo
WHERE nomeCliente = 'Lucas';
GO