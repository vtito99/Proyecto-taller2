INSERT INTO Usuario(id, pass, nombre, apellido, tipoUsuario, fechaNacimiento, mail)
values ('villalva03', 'tito', 'Francisco', 'Villalva', 'Vendedor', '03/10/91', 'villalva03@gmail.com')

INSERT INTO Usuario(id, pass, nombre, apellido, tipoUsuario, fechaNacimiento, mail)
values ('adrian10', 'coti', 'Adrian', 'Perfetto', 'Admin', '10/12/90', 'coti@gmail.com')

INSERT INTO Usuario(id, pass, nombre, apellido, tipoUsuario, fechaNacimiento, mail)
values ('bruno31', 'emma', 'Bruno', 'Riotorto', 'Supervisor', '31/07/91', 'emma@gmail.com')


INSERT INTO Cliente(dni_cliente, nombre, apellido, direccion, telefono, fechaNacimiento, mail)
values ('36469365', 'Tito', 'Villalva', 'Bº Independencia', '3794330851', '03/10/91', 'villalva03@gmail.com')

INSERT INTO Cliente(dni_cliente, nombre, apellido, direccion, telefono, fechaNacimiento, mail)
values ('11111111', 'Ramon', 'Ramon', 'Bº Indep', '3794330851', '03/10/91', 'villa03@gmail.com')


INSERT INTO TipoProducto(descripcion)
values ('Bateria')

INSERT INTO Producto(nombre, descripcion, precio, stock, id_tipoProducto, ruta_img)
values('Taladro', 'GSB 13 RE', '947', '45', 1, 'C:\Users\CECY\Documents\Visual Studio 2010\Projects\PruebaLogin\PruebaLogin\Resources\TaladroEGSB13RE.png')


INSERT INTO Producto(nombre, descripcion, precio, stock, id_tipoProducto, ruta_img)
values('Taladro', 'GSR 14-4V-LI', '2385', '25', 2, 'C:\Users\CECY\Documents\Visual Studio 2010\Projects\PruebaLogin\PruebaLogin\Resources\TaladroBGSR144VLI.jpg')

INSERT INTO Producto(nombre, descripcion, precio, stock, id_tipoProducto, ruta_img)
values('Amoladora', 'GWS-26-230 JBV', '2300', '45', 1, 'C:\Users\CECY\Documents\Visual Studio 2010\Projects\PruebaLogin\PruebaLogin\Resources\AmoladoraEGWS26-230JBV.jpg')

INSERT INTO Producto(nombre, descripcion, precio, stock, id_tipoProducto, ruta_img)
values('Amoladora', 'GWS-18-125 V-LI', '4500', '25', 2, 'C:\Users\CECY\Documents\Visual Studio 2010\Projects\PruebaLogin\PruebaLogin\Resources\AmoladoraBGWS-18-125V-LI.png')

INSERT INTO Producto(nombre, descripcion, precio, stock, id_tipoProducto, ruta_img)
values('Atornillador', 'GSR 6-45TE', '2500', '45', 1, 'C:\Users\CECY\Documents\Visual Studio 2010\Projects\PruebaLogin\PruebaLogin\Resources\AtornilladorEGSR-6-45TE.jpg')

INSERT INTO Producto(nombre, descripcion, precio, stock, id_tipoProducto, ruta_img)
values('Atornillador', 'GSR MX2 Drive', '2350', '25', 2, 'C:\Users\CECY\Documents\Visual Studio 2010\Projects\PruebaLogin\PruebaLogin\Resources\AtornilladorBGSR-MX2Drive.png')

INSERT INTO Producto(nombre, descripcion, precio, stock, id_tipoProducto, ruta_img)
values('Martillo', 'GBH 540 DCE', '8550', '45', 1, 'C:\Users\CECY\Documents\Visual Studio 2010\Projects\PruebaLogin\PruebaLogin\Resources\MartilloEGBH-540-DCE.png')

INSERT INTO Producto(nombre, descripcion, precio, stock, id_tipoProducto, ruta_img)
values('Martillo', 'GBH 36 V-EC', '13250', '25', 2, 'C:\Users\CECY\Documents\Visual Studio 2010\Projects\PruebaLogin\PruebaLogin\Resources\MartilloBGBH-36-V-EC.jpg')

INSERT INTO Producto(nombre, descripcion, precio, stock, id_tipoProducto, ruta_img)
values('Sierra', 'GKS 7000', '1850', '45', 1, 'C:\Users\CECY\Documents\Visual Studio 2010\Projects\PruebaLogin\PruebaLogin\Resources\SierraEGKS7000.png')

INSERT INTO Producto(nombre, descripcion, precio, stock, id_tipoProducto, ruta_img)
values('Sierra', 'GKS 18 V-LI', '6090', '25', 2, 'C:\Users\CECY\Documents\Visual Studio 2010\Projects\PruebaLogin\PruebaLogin\Resources\SierraBGKS-18-V-LI.jpg')

















DBCC CHECKIDENT (Producto, RESEED,0)

select * from dbo.Usuario
select * from dbo.Cliente
select * from dbo.TipoProducto
select * from dbo.Producto
select DISTINCT dbo.Producto.id_producto,dbo.TipoProducto.id_tipoProducto, dbo.Producto.nombre, dbo.TipoProducto.descripcion
from dbo.Producto, dbo.TipoProducto

delete from dbo.Producto
delete from dbo.TipoProducto
delete from dbo.Cliente
delete from dbo.Usuario
where id_usuario = 4

alter table dbo.Producto
add ruta_img varchar(150)


select * from dbo.Cliente
where estado = 'A'

update dbo.Cliente
set estado = 'B'
where dni_cliente = 36566543