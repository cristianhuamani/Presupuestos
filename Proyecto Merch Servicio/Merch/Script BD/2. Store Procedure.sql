USE [Merch]
GO

CREATE PROCEDURE [dbo].[Documento_correlativo_Obtener]
@doc char(2),
@numero char(5) out
AS

SELECT
@numero = numero
FROM
dbo.Documento_correlativo
WHERE
doc = @doc
GO

CREATE PROCEDURE [dbo].[Documento_correlativo_Insertar]
@doc char(2),
@numero char(5)
AS

INSERT dbo.Documento_correlativo
(
doc,
numero
)
VALUES
(
@doc,
@numero
)
GO

CREATE PROCEDURE [dbo].[Documento_correlativo_Act]
@doc char(2),
@numero char(5)
AS

UPDATE dbo.Documento_correlativo
SET
numero = @numero
WHERE
doc = @doc
GO

CREATE PROCEDURE [dbo].[Costo_Anio_Obtener]
@idAnio char(4),
@anio char(2) out,
@numero char(4) out
AS

SELECT
@anio = anio,
@numero = numero
FROM
dbo.Costo_Anio
WHERE
idAnio = @idAnio
GO

CREATE PROCEDURE [dbo].[Costo_Anio_Insertar]
@idAnio char(4),
@anio char(2),
@numero char(4)
AS

INSERT dbo.Costo_Anio
(
idAnio,
anio,
numero
)
VALUES
(
@idAnio,
@anio,
@numero
)
GO

CREATE PROCEDURE [dbo].[Costo_Anio_Actualizar]
@idAnio char(4),
@anio char(2),
@numero char(4)
AS

UPDATE dbo.Costo_Anio
SET
anio = @anio,
numero = @numero
WHERE
idAnio = @idAnio
GO

CREATE PROCEDURE [dbo].[Sexo_ListarDes]
AS

SELECT
idSexo,
sexo
FROM
dbo.Sexo
ORDER BY sexo
GO

CREATE PROCEDURE [dbo].[Nivel_ListarDes]
AS

SELECT
idNivel,
Nivel
FROM
dbo.Nivel
ORDER BY Nivel
GO

CREATE PROCEDURE [dbo].[Partida_Obtener]
@idPartida char(3),
@Partida char(50) out,
@idEstado char(1) out
AS

SELECT
@Partida = Partida,
@idEstado = idEstado
FROM
dbo.Partida
WHERE
idPartida = @idPartida
GO

CREATE PROCEDURE [dbo].[Partida_ListarUso]
@idPartida char(3),
@Partida char(50)
AS

SELECT
par.idPartida,
par.Partida
FROM
dbo.Partida par
WHERE
par.idPartida = ISNULL(@idPartida,par.idPartida) AND
par.Partida = ISNULL(@Partida,par.Partida)
ORDER BY 1
GO

CREATE PROCEDURE [dbo].[Partida_ListarDes]
AS

SELECT
idPartida,
Partida
FROM
dbo.Partida
WHERE idEstado = 'A'
ORDER BY Partida
GO

CREATE PROCEDURE [dbo].[Partida_Listar]
AS
SELECT
par.idPartida,
par.Partida,
est.Estado
FROM
dbo.Partida par
INNER JOIN Estado est on est.idEstado = par.idEstado

GO

CREATE PROCEDURE [dbo].[Partida_Insertar]
@Partida char(50),
@idEstado char(1)

AS

--Variable para obtener el Id de partida
declare @codigo char(3)
set @codigo = (select right('00' + rtrim(convert(char(3),convert(int,isnull(max(idPartida),'000'))+1)),3) from Partida)

INSERT dbo.Partida
(
idPartida,
Partida,
idEstado
)
VALUES
(
@codigo,
@Partida,
@idEstado
)
GO

CREATE PROCEDURE [dbo].[Partida_Actualizar]
@idPartida char(3),
@Partida char(50),
@idEstado char(1)
AS

UPDATE dbo.Partida
SET
Partida = @Partida,
idEstado = @idEstado 
WHERE
idPartida = @idPartida
GO

CREATE PROCEDURE [dbo].[Personal_Obtener]
@idPersona int,
@codigoPersona char(8) out,
@nombre varchar(50) out,
@apellidoPaterno varchar(50) out,
@apellidoMaterno varchar(50) out,
@direccion varchar(50) out,
@telefono varchar(11) out,
@fechaNac date out,
@idSexo char(1) out,
@idEstado char(1) out
AS

SELECT
@codigoPersona = codigoPersona,
@nombre = nombre,
@apellidoPaterno = apellidoPaterno,
@apellidoMaterno = apellidoMaterno,
@direccion = direccion,
@telefono = telefono,
@fechaNac = fechaNac,
@idSexo = idSexo,
@idEstado = idEstado
FROM
dbo.Personal
WHERE
idPersona = @idPersona
GO

CREATE PROCEDURE [dbo].[Personal_ListarUso]
@codigoPersona char(8),
@nombre varchar(50),
@apellidoPaterno varchar(50),
@apellidoMaterno varchar(50),
@direccion varchar(50)
AS

SELECT
per.idPersona,
per.codigoPersona,
per.nombre,
per.apellidoPaterno,
per.apellidoMaterno,
per.direccion,
per.telefono,
per.fechaNac,
sex.sexo,
est.estado
FROM
dbo.Personal per
LEFT JOIN dbo.Sexo sex ON sex.idSexo = per.idSexo
LEFT JOIN dbo.Estado est ON est.idEstado = per.idEstado
WHERE
per.codigoPersona = ISNULL(@codigoPersona,per.codigoPersona) AND
per.nombre LIKE '%' + @nombre + '%' AND
per.apellidoPaterno LIKE '%' + @apellidoPaterno + '%' AND
per.apellidoMaterno LIKE '%' + @apellidoMaterno + '%' AND
per.direccion LIKE '%' + @direccion + '%'
ORDER BY 1
GO

CREATE PROCEDURE [dbo].[Personal_ListarDes]
@idSexo char(1),
@idEstado char(1)
AS

SELECT
idPersona,
nombre
FROM
dbo.Personal
Where idEstado=isnull(@idEstado,idEstado)and 
idSexo=isnull(@idSexo,idSexo)
ORDER BY nombre
GO

CREATE PROCEDURE [dbo].[Personal_Listar]
@idPersona int,
@idSexo char(1),
@idEstado char(1)
AS

SELECT
idPersona,
codigoPersona,
nombre,
apellidoPaterno,
apellidoMaterno,
direccion,
telefono,
fechaNac,
idSexo,
idEstado
FROM
dbo.Personal
WHERE
idPersona = ISNULL(@idPersona,idPersona)
ORDER BY 1
GO

CREATE PROCEDURE [dbo].[Personal_Insertar]
@idPersona int out,
@codigoPersona char(8),
@nombre varchar(50),
@apellidoPaterno varchar(50),
@apellidoMaterno varchar(50),
@direccion varchar(50),
@telefono varchar(11),
@fechaNac date,
@idSexo char(1),
@idEstado char(1)
AS

INSERT dbo.Personal
(
codigoPersona,
nombre,
apellidoPaterno,
apellidoMaterno,
direccion,
telefono,
fechaNac,
idSexo,
idEstado
)
VALUES
(
@codigoPersona,
@nombre,
@apellidoPaterno,
@apellidoMaterno,
@direccion,
@telefono,
@fechaNac,
@idSexo,
@idEstado
)

SET @idPersona = @@IDENTITY
GO

CREATE PROCEDURE [dbo].[Personal_Actualizar]
@idPersona int,
@codigoPersona char(8),
@nombre varchar(50),
@apellidoPaterno varchar(50),
@apellidoMaterno varchar(50),
@direccion varchar(50),
@telefono varchar(11),
@fechaNac date,
@idSexo char(1),
@idEstado char(1)
AS

UPDATE dbo.Personal
SET
codigoPersona = @codigoPersona,
nombre = @nombre,
apellidoPaterno = @apellidoPaterno,
apellidoMaterno = @apellidoMaterno,
direccion = @direccion,
telefono = @telefono,
fechaNac = @fechaNac,
idSexo = @idSexo,
idEstado = @idEstado
WHERE
idPersona = @idPersona
GO

CREATE PROCEDURE [dbo].[Cliente_Obtener]
@idCliente int,
@ruc char(11) out,
@cliente varchar(50) out,
@direccion varchar(50) out,
@contacto varchar(50) out,
@correo varchar(30) out,
@telefono varchar(11) out,
@idEstado char(1) out
AS

SELECT
@ruc = ruc,
@cliente = cliente,
@direccion = direccion,
@contacto = contacto,
@correo = correo,
@telefono = telefono,
@idEstado = idEstado
FROM
dbo.Cliente
WHERE
idCliente = @idCliente
GO

CREATE PROCEDURE [dbo].[Cliente_ListarUso]
@ruc char(11),
@cliente varchar(50),
@direccion varchar(50),
@contacto varchar(50),
@telefono varchar(11)
AS

SELECT
cli.idCliente,
cli.ruc,
cli.cliente,
cli.direccion,
cli.contacto,
cli.correo,
cli.telefono,
est.estado
FROM
dbo.Cliente cli
LEFT JOIN dbo.Estado est ON est.idEstado = cli.idEstado
WHERE
cli.ruc = ISNULL(@ruc,cli.ruc) AND
cli.cliente LIKE '%' + @cliente + '%' AND
cli.direccion LIKE '%' + @direccion + '%' AND
cli.contacto LIKE '%' + @contacto + '%' AND
cli.telefono LIKE '%' + @telefono + '%'
ORDER BY 1
GO

CREATE PROCEDURE [dbo].[Cliente_ListarDes]
@idEstado char(1)
AS

SELECT
idCliente,
cliente
FROM
dbo.Cliente
Where idEstado=isnull(@idEstado,idEstado)
ORDER BY cliente
GO

CREATE PROCEDURE [dbo].[Cliente_Listar]
@idCliente int,
@idEstado char(1)
AS

SELECT
idCliente,
ruc,
cliente,
direccion,
contacto,
correo,
telefono,
idEstado
FROM
dbo.Cliente
WHERE
idCliente = ISNULL(@idCliente,idCliente)
ORDER BY 1
GO

CREATE PROCEDURE [dbo].[Cliente_Insertar]
@idCliente int out,
@ruc char(11),
@cliente varchar(50),
@direccion varchar(50),
@contacto varchar(50),
@correo varchar(30),
@telefono varchar(11),
@idEstado char(1)
AS

SELECT @idCliente = ISNULL(MAX(idCliente), 0) + 1 FROM dbo.Cliente

INSERT dbo.Cliente
(
idCliente,
ruc,
cliente,
direccion,
contacto,
correo,
telefono,
idEstado
)
VALUES
(
@idCliente,
@ruc,
@cliente,
@direccion,
@contacto,
@correo,
@telefono,
@idEstado
)
GO

CREATE PROCEDURE [dbo].[Cliente_Actualizar]
@idCliente int,
@ruc char(11),
@cliente varchar(50),
@direccion varchar(50),
@contacto varchar(50),
@correo varchar(30),
@telefono varchar(11),
@idEstado char(1)
AS

UPDATE dbo.Cliente
SET
ruc = @ruc,
cliente = @cliente,
direccion = @direccion,
contacto = @contacto,
correo = @correo,
telefono = @telefono,
idEstado = @idEstado
WHERE
idCliente = @idCliente
GO

CREATE PROCEDURE [dbo].[CentroCosto_Cab_Obtener]
@ccosto char(6),
@ej char(4) out,
@mes char(2) out,
@descripcion varchar(50) out,
@idcliente int out,
@idPersona int out,
@usr char(3) out,
@fechaReg date out,
@hora char(8) out,
@usrMod char(3) out,
@fechaMod date out,
@horaMod char(8) out,
@total decimal(12,2) out,
@idEstado char(1) out
AS

SELECT
@ej = ej,
@mes = mes,
@descripcion = descripcion,
@idcliente = idCliente,
@idPersona = idPersona,
@usr = usr,
@fechaReg = fechaReg,
@hora = hora,
@usrMod = usrMod,
@fechaMod = fechaMod,
@horaMod = horaMod,
@total = total,
@idEstado = idEstado
FROM
dbo.CentroCosto_Cab
WHERE
ccosto = @ccosto
GO

CREATE PROCEDURE [dbo].[CentroCosto_Cab_ListarUso]
@Filtro varchar(50)
AS

SELECT
cen.ej,
cen.ccosto,
cen.descripcion,
CONVERT(char(10),cen.fechaReg,103) AS fechaReg,
est.estado
FROM
dbo.CentroCosto_Cab cen
LEFT JOIN dbo.Estado est ON est.idEstado = cen.idEstado
WHERE
cen.ccosto LIKE '%' + @Filtro + '%' OR
cen.descripcion LIKE '%' + @Filtro + '%'
ORDER BY cen.ej DESC,cen.ccosto DESC
GO

CREATE PROCEDURE [dbo].[CentroCosto_Cab_ListarDes]
@idCliente int,
@idPersona int,
@idEstado char(1)
AS

SELECT
ccosto,
descripcion
FROM
dbo.CentroCosto_Cab
WHERE idCliente=isnull(@idCliente,idCliente)and 
idPersona = isnull(@idPersona,idPersona)and
idEstado=isnull(@idEstado,idEstado)
ORDER BY descripcion
GO

CREATE PROCEDURE [dbo].[CentroCosto_Cab_Listar]
@ccosto char(6),
@cliente char(11),
@responsable char(8),
@idEstado char(1)
AS

SELECT
ccosto,
ej,
mes,
descripcion,
idCliente,
idPersona,
usr,
fechaReg,
hora,
usrMod,
fechaMod,
horaMod,
total,
idEstado
FROM
dbo.CentroCosto_Cab
WHERE
ccosto = ISNULL(@ccosto,ccosto)
ORDER BY 1
GO

CREATE PROCEDURE [dbo].[CentroCosto_Cab_Insertar]
@ccosto char(6) out,
@ej char(4) out,
@mes char(2) out,
@descripcion varchar(50),
@idCliente int,
@idPersona int,
@usr char(3),
@total decimal(12,2),
@idEstado char(1)
AS

DECLARE @Numero char(4)
set @ej = (select year(GETDATE()))
set @mes = (select right('0'+rtrim(convert(char(2),month(GETDATE()))),2))
set @Numero=ISNULL((select numero from Costo_Anio where idAnio=@ej),'')

--creamos el correlativo de la llave si existe le sumanos uno si no existe lo insertamos
if @Numero = ''
	begin
		set @Numero = '0001'	
		insert into Costo_Anio ([idAnio],[anio],[numero])values(@ej,right(@ej,2),@Numero) 
	end
else
	begin
		set @Numero = right('000'+rtrim(convert(char(4),convert(int,@Numero)+1)),4)
		update Costo_Anio set [numero]=@Numero where  [idAnio]=@ej
	end

--Creamos el centro de costo
set @ccosto = right(@ej,2)+@Numero

INSERT dbo.CentroCosto_Cab
(
ccosto,
ej,
mes,
descripcion,
idCliente,
idPersona ,
usr,
fechaReg,
hora,
total,
idEstado
)
VALUES
(
@ccosto,
@ej,
@mes,
@descripcion,
@idCliente,
@idPersona,
@usr,
GETDATE(),
CONVERT(char(8),GETDATE(),108),
@total,
@idEstado
)
GO

CREATE PROCEDURE [dbo].[CentroCosto_Cab_Actualizar]
@ccosto char(6),
@descripcion varchar(50),
@idCliente int,
@idPersona int,
@usrMod char(3),
@total decimal(12,2),
@idEstado char(1)
AS

UPDATE dbo.CentroCosto_Cab
SET
descripcion = @descripcion,
idCliente = @idCliente,
idPersona= @idPersona,
usrMod = @usrMod,
fechaMod = GETDATE(),
horaMod = CONVERT(char(8),GETDATE(),108),
total = @total,
idEstado = @idEstado
WHERE
ccosto = @ccosto
GO

CREATE PROCEDURE [dbo].[Usuario_Obtener]
@usr char(2),
@idPersona int,
@usrNombre varchar(20) out,
@clave varchar(10) out,
@idEstado char(1) out
AS

SELECT
@idPersona = idPersona,
@usrNombre = usrNombre,
@clave = clave,
@idEstado = idEstado
FROM
dbo.Usuario
WHERE
usr = @usr
GO

CREATE PROCEDURE [dbo].[Usuario_ListarUso]
@usr char(2),
@usrNombre varchar(20),
@clave varchar(10)
AS

SELECT
usu.usr,
per.nombre,
usu.usrNombre,
usu.clave,
est.estado
FROM
dbo.Usuario usu
LEFT JOIN dbo.Personal per ON per.idPersona = usu.idPersona
LEFT JOIN dbo.Estado est ON est.idEstado = usu.idEstado
WHERE
usu.usr = ISNULL(@usr,usu.usr) AND
usu.usrNombre LIKE '%' + @usrNombre + '%' AND
usu.clave LIKE '%' + @clave + '%'
ORDER BY 1
GO

CREATE PROCEDURE [dbo].[Usuario_Listar]
@usr char(2),
@codigoPersona char(8),
@idEstado char(1)
AS

SELECT
usr,
idPersona,
usrNombre,
clave,
idEstado
FROM
dbo.Usuario
WHERE
usr = ISNULL(@usr,usr)
ORDER BY 1
GO

CREATE PROCEDURE [dbo].[Usuario_Insertar]
@usr char(2),
@codigoPersona char(8),
@usrNombre varchar(20),
@clave varchar(10),
@idEstado char(1)
AS

INSERT dbo.Usuario
(
usr,
idPersona,
usrNombre,
clave,
idEstado
)
VALUES
(
@usr,
@codigoPersona,
@usrNombre,
@clave,
@idEstado
)
GO

CREATE PROCEDURE [dbo].[Usuario_Actualizar]
@usr char(2),
@idPersona int,
@usrNombre varchar(20),
@clave varchar(10),
@idEstado char(1)
AS

UPDATE dbo.Usuario
SET
idPersona = @idPersona,
usrNombre = @usrNombre,
clave = @clave,
idEstado = @idEstado
WHERE
usr = @usr
GO

CREATE PROCEDURE [dbo].[Nivel_Personal_Obtener]
@idNivel char(1),
@idPersona  int,
@idEstado char(1) out
AS

SELECT
@idEstado = idEstado
FROM
dbo.Nivel_Personal
WHERE
idNivel = @idNivel AND
idPersona = @idPersona 
GO

CREATE PROCEDURE [dbo].[Nivel_Personal_ListarUso]
@idNivel char(1),
@idPersona int
AS

SELECT
niv_2.Nivel,
per.nombre,
est.estado
FROM
dbo.Nivel_Personal niv
INNER JOIN dbo.Nivel niv_2 ON niv_2.idNivel = niv.idNivel
INNER JOIN dbo.Personal per ON per.idPersona = niv.idPersona
LEFT JOIN dbo.Estado est ON est.idEstado = niv.idEstado
WHERE
niv.idNivel = ISNULL(@idNivel,niv.idNivel) AND
niv.idPersona= ISNULL(@idPersona,niv.idPersona)
ORDER BY 1
GO

CREATE PROCEDURE [dbo].[Nivel_Personal_Listar]
@idNivel char(1),
@idPersona int,
@idEstado char(1)
AS

SELECT
idNivel,
idPersona,
idEstado
FROM
dbo.Nivel_Personal
WHERE
idNivel = ISNULL(@idNivel,idNivel) AND
idPersona= ISNULL(@idPersona,idPersona)
ORDER BY 1
GO

CREATE PROCEDURE [dbo].[Nivel_Personal_Insertar]
@idNivel char(1),
@codigoPersona char(8),
@idEstado char(1)
AS

INSERT dbo.Nivel_Personal
(
idNivel,
idPersona,
idEstado
)
VALUES
(
@idNivel,
@codigoPersona,
@idEstado
)
GO

CREATE PROCEDURE [dbo].[Nivel_Personal_Eliminar]
@idNivel char(1),
@idPersona int,
@idEstado char(1)
AS

DELETE FROM
dbo.Nivel_Personal
WHERE
idNivel = ISNULL(@idNivel,idNivel) AND
idPersona = ISNULL(@idPersona,idPersona)
GO

CREATE PROCEDURE [dbo].[Nivel_Personal_Actualizar]
@idNivel char(1),
@codigoPersona char(8),
@idEstado char(1)
AS

UPDATE dbo.Nivel_Personal
SET
idEstado = @idEstado
WHERE
idNivel = @idNivel AND
idPersona = @codigoPersona
GO

CREATE PROCEDURE [dbo].[CentroCosto_Lin_Obtener]
@ccosto char(6),
@idPartida char(3),
@total decimal(12,2) out
AS

SELECT
@total = total
FROM
dbo.CentroCosto_Lin
WHERE
ccosto = @ccosto AND
idPartida = @idPartida
GO

CREATE PROCEDURE [dbo].[CentroCosto_Lin_ListarUso]
@ccosto char(6)
AS

SELECT
cen.idPartida,
par.Partida,
cen.total
FROM
dbo.CentroCosto_Lin cen
INNER JOIN dbo.Partida par ON par.idPartida = cen.idPartida
WHERE
cen.ccosto = @ccosto
ORDER BY 1
GO

CREATE PROCEDURE [dbo].[CentroCosto_Lin_Listar]
@ccosto char(6)
AS

SELECT
lin.idPartida,
par.Partida
FROM
dbo.CentroCosto_Lin lin
INNER JOIN Partida par ON lin.idPartida=par.idPartida
WHERE ccosto = @ccosto
ORDER BY Partida

GO

CREATE PROCEDURE [dbo].[CentroCosto_Lin_Insertar]
@ccosto char(6),
@idPartida char(3),
@total decimal(12,2)
AS

INSERT dbo.CentroCosto_Lin
(
ccosto,
idPartida,
total
)
VALUES
(
@ccosto,
@idPartida,
@total
)
GO

CREATE PROCEDURE [dbo].[CentroCosto_Lin_Eliminar]
@ccosto char(6)
AS

DELETE FROM
dbo.CentroCosto_Lin
WHERE
ccosto = @ccosto
GO

CREATE PROCEDURE [dbo].[CentroCosto_Lin_Actualizar]
@ccosto char(6),
@idPartida char(3),
@total decimal(12,2)
AS

UPDATE dbo.CentroCosto_Lin
SET
total = @total
WHERE
ccosto = @ccosto AND
idPartida = @idPartida
GO

CREATE -- ALTER
PROCEDURE [dbo].[Documento_Cab_Obtener]
@ccosto char(6),
@doc char(2),
@numero char(5),
@descripcion varchar(50) out,
@cliente varchar(50) out,
@Ejecutivo varchar(50) out,
@ej char(4) out,
@mes char(2) out,
@idPersona int out,
@total decimal(12,2) out,
@usr char(3) out,
@fechaReg date out,
@hora char(8) out,
@usrMod char(3) out,
@fechaMod date out,
@horaMod char(8) out,
@usrTermino char(3) out,
@fechaTermino date out,
@horaTermino char(8) out,
@idEstado char(1) out
AS

SELECT
@ej = doc.ej,
@mes = doc.mes,
@idPersona = doc.idPersona,
@total = doc.total,
@descripcion =cab.descripcion,
@cliente =cli.cliente,
@ejecutivo = per.nombre+' '+per.apellidoPaterno +' '+per.apellidoMaterno,
@usr = doc.usr,
@fechaReg = doc.fechaReg,
@hora = doc.hora,
@usrMod = doc.usrMod,
@fechaMod = doc.fechaMod,
@horaMod = doc.horaMod,
@usrTermino = doc.usrTermino,
@fechaTermino = doc.fechaTermino,
@horaTermino = doc.horaTermino,
@idEstado = doc.idEstado
FROM
dbo.Documento_Cab doc
INNER JOIN CentroCosto_Cab cab on cab.ccosto= doc.ccosto
INNER JOIN Cliente cli on cli.idCliente = cab.idCliente
INNER JOIN Personal per on per.idPersona = cab.idPersona
WHERE
doc.ccosto = @ccosto AND
doc.doc = @doc AND
doc.numero = @numero
GO

--[dbo].[Documento_Cab_ListarUso] ''
CREATE --ALTER
PROCEDURE [dbo].[Documento_Cab_ListarUso]
@filtro as varchar(50)
AS

SELECT
doc.ej,
doc.ccosto,
doc.doc,
doc.numero,
cen.descripcion,
doc.fechaReg,
cli.cliente,
est.estado
FROM
dbo.Documento_Cab doc
INNER JOIN dbo.CentroCosto_Cab cen ON cen.ccosto = doc.ccosto
INNER JOIN dbo.Cliente cli ON cli.idCliente = cen.idCliente
INNER JOIN dbo.Estado est ON est.idEstado = doc.idEstado
WHERE
doc.ccosto Like'%'+@filtro+'%' OR
doc.numero Like'%'+@filtro+'%' OR
doc.ej Like'%'+@filtro+'%' OR
doc.mes Like'%'+@filtro+'%' 

ORDER BY 1
GO

CREATE PROCEDURE [dbo].[Documento_Cab_Listar]
@ccosto char(6),
@doc char(2),
@numero char(5),
@idEstado char(1)
AS

SELECT
ccosto,
doc,
numero,
ej,
mes,
idPersona,
total,
usr,
fechaReg,
hora,
usrMod,
fechaMod,
horaMod,
usrTermino,
fechaTermino,
horaTermino,
idEstado
FROM
dbo.Documento_Cab
WHERE
ccosto = ISNULL(@ccosto,ccosto) AND
doc = ISNULL(@doc,doc) AND
numero = ISNULL(@numero,numero)
ORDER BY 1
GO

CREATE PROCEDURE [dbo].[Documento_Cab_Insertar]
@ccosto char(6),
@doc char(2),
@numero char(5) out,
@ej char(4) out,
@mes char(2) out,
@idPersona int,
@total decimal(12,2),
@usr char(3),
@idEstado char(1)
AS

set @ej = (select year(GETDATE()))
set @mes = (select right('0'+rtrim(convert(char(2),month(GETDATE()))),2))


set @Numero=ISNULL((select numero from Documento_correlativo where doc=@doc),'')

--creamos el correlativo de la llave si existe le sumanos uno si no existe lo insertamos
if @Numero = ''
	begin
		set @Numero = '00001'	
		insert into Documento_correlativo ([ccosto],[doc],[numero])values(@ccosto,@doc,@Numero) 
	end
else
	begin
		set @Numero = right('0000'+rtrim(convert(char(5),convert(int,@Numero)+1)),5)
		update Documento_correlativo  set [numero]=@Numero where  [ccosto]=@ccosto and doc=@doc
	end

INSERT dbo.Documento_Cab
(
ccosto,
doc,
numero,
ej,
mes,
idPersona,
total,
usr,
fechaReg,
hora,
idEstado
)
VALUES
(
@ccosto,
@doc,
@numero,
@ej,
@mes,
@idPersona,
@total,
@usr,
GETDATE(),
CONVERT(char(8),GETDATE(),108),
@idEstado
)
GO

CREATE PROCEDURE [dbo].[Documento_Cab_Actualizar]
@ccosto char(6),
@doc char(2),
@numero char(5),
@ej char(4),
@mes char(2),
@idPersona int,
@total decimal(12,2),
@usr char(3),
@fechaReg date,
@hora char(8),
@usrMod char(3),
@fechaMod date,
@horaMod char(8),
@usrTermino char(3),
@fechaTermino date,
@horaTermino char(8),
@idEstado char(1)
AS

UPDATE dbo.Documento_Cab
SET
ej = @ej,
mes = @mes,
idPersona = @idPersona,
total = @total,
usr = @usr,
fechaReg = @fechaReg,
hora = @hora,
usrMod = @usrMod,
fechaMod = @fechaMod,
horaMod = @horaMod,
usrTermino = @usrTermino,
fechaTermino = @fechaTermino,
horaTermino = @horaTermino,
idEstado = @idEstado
WHERE
ccosto = @ccosto AND
doc = @doc AND
numero = @numero
GO

CREATE PROCEDURE [dbo].[Documento_Lin_Obtener]
@ccosto char(6),
@doc char(2),
@numero char(5),
@idPartida char(3),
@ej char(4) out,
@mes char(2) out,
@cantidad int out,
@precio decimal(12,2) out,
@total decimal(12,2) out
AS

SELECT
@ej = ej,
@mes = mes,
@cantidad = cantidad,
@precio = precio,
@total = total
FROM
dbo.Documento_Lin
WHERE
ccosto = @ccosto AND
doc = @doc AND
numero = @numero AND
idPartida = @idPartida
GO

CREATE PROCEDURE [dbo].[Documento_Lin_ListarUso]
@ccosto char(6),
@doc char(2),
@numero char(5)

AS

SELECT
doc.idPartida,
par.Partida,
doc.cantidad,
doc.precio,
doc.total
FROM
dbo.Documento_Lin doc
INNER JOIN dbo.Partida par ON par.idPartida = doc.idpartida
WHERE
doc.ccosto = ISNULL(@ccosto,doc.ccosto) AND
doc.doc = ISNULL(@doc,doc.doc) AND
doc.numero = ISNULL(@numero,doc.numero)

ORDER BY 1
GO

CREATE PROCEDURE [dbo].[Documento_Lin_Listar]
@ccosto char(6),
@doc char(2),
@numero char(5),
@idPartida char(3)
AS

SELECT
ccosto,
doc,
numero,
idPartida,
ej,
mes,
cantidad,
precio,
total
FROM
dbo.Documento_Lin
WHERE
ccosto = ISNULL(@ccosto,ccosto) AND
doc = ISNULL(@doc,doc) AND
numero = ISNULL(@numero,numero) AND
idPartida = ISNULL(@idPartida,idPartida)
ORDER BY 1
GO

CREATE --ALTER
PROCEDURE [dbo].[Documento_Lin_Insertar]
@ccosto char(6),
@doc char(2),
@numero char(5),
@idPartida char(3),
@cantidad int,
@precio decimal(12,2),
@total decimal(12,2)
AS

INSERT dbo.Documento_Lin
(
ccosto,
doc,
numero,
idPartida,
ej,
mes,
cantidad,
precio,
total
)
VALUES
(
@ccosto,
@doc,
@numero,
@idPartida,
YEAR(GETDATE()),
RIGHT('0' + CONVERT(varchar(2),MONTH(GETDATE())),2),
@cantidad,
@precio,
@total
)
GO

CREATE PROCEDURE [dbo].[Documento_Lin_Eliminar]
@ccosto char(6),
@doc char(2),
@numero char(5),
@idPartida char(3)
AS

DELETE FROM
dbo.Documento_Lin
WHERE
ccosto = ISNULL(@ccosto,ccosto) AND
doc = ISNULL(@doc,doc) AND
numero = ISNULL(@numero,numero) AND
idPartida = ISNULL(@idPartida,idPartida)
GO

CREATE PROCEDURE [dbo].[Documento_Lin_Actualizar]
@ccosto char(6),
@doc char(2),
@numero char(5),
@idPartida char(3),
@ej char(4),
@mes char(2),
@cantidad int,
@precio decimal(12,2),
@total decimal(12,2)
AS

UPDATE dbo.Documento_Lin
SET
ej = @ej,
mes = @mes,
cantidad = @cantidad,
precio = @precio,
total = @total
WHERE
ccosto = @ccosto AND
doc = @doc AND
numero = @numero AND
idPartida = @idPartida
GO

CREATE PROCEDURE [dbo].[Nivel_Personal_ListarDes]

@idNivel char(1),
@idEstado char(1)
AS

SELECT
niv.idPersona,
per.nombre +' '+ per.apellidoPaterno +' '+per.apellidoMaterno as nombre
FROM
dbo.Nivel_Personal niv
inner join Personal per on per.idPersona = niv.idPersona
WHERE
niv.idEstado= ISNULL(@idEstado,niv.idEstado) AND 
niv.idNivel=ISNULL(@idNivel,niv.idNivel)
ORDER BY 2
GO


--***********************************************************************************************
CREATE PROCEDURE [dbo].[Costo_Partida_ListarDes]
@ccosto char(6)
AS

SELECT
lin.idPartida,
par.Partida
FROM
dbo.CentroCosto_Lin lin
INNER JOIN Partida par ON lin.idPartida=par.idPartida
WHERE ccosto = @ccosto
ORDER BY Partida
GO

