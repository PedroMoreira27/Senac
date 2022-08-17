create database testetrigger	

create table caixa(
dt_caixa date, 
saldo_inicial decimal(10,2),
saldo_final decimal(10,2)
)

insert into caixa 
values ('2022-03-23',100,100)

create table vendas(
dt_venda date,
codigo int,
valor decimal(10,2)
)

insert into vendas 
values('2022-03-23',1,50)

create trigger tgr_vendas_ai
on vendas
for insert
as begin
	declare 
	@valor decimal(10,2),
	@dt_venda date

	select @dt_venda = dt_venda, @valor = valor from inserted
	Update caixa set saldo_final = saldo_final + @valor
	where dt_caixa = @dt_venda
end

create trigger tgr_vendas_ad
on vendas
for delete
as begin
	declare 
	@valor decimal(10,2),
	@dt_venda date

	select @dt_venda = dt_venda, @valor = valor from deleted
	Update caixa set saldo_final = saldo_final - @valor
	where dt_caixa = @dt_venda
end

delete from vendas 