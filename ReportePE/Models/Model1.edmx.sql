
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/09/2021 11:06:50
-- Generated from EDMX file: C:\Sistemas\ReportePE\ReportePE\Models\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [RapEnsambleEMM];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[CSL_CON_OPCModelStoreContainer].[Cambiodetroquel]', 'U') IS NOT NULL
    DROP TABLE [CSL_CON_OPCModelStoreContainer].[Cambiodetroquel];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cambiodetroquels'
CREATE TABLE [dbo].[Cambiodetroquels] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [TROQUEL] int  NULL,
    [NOMBRE] varchar(50)  NULL,
    [INICIO] datetime  NULL,
    [FIN] datetime  NULL,
    [RUN] datetime  NULL,
    [TOTAL] int  NULL,
    [MODELO] varchar(50)  NULL,
    [TOTALHTH] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Cambiodetroquels'
ALTER TABLE [dbo].[Cambiodetroquels]
ADD CONSTRAINT [PK_Cambiodetroquels]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------