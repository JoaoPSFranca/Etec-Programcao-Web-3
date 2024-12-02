Delimiter $$

/* Class Pessoa */
drop procedure if exists adicionarPessoas$$
Create Procedure adicionarPessoas(vCpf varchar(20), vNome varchar(255), vTelefone varchar(20))
begin
	Declare proxCode int default 1;
	Select max(cd_pessoa)+1 into proxCode from pessoa;
	insert into pessoa values(proxCode, vCpf, vNome, vTelefone);
end$$


drop procedure if exists pessoaEspecifica$$
Create Procedure pessoaEspecifica(vCode int)
begin
	select 
		nm_pessoa as nome, 
		nm_cpf as cpf, 
		nm_telefone as telefone 
	from 
		pessoa 
	where 
		cd_pessoa = vCode;
end$$

drop procedure if exists editarPessoa$$
Create Procedure editarPessoa(vNome varchar(255), vTelefone varchar(20), vCode int)
begin
	Update 
		Pessoa
	set
		nm_pessoa = vNome, 
		nm_telefone = vTelefone
	where 
		cd_pessoa = vCode;
end$$

drop procedure if exists deletarPessoa$$
Create Procedure deletarPessoa(vCode int)
begin
	delete from pet where cd_pessoa = vCode;
	delete from pessoa where cd_pessoa = vCode;
end$$

/* Class Pessoas */
drop procedure if exists ListarPessoas$$
Create Procedure ListarPessoas()
begin
	select 
		cd_pessoa as codigo, 
		nm_pessoa as nome,
		nm_cpf as cpf
	from pessoa 
	order by nm_pessoa;
end$$

/* Class Pet */
drop procedure if exists petEspecifico$$
Create Procedure petEspecifico(vCodigoP int, vCodigoPS int)
begin
	select 
		ps.nm_pessoa as dono,
		r.nm_raca as raca,
		p.qt_peso as peso,
		date_format(p.dt_nascimento, '%d/%m/%Y') as 'data' 
	from pet p 
	join pessoa ps on (p.cd_pessoa = ps.cd_pessoa)
	join raca r on (r.cd_raca = p.cd_raca) 
	where 
		ps.cd_pessoa = vCodigoPS and 
		p.cd_pet = vCodigoP;
end$$

drop procedure if exists editarPet$$
Create Procedure editarPet(vPeso double, vData varchar(20), vCodigoP int, vCodigoPS int)
begin
	update 
		pet
	set
		qt_peso = vPeso, 
		dt_nascimento = vData
	where 
		cd_pessoa = vCodigoPS and
		cd_pet = vCodigoP;
end$$

drop procedure if exists deletarPet$$
Create Procedure deletarPet(vCodigoP int, vCodigoPS int)
begin
	delete from pet where cd_pessoa = vCodigoPS and cd_pet = vCodigoP;
end$$

drop procedure if exists adicionarPet$$
Create Procedure adicionarPet(vCodigoPS int, vCodigoR int, vNome varchar(200), vPeso double, vData varchar(20))
begin
	Declare proxCode int default 1;
	select 
		max(cd_pet)+1 into proxCode
	from pet 
	where cd_pessoa = vCodigoPS;

	if proxCode is null then
		set proxCode = 1;
	end if;
	insert into pet values(proxCode, vCodigoPS, vCodigoR, vNome, vPeso, vData);
end$$

/* Class Pets */
drop procedure if exists ListarPets$$
Create Procedure ListarPets(vCodigoPS int)
begin
	select 
		cd_pet as codigo, 
		nm_pet as nome 
	from pet 
	where cd_pessoa = vCodigoPS 
	order by nm_pet;
end$$

/* Class Racas */
drop procedure if exists ListarRacas$$
Create Procedure ListarRacas()
begin
	select 
		cd_raca as codigo, 
		nm_raca as nome 
	from raca 
	order by nm_raca;
end$$

Delimiter ;