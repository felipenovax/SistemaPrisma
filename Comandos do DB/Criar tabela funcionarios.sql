create table IF NOT EXISTS funcionarios (
nome varchar(30) NOT NULL,
localnascimento varchar(30),
ufnascimento varchar(2),
nascimento date,
sexo enum('M','F'),
escolaridade varchar(14),
cpf varchar(11),
rg varchar(13) UNIQUE,
rguf varchar(2),
orgaoexpeditor varchar(10),
estadocivil varchar(10),
nomepai varchar(30),
nomemae varchar(30),
endereco varchar(150),
numero varchar (20),
bairro varchar(50),
cidade varchar(50),
uf varchar(2),
cep varchar(10),
telefone varchar(14),
celular varchar(14),
email varchar(100),
codigo varchar(10),
datacadastro date,
login varchar(20),
setor varchar(20),
cargo varchar(20),
primary key(cpf)

) default charset = utf8mb4;