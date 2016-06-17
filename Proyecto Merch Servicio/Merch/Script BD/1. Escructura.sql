use master 
go 
create database Merch
go
use Merch
go 

--Creacion de Tablas Maestras 
--***************************
Create Table Estado(
idEstado char(1) primary key,
estado varchar(25) not null
)

Create Table Sexo(
idSexo char(1) primary key,
sexo varchar(25) not null
)

Create Table Nivel( 
idNivel char(1) primary key,
Nivel varchar(50) not null
)

Create Table Partida(
idPartida char(3) primary key,
Partida char(50) not null,
idEstado char(1) CONSTRAINT FK_tblPartida_idEstado Foreign key references Estado(idEstado)
)

Create Table Costo_Anio(
idAnio char(4) primary key,
anio char(2) not null,
numero char(4) not null
)

Create Table Documento_correlativo(
ccosto char(6) primary key, 
doc char(2),
numero char(5) not null
)

--Creacion de tablas Transaccionarias
--***********************************
--drop table Cliente
Create Table Cliente(
idCliente int Primary Key,
ruc char(11)not null Constraint UQ_Cliente_Ruc3 Unique(ruc),
cliente varchar(50)not null Constraint UQ_Cliente_Cliente Unique(cliente),
direccion varchar(50)not null,
contacto varchar(50)not null,
correo varchar(30) null,
telefono varchar(11)not null,
idEstado char(1) Constraint FK_tblCliente_idEstado3 Foreign Key References Estado(idEstado)
)
Alter table Cliente add constraint CK_Cliente_idEstado  check(idEstado='A' or idEstado='I')

Create Table Personal(
idPersona int Primary key,
codigoPersona char(8) not null Constraint UQ_Personal_codigoPersona Unique(codigoPersona),
nombre varchar(50) not null,
apellidoPaterno varchar(50) not null,
apellidoMaterno  varchar(50) not null,
direccion varchar(50) not null,
telefono varchar(11) null,
fechaNac date not null,
idSexo char(1) Constraint FK_tblSexo_idSexo Foreign Key References Sexo(idSexo),
correo varchar(30) null,
idEstado char(1) Constraint FK_tblPersonal_idEstado Foreign Key References Estado(idEstado)
)
Alter table Personal add Constraint CK_Personal_idEstado Check(idEstado='A' or idEstado='I')

Create Table Usuario(
idUsuario int primary key Identity,
usr char(3) not null Constraint UQ_Usuario_Usr Unique(usr),
idPersona int Constraint FK_tblUsuario_tblPersonal_idPersona Foreign key references Personal(idPersona),
usrNombre varchar(20) not null,
clave varchar(10) not null,   
idEstado char(1) Constraint FK_tblusuario_idEstado Foreign key references Estado(idEstado)
)
Alter table Usuario add Constraint CK_Usuario_idEstado Check(idEstado='A' or idEstado='I')

Create Table Nivel_Personal(
idNivel char(1)  not null Constraint FK_tblNivelPersonal_tblNivel_idNivel Foreign key references Nivel(idNivel),
idPersona int not null Constraint FK_tblNivelPersonal_tblPersonal_idPersonal Foreign key  references Personal(idPersona),
idEstado char(1) Constraint FK_NivelPersonal_idEstado Foreign key references Estado(idEstado)
)
Alter table Nivel_Personal Add primary key(idNivel, idPersona);

Create Table CentroCosto_Cab(
ccosto char(6) Primary Key,
ej char(4) not null,
mes char(2) not null,
descripcion varchar(50) not null,
idCliente int Constraint FK_tblCentroCostoCab_tblCliente_idCliente Foreign key references Cliente(idCliente),
idPersona int Constraint FK_tblCentroCostoCab_Nivel_Personal_idPersona Foreign key references Personal(idPersona),
usr char(3) not null,
fechaReg date not null,
hora char(8) not null,
usrMod char(3) null,
fechaMod date null,
horaMod char(8) null,
total decimal(12,2) not null,
idEstado char(1) Constraint FK_CentroCostoCab_idEstado Foreign key references Estado(idEstado)
)
Alter Table CentroCosto_Cab Add constraint CK_CentroCosto_Cab_idEstado check(idEstado='A' or idEstado='X' or idEstado='C') --A-Activo / X-Anulado / C-Cerrado
Alter Table CentroCosto_Cab Add constraint CK_CentroCosto_Cab_total check(total>0 and total<=999999999.99)

Create Table CentroCosto_Lin(
ccosto char(6) not null Constraint FK_tblCentroCostoLin_tblCentroCostoCab_ccosto Foreign Key references CentroCosto_Cab(ccosto), 
idPartida char(3) not null Constraint FK_tblCentroCostoLin_tblPartida_idPartida Foreign Key references Partida(idPartida),
total decimal(12,2) not null
)
Alter Table CentroCosto_Lin Add primary key(ccosto, idpartida);
Alter Table CentroCosto_Lin Add constraint CK_CentroCosto_Lin_total check(total>0 and total<=999999999.99)

Create Table Documento_Cab(
ccosto char(6) not null Constraint FK_tblDocumentoCab_tblCentroCostoCab_ccosto Foreign key references CentroCosto_Cab(ccosto),
doc char(2) not null,
numero char(5) not null,
ej char(4) not null,
mes char(2) not null,
idPersona int Constraint FK_tblDocumento_Cab_Personal_idPersona Foreign key References Personal(idPersona),
total decimal(12,2) not null,
usr char(3) not null,
fechaReg date not null,
hora char(8)not null,
usrMod char(3) null,
fechaMod date null,
horaMod char(8) null,
usrTermino char(3) null,
fechaTermino date null,
horaTermino char(8) null,
idEstado char(1) NOT NULL Constraint FK_Documento_Cab_idEstado Foreign key references Estado(idEstado)
)
Alter Table Documento_Cab Add primary key(ccosto, doc, numero);
Alter Table Documento_Cab Add constraint CK_Documento_Cab_idEstado check(idEstado='P' or idEstado='V' or idEstado='R' or idEstado='B') --P-Pendiente / V-Enviado / R-Rechazado / B-Aprobado 
Alter Table Documento_Cab Add constraint CK_Documento_Cab_total check(total>0 and total<=999999999.99)

Create Table Documento_Lin(
ccosto char(6) not null,
doc char(2) not null,
numero char(5) not null,
idPartida char(3) not null,
ej char(4) not null,
mes char(2) not null,
cantidad int not null,
precio decimal(12,2) not null,
total  decimal(12,2) not null
)
Alter Table Documento_Lin Add primary key (ccosto, doc, numero, idpartida);
Alter Table Documento_Lin Add constraint fk_DocumentoCab_DocumentoLin Foreign key (ccosto, doc, numero) REFERENCES Documento_Cab(ccosto, doc, numero)
Alter Table Documento_Lin Add constraint CK_Documento_Lin_total check(total>0 and total<=999999999.99)
Alter Table Documento_Lin Add constraint CK_Documento_Lin_precio check(precio>0 and precio<=999999999.99)
 
