drop schema if exists PetsPessoas; 
create schema PetsPessoas;
use PetsPessoas;

create table pessoa(
	cd_pessoa int,
	nm_cpf varchar(20),
	nm_pessoa varchar(255),
	nm_telefone varchar(20),
	constraint pk_pessoa primary key (cd_pessoa) 
);

create table raca(
	cd_raca int,
	nm_raca varchar(200),
	nm_porte varchar(50),
	constraint pk_raca primary key (cd_raca)
);

create table pet(
	cd_pet int,
	cd_pessoa int,
	cd_raca int, 
	nm_pet varchar(200),
	qt_peso double,
	dt_nascimento dateTime,
	constraint pk_pet primary key (cd_pet, cd_pessoa),
	constraint fk_pet_pessoa foreign key (cd_pessoa)
		references pessoa (cd_pessoa),
	constraint fk_pet_raca foreign key (cd_raca)
		references raca (cd_raca)
);