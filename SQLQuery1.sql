create database locadora

create table clientes(
codcli int primary key identity(1,1),
nome varchar(50) not null,
cep numeric(8),
endereco varchar(70) not null,
complemento varchar(30),
rg varchar(12) not null,
cpf varchar(11) not null,
tel_fixo numeric(12),
tel_cel numeric(13) not null,
passaporte varchar(6) not null,
cnh varchar(11) not null,
profissao varchar(30) not null,
renda_mensal numeric(7,2) not null,
motivo varchar(80) not null,
estado_civil varchar(15) not null,
data_nasc date not null,
constraint uq_cpf 
unique(cpf)
)

create table veiculos( 
cod_vei int primary key identity(1,1),
tipo varchar(30) not null,
marca varchar(15) not null,
modelo varchar(30) not null,
placa varchar(8) not null,
chassi varchar(17)not null
)

create table empresa(
cod_emp int primary key identity(1,1),
endereco varchar(50) not null,
tel_fixo numeric(12),
tel_cel numeric(11) not null,
nome varchar(50) not null,
cnpj varchar(14) not null
)

create table seguro (
cod_seg int primary key identity (1,1),
precoseg numeric(10) not null,
enderecoseg varchar(50) not null,
cod_vei int not null,
codcli int not null
)

create table compras(
codcompra int primary key identity(1,1),
codcli int not null, 
cod_vei int not null
)

alter table compras 
add constraint FK_clientes
foreign key (codcli)
references clientes(codcli)

alter table compras 
add constraint FK_veiculos 
foreign key (cod_vei)
references veiculos(cod_vei)


insert into clientes 
values ('amanda',84909889,'Rua martinho da vila, 363 - Centro','bloco 3',123456756011,12345878901,123454589009,1228567890890,'123456','14375379024','1','1','2532.00','1','2000-03-02')

insert into veiculos
values ('Carro 4 portas','fiat','toro','KEL-5529','12342950340WERTYU'),
	   ('Carro 4 portas','volvo','sX5','ETY-7539','1234529487CWERTYU')


select * from clientes
select * from veiculos
select * from compras
 

insert into compras 
values(5,1)

alter table veiculos 
add ano numeric(4),
potencia numeric(3),
cor varchar(30)

create table aluga(
codaluga int primary key identity(1,1),
cod_vei int not null,
codcli int not null,
constraint fk_cliente
foreign key (codcli)
references clientes(codcli),
constraint fk_veiculos
foreign key (cod_vei)
references veiculos(cod_vei)
)

select c.nome, c.cpf, v.modelo, v.cor
from compras co inner join clientes c
on co.codcli = c.codcli
inner join veiculos v
on co.cod_vei = v.cod_vei

