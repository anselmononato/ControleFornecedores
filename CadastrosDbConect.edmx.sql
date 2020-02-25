
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/24/2020 16:35:21
-- Generated from EDMX file: C:\Users\Administrador.WIN-N1TKF8VJBI9\Source\Repos\anselmononato\ControleFornecedores\CadastrosDbConect.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Cadastros];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AssociacaoFornecedor_Empresa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AssociacaoFornecedor] DROP CONSTRAINT [FK_AssociacaoFornecedor_Empresa];
GO
IF OBJECT_ID(N'[dbo].[FK_AssociacaoFornecedor_Fornecedor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AssociacaoFornecedor] DROP CONSTRAINT [FK_AssociacaoFornecedor_Fornecedor];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AssociacaoFornecedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AssociacaoFornecedor];
GO
IF OBJECT_ID(N'[dbo].[Empresa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Empresa];
GO
IF OBJECT_ID(N'[dbo].[Fornecedor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fornecedor];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AssociacaoFornecedor'
CREATE TABLE [dbo].[AssociacaoFornecedor] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Empresa_ID] int  NOT NULL,
    [Fornecedor_ID] int  NOT NULL
);
GO

-- Creating table 'Empresa'
CREATE TABLE [dbo].[Empresa] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [NomeFantasia] varchar(250)  NOT NULL,
    [UF] varchar(2)  NOT NULL,
    [CNPJ] varchar(15)  NOT NULL
);
GO

-- Creating table 'Fornecedor'
CREATE TABLE [dbo].[Fornecedor] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Nome] varchar(250)  NULL,
    [Tipo] varchar(2)  NULL,
    [CPF_CNPJ] varchar(15)  NOT NULL,
    [Nascimento] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'AssociacaoFornecedor'
ALTER TABLE [dbo].[AssociacaoFornecedor]
ADD CONSTRAINT [PK_AssociacaoFornecedor]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Empresa'
ALTER TABLE [dbo].[Empresa]
ADD CONSTRAINT [PK_Empresa]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Fornecedor'
ALTER TABLE [dbo].[Fornecedor]
ADD CONSTRAINT [PK_Fornecedor]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Empresa_ID] in table 'AssociacaoFornecedor'
ALTER TABLE [dbo].[AssociacaoFornecedor]
ADD CONSTRAINT [FK_AssociacaoFornecedor_Empresa]
    FOREIGN KEY ([Empresa_ID])
    REFERENCES [dbo].[Empresa]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AssociacaoFornecedor_Empresa'
CREATE INDEX [IX_FK_AssociacaoFornecedor_Empresa]
ON [dbo].[AssociacaoFornecedor]
    ([Empresa_ID]);
GO

-- Creating foreign key on [Fornecedor_ID] in table 'AssociacaoFornecedor'
ALTER TABLE [dbo].[AssociacaoFornecedor]
ADD CONSTRAINT [FK_AssociacaoFornecedor_Fornecedor]
    FOREIGN KEY ([Fornecedor_ID])
    REFERENCES [dbo].[Fornecedor]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AssociacaoFornecedor_Fornecedor'
CREATE INDEX [IX_FK_AssociacaoFornecedor_Fornecedor]
ON [dbo].[AssociacaoFornecedor]
    ([Fornecedor_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------