use merch
--********************************************************
--Sexo select * from sexo
insert into Sexo(idSexo,sexo) values('M','Masculino')
insert into Sexo(idSexo,sexo) values('F','Femenino')

--Estado select * from Estado
insert into estado values('A','Activo')
insert into estado values('I','Inactivo')
insert into estado values('C','Cerrado')

--Nivel  select * from Nivel
insert into Nivel(idNivel,Nivel) values('D','Director')
insert into Nivel(idNivel,Nivel) values('E','Ejecutivo')
insert into Nivel(idNivel,Nivel) values('S','Supervisor')
insert into Nivel(idNivel,Nivel) values('A','Asistente')
insert into Nivel(idNivel,Nivel) values('P','Presupuesto')
insert into Nivel(idNivel,Nivel) values('V','Sistemas (Vip)')

--Partida select * from Partida
insert into Partida(idPartida,Partida,idEstado) values('001','Vigilancia','A')                                        
insert into Partida(idPartida,Partida,idEstado) values('002','Mantenimiento','A')                                     
insert into Partida(idPartida,Partida,idEstado) values('003','Movilidad','A')                                            
insert into Partida(idPartida,Partida,idEstado) values('004','Pago Personal','A')                             
insert into Partida(idPartida,Partida,idEstado) values('005','visibilidad','A')                                       
insert into Partida(idPartida,Partida,idEstado) values('006','Servicio de Luz','A')                                    
insert into Partida(idPartida,Partida,idEstado) values('007','Servicio de Agua','A')                                         
insert into Partida(idPartida,Partida,idEstado) values('008','Servicio de Internet','A')
insert into Partida(idPartida,Partida,idEstado) values('009','Fotocheck','A')	                                
insert into Partida(idPartida,Partida,idEstado) values('010','Insumos Produccion','A')

--Personal select * from Personal 
insert into Personal(idPersona, codigoPersona, nombre, apellidoPaterno, apellidoMaterno, direccion, telefono, fechaNac, idSexo,correo,idEstado) values(1,'45038505','Eduardo','Barrios','Quirhuayo','av desd','45745454',convert(date,'15/02/1990',103),'M','Eduardo_0119@hotmail.com','A')
insert into Personal(idPersona, codigoPersona, nombre, apellidoPaterno, apellidoMaterno, direccion, telefono, fechaNac, idSexo,correo,idEstado) values(2,'46058727','Cristian','Huamani','Macahuachi','av union 731','5607190',convert(date,'11/12/1990',103),'M','omar_halcon16@hotmail.com','A')
insert into Personal(idPersona, codigoPersona, nombre, apellidoPaterno, apellidoMaterno, direccion, telefono, fechaNac, idSexo,correo,idEstado) values(3,'44757916','Juan','Alva','Solis','av brasil 1122','4284865',convert(date,'30/12/1987',103),'M','jtwo_18@hotmail.com','A')
insert into Personal(idPersona, codigoPersona, nombre, apellidoPaterno, apellidoMaterno, direccion, telefono, fechaNac, idSexo,correo,idEstado) values(4,'57891245','Jose','Elguera','Mamani','jr ayacucho 753','2609166',convert(date,'18/09/1989',103),'M','juanelguera_123@hotmail.com','A')
insert into Personal(idPersona, codigoPersona, nombre, apellidoPaterno, apellidoMaterno, direccion, telefono, fechaNac, idSexo,correo,idEstado) values(5,'12057894','Araceli','Gaspar','Quispe','av mariategui 45','5191000',convert(date,'31/10/1991',103),'F','AGaspar_love5@hotmail.com','A')
insert into Personal(idPersona, codigoPersona, nombre, apellidoPaterno, apellidoMaterno, direccion, telefono, fechaNac, idSexo,correo,idEstado) values(6,'75981265','Ana','Rojas','Soto','av panamericana 789','7539638',convert(date,'04/07/1993',103),'F','Ana_Kat15@hotmail.com','A')
insert into Personal(idPersona, codigoPersona, nombre, apellidoPaterno, apellidoMaterno, direccion, telefono, fechaNac, idSexo,correo,idEstado) values(7,'63257894','Richard','Cardenas','Machuca','av angamos 1256','2365012',convert(date,'15/01/1990',103),'M','RCardenas.514@hotmail.com','A')
insert into Personal(idPersona, codigoPersona, nombre, apellidoPaterno, apellidoMaterno, direccion, telefono, fechaNac, idSexo,correo,idEstado) values(8,'65113589','Renzo','Inga','Correa','av ucayali 56','8523694',convert(date,'23/08/1991',103),'M','Renzo_1416@hotmail.com','A')
insert into Personal(idPersona, codigoPersona, nombre, apellidoPaterno, apellidoMaterno, direccion, telefono, fechaNac, idSexo,correo,idEstado) values(9,'74258966','Marivel','Sulca','Parra','av union 735','6120000',convert(date,'06/04/1990',103),'M','mavelsp13@hotmail.com','A')

--Cliente select * from Cliente
insert into Cliente(idCliente, ruc, cliente, direccion, contacto,correo, telefono, idEstado) values(1,'20100919002','COLGATE-PALMOLIVE PERU SA','av rosales # 1254','Luis Castro','investor_relation@colpal.com','7462456','A')
insert into Cliente(idCliente, ruc, cliente, direccion, contacto,correo, telefono, idEstado) values(2,'20335020872','HEWLETT PACKARD','Av. Victor Andres Belaunde 147','Victor Hina Azato','servicios.formacion@hp.com','2229161','A')
insert into Cliente(idCliente, ruc, cliente, direccion, contacto,correo, telefono, idEstado) values(3,'20100055237','CONSORCIO PORTA',' Panamericana Sur 1801','Richard Perez','tiendalimanorte@portaline.com','512-3737','A')
insert into Cliente(idCliente, ruc, cliente, direccion, contacto,correo, telefono, idEstado) values(4,'20100050359','AW FABER CASTELL PERUANA SA','Av la Molina 15012','Manuel Cornejo','M.Cornejo@faber-castell.com','6121900','A')
insert into Cliente(idCliente, ruc, cliente, direccion, contacto,correo, telefono, idEstado) values(5,'20103459028','ALICORP SAA','Av. Argentina 4793','Ruben Rojas','rrojasb@alicorp.com.pe','5950444','A')
insert into Cliente(idCliente, ruc, cliente, direccion, contacto,correo, telefono, idEstado) values(6,'20100128056','SAGA FALABELLA S A','Av. Paseo de la República 3220','Joselin Quispe','jquispe@sagafalabella.com.pe','4521404','A')
insert into Cliente(idCliente, ruc, cliente, direccion, contacto,correo, telefono, idEstado) values(7,'20467534026','AMERICA MOVIL PERU S.A.C','AV. NICOLAS ARRIOLA NRO. 480','Angela Vasquez','atencionalcliente@claro.com.pe','6131000','A')
insert into Cliente(idCliente, ruc, cliente, direccion, contacto,correo, telefono, idEstado) values(8,'20372807637','IMPORTACIONES JAAMSA S.A','Jr. Lampa 990','Pablo Rosales','soporte@jaamsa.com','2362006','A')
insert into Cliente(idCliente, ruc, cliente, direccion, contacto,correo, telefono, idEstado) values(9,'20112273922','MAESTRO PERU SA','JR. SAN LORENZO NRO. 881','Willy Condori','maestro@maestro.com.pe','6111900','A')
insert into Cliente(idCliente, ruc, cliente, direccion, contacto,correo, telefono, idEstado) values(10,'20100102413','UNIQUE S.A.',' AV. JUAN DE ARONA NRO. 151','July Carrasco','contacto@negociosmujeres.com','5134156','A')

--select * from Cliente
--select * from Nivel_Personal
insert into Nivel_Personal values ('E',1,'A')
insert into Nivel_Personal values ('S',2,'A')

