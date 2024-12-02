drop schema if exists exemplo1_35347; 
create schema exemplo1_35347;
use exemplo1_35347;

create table pessoa(
	nm_cpf varchar(20),
	nm_pessoa varchar(255),
	nm_telefone varchar(20),
	constraint pk_pessoa primary key (nm_cpf) 
);