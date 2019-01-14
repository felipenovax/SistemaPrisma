create table IF NOT EXISTS municipios (
id varchar(10),
UF varchar(2),
Municípios varchar(30) NOT NULL,
primary key (id)
) default charset = utf8mb4;