Create database ProSalud

use ProSalud

CREATE TABLE Usuarios(
ID int not null identity,                   --0 
Nombre nvarchar(50) not null,               --1
Apellido nvarchar(50) not null,             --2
Edad varchar (20) not null,                 --3
Fecha varchar (20) not null,                --4
Genero varchar (15) not null,               --5
Tel varchar (30) not null,                  --6
Curp nvarchar (50) not null,                --7 
Direccion nvarchar (50) not null,           --8
Correo nvarchar(50) not null,               --9
Usuario nvarchar(50) not null,              --10
Contrase�a varchar(20) not null);           --11

CREATE TABLE Contacto(
ID int not null identity,
Estado varchar (30) not null,
Municipio varchar (30) not null,
Sucursal varchar (20) not null,
Asunto varchar (30) not null,
Correo nvarchar(50) not null,
Comentario nvarchar (100) not null);

select * from Usuarios

CREATE TABLE Cita( 
ID int not null identity,          --0
Sucursal varchar (20) not null,    --1
Municipio varchar (30) not null,   --2
Estado varchar (30) not null,      --3
Fecha varchar (20) not null,       --4
Hora varchar (20) not null,        --5
Estudio varchar (50) not null,     --6
Tipo varchar (50) not null,        --7
Precio varchar (20) not null,      --8
Codigo bigint not null,            --9
Usuario nvarchar(50) not null);   --10

CREATE TABLE Laboratorio( 
ID int not null identity,
Estudio varchar (50) not null,
Precio varchar (20) not null,
Descripcion varchar (max) not null);

Insert into Laboratorio values ('CHECK UP b�sico', '849', 'Indicaciones: un ayuno de 8 a 12 horas antes de que le tomen sus muestras de sangre. Durante ese tiempo no debe ingerir alimentos ni bebidas.')
Insert into Laboratorio values ('Examen antidopaje', '260', 'Indicaciones: en las instalaciones se recoger una muestra de orina (de la mitad del chorro).')
Insert into Laboratorio values ('Prueba de embarazo', '150', 'Indicaciones: ayuno no requerido. Presentar identificaci�n oficial con fotograf�a. En caso de ser menor de edad, la paciente deber� estar acompa�ada del padre, madre o tutor.')
Insert into Laboratorio values ('Biometr�a hem�tica', '105', 'Indicaciones: ayuno m�nimo de 4 horas.')
Insert into Laboratorio values ('Examen general de orina', '150', 'Indicaciones: recolectar la primera orina de la ma�ana en un contenedor para muestras nuevo, desechando la primera parte y recolectando el resto, asear previamente el �rea genital antes de recolectar la muestra.')
Insert into Laboratorio values ('Citologia moco fecal', '63', 'Indicaciones: muestra reciente de heces.')
Insert into Laboratorio values ('Calprotectina fecal', '825', 'Indicaciones: recolectar una muestra de heces en recipiente est�ril la cual no debe estar en contacto con agua u orina. La muestra no debe tener m�s de 2 horas de haber sido recolectada al momento de la entrega.')
Insert into Laboratorio values ('Papanicolaou', '150', 'Indicaciones: realizar la prueba cinco d�as despu�s de haber finalizado el sangrado menstrual. No uses tampones al menos 48 horas antes de la prueba. Evita usar geles lubricantes, duchas o cremas vaginales.')
Insert into Laboratorio values ('Qu�mica Sangu�nea completa', '350', 'Indicaciones: un ayuno de 12 horas. No hacer ejercicio intenso 2 d�as antes de la prueba. Abstenerse de consumir 12 horas antes tabaco, alcohol o cafe�na para no afectar los resultados.')
Insert into Laboratorio values ('Prueba del VIH', '700','Indicaciones: ayuno m�nimo de 8 horas.')
Insert into Laboratorio values ('Ex�menes prenupciales', '550', 'Indicaciones: ayuno m�nimo de 8 horas.')
Insert into Laboratorio values ('Glucosa', '44', 'Indicaciones: ayuno de 8 a 12 horas. No realizar ning�n ejercicio ni desgaste f�sico antes de la toma de muestra. No fumar antes de la toma de muestra, ni ingerir bebidas alcoh�licas 24 horas antes.')
Insert into Laboratorio values ('Perfil tiroideo', '480', 'Indicaciones: ayuno m�nimo de 8 horas.')

select * from Laboratorio

CREATE TABLE Ultrasonido( 
ID int not null identity,
Estudio varchar (50) not null,
Precio varchar (20) not null,
Descripcion varchar (max) not null);

Insert into Ultrasonido values ('Tiroides-cuello', '350', 'Indicaciones: Ninguna. Se sugiere presentar orden m�dica no mayor de 3 meses.')
Insert into Ultrasonido values ('Mamario', '335', 'Indicaciones: Mujeres mayores de 40 a�os traer mastograf�a reciente. Hombres mayores de 20 a�os traer orden medica no mayor de 3 meses. Pacientes menores de 18 a�os presentarse acompa�ado de un adulto.')
Insert into Ultrasonido values ('Testicular', '335', 'Indicaciones: Aseo previo en el �rea genital. Se sugiere presentar solicitud m�dica no mayor de 3 meses.')
Insert into Ultrasonido values ('H�gado y v�as biliares', '190', 'Indicaciones: De 6 horas m�nimo de ayuno s�lido y l�quido..')
Insert into Ultrasonido values ('Transvaginal', '335', 'Indicaciones: Se requiere contar con vejiga vac�a. Aseo previo en el �rea genital, presentar solicitud m�dica no mayor de 3 meses.')
Insert into Ultrasonido values ('Ultrasonido 4D', '305', 'Indicaciones: Se realiza en pacientes entre la semana 14 a 34 de gestaci�n.')
Insert into Ultrasonido values ('Obst�trico TRIM I', '190', 'Indicaciones: Para este estudio se requiere tener vejiga llena, por lo que se sugiere tomar 1.5 litros de agua 30 min antes de realizar el estudio y avisar en consultorio cuando sienta urgencia urinaria.')
Insert into Ultrasonido values ('Obst�trico TRIM ll y lll', '190', 'Indicaciones: Ninguna.')
Insert into Ultrasonido values ('Rodilla musculo tendinoso', '450', 'Indicaciones: Ninguna, presentar orden m�dica no mayor de 3 meses. y acudir con ropa c�moda.')
Insert into Ultrasonido values ('Apendicular', '190','Indicaciones: Ninguna. se sugiere presentar orden m�dica no mayor de 3 meses.')
Insert into Ultrasonido values ('Abdominal inferior', '250', 'Indicaciones: Ayudo s�lido de 6 horas m�nimo. Se requiere tener vejiga llena, se sugiere tomar 1.5 litros de agua 30 min antes de realizar el estudio y avisar en consultorio cuando sienta urgencia urinaria.')
Insert into Ultrasonido values ('Abdominal superior', '220', 'Indicaciones: De 6 horas m�nimo de ayuno s�lido y l�quido.')
Insert into Ultrasonido values ('Renal y de v�as urinarias', '340', 'Indicaciones: Para este estudio se requiere tener vejiga llena, por lo que se sugiere tomar 1.5 litros de agua 30 min antes de realizar el estudio y avisar en consultorio cuando sienta urgencia urinaria.')

select * from Ultrasonido

CREATE TABLE RayosX( 
ID int not null identity,
Estudio varchar (50) not null,
Precio varchar (20) not null,
Descripcion varchar (max) not null);

Insert into RayosX values ('Abdomen AP', '290', 'Indicaciones: Se recomienda presentar orden m�dica en caso de contar con ella.')
Insert into RayosX values ('Antebrazo Cubito y Radio AP', '190', 'Indicaciones: Se recomienda presentar orden m�dica en caso de contar con ella.')
Insert into RayosX values ('Brazo Humero AP', '190', 'Indicaciones: Se recomienda presentar orden m�dica en caso de contar con ella.')
Insert into RayosX values ('Clav�cula AP y Oblicua', '330', 'Indicaciones: Se recomienda presentar orden m�dica en caso de contar con ella.')
Insert into RayosX values ('Columna Cervical y Lumbar', '560', 'Indicaciones: Se recomienda presentar orden m�dica en caso de contar con ella.')
Insert into RayosX values ('Columna Dorsal y Lumbar', '560', 'Indicaciones: Se recomienda presentar orden m�dica en caso de contar con ella.')
Insert into RayosX values ('Cr�neo AP', '250', 'Indicaciones: Cabello seco y limpio, sin fijador ni crema para cabello. Se recomienda presentar orden m�dica de contar con ella.')
Insert into RayosX values ('F�mur AP', '590', 'Indicaciones: Ninguna.')
Insert into RayosX values ('Mano AP', '190', 'Indicaciones: Ninguna.')
Insert into RayosX values ('Mu�eca T�nel del Carpo', '330','Indicaciones: Ninguna.')
Insert into RayosX values ('Pelvis AP -Cadera- y Oblicua', '200', 'Indicaciones: Ninguna.')
Insert into RayosX values ('Pierna -Tibia y Peron�- AP', '190', 'Indicaciones: Ninguna.')
Insert into RayosX values ('Tobillo AP', '200', 'Indicaciones: Ninguna.')
Insert into RayosX values ('T�rax �seo AP y oblicua ', '330', 'Indicaciones: Es obligatorio presentar orden m�dica impresa, no se aceptan en medios digitales como WhatsApp y correo electr�nico.')

select * from RayosX

CREATE TABLE Resonancia( 
ID int not null identity,
Estudio varchar (50) not null,
Precio varchar (20) not null,
Descripcion varchar (max) not null);

Insert into Resonancia values ('Abdomen', '2800', 'Indicaciones: Ayuno m�nimo de 4 horas. No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')
Insert into Resonancia values ('Antebrazo y brazo', '3850', 'Indicaciones: Ayuno m�nimo de 4 horas. No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')
Insert into Resonancia values ('Cadera', '2800', 'Indicaciones: Ayuno m�nimo de 4 horas. No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')
Insert into Resonancia values ('Columna Cervical', '2800', 'Indicaciones: Ayuno m�nimo de 4 horas. No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')
Insert into Resonancia values ('Columna Lumbar', '2800', 'Indicaciones: Ayuno m�nimo de 4 horas. No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')
Insert into Resonancia values ('Cr�neo', '2800', 'Indicaciones: Ayuno m�nimo de 4 horas. No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')
Insert into Resonancia values ('Cuello Tejidos Blandos', '2800', 'Indicaciones: No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')
Insert into Resonancia values ('Gl�ndulas Suprarrenales', '3850', 'Indicaciones: Ayuno m�nimo de 4 horas. No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')
Insert into Resonancia values ('Hombro', '3850', 'Indicaciones: Ayuno m�nimo de 4 horas. No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')
Insert into Resonancia values ('Neurinoma del Ac�stico', '2800','Indicaciones: No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')
Insert into Resonancia values ('Pelvis', '3850', 'Indicaciones: Ayuno m�nimo de 4 horas. No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')
Insert into Resonancia values ('Pierna Y Pie', '3850', 'Indicaciones: No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')
Insert into Resonancia values ('Prenatal', '2800', 'Indicaciones: No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')
Insert into Resonancia values ('Pr�stata', '3850', 'Indicaciones: Ayuno m�nimo de 4 horas. No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')
Insert into Resonancia values ('T�rax', '2800', 'Indicaciones: No es necesario suspender medicamento. Se recomienda orden medica en caso de contar con ella. No se realizan estudios con sedaci�n.')

select * from Resonancia

CREATE TABLE Tomografia( 
ID int not null identity,
Estudio varchar (50) not null,
Precio varchar (20) not null,
Descripcion varchar (max) not null);

Insert into Tomografia values ('Abdominopelvico', '1250', 'Indicaciones: Se requiere orden m�dica. Ayuno m�nimo de 6 horas. Pacientes deben de hidratarse previamente a su cita. No se realizan estudios con sedaci�n. Acudir 2 horas antes de su cita.')
Insert into Tomografia values ('Antebrazo y Brazo', '1250', 'Indicaciones: Se recomienda orden m�dica. No se realizan estudios con sedaci�n.')
Insert into Tomografia values ('Cadera', '1250', 'Indicaciones: Se recomienda orden m�dica. No se realizan estudios con sedaci�n.')
Insert into Tomografia values ('Columna Cervical', '2850', 'Indicaciones: Se recomienda orden m�dica. No se realizan estudios con sedaci�n.')
Insert into Tomografia values ('Columna Dorsal', '2850', 'Indicaciones: Se recomienda orden m�dica. No se realizan estudios con sedaci�n.')
Insert into Tomografia values ('Cr�neo y Cuello', '1250', 'Indicaciones: Se recomienda orden m�dica. No se realizan estudios con sedaci�n.')
Insert into Tomografia values ('Mano y Mu�eca', '1250','Indicaciones: Se recomienda orden m�dica. No se realizan estudios con sedaci�n.')
Insert into Tomografia values ('Macizo Facial', '2850', 'Indicaciones: Se recomienda orden m�dica. No se realizan estudios con sedaci�n.')
Insert into Tomografia values ('Pelvis', '1250', 'Indicaciones: Se recomienda orden m�dica. No se realizan estudios con sedaci�n.')
Insert into Tomografia values ('Pie y Pierna', '2850', 'Indicaciones: Se recomienda orden m�dica. No se realizan estudios con sedaci�n.')
Insert into Tomografia values ('Senos Paranasales', '2900', 'Indicaciones: Se requiere orden m�dica. Ayuno m�nimo de 6 horas. Pacientes deben de hidratarse previamente a su cita. No se realizan estudios con sedaci�n. Acudir 2 horas antes de su cita.')
Insert into Tomografia values ('T�rax', '1250', 'Indicaciones: Se recomienda orden m�dica. No se realizan estudios con sedaci�n.')

select * from Tomografia

CREATE TABLE Electro( 
ID int not null identity,
Estudio varchar (50) not null,
Precio varchar (20) not null,
Descripcion varchar (max) not null);

Insert into Electro values ('Electrocardiograma', '125', 'Indicaciones: Se recomienda Dos horas antes del examen, No ingerir bebidas alcoh�licas o energ�ticas. No haber bebido caf�. No fumar. No haber realizado actividad f�sica extenuante.')

select * from Electro

CREATE TABLE Resultado( 
ID int not null identity,
Nombre varchar (20) not null,
Apellido varchar (30) not null,
Cedula varchar (30) not null,
Descripcion varchar (100) not null,
Codigo bigint not null,
Imagen image not null);

create function dbo.CitaConsulta(@codigo bigint)
returns @Consulta table(
Nombre varchar(50) not null,               
Apellido varchar(50) not null,             
Edad varchar (20) not null,   
Genero varchar (15) not null,   
Fecha varchar (20) not null,       
Hora varchar (20) not null,        
Estudio varchar (50) not null,     
Tipo varchar (50) not null,
Codigo bigint)
as
begin
insert @Consulta select Usuarios.Nombre, Usuarios.Apellido, Usuarios.Edad, Usuarios.Genero, Cita.Fecha, Cita.Hora, Cita.Estudio, Cita.Tipo, Cita.Codigo
     FROM Usuarios
     INNER JOIN Cita ON Usuarios.Usuario = Cita.Usuario 
	 where Codigo = @Codigo
return
end

select * from CitaConsulta(87929274)

select * from Usuarios 

select * from Contacto

select * from Cita

select * from Resultado

select * from Dias

delete from Resultado where id= 3