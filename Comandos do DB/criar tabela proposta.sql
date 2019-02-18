create table IF NOT EXISTS proposta (
codigo_p int(20) NOT NULL AUTO_INCREMENT,
razao_social varchar(30) NOT NULL,
cnpj varchar(30),
data_proposta varchar(60) NOT NULL,
responsavel varchar(60),
endereco varchar(60),
numero varchar(10),
complemento varchar (30),
cep varchar (9),
uf varchar (2),
telefone varchar (10),
ramal varchar (5),
primary key (codigo_p)
) default charset = utf8mb4;