create database testes

create table cliente(
codcli int primary key identity(1,1),
nome varchar(40) not null,
endereco varchar (50) not null,
complemento varchar (50)
)

alter table cliente 
add constraint df_teste
default 'teste' for complemento


insert into cliente (nome,endereco)
values ('casa1.0','casa2.0')

select * from cliente



create table compra(
cod int primary key identity(1,1),
qtde numeric(8) not null,
vlr_unit numeric (7,2) not null
)

insert into compra
values (10, 1500.00)

select qtde, vlr_unit, qtde * vlr_unit as ValorTotal from compra

create table table4(
codi int primary key identity(1,1),
qtd numeric(10) not null,
val_unit numeric(8,2) not null,
vlr_total  as qtd * val_unit
)

insert into table4
values (15,150.70)

select * from table4








create database LojaCalcado

create table cliente(
cod_cli int primary key identity(1,1),
nome varchar(50) not null,
endereco varchar(70) not null,
complemento varchar (30),
cep numeric(8) not null,
cpf char(11) not null,
rg varchar(10) not null,
tel_fixo numeric(10) not null,
cel_fixo numeric (11) not null,
email varchar(50) not null,
constraint uq_cpf unique (cpf),
constraint uq_rg unique (rg)
)

create table produto(
cod_prod int primary key identity (1,1),
nome_cal varchar(40) not null,
fabricante varchar (30) not null,
numero numeric (2) not null,
obs varchar (200)
)

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
estotal as entrada + qtd
)















