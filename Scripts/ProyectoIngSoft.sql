CREATE DATABASE Clinic_Planner;

use Clinic_Planner;

alter table Agenda Change IdPsicologo IdPsi int not null;

CREATE TABLE Psicologo(
	TipoId Varchar(4) not null,
    IdPsicologo INT NOT NULL, 
    NombrePsicologo VARCHAR(50),
    ApellidoPsicologo VARCHAR(50),
    Direccion VARCHAR(100),
    Telefono VARCHAR(10),
    Email VARCHAR(100),
    FechaNacimiento VARCHAR(20),
    Edad INT,
    Sexo VARCHAR(9),
    Especializacion VARCHAR(20) default "No aplica",
    PRIMARY KEY (IdPsicologo)
);


CREATE TABLE Paciente(
	TipoId Varchar(4),
    IdPaciente INT NOT NULL, 
    NombrePaciente VARCHAR(50),
    ApellidoPaciente VARCHAR(50),
    Direccion VARCHAR(100),
    Telefono VARCHAR(10),
    Email VARCHAR(100),
    FechaNacimiento VARCHAR(20),
    Edad INT,
    Sexo VARCHAR(9),
    PRIMARY KEY (IdPaciente)
);


CREATE TABLE Sesion(
    IdSesion INT auto_increment NOT NULL,
    IdPsicologoS INT,
    IdPacienteS INT,
    Fecha VARCHAR(40),
    Hora Varchar(20),
    Estado Varchar(15),
    PRIMARY KEY (IdSesion),
    FOREIGN KEY (IdPsicologoS )REFERENCES Psicologo(IdPsicologo),
    FOREIGN KEY (IdPacienteS) REFERENCES Paciente(IdPaciente)
);


CREATE TABLE HistorialSesion (
    IdHistorial INT NOT NULL,
    IdSesionH Int,
    IdPacienteH INT, 
    FOREIGN KEY (IdHistorial) references Sesion(IdSesion),
    FOREIGN KEY (IdPacienteH) REFERENCES Paciente(IdPaciente)
);

CREATE TABLE NotaSesion (
    IdNotas INT auto_increment NOT NULL,
    IdSesionN int,
    Nota VARCHAR(1000),
    Diagnostico VARCHAR(1000),
    PRIMARY KEY (IdNotas),
	Foreign key (IdSesionN) references Sesion(IdSesion)
);
CREATE TABLE Agenda(
	IdAgenda int auto_increment NOT NULL,
	IdPsicologoA int not null,
	IdSesionA int NOT NULL,
	Primary key (IdAgenda),
	Foreign key (IdPsicologoA) references Psicologo(IdPsicologo),
	Foreign key (IdSesionA) references Sesion (IdSesion)
);

INSERT INTO PSICOLOGO (TipoId, IdPsicologo, NombrePsicologo, ApellidoPsicologo, Direccion, Telefono, 
Email, FechaNacimiento, Edad, Sexo, Especializacion) values 
("C.C", 2, "Hector", "David Giraldo","123", "asd", "asd", "02-09-1999", 22, "Masculino", "asd" );

INSERT INTO Paciente (TipoId, IdPaciente, NombrePaciente, ApellidoPaciente, Direccion, Telefono, 
Email, FechaNacimiento, Edad, Sexo) values 
("C.C", 3, "Hector", "Castaño David","123", "asd", "asd", "02-09-1999", 22, "Masculino" );



insert into Agenda (IdAgenda, IdPsicologoA, IdSesionA) Values (2, 1, 5);
use clinic_planner;
select * from Agenda where IdPsicologoA = 2;
Select * from NotaSesion;
select * from sesion;
Drop database Clinic_planner;
Select  IdPsicologo, ApellidoPsicologo, IdPaciente, ApellidoPaciente, Fecha,Hora,Estado From Sesion Join Paciente s Join Psicologo p ON Sesion.IdPsicologoS = p.IdPsicologo; 
delete from Sesion where Id = 4;
