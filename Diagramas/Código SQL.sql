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
   item = new ListViewItem(Leitor["Nome_Album"].ToString());
                item.Group = lv_Midias.Groups[Leitor["Tipo_Midia"].ToString()];
                lv_Midias.Items.Add(item);
                item.SubItems.Add(Leitor["Nome_Interprete"].ToString());
                item.SubItems.Add(Leitor["Origem_Compra"].ToString());
                item.SubItems.Add(Leitor["Nome_Autor"].ToString());
                item.SubItems.Add(Leitor["Nome_Musica"].ToString());
                item.SubItems.Add(Leitor["Observacao"].ToString());
                item.SubItems.Add(Leitor["Nota"].ToString());
                item.SubItems.Add(Leitor["Data_Album"].ToString());
                item.SubItems.Add(Leitor["Data_Compra"].ToString());




SELECT Nome_Fornecedor       AS [Fornecedor], CNPJ,
		   Telefone, Email   AS [E-mail],
		   Endereco          AS [Endereço],
		   Numero            AS [Numero], Bairro,
		   Cidade.nom_cidade AS [Cidade]
	FROM fornecedores
	INNER JOIN Cidade
	ON Fornecedores.cod_cidade = Cidade.cod_cidade
	WHERE Fornecedores.cod_cidade = @codigo
	
	
	SELECT Midias.Nome_Album,
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
                        WHERE Emprestimos.Id_Amigo = 1
