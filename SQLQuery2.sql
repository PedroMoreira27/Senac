create table produtos_pedro(
	ID int primary key identity(1,1)not null,
	Nome_Prod varchar(30) not null,
	estoque numeric(4)not null,
	reg_data datetime not null
)