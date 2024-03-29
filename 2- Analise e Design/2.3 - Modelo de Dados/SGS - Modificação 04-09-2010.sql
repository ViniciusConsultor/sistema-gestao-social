/*
   sábado, 4 de setembro de 201013:55:02
   User: 
   Server: .\SQLEXPRESS
   Database: 
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_Login
	(
	CodigoLogin int NOT NULL IDENTITY (1, 1),
	Pessoa_CodigoPessoa int NULL,
	Nome varchar(50) NOT NULL,
	Login varchar(10) NOT NULL,
	Senha varchar(10) NOT NULL,
	Email varchar(50) NULL,
	Perfil varchar(20) NOT NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_Login SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_Login ON
GO
IF EXISTS(SELECT * FROM dbo.Login)
	 EXEC('INSERT INTO dbo.Tmp_Login (CodigoLogin, Pessoa_CodigoPessoa, Nome, Login, Senha, Email, Perfil)
		SELECT CodigoLogin, Pessoa_CodigoPessoa, Nome, Login, Senha, Email, Perfil FROM dbo.Login WITH (HOLDLOCK TABLOCKX)')
GO
COMMIT
