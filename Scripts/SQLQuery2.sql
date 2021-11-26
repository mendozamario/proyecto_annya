CREATE TABLE Psicologo(
    TipoId VARCHAR(4) not null,
    Id INT NOT NULL, 
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Direccion VARCHAR(100),
    Telefono VARCHAR(10),
    Email VARCHAR(100),
    FechaNacimiento VARCHAR(10),
    Edad INT,
    Sexo VARCHAR(9),
    Especializacion VARCHAR(20) default 'No aplica',
    PRIMARY KEY (Id)
);

CREATE TABLE Agenda(
	Id int not null,
	IdPsicologo int not null,
	IdSesion int not null,
	Primary key (Id),
	Foreign key (IdPsicologo) references Psicologo(Id),
	Foreign key (IdSesion) references Sesion (Id)
);

CREATE TABLE Paciente(
TipoId VARCHAR(4) not null,
    Id INT NOT NULL, 
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Direccion VARCHAR(100),
    Telefono VARCHAR(10),
    Email VARCHAR(100),
    FechaNacimiento VARCHAR(10),
    Edad INT,
    Sexo VARCHAR(9),
    PRIMARY KEY (Id)
);

CREATE TABLE Sesion(
    Id INT NOT NULL,
    Fecha VARCHAR(10),
    IdPsicologo INT,
    IdPaciente INT, 
    PRIMARY KEY (Id),
    FOREIGN KEY (IdPsicologo )REFERENCES Psicologo(Id),
    FOREIGN KEY (IdPaciente) REFERENCES Paciente(Id)
);


CREATE TABLE HistorialSesion (
    Id INT NOT NULL,
    IdPaciente INT, 
    PRIMARY KEY (Id),
    FOREIGN KEY (IdPaciente) REFERENCES Paciente(Id)
);

CREATE TABLE NotaSesion (
    Id INT NOT NULL,
    Nota VARCHAR(1000),
    Diagnostico VARCHAR(1000),
    PRIMARY KEY (Id)
);

CREATE TABLE Auth (
    Id INT NOT NULL,
    Username VARCHAR(50),
    Password VARCHAR(100),
    Email VARCHAR(100),
    Type VARCHAR(12),
    PRIMARY KEY (Id)
);


