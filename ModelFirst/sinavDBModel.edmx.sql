
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/22/2020 02:30:28
-- Generated from EDMX file: c:\users\monster\documents\visual studio 2013\Projects\ModelFirst_18440038\ModelFirst_18440038\sinavDBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [sinavMDB];
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

-- Creating table 'admin1Set'
CREATE TABLE [dbo].[admin1Set] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [isim] nvarchar(max)  NOT NULL,
    [sifre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ogrenciSet'
CREATE TABLE [dbo].[ogrenciSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [isim] nvarchar(max)  NOT NULL,
    [dersno] nvarchar(max)  NOT NULL,
    [sifre] nvarchar(max)  NOT NULL,
    [adminID] int  NOT NULL
);
GO

-- Creating table 'sorularSet'
CREATE TABLE [dbo].[sorularSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [baslik] nvarchar(max)  NOT NULL,
    [cvpa] nvarchar(max)  NOT NULL,
    [cvpb] nvarchar(max)  NOT NULL,
    [cvpc] nvarchar(max)  NOT NULL,
    [dogrucvp] nvarchar(max)  NOT NULL,
    [adminID] int  NOT NULL,
    [sinavID] int  NOT NULL
);
GO

-- Creating table 'sinavSet'
CREATE TABLE [dbo].[sinavSet] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [sinavadi] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'admin1Set'
ALTER TABLE [dbo].[admin1Set]
ADD CONSTRAINT [PK_admin1Set]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ogrenciSet'
ALTER TABLE [dbo].[ogrenciSet]
ADD CONSTRAINT [PK_ogrenciSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'sorularSet'
ALTER TABLE [dbo].[sorularSet]
ADD CONSTRAINT [PK_sorularSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'sinavSet'
ALTER TABLE [dbo].[sinavSet]
ADD CONSTRAINT [PK_sinavSet]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [adminID] in table 'sorularSet'
ALTER TABLE [dbo].[sorularSet]
ADD CONSTRAINT [FK_adminsorular]
    FOREIGN KEY ([adminID])
    REFERENCES [dbo].[admin1Set]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_adminsorular'
CREATE INDEX [IX_FK_adminsorular]
ON [dbo].[sorularSet]
    ([adminID]);
GO

-- Creating foreign key on [adminID] in table 'ogrenciSet'
ALTER TABLE [dbo].[ogrenciSet]
ADD CONSTRAINT [FK_adminogrenci]
    FOREIGN KEY ([adminID])
    REFERENCES [dbo].[admin1Set]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_adminogrenci'
CREATE INDEX [IX_FK_adminogrenci]
ON [dbo].[ogrenciSet]
    ([adminID]);
GO

-- Creating foreign key on [sinavID] in table 'sorularSet'
ALTER TABLE [dbo].[sorularSet]
ADD CONSTRAINT [FK_sinavsorular]
    FOREIGN KEY ([sinavID])
    REFERENCES [dbo].[sinavSet]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_sinavsorular'
CREATE INDEX [IX_FK_sinavsorular]
ON [dbo].[sorularSet]
    ([sinavID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------