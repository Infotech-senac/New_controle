
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/03/2020 13:30:41
-- Generated from EDMX file: C:\Users\User\source\repos\New_controle\Models\EF\APPcontrole.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ini_do_estoqueSet'
CREATE TABLE [dbo].[ini_do_estoqueSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Shampoo] nvarchar(20)  NULL,
    [Condicionador] nvarchar(20)  NULL,
    [Sabonete] nvarchar(20)  NULL
);
GO

-- Creating table 'Quantidade_em_estoqueSet'
CREATE TABLE [dbo].[Quantidade_em_estoqueSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Shampoo] nvarchar(20)  NULL,
    [Condicionador] nvarchar(20)  NULL,
    [Sabonete] nvarchar(20)  NULL
);
GO

-- Creating table 'Reposicao_estoqueSet'
CREATE TABLE [dbo].[Reposicao_estoqueSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Shampoo] nvarchar(20)  NULL,
    [Condicionador] nvarchar(20)  NULL,
    [Sabonete] nvarchar(20)  NULL
);
GO

-- Creating table 'Baixa_produtoSet'
CREATE TABLE [dbo].[Baixa_produtoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Shampoo] nvarchar(20)  NULL,
    [Condicionador] nvarchar(20)  NULL,
    [Sabonete] nvarchar(20)  NULL
);
GO

-- Creating table 'produtos_em_reposicaoSet'
CREATE TABLE [dbo].[produtos_em_reposicaoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Shampoo] nvarchar(20)  NULL,
    [Condicionador] nvarchar(20)  NULL,
    [Sabonete] nvarchar(20)  NULL
);
GO

-- Creating table 'produtos_enviadoSet'
CREATE TABLE [dbo].[produtos_enviadoSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Shampoo] nvarchar(20)  NULL,
    [Condicionador] nvarchar(20)  NULL,
    [Sabonete] nvarchar(20)  NULL
);
GO

-- Creating table 'ProdutosSet'
CREATE TABLE [dbo].[ProdutosSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Shampoo] nvarchar(20)  NULL,
    [Condicionador] nvarchar(20)  NULL,
    [Sabonete] nvarchar(20)  NULL
);
GO

-- Creating table 'Produtos_em_estoqueSet'
CREATE TABLE [dbo].[Produtos_em_estoqueSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Shampoo] nvarchar(20)  NULL,
    [Condicionador] nvarchar(20)  NULL,
    [Sabonete] nvarchar(20)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ini_do_estoqueSet'
ALTER TABLE [dbo].[ini_do_estoqueSet]
ADD CONSTRAINT [PK_ini_do_estoqueSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Quantidade_em_estoqueSet'
ALTER TABLE [dbo].[Quantidade_em_estoqueSet]
ADD CONSTRAINT [PK_Quantidade_em_estoqueSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reposicao_estoqueSet'
ALTER TABLE [dbo].[Reposicao_estoqueSet]
ADD CONSTRAINT [PK_Reposicao_estoqueSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Baixa_produtoSet'
ALTER TABLE [dbo].[Baixa_produtoSet]
ADD CONSTRAINT [PK_Baixa_produtoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'produtos_em_reposicaoSet'
ALTER TABLE [dbo].[produtos_em_reposicaoSet]
ADD CONSTRAINT [PK_produtos_em_reposicaoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'produtos_enviadoSet'
ALTER TABLE [dbo].[produtos_enviadoSet]
ADD CONSTRAINT [PK_produtos_enviadoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProdutosSet'
ALTER TABLE [dbo].[ProdutosSet]
ADD CONSTRAINT [PK_ProdutosSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Produtos_em_estoqueSet'
ALTER TABLE [dbo].[Produtos_em_estoqueSet]
ADD CONSTRAINT [PK_Produtos_em_estoqueSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------