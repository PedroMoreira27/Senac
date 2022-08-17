create database LojaCalcado

create table cliente(
cod_cli int primary key identity (1,1),
nome varchar (50) not null,
endereco varchar (70) not null,
complemento varchar (30),
cep numeric (8) not null,
cpf char (11) not null,
rg varchar (10) not null,
tel_fixo numeric (10) not null,
cel_fixo numeric (11) not null,
email varchar (50) not null,
constraint uq_cpf unique (cpf),
constraint uq_rg unique (rg)
)

create table produto(
cod_prod int primary key identity (1,1),
nome_cal varchar (40) not null,
fabricante varchar (30) not null,
numero numeric (2) not null,
Obs varchar (200) 
)

insert into produto
values ('Puma','Puma.CO',40,'tenis acessivel')

create table compra(
cod_compra int primary key identity (1,1),
cod_cli int not null,
constraint fk_cliente foreign key (cod_cli) references cliente (cod_cli),
cod_prod int not null,
constraint fk_produto foreign key (cod_prod) references produto (cod_prod),
dt_compra date not null,
qtde numeric (3) not null
)

create table estoque(
cod_estoque int primary key identity (1,1),
cod_prod int not null,
constraint fk_estprod foreign key (cod_prod) references produto (cod_prod),
entrada numeric (5) not null,
qtd numeric (5) not null,
estotal as entrada + qtd
)

select * from produto

insert into estoque
values (1,100,0)

update estoque set entrada = entrada + 300 where cod_estoque = 2

select * from estoque 

select p.nome_cal, e.estotal
from estoque e inner join produto p
on e.cod_prod=p.cod_prod


insert into cliente
values ('Claudio Almeida','Rua Monsenhor Rosa - 932','Ap-11',14400887,18293017483,1838294710,1829317483,18318294710,'Claudinobrabo@gmail.com')



create table tabela(
codigo int primary key identity (1,1),
qtde numeric (8) not null,
vlr_unit numeric(8,2) not null,
vlr_total as qtde * vlr_unit
)

insert into tabela values (10,500.00)

select * from tabela

update tabela set qtde = qtde + 20 where codigo = 1


insert into cliente
values('Berto','alberto silva, 523','Casa1',1470887,12349677483,1868264710,1284017483,11038594710,'Albertin@gmail.com')