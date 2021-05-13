create database Tienda
go

use Tienda

create table Brand(

	BrandId int identity (1,1) primary key not null,
	Nombre varchar(20) not null,
	Descripcion varchar(20) not null
	
)

create table Category(

	CategoryId int identity (1,1) primary key not null,
	Nombre varchar(20) not null,

)

create table Product(

	ProductId  int identity (1,1) primary key not null,
	Nombre varchar(20) not null,
	Precio money not null,
	BrandId int foreign key (BrandId) references Brand(BrandId) not null,
	CategoryId int foreign key (CategoryId) references Category(CategoryId) not null,
)