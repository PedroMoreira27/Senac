create table Produtos(
	ID int primary key identity(1,1)not null,
	Nome_Prod varchar(30) not null,
	estoque numeric(4)not null,
	vlr_unit numeric(7,2) not null
	)

 select * from Produtos 

 drop table Produtos
