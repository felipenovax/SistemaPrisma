create table IF NOT EXISTS usuarios (
codigo int(11) NOT NULL AUTO_INCREMENT,
nome varchar(30) NOT NULL,
login varchar(30),
senha varchar(60) NOT NULL,
setor varchar(20),
cargo varchar(20),
administrador enum('S','N'),
primary key (id)
) default charset = utf8mb4;