CREATE DATABASE ControleDeMidias
GO

USE ControleDeMidias
GO

CREATE TABLE Midias 
(
	Id_Midia INT PRIMARY KEY IDENTITY(1,1),
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
insert into midias values
('Diego','Deig germano','Sometimes you','naumm sei','2005-02-02','2005-02-02','JDSKHFKSJD','carchar','jcdshfdkf','02');
go
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
SELECT	  Midias.Nome_Album,
		  Midias.Nome_Interprete, 
		  Midias.Origem_Compra,  
		  Midias.Nome_Autor, 
		  Midias.Nome_Musica, 
		  Midias.Observacao, 
		  Midias.Nota, 
		  Midias.Data_Album, 
		  Midias.Data_Compra,
		  Midias.Tipo_Midia
FROM Emprestimos  
INNER JOIN Midias 
ON Emprestimos.Id_Midia = Midias.Id_Midia 
WHERE Emprestimos.Id_Amigo = 8
ORDER BY 


INSERT INTO Amigos([Nome],[Telefone],[Email],[Observacao]) VALUES('diego','teste@skdsf.com','(12)-3645-3832','Naumm temmm');
go

INSERT INTO Emprestimos VALUES ( 11 , 19, GETDATE(),0)

select * from Emprestimos

select * from Midias

select * from Midias

