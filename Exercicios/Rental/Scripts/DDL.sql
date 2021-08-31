CREATE DATABASE M_Rental;
GO

USE M_Rental;
GO

CREATE TABLE Empresa(
	IdEmpresa INT PRIMARY KEY IDENTITY(1,1),
	NomeEmpresa VARCHAR(30) NOT NULL
);
GO

CREATE TABLE Marca(
	IdMarca INT PRIMARY KEY IDENTITY(1,1),
	NomeMarca VARCHAR(14) NOT NULL UNIQUE
);
GO

CREATE TABLE Modelo(
	IdModelo INT PRIMARY KEY IDENTITY(1,1),
	IdMarca INT FOREIGN KEY REFERENCES Marca(IdMarca),
	NomeModelo VARCHAR(12),
	AnoLancamento DATE
);
GO


CREATE TABLE Veiculo(
	IdVeiculo INT PRIMARY KEY IDENTITY(1,1),
	IdEmpresa INT FOREIGN KEY REFERENCES Empresa(IdEmpresa),
	IdModelo INT FOREIGN KEY REFERENCES Modelo(IdModelo),
	CorVeiculo VARCHAR(12) NOT NULL
);
GO

CREATE TABLE Cliente(
	IdCliente INT PRIMARY KEY IDENTITY(1,1),
	NomeCliente VARCHAR(20) NOT NULL,
	SobrenomeCliente VARCHAR(30),
	CPF CHAR(11) NOT NULL
);
GO

CREATE TABLE Aluguel(
	IdAluguel INT PRIMARY KEY IDENTITY(1,1),
	IdVeiculo INT FOREIGN KEY REFERENCES Veiculo(IdVeiculo),
	IdCliente INT FOREIGN KEY REFERENCES Cliente(IdCliente),
	DataRetirada DATE,
	DataDevolucao DATE
);
GO
