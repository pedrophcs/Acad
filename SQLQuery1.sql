USE CadastroAcademia;

CREATE TABLE PROFESSORES(
	ID INT PRIMARY KEY IDENTITY (1,1),
	NOME NVARCHAR(100) NOT NULL,
	EMAIL NVARCHAR(100) NOT NULL UNIQUE,
	SENHA NVARCHAR(20) NOT NULL
	);

INSERT INTO PROFESSORES(NOME,EMAIL,SENHA) 
VAlUES ('Pedro Cordeiro', 'pedroob555@gmail.com', '1234');

INSERT INTO PROFESSORES (NOME,EMAIL,SENHA)
VALUES ('Henrique','teste','123');

CREATE TABLE Modalidades(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome NVARCHAR(50) NOT NULL UNIQUE
	);

CREATE TABLE Alunos(
	Id INT PRIMARY KEY IDENTITY(1,1),
	Nome NVARCHAR(100) NOT NULL,
	DataNascimento DATE NOT NULL,
	Email NVARCHAR(100),
	Telefone NVARCHAR(20),
	Peso DECIMAL(5,2),
	Altura DECIMAL(4,2),
	Objetivo NVARCHAR(100),
	ModalidadeID INT NOT NULL,
	FOREIGN KEY (ModalidadeID) REFERENCES Modalidades(id)
	);

	INSERT INTO Modalidades(Nome) VALUES ('Musculação');
	INSERT INTO Modalidades(Nome) VALUES ('Ginástica');
	INSERT INTO Modalidades(Nome) VALUES ('Zumba');
	INSERT INTO Modalidades(Nome) VALUES ('Boxe');
	INSERT INTO Modalidades(Nome) VALUES ('Muay Thai');

	INSERT INTO Planos(Nome) VALUES ('Mensal');
	INSERT INTO Planos(Nome) VALUES ('Semestral');
	INSERT INTO Planos(Nome) VALUES ('Anual');


EXEC sp_rename 'Alunos.Objetivo', 'Plano', 'COLUMN';

ALTER TABLE Alunos
DROP COLUMN Plano;

CREATE TABLE PLANOS(
Id INT PRIMARY KEY IDENTITY(1,1),
Nome NVARCHAR(10) NOT NULL,
);


ALTER TABLE Alunos
ADD PlanosID INT NOT NULL;

ALTER TABLE Alunos
ADD CONSTRAINT FK_ALUNOS_PLANO
FOREIGN KEY (PlanosID) REFERENCES Planos(Id);

INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID)
VALUES ('Pedro Henrique Cordeiro da Silva', '21/10/1999', 'ph.cordeiro555@gmail.com', '19988302201', 123, 1.95, 1, 1);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Ana Clara Souza', '05/03/1995', 'ana.souza@example.com', '11987654321', 65, 1.68, 2, 1);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Bruno Oliveira', '12/11/1988', 'bruno.oliveira@example.com', '21991234567', 80, 1.82, 3, 2);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Carla Mendes', '22/07/2000', 'carla.mendes@example.com', '31999887766', 58, 1.60, 1, 3);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Daniel Ferreira', '18/01/1992', 'daniel.ferreira@example.com', '41998765432', 75, 1.75, 2, 2);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Eduarda Lima', '09/09/1997', 'eduarda.lima@example.com', '51997654321', 62, 1.65, 3, 1);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Felipe Costa', '30/04/1985', 'felipe.costa@example.com', '61996543210', 90, 1.85, 1, 3);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Gabriela Rocha', '15/06/1990', 'gabriela.rocha@example.com', '71995432109', 55, 1.62, 2, 1);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Hugo Santos', '25/12/1994', 'hugo.santos@example.com', '81994321098', 78, 1.78, 3, 2);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Isabela Martins', '07/08/1998', 'isabela.martins@example.com', '91993210987', 60, 1.70, 1, 1);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('João Pedro Silva', '14/02/1987', 'joao.silva@example.com', '11992109876', 85, 1.80, 2, 3);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Karla Mendes', '03/11/1993', 'karla.mendes@example.com', '21991098765', 70, 1.66, 3, 2);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Leonardo Almeida', '28/05/1991', 'leonardo.almeida@example.com', '31990987654', 88, 1.83, 1, 1);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Mariana Ferreira', '21/07/1996', 'mariana.ferreira@example.com', '41990876543', 58, 1.67, 2, 2);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Nathan Silva', '10/10/1999', 'nathan.silva@example.com', '51990765432', 77, 1.79, 3, 3);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Olívia Souza', '05/04/1992', 'olivia.souza@example.com', '61990654321', 63, 1.64, 1, 1);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Paulo Ricardo', '16/01/1989', 'paulo.ricardo@example.com', '71990543210', 92, 1.87, 2, 2);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Quésia Lima', '30/09/1995', 'quesia.lima@example.com', '81990432109', 59, 1.61, 3, 3);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Rafael Gomes', '12/12/1993', 'rafael.gomes@example.com', '91990321098', 83, 1.77, 1, 1);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Sofia Pereira', '08/06/1997', 'sofia.pereira@example.com', '11990210987', 56, 1.63, 2, 2);
INSERT INTO Alunos (Nome, DataNascimento, Email, Telefone, Peso, Altura, ModalidadeID, PlanosID) 
VALUES ('Tiago Carvalho', '27/03/1990', 'tiago.carvalho@example.com', '21990109876', 81, 1.76, 3, 3);
