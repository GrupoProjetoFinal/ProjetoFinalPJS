CREATE DATABASE ControleDeMidias
GO

USE ControleDeMidias
GO

CREATE TABLE Midias 
(
	Id_Midia INT PRIMARY KEY IDENTITY(1,1),
	Foto_Album IMAGE,
	Nome_Interprete VARCHAR(50),
	Nome_Autor VARCHAR(200),
	Nome_Musica VARCHAR(50),
	Nome_Album VARCHAR(50),
	Data_Album DATE,
	Data_Compra DATE,
	Origem_Compra VARCHAR(50),
	Tipo_Midia VARCHAR(10)NOT NULL,
	Observacao VARCHAR(200),
	Nota VARCHAR(3)
)
GO

CREATE TABLE Amigos 
(
	Id_Amigo INT IDENTITY(1,1) PRIMARY KEY,
	Nome VARCHAR(50)NOT NULL,
	Telefone VARCHAR(20),
	Email VARCHAR(50),
	Observacao VARCHAR(200)
)
GO

CREATE TABLE Emprestimos 
(
	Id_Emprestimo INT IDENTITY(1,1) PRIMARY KEY,
	Id_Midia INT,
	Id_Amigo INT,
	Data_Emprestimo DATE,
	Quantidade_Dias INT,
	FOREIGN KEY(Id_Midia) REFERENCES Midias (Id_Midia),
	FOREIGN KEY(Id_Amigo) REFERENCES Amigos (Id_Amigo)
)
GO

