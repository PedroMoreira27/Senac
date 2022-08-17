create database loja
create table clientes(
codcli int primary key identity(1,1),
nome varchar(50) not null,
endereco varchar(60) not null,
complemento varchar(30),
cep numeric(8) not null,
cpf char(11) not null,
rg varchar(12) not null,
tel_fixo numeric(12),
tel_cel numeric(13) not null,
salario numeric(7,2) not null,
)
create table produtos(
cod_prod int primary key identity(1,1),
descricao varchar(50) not null,
quantidade numeric(6) not null,
marca varchar(15) not null
)

select * from clientes

create table compras(
codcompra int primary key identity(1,1),
codcli int not null, 
cod_prod int not null
)

alter table compras 
add constraint FK_clientes
foreign key (codcli)
references clientes(codcli)

alter table compras 
add constraint FK_produto 
foreign key (cod_prod)
references produtos(cod_prod)

insert into clientes 
values ('barbara','Rua laercio onardio, 963 - Centro','bloco 6',89009889,12345678901,123456789012,123456789009,1234567890890,4470.00)

select * from clientes
select * from produtos
select * from compras

delete from clientes
where codcli = 2

insert into produtos
values ('TV 50',10,'LG')

insert into compras
values (1,3)