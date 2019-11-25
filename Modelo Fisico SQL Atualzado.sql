/* Modelo Logico: */

create DataBase db_Pim
go

use db_Pim
go

/* INICIO Criando Tabaleas */
create TABLE tb_Pessoas (
	IdPessoa INT PRIMARY KEY identity,
    Nome_Pessoa VARCHAR (40),
	CPF VARCHAR (11),
	DataNascimento DATE,
	TipoUsuario VARCHAR (11),
	Celular VARCHAR (11),
	Telefone VARCHAR (10),
	Email VARCHAR (70),
	Endereco VARCHAR (40),
	Numero VARCHAR (5),
    Bairro VARCHAR (30),
    Complemento VARCHAR (40),
	Inativar bit,
    fk_Cidades_IdCidade INT
);
go

CREATE TABLE tb_Cidades (
    IdCidade INT PRIMARY KEY identity,
	Nome_Cidade VARCHAR (40),
	CEP VARCHAR (9),
    fk_Estados_IdEstado INT
);
go

CREATE TABLE tb_Funcionarios (
	IdFuncionario INT PRIMARY KEY identity,
	Usuario VARCHAR (20),
    Senha VARCHAR (20),
    fk_Pessoas_IdPessoa INT
);
go

CREATE TABLE tb_Clientes (
    IdCliente INT PRIMARY KEY identity,
    fk_Pessoas_IdPessoa INT
);
go

CREATE TABLE tb_Transacoes (
    IdTransacao INT PRIMARY KEY identity,
	Desconto FLOAT,
    SubTotal FLOAT,
	Total FLOAT,
	DataVenda date,
    fk_Funcionarios_IdFuncionario INT,
    fk_Clientes_IdCliente INT
);
go

CREATE TABLE tb_Estoques (
    IdEstoque INT PRIMARY KEY identity,
    Quantidade INT,
    ValorUnitario FLOAT,
	Custo float,
    fk_Produtos_IdProduto INT
);
go

CREATE TABLE tb_Produtos (
	IdProduto INT PRIMARY KEY identity,
    Nome_produto VARCHAR (40),
    Tamanho VARCHAR (3),
    Fabricante VARCHAR (40),
    Fornecedor VARCHAR (40),
	CodReferencia int, 
	inativar bit
);
go

CREATE TABLE tb_Estados (
	IdEstado INT PRIMARY KEY identity,
    Sigla VARCHAR (2)
);
go

CREATE TABLE tb_ItensTransacoes_Produtos (
    IdItensTransacao INT PRIMARY KEY identity,
    fk_Produtos_IdProduto INT,
    fk_Transacoes_IdTransacao INT
);
go
/* FIM Criando Tabaleas */

/* INICIO Alterando Tabelas */
ALTER TABLE tb_Pessoas ADD CONSTRAINT FK_Pessoas_Cidades
    FOREIGN KEY (fk_Cidades_IdCidade)
    REFERENCES tb_Cidades (IdCidade)
    ON DELETE CASCADE;
go

ALTER TABLE tb_Cidades ADD CONSTRAINT FK_Cidades_Estados
    FOREIGN KEY (fk_Estados_IdEstado)
    REFERENCES tb_Estados (IdEstado)
go

ALTER TABLE tb_Funcionarios ADD CONSTRAINT FK_Funcionarios_Pessoas
    FOREIGN KEY (fk_Pessoas_IdPessoa)
    REFERENCES tb_Pessoas (IdPessoa)

go

ALTER TABLE tb_Clientes ADD CONSTRAINT FK_Clientes_Pessoas
    FOREIGN KEY (fk_Pessoas_IdPessoa)
    REFERENCES tb_Pessoas (IdPessoa)
go

ALTER TABLE tb_Transacoes ADD CONSTRAINT FK_Transacoes_Funcionarios
    FOREIGN KEY (fk_Funcionarios_IdFuncionario)
    REFERENCES tb_Funcionarios (IdFuncionario)
go

ALTER TABLE tb_Transacoes ADD CONSTRAINT FK_Transacoes_Clientes
    FOREIGN KEY (fk_Clientes_IdCliente)
    REFERENCES tb_Clientes (IdCliente)
go

ALTER TABLE tb_Estoques ADD CONSTRAINT FK_Estoques_Produtos
    FOREIGN KEY (fk_Produtos_IdProduto)
    REFERENCES tb_Produtos (IdProduto)
    ON DELETE CASCADE;
go

ALTER TABLE tb_ItensTransacoes_Produtos ADD CONSTRAINT FK_ItensTransacoes_Produtos
    FOREIGN KEY (fk_Produtos_IdProduto)
    REFERENCES tb_Produtos (IdProduto);
go

ALTER TABLE tb_ItensTransacoes_Produtos ADD CONSTRAINT FK_ItensTransacoes_Transacao
    FOREIGN KEY (fk_Transacoes_IdTransacao)
    REFERENCES tb_Transacoes (IdTransacao);
go
/* FIM Alterando Tabelas */

/* Inicio Procedure */

/* Inicio Insert Cliente */
create procedure SP_CadastroCliente
(
	@Nome_Pessoa Varchar(40),
	@CPF Varchar(11),
	@DataNascimento date,
	@TipoUsuario Varchar(11),
	@CEP Varchar(9),
	@Endereco Varchar(40),
	@Numero Varchar(5),
	@Bairro Varchar(30),
	@Complemento Varchar(40),
	@Nome_Cidade Varchar(40),
	@Estado Varchar(2),
	@Telefone Varchar(10),
	@Celular Varchar(11),
	@Email Varchar(70),
	@Inativar bit
)
as
begin
	insert into tb_Estados
	values (@Estado)
	declare @Id_Estado int=@@identity

	insert into tb_Cidades
	values (@Nome_Cidade, @CEP, @id_Estado)
	declare @Id_Cidade int=@@identity

	insert into tb_Pessoas
	values (@Nome_Pessoa, @CPF, @DataNascimento, @TipoUsuario, @Celular, @Telefone, @Email,@Endereco, @Numero, @Bairro, @Complemento, @Inativar, @Id_Cidade)
	declare @Id_Pessoa int=@@identity

	insert into tb_Clientes
	values (@Id_Pessoa) 
end
/* Fim Insert Cliente */

/* Inicio Insert Funcionario */
create procedure SP_CadastroFuncionario
(
	@Nome_Pessoa Varchar(40),
	@CPF Varchar(11),
	@DataNascimento date,
	@TipoUsuario Varchar(11),
	@CEP Varchar(9),
	@Endereco Varchar(40),
	@Numero Varchar(5),
	@Bairro Varchar(30),
	@Complemento Varchar(40),
	@Nome_Cidade Varchar(40),
	@Estado Varchar(2),
	@Telefone Varchar(10),
	@Celular Varchar(11),
	@Email Varchar(70),
	@Usuario Varchar(20),
	@Senha Varchar(20),
	@Inativar bit
)
as
begin
	insert into tb_Estados
	values (@Estado)
	declare @Id_Estado int=@@identity

	insert into tb_Cidades
	values (@Nome_Cidade, @CEP, @id_Estado)
	declare @Id_Cidade int=@@identity

	insert into tb_Pessoas
	values (@Nome_Pessoa, @CPF, @DataNascimento, @TipoUsuario, @Celular, @Telefone, @Email,@Endereco, @Numero, @Bairro, @Complemento, @Inativar, @Id_Cidade)
	declare @Id_Pessoa int=@@identity

	insert into tb_Funcionarios
	values (@Usuario,@Senha, @Id_Pessoa) 
end
/* FIm Insert Funcionario */

/* Inicio Insert Produtos */
create procedure SP_CadastroProdutos
(
	@Nome_Produto Varchar(40),
	@Fabricante Varchar(40),
	@Tamanho Varchar(3),
	@Custo float,
	@Fornecedor Varchar(40),
	@Precounitario float,
	@CodReferencia int,
	@Inativar bit
)
as
begin
	insert into tb_Produtos
	values (@Nome_Produto, @Tamanho, @Fabricante, @Fornecedor,@CodReferencia, @Inativar)
	declare @Id_Produto int=@@identity

	insert into tb_Estoques (ValorUnitario, Custo, fk_Produtos_IdProduto)
	values (@Precounitario,@Custo, @Id_Produto)
end
/* Fim Insert Produtos */

/* Inicio Insert Vendas */
create procedure SP_CadastroVenda
(
	@SubTotal float,
	@Desconto float,
	@Total float,
	@IdFuncioanrio int,
	@IdCliente int,
	@DataVenda date
)
as
begin
	insert into tb_Transacoes
	values (@Desconto, @SubTotal, @Total,@DataVenda, @IdFuncioanrio, @IdCliente)

	select SCOPE_IDENTITY() from tb_Transacoes

end
/* Fim Insert Vendas */

/* Inicio Insert ProdutoVendas */
create procedure SP_CadastroProdutoVenda
(
	@IdVenda int,
	@Quantidade int,
	@IdProduto int
)
as
begin
	insert into tb_ItensTransacoes_Produtos
	values (@IdProduto, @IdVenda)

	update tb_Estoques
	set Quantidade = Quantidade - @Quantidade
	where tb_Estoques.fk_Produtos_IdProduto = @IdProduto
end
/* Fim Insert Vendas */
	


/* inicio Update Cliente */
create procedure SP_EditarCliente
(
	@Nome_Pessoa Varchar(40),
	@CPF Varchar(11),
	@DataNascimento date,
	@TipoUsuario Varchar(11),
	@CEP Varchar(9),
	@Endereco Varchar(40),
	@Numero Varchar(5),
	@Bairro Varchar(30),
	@Complemento Varchar(40),
	@Nome_Cidade Varchar(40),
	@Estado Varchar(2),
	@Telefone Varchar(10),
	@Celular Varchar(11),
	@Email Varchar(70),
	@IdPessoa int
)
as
begin
	declare @FkCidade int
	update tb_Pessoas
	set Nome_Pessoa = @Nome_Pessoa, CPF = @CPF, DataNascimento = @DataNascimento, TipoUsuario = @TipoUsuario, Celular = @Celular, @Telefone = @Telefone, Email = @Email, Endereco = @Endereco, Numero =  @Numero, Bairro = @Bairro, Complemento = @Complemento, @FkCidade = (select fk_Cidades_IdCidade from tb_Pessoas where IdPessoa = @IdPessoa)  
	where IdPessoa = @IdPessoa

	declare @FkEstado int
	update tb_Cidades
	set Nome_Cidade = @Nome_Cidade, CEP = @CEP, @FkEstado = (select fk_Estados_IdEstado from tb_Cidades where IdCidade = @FkCidade)
	where IdCidade = @FkCidade

	update tb_Estados
	set Sigla = @Estado
	where IdEstado = @FkEstado
end
/* Fim Update Cliente */

/* inicio Update Funcionario */
create procedure SP_EditarFuncionario
(
	@Nome_Pessoa Varchar(40),
	@CPF Varchar(11),
	@DataNascimento date,
	@TipoUsuario Varchar(11),
	@CEP Varchar(9),
	@Endereco Varchar(40),
	@Numero Varchar(5),
	@Bairro Varchar(30),
	@Complemento Varchar(40),
	@Nome_Cidade Varchar(40),
	@Estado Varchar(2),
	@Telefone Varchar(10),
	@Celular Varchar(11),
	@Email Varchar(70),
	@Usuario Varchar(20),
	@Senha Varchar(20),
	@IdPessoa int
)
as
begin
	declare @FkCidade int
	update tb_Pessoas
	set Nome_Pessoa = @Nome_Pessoa, CPF = @CPF, DataNascimento = @DataNascimento, TipoUsuario = @TipoUsuario, Celular = @Celular, @Telefone = @Telefone, Email = @Email, Endereco = @Endereco, Numero =  @Numero, Bairro = @Bairro, Complemento = @Complemento, @FkCidade = (select fk_Cidades_IdCidade from tb_Pessoas where IdPessoa = @IdPessoa)  
	where IdPessoa = @IdPessoa

	declare @FkEstado int
	update tb_Cidades
	set Nome_Cidade = @Nome_Cidade, CEP = @CEP, @FkEstado = (select fk_Estados_IdEstado from tb_Cidades where IdCidade = @FkCidade)
	where IdCidade = @FkCidade

	update tb_Estados
	set Sigla = @Estado
	where IdEstado = @FkEstado

	update tb_Funcionarios
	set Usuario = @Usuario, Senha = @Senha
	where fk_Pessoas_IdPessoa = @IdPessoa
end
/* Fim Update Funcionario */

/* inicio Update Produtos */
create procedure SP_EditarProduto
(
	@Nome_Produto Varchar(40),
	@Fabricante Varchar(40),
	@Tamanho Varchar(3),
	@Custo float,
	@Fornecedor Varchar(40),
	@Precounitario float,
	@Quantidade int,
	@IdProduto int

)
as
begin

	update tb_Produtos
	set Nome_produto = @Nome_Produto, Tamanho = @Tamanho, Fabricante = @Fabricante, Fornecedor = @Fornecedor   
	where IdProduto = @IdProduto

	update tb_Estoques
	set Quantidade = @Quantidade, ValorUnitario = @Precounitario, Custo = @Custo
	where fk_Produtos_IdProduto = @IdProduto
end
/* Fim Update Produtos */

/* inicio Update QuantidadeProduto */
create procedure SP_AdicionarQuantidade
(
	@Quantidade int,
	@IdProduto int
)
as
begin
	update tb_Estoques
	set Quantidade = Quantidade + @Quantidade
	where fk_Produtos_IdProduto = @IdProduto
end
/* Fim Quantidade Produtos */
/* fim Procedure */

insert tb_Funcionarios(Usuario, Senha)
values ('admin', 'admin')

select Nome_produto, Fornecedor  from tb_Produtos
where inativar = 1 and IdProduto = 1
select *  from tb_Estoques

select Fabricante, Custo, ValorUnitario, Quantidade  from tb_Produtos
inner join tb_Estoques
on tb_Produtos.IdProduto = tb_Estoques.fk_Produtos_IdProduto
where inativar = 1 and Nome_produto like @nome_Produto

exec SP_CadastroVenda 1, 1,1,1,1


select CodReferencia, ValorUnitario, Nome_produto from tb_Produtos
inner join tb_Estoques
on tb_Produtos.IdProduto = tb_Estoques.fk_Produtos_IdProduto
where inativar = 1 and Nome_produto like '% %'

insert into tb_Funcionarios (Usuario, Senha)
values ('admin', 'admin')

select * from tb_Pessoas
select * from tb_Funcionarios
select * from tb_Clientes

SELECT * from tb_Produtos
select * from tb_Estoques