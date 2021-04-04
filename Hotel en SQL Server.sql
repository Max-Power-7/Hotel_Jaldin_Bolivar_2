create database Hotel
go
use hotel

--Para saber que triggers actuan sobre la tabla Habitacioion
--

--Para borrar un trigger completamente de la base de datos
--drop trigger Habitacion_Libre

--PARA DESHABILITAR Y HABILITAR UN TRIGGER
--disable trigger Habitacion_Libre on detalle_habitacion
--enable trigger Habitacion_Libre on detalle_habitacion

--Para deshabilitar un boton en un formulario en visual 
--button2.Enabled = false;

--Consulta para ver todas las tablas en una base de datos
SELECT CAST(table_name as varchar)  FROM INFORMATION_SCHEMA.TABLES

--TABLAS
--drop table Cliente_Titular
create table Cliente_Titular(
id_cliente int primary key identity(1,1),
ci int not null,
nombre varchar(30) not null,
paterno varchar(30) not null,
materno varchar(30),
lugar_nacimiento varchar(30) not null,
telefono int,
fecha_nac date,
extranjero varchar(2)not null check(extranjero in('Si','No')),
id_huesped int default null,
foreign key(id_huesped)references Cliente_Titular(id_cliente)
)

--select *from Cliente_Titular
create table Tipo_Empleado(
id_tipoEmpleado int primary key identity(1,1),
cargo varchar(40) not null
)
create table Detalle_habitacion(
id_detalle int primary key identity(1,1),
camas int not null,
limite_personas int not null,
tv_cable char(2) not null check(tv_cable in('SI','NO')),
dvd char(2) not null check(dvd in('SI','NO')),
aire_acondicionado char(2) not null check(aire_acondicionado in('SI','NO')),
internet char(2) not null check(internet in('SI','NO')),
baño_privado char(2) not null check(baño_privado in('SI','NO')),
)
create table Tipo_Habitacion(
id_tipoHabitacion int primary key identity(1,1),
tipo varchar(30) not null,
precio money not null,
id_detalle int not null,
foreign key (id_detalle)references Detalle_habitacion(id_detalle)
)
create table Habitacion(
id_habitacion int primary key identity(1,1),
nro_habitacion int not null,
nro_piso int not null,
estado varchar(20) not null,
id_tipoHabitacion int not null,
foreign key(id_tipoHabitacion) references Tipo_Habitacion(id_tipoHabitacion)
)
create table Empleado(
id_empleado int primary key identity(1,1),
ci int not null,
nombre varchar(30) not null,
paterno varchar(30) not null,
materno varchar(30),
telefono int not null,
fecha_ingreso date not null,
sueldo money not null,
id_tipoEmpleado int not null,
id_jefe int,
foreign key(id_jefe)references Empleado(id_empleado),
foreign key(id_tipoEmpleado)references Tipo_Empleado(id_tipoEmpleado)
)
create table Nota_Hospedaje(
id_nota int primary key identity(1,1),
fecha date,
monto money, 
id_cliente int,
id_empleado int,
foreign key(id_cliente)references Cliente_Titular(id_cliente),
foreign key(id_empleado)references Empleado(id_empleado)
)
create table Detalle_Hospedaje(
id_nota int not null,
id_habitacion int not null,
primary key(id_nota,id_habitacion),
foreign key(id_nota) references Nota_Hospedaje(id_nota), 
foreign key(id_habitacion)references Habitacion(id_habitacion),
cant_dias int,
descuento float,
fecha_salida date not null,
preciov money
)
create table Reserva(
id_reserva int primary key identity(1,1),
fecha_reserva date,
plazo_dias int,
estado varchar(30),
id_cliente int,
foreign key(id_cliente)references Cliente_Titular(id_cliente),
id_habitacion int,
foreign key(id_habitacion) references Habitacion(id_habitacion),
id_empleado int,
foreign key(id_empleado) references Empleado(id_empleado),
)

-------              PROCEDIMIENTOS ALMACENADOS           ----------
GO
-------              CLIENTE           ----------
--PROCEDIMINETO INSERTAR CLIENTE
create procedure insertar_cliente(
@ci int, 
@nombre varchar(30),
@paterno varchar(30),
@materno varchar(30),
@lugar_nacimiento varchar(30),
@telefono int,
@fecha_nac date,
@extranjero char(2),
@id_huesped int 
)as
if (@id_huesped =0)
begin
	set @id_huesped=null
end
begin 
   begin try
      begin tran	 
		if ((select count(ci) from Cliente_Titular where ci=@ci)=0)
		begin
		   insert into Cliente_Titular values(@ci,@nombre,@paterno,@materno,@lugar_nacimiento,@telefono,@fecha_nac,@extranjero,@id_huesped)
	       commit tran
		end 
		else
		begin
		   print 'El CI ya existe'
		   rollback tran return
		end 
   end try
   begin catch    
     raiserror('Error insertando cliente',16,1) 
	 rollback tran
   end catch
end
go

--PROCEDIMIENTO MODIFICAR CLIENTE
create procedure modificar_cliente(
@id_cliente1 int,
@ci1 int, 
@nombre1 varchar(30),
@paterno1 varchar(30),
@materno1 varchar(30),
@lugar_nacimiento1 varchar(30),
@telefono1 int,
@fecha_nac1 date,
@extranjero1 char(2),
@id_huesped1 int
)as
if (@id_huesped1=0)
begin
	set @id_huesped1=null
end
begin      
	    begin try
			begin tran
			update Cliente_Titular set ci=@ci1 ,
		                           nombre=@nombre1 ,
								   paterno=@paterno1 ,
								   materno=@materno1 ,
								   lugar_nacimiento=@lugar_nacimiento1,
								   telefono=@telefono1,
								   fecha_nac=@fecha_nac1,
								   extranjero=@extranjero1,								
								   id_huesped=@id_huesped1
								   where id_cliente=@id_cliente1
								  commit transaction         
	    end try
		begin catch
		    rollback transaction 
			print 'Error al modificar' 
		end catch
end
go

--PROCEDIMIENTO ELIMINAR CLIENTE
create procedure eliminar_cliente(
@id_cliente2 int
)as
begin 
   begin try
   begin transaction 	  
	      delete Cliente_Titular where id_cliente=@id_cliente2 
	      commit transaction     
	end try   	  
	begin catch
	    rollback transaction
		print 'error'
	end catch
end
go

-------              TIPO EMPLEADO           ----------
--PROCEDIMIENTO INSERTAR TIPO EMPLEADO
create procedure inser_tipoEmpleado(
@cargo varchar(30)
)as
begin
  begin try
     begin tran
	 insert into Tipo_Empleado values(@cargo)
	 commit tran
  end try
  begin catch
     rollback tran
	 print 'error'
  end catch
end
go

--PROCEDIMIENTO MODIFICAR TIPO EMPLEADO
create procedure Modificar_Tipo_Empleado(
@id_tipo_empleado int,
@cargo varchar(30)
)as
begin
  begin try 
     begin transaction
	    update Tipo_Empleado set cargo=@cargo where id_tipoEmpleado=@id_tipo_empleado
		commit tran
  end try
  begin catch
     rollback transaction
	 print 'error'
  end catch
end
go

--PROCEDIMIENTO ELIMINAR TIPO EMPLEADO
create procedure Eliminar_Tipo_Empleado(
@id_tipo_empleado int
)as
begin
  begin try 
     begin transaction
	    delete Tipo_Empleado where id_tipoEmpleado=@id_tipo_empleado
		commit tran
  end try
  begin catch
     rollback tran
	 print 'error'
  end catch
end
go

-------              EMPLEADO           ----------
go
--PROCEDIMIENTO INSERTAR EMPLEADO
create procedure insertar_empleado(
@ci_emp int,
@nombre_emp varchar(30),
@paterno_emp varchar(30),
@materno_emp varchar(30),
@telefono_emp int,
@fecha_ingreso date,
@sueldo money,
@id_tipo varchar(30),
@id_jefe int
)as
begin	
   begin try 
	  declare @tipo int
      begin tran
		 if ((select count (ci) from Empleado where ci=@ci_emp)=0)
		 begin  
		   set @tipo=(select id_tipoEmpleado from Tipo_Empleado where cargo= @id_tipo)
		   if(@id_jefe=0) 
		   begin 
				set @id_jefe=null 
		   end
		   insert into Empleado values(@ci_emp,@nombre_emp,@paterno_emp,@materno_emp,@telefono_emp,@fecha_ingreso,@sueldo,@tipo,@id_jefe)
	       commit tran
		 end
		 else
		 begin
		    print 'El CI ya existe'
		   rollback tran return 
		 end
   end try
   begin catch
      raiserror ('Error nsertando al empleado',16,1)
	  rollback tran	  
   end catch
end
go

go
--PROCEDIMIENTO MODIFICAR EMPLEADO
create procedure Modificar_Empleado(
@id_empleado int,
@ci1 int,
@nombre1 varchar(30),
@paterno1 varchar(30),
@materno1 varchar(30),
@telefono1 int,
@fecha_ingreso date,
@sueldo money,
@id_tipo_empl varchar(30),
@id_jef int
)as
begin
  begin try 
	declare @tipo int
	set @tipo=0
      begin tran
			if(@id_tipo_empl='recepcionista') set @tipo=1
			if(@id_tipo_empl='encargado de limpieza') set @tipo=2
			if(@id_tipo_empl='botones') set @tipo=3
			if(@id_tipo_empl='tecnico plomero') set @tipo=4
			if(@id_tipo_empl='tecnico electricista') set @tipo=5
			if(@id_jef=0) begin set @id_jef=null end
      update Empleado set ci=@ci1,
						  nombre=@nombre1,
						  paterno=@paterno1,
						  materno=@materno1,
						  telefono=@telefono1,
						  fecha_ingreso=@fecha_ingreso,
						  sueldo=@sueldo,
						  id_tipoEmpleado=@tipo,
						  id_jefe=@id_jef
	  where id_empleado=@id_empleado
    commit tran
  end try
  begin catch
     raiserror ('Error modificando al empleado',16,1)
	 rollback transaction   
  end catch
end
go

--PROCEDIMIENTO ELIMINAR_EMPLEADO
create proc Eliminar_empleado( 
@id_emp int
)as
begin try
	begin tran	
		delete from Empleado where id_empleado=@id_emp
	commit tran
end try
begin catch
	raiserror ('Error eliminando empleado',16,1)
	rollback tran
end catch

-------              NOTA HOSPEDAJE           ----------

go

--PROCEDIMIENTO INSERTAR_NOTA
create proc Insertar_Nota( 
@id_cli int,
@id_emp int
)as
begin try
	declare @fecha_N date
	declare @monto_N money
	set @fecha_N=getdate()
	set @monto_N=0
	begin tran	
		insert into Nota_Hospedaje values(@fecha_N,@monto_N,@id_cli,@id_emp)
	commit tran
end try
begin catch
	raiserror ('Error insertando nota',16,1)
	rollback tran
end catch
go

--PROCEDIMIENTO MODIFICAR_NOTA
create proc Modificar_Nota(
@id_nota int,
@fecha_N date,
@monto_N money,
@id_cli int,
@id_emp int
)as
begin
	begin try
		begin tran
		update Nota_Hospedaje 
		set fecha=@fecha_N,monto=@monto_N,id_cliente=@id_cli,id_empleado=@id_emp
		where id_nota=@id_nota
		commit tran
	end try
	begin catch
		raiserror ('Error',16,1)
		rollback tran
	end catch
end
go

--PROCEDIMIENTO ELIMINAR_NOTA
create procedure Eliminar_Nota(
@id_nota int
)as
begin
	begin try
		begin tran
		delete Nota_Hospedaje where id_nota=@id_nota
		commit tran
	end try
	begin catch
		print 'error'
		rollback tran
	end catch
end

-------              DETALLE HABITACION           ----------
go
--PROCEDIMIENTO INSERTAR DETALLEHABITACION
create procedure Insertar_Detalle_Hab(
@camas int,
@limite_personas int,
@tv_cable char(2),
@dvd char(2),
@aire_acondicionado char(2),
@internet char(2),
@baño_privado char(2)
)as
begin try 
	begin tran
		insert into Detalle_habitacion values(@camas,@limite_personas,@tv_cable,@dvd,@aire_acondicionado,@internet,@baño_privado)
	commit tran
end try
begin catch
	print 'error'
	rollback tran
end catch

go
--PROCEDIMIENTO MODIFICAR DETALLEHABITACION
create procedure Modificar_Detalle_Hab(
@id_detalle int,
@camas int,
@limite_personas int,
@tv_cable char(2),
@dvd char(2),
@aire_acondicionado char(2),
@internet char(2),
@baño_privado char(2)
)as
begin try 
	begin tran
		update Detalle_habitacion set camas=@camas,
									limite_personas=@limite_personas,
									tv_cable=@tv_cable,
									dvd=@dvd,
									aire_acondicionado=@aire_acondicionado,
									internet=@internet,
									baño_privado=@baño_privado
		where id_detalle=@id_detalle
	commit tran
end try
begin catch
	print 'error'
	rollback tran
end catch

go
--PROCEDIMIENTO ELIMINAR DETALLEHABITACION
create procedure Eliminar_Detalle_Hab(
@id_detallehab int
)as
begin try 
	begin tran
		delete Detalle_habitacion where id_detalle=@id_detallehab	
	commit tran
end try
begin catch
	print 'error'
	rollback tran
end catch

go
-------            TIPO HABITACION           ----------

--PROCEDIMIENTO INSERTAR TIPOHABITACION
create procedure Insertar_TipoHab(
@tipo varchar(30),
@precio money,
@id_detalle int
)as
begin try 
	begin tran
		insert into Tipo_Habitacion values(@tipo,@precio,@id_detalle)
	commit tran
end try
begin catch
	print 'error'
	rollback tran
end catch

go
--PROCEDIMIENTO MODIFICAR TIPOHABITACION
create procedure Modificar_TipoHab(
@id_tipo int,
@tipo varchar(30),
@precio money,
@id_detalle int
)as
begin try 
	begin tran
		update Tipo_Habitacion set tipo=@tipo,
									precio=@precio,
									id_detalle=@id_detalle
		where id_tipoHabitacion=@id_tipo
	commit tran
end try
begin catch
	print 'error'
	rollback tran
end catch

go
--PROCEDIMIENTO ELIMINAR TIPOHABITACION
create procedure Eliminar_TipoHab(
@id_tipo int
)as
begin try 
	begin tran
		delete Tipo_Habitacion where id_tipoHabitacion=@id_tipo
	commit tran
end try
begin catch
	print 'error'
	rollback tran
end catch

go
-------             HABITACION           ----------
--PROCEDIMIENTO INSERTAR HABITACION
create procedure Insertar_Hab(
@nro_hab int,
@nro_piso int,
@estado varchar(15),
@id_tipo int
)as
begin try 
	begin tran
		insert into Habitacion values(@nro_hab,@nro_piso,@estado,@id_tipo)
	commit tran
end try
begin catch
	print 'error'
	rollback tran
end catch
go

--PROCEDIMIENTO MODIFICAR HABITACION
create procedure Modificar_Hab(
@id_hab int,
@nro_hab int,
@nro_piso int,
@estado varchar(15),
@id_tipo int
)as
begin try 
	begin tran
		update Habitacion 
		set nro_habitacion=@nro_hab,
			nro_piso=@nro_piso,
			estado=@estado,
			id_tipoHabitacion=@id_tipo
		where id_habitacion=@id_hab
	commit tran
end try
begin catch
	print 'error'
	rollback tran
end catch
go

--PROCEDIMIENTO ELIMINAR HABITACION
create procedure Eliminar_Hab(
@id_hab int
)as
begin try 
	begin tran
		delete Habitacion where id_habitacion=@id_hab
	commit tran
end try
begin catch
	print 'error'
	rollback tran
end catch

go
-------          RESERVA         --------------

--PROCEDIMIENTO INSERTAR RESERVA
create procedure Insertar_Reserva(
@fecha_r date,
@plazo_dias int,
@estado varchar(15),
@id_cli int,
@id_hab int,
@id_emp int
)as
begin try 
	begin tran	   
	   set @estado ='Vigente'
	   set @fecha_r =GETDATE()
	   set @id_emp =(select id_empleado from Empleado where id_empleado=@id_emp)
	   if ((select estado from Habitacion where id_habitacion=@id_hab)<>'libre')
          begin
	        print 'habitacion no disponible'
	        rollback tran return
    	  end
	   else
       begin
			insert into Reserva values(@fecha_r,@plazo_dias,@estado,@id_cli,@id_hab,@id_emp)	   
			update Habitacion set estado= 'Reservado'
			where id_habitacion=@id_hab
			commit tran
	   end
end try
begin catch
	print 'error'
	rollback tran
end catch
 GO 

--PROCEDIMIENTO MODIFICAR RESERVA
create procedure Modificar_Reserva(
@id_reserva int,
@fecha_r date,
@plazo_dias int,
@estado varchar(15),
@id_cli int,
@id_hab int,
@id_emp int
)as
begin try 
	begin tran
		update Reserva 
		set fecha_reserva=@fecha_r,
			plazo_dias=@plazo_dias,
			estado=@estado,
			id_cliente=@id_cli,
			id_habitacion=@id_hab,
			id_empleado=@id_emp
		where id_reserva=@id_reserva
	commit tran
end try
begin catch
	print 'error'
	rollback tran
end catch

GO
--PROCEDIMIENTO ELIMINAR RESERVA
create procedure Eliminar_Reserva(
@id_reserva int
)as
begin try 
	begin tran
		declare @id_habitacion int
		set @id_habitacion=(select id_habitacion from Reserva where id_reserva=@id_reserva)
		update Habitacion set estado='libre' where id_habitacion =@id_habitacion
		delete Reserva where id_reserva=@id_reserva
	    commit tran
end try
begin catch
	print 'error'
	rollback tran
end catch

-------          DETALLE HOSPEDAJE         --------------
go
--PROCEDIMIENTO INSERTAR DETALLE HOSPEDAJE
create procedure Insertar_Detalle_Hospedaje(
@id_hab int,
@cant_dias int
)as
begin try
	declare @id_nota int
	declare @descuento float
	declare @fecha_salida date
	declare @preciov money
	set @id_nota=(select max(id_nota) from Nota_Hospedaje)
	set @fecha_salida=getdate()
	set @descuento=0
	set @preciov=0
	begin tran
		insert into Detalle_Hospedaje values(@id_nota,@id_hab,@cant_dias,@descuento,@fecha_salida,@preciov)
	commit tran
end try
begin catch
	print 'error insertando detalle hospedaje'
	rollback tran
end catch
go
--PROCEDIMIENTO MODIFICAR DETALLEHOSPEDAJE
create procedure Modificar_Detalle_Hospedaje(
@id_nota int,
@id_hab int,
@cant_dias int,
@descuento float,
@fecha_salida date,
@preciov money
)as
begin try 
	begin tran
		set @fecha_salida=(select fecha from Nota_Hospedaje where id_nota=@id_nota)
		set @fecha_salida=(dateadd(day,@cant_dias,@fecha_salida))

		set @preciov=(@cant_dias*(select precio 
								  from Habitacion,Tipo_Habitacion 
								  where habitacion.id_tipoHabitacion=Tipo_Habitacion.id_tipoHabitacion and id_habitacion=@id_hab))
		update Detalle_Hospedaje 
		set cant_dias=@cant_dias,	
			descuento=@descuento,
			fecha_salida=@fecha_salida,
			preciov=@preciov
		where id_nota=@id_nota and id_habitacion=@id_hab
		
		update Nota_Hospedaje set monto=@preciov-(@preciov*(@descuento/100)) where id_nota=@id_nota
	commit tran
end try
begin catch
	print 'error'
	rollback tran
end catch
go

--PROCEDIMIENTO ELIMINAR DETALLEHOSPEDAJE
create procedure Eliminar_Detalle_Hospedaje(
@id_nota int,
@id_hab int
)as
begin try 
	begin tran
		delete Detalle_Hospedaje 
		where id_nota=@id_nota and id_habitacion=@id_hab
	commit tran
end try
begin catch
	print 'error eliminando el detalle'
	rollback tran
end catch
go



--Procedimiento para poblar "n" habitaciones
create procedure Poblar_Habitaciones(
@n int
)as
declare @c int
declare @piso int
declare @aux int
begin try 
	begin tran		
		set @c=1
		set @piso=1
		while(@c<=@n)
		begin
			set @aux=1
			while(@aux<5)
			begin
				exec Insertar_Hab @c,@piso,'libre',@piso
				set @c=@c+1
				set @aux=@aux+1
			end
			if(@aux=5)			
			begin 
				exec Insertar_Hab @c,@piso,'libre',@piso
			end
			set @piso = @piso+1
			set @c=@c+1						
		end
	commit tran
end try
begin catch
	print 'error poblando habitaciones'
	rollback tran
end catch

-------          TRIGGERS         --------------
go
--TRIGGER QUE VERIFICA QUE LA EDAD DE LOS CLIENTES TITULARES SEA LA ADECUADA PARA ACCEDER AL SERVICIO DE HOSPEDAJE
create trigger Verificar_edad
on cliente_titular
for insert
as
begin
     if(select datediff(year,fecha_nac,getdate()) from inserted) < 18 
	 begin
		if (select id_huesped from inserted)is null
		begin			
			print 'No puede hospedarse un menor de edad solo'
			rollback tran						
		end
	 end	 
end
go


--Trigger para actualizar los datos de fecha salida en la tabla detalle_hospedaje de forma correcta y coherente con los demas
--datos asociados
go
create trigger insertar_fecha_salida 
on Detalle_Hospedaje
for insert
as 
begin     	 
     declare @cant_d int
	 declare @fecha_ini date
	 set @cant_d=(select cant_dias from inserted)
	 set @fecha_ini=getdate()
	 update Detalle_Hospedaje 
	 set fecha_salida = DATEADD(day,@cant_d,@fecha_ini)
	 where id_nota=(select id_nota from inserted) and id_habitacion=(select id_habitacion from inserted)
end
GO

--Trigger que cambie el estado de una habitacion a ocupada
create trigger Habitacion_Ocupada
on Detalle_Hospedaje
for insert
as
begin
	update Habitacion
	set estado='Ocupada'
	where id_habitacion=(select id_habitacion from inserted)
end
go

--Añade el Descuento Precio Venta y Monto Total
create trigger descuento_preciov_monto
on Detalle_Hospedaje
for insert
as
begin
   declare @preciov money
   declare @cantidad_dias int
   declare @precio_habitacion money
   declare @monto_total money
   declare @descuento int   
   --guardamos el precio de la habitacion
   set @precio_habitacion =(select precio                                       
                            from Habitacion,Tipo_Habitacion 
                            where Habitacion.id_tipoHabitacion=Tipo_Habitacion.id_tipoHabitacion 
							and id_habitacion=(select  id_habitacion from inserted) )    
   --guardamos la cantidad de dias   
   set @cantidad_dias=(select cant_dias from inserted)    
   --Añadimos el descuento del 10% si la cantidad de dias es  mayor igual a 10
   if (@cantidad_dias >= 10)
   begin
             update Detalle_Hospedaje 
			 set descuento = 10
	         where id_habitacion=(select id_habitacion from inserted) and
			       id_nota=(select id_nota from inserted)			     
      set @descuento = 10   --guardamos el descuento
   end
   else
   begin
      update Detalle_Hospedaje set descuento= 0
	               where id_habitacion=(select id_habitacion from inserted) and
			       id_nota=(select id_nota from inserted)
      set @descuento = 0;    --guardamos el descuento
   end
   --guardamos el precio de la venta							   
	set @preciov = @precio_habitacion*@cantidad_dias  
   --Seteamos el precio de la venta (cantidad_dias  x  precio_habitacion)
    update Detalle_Hospedaje set preciov = @preciov 
	where id_habitacion= (select id_habitacion from inserted)
	and id_nota=(select id_nota from inserted)                               	
   -- Seteamos el monto total de preguntando si tiene descuento o no
      if (@descuento = 0)
	  begin
	    set @monto_total=@preciov
	  end
	  else
	  begin
		set @monto_total=(@preciov - ( @preciov *0.1))	     
	  end
	-- Sumamos todos los precios de venta anteriores de habitaciones pertenecientes a la misma nota
	set @monto_total=(select sum(preciov) from Detalle_Hospedaje where id_nota=(select id_nota from inserted)) --+@monto_total
	--Agregamos el monto total por fin a la nota
	update Nota_Hospedaje set monto=@monto_total
	where id_nota=( select id_nota from inserted )	
end

--Trigger que cambia el estado de una habitacion a libre o disponible
--cuando se elimina el detalle hospedaje que le correspondia
go
create trigger Habitacion_Libre_Del
on Detalle_Hospedaje
for delete
as
begin	
	update Habitacion
	set estado='Libre'
	where id_habitacion=(select id_habitacion from deleted)		
	--Disminuyendo el precio de venta que fue eliminado al monto total
	update Nota_Hospedaje
	set monto=monto-(select preciov from deleted)
	where id_nota=(select id_nota from deleted)
end
go
--Trigger que cambia el estado de una habitacion a libre o disponible cuando se modifica un detalle hospedaje
--y su fecha salida resulta ser menor que la actual
create trigger Habitacion_Libre_Upd
on Detalle_Hospedaje
for update
as
begin	
	if(getdate()>(select fecha_salida from deleted))
	update Habitacion
	set estado='Libre'
	where id_habitacion=(select id_habitacion from deleted)		
end
go
--El cliente insertado en Nota_Hospedaje que sea huesped o acompañante de uno titular pasa a ser titular cuando obtiene su nota
create trigger Insertar_Cliente_Huesped 
on Nota_Hospedaje
for insert 
as
begin    
    if ((select id_huesped from Cliente_Titular where id_cliente=(select id_cliente from inserted)) is not  null)
	begin
	  update Cliente_Titular set id_huesped = null 
	  where id_cliente=(select id_cliente from inserted)
	end
end





------------------------POBLANDO TABLAS CON LOS PROCEDIMIENTOS--------------------------------------------

--select *from Cliente_Titular
exec Insertar_Cliente 9543214,'Michael','Ballack','GorLitz','Alemania',75461353,'12/09/1989','SI',NULL
exec Insertar_Cliente 5971246,'Jose','Orlando','Lopez','Bolivia',75313218,'08/04/1998','NO',1
exec Insertar_Cliente 6124321,'Gustavo','Martinez','Almanza','Bolivia',78132184,'15/07/1997','NO',1
exec Insertar_Cliente 4132136,'Humberto','Velez','Barrera','Bolivia',61233218,'16/05/1997','NO',NULL
exec Insertar_Cliente 6456237,'Yolanda','Arnold','Escobar','Bolivia',63298718,'13/03/1997','NO',4
exec Insertar_Cliente 4567823,'Fabricio','Ramos','Ojeda','Bolivia',69945218,'11/01/1997','NO',NULL
exec Insertar_Cliente 9864546,'Esteban','Toledo','Burgos','Bolivia',73123218,'16/03/1997','NO',NULL
exec Insertar_Cliente 9756423,'Ximena','Velez','Barrera','Ecuador',76413215,'19/10/1997','SI',NULL
exec Insertar_Cliente 9142378,'Oliver','Contreras','Polimero','Bolivia',61233218,'23/12/1996','NO',NULL
exec Insertar_Cliente 9425637,'Zanderson','Jalisco','Rivera','Bolivia',61233218,'27/11/1997','NO',NULL

--select *from Detalle_habitacion
exec Insertar_Detalle_Hab 1,2,'SI','NO','NO','NO','NO'
exec Insertar_Detalle_Hab 4,6,'SI','SI','SI','SI','SI'
exec Insertar_Detalle_Hab 2,2,'SI','NO','SI','SI','SI'
exec Insertar_Detalle_Hab 1,2,'SI','SI','SI','SI','SI'

--select *from Tipo_Habitacion
exec Insertar_TipoHab 'simple',80,1
exec Insertar_TipoHab 'familiar',200,1
exec Insertar_TipoHab 'matrimonial',350,1
exec Insertar_TipoHab 'especial',150,1

--select *from Habitacion
exec Poblar_Habitaciones 20

--select *from Tipo_Empleado
exec inser_tipoEmpleado 'recepcionista'
exec inser_tipoEmpleado 'encargado de limpieza'
exec inser_tipoEmpleado 'botones'
exec inser_tipoEmpleado 'tecnico plomero'
exec inser_tipoEmpleado 'tecnico electricista'

--select *from Empleado
exec insertar_empleado 9543813,'Joshua','Colision','Jalisco',64534745,'04/06/2010',1100,'recepcionista',null
exec insertar_empleado 9212234,'Lorenzo','Estrada','Tamales',74539134,'05/04/2011',1100,'encargado de limpieza',1
exec insertar_empleado 9436787,'Ulises','Matutino','',69808543,'24/03/2015',1100,'encargado de limpieza',1
exec insertar_empleado 9143584,'Yolanda','Pantera','Santuario',61254534,'17/04/2013',1100,'encargado de limpieza',1
exec insertar_empleado 9074783,'Alejandra','Toledo','Figeroa',60324234,'11/01/2017',1100,'botones',1
exec insertar_empleado 9132485,'Daniela','Olivares','Marcial',72134325,'13/02/2015',1100,'botones',1
exec insertar_empleado 9578404,'Grabiela','Pintora','Bolero',68944323,'19/04/2012',1100,'tecnico plomero',1
exec insertar_empleado 9314853,'Miranda','Carballo','Montes',70348534,'22/05/2011',1100,'tecnico electricista',1
exec insertar_empleado 58578,'Muriel','Liston','Aguilar',6542877,'22/04/2017',1100,'tecnico electricista',1


