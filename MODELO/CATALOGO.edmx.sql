
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/03/2015 15:09:06
-- Generated from EDMX file: C:\TRABAJO\SISTEMA\MODELO\CATALOGO.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
CREATE DATABASE SISTEMA;
GO
USE [SISTEMA];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MODULOSUBMODULO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SUBMODULOS] DROP CONSTRAINT [FK_MODULOSUBMODULO];
GO
IF OBJECT_ID(N'[dbo].[FK_SUBMODULOFORMULARIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FORMULARIOS] DROP CONSTRAINT [FK_SUBMODULOFORMULARIO];
GO
IF OBJECT_ID(N'[dbo].[FK_FORMULARIOACCION]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ACCIONES] DROP CONSTRAINT [FK_FORMULARIOACCION];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIOGRUPO_USUARIO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIOGRUPO] DROP CONSTRAINT [FK_USUARIOGRUPO_USUARIO];
GO
IF OBJECT_ID(N'[dbo].[FK_USUARIOGRUPO_GRUPO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[USUARIOGRUPO] DROP CONSTRAINT [FK_USUARIOGRUPO_GRUPO];
GO
IF OBJECT_ID(N'[dbo].[FK_GRUPOACCION_GRUPO]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GRUPOACCION] DROP CONSTRAINT [FK_GRUPOACCION_GRUPO];
GO
IF OBJECT_ID(N'[dbo].[FK_GRUPOACCION_ACCION]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[GRUPOACCION] DROP CONSTRAINT [FK_GRUPOACCION_ACCION];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[USUARIOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USUARIOS];
GO
IF OBJECT_ID(N'[dbo].[GRUPOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GRUPOS];
GO
IF OBJECT_ID(N'[dbo].[FORMULARIOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FORMULARIOS];
GO
IF OBJECT_ID(N'[dbo].[ACCIONES]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ACCIONES];
GO
IF OBJECT_ID(N'[dbo].[MODULOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MODULOS];
GO
IF OBJECT_ID(N'[dbo].[SUBMODULOS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SUBMODULOS];
GO
IF OBJECT_ID(N'[dbo].[PARAMETROS]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PARAMETROS];
GO
IF OBJECT_ID(N'[dbo].[USUARIOGRUPO]', 'U') IS NOT NULL
    DROP TABLE [dbo].[USUARIOGRUPO];
GO
IF OBJECT_ID(N'[dbo].[GRUPOACCION]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GRUPOACCION];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'USUARIOS'
CREATE TABLE [dbo].[USUARIOS] (
    [CODIGO] int IDENTITY(1,1) NOT NULL,
    [NOMBRE_USUARIO] nvarchar(max)  NOT NULL,
    [NOMBRE] nvarchar(max)  NOT NULL,
    [CLAVE] nvarchar(max)  NOT NULL,
    [EMAIL] nvarchar(max)  NOT NULL,
    [TELEFONO] nvarchar(max)  NOT NULL,
    [ACTIVO] bit  NOT NULL,
    [RESETEAR_CLAVE] bit  NOT NULL,
    [IMAGEN] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'GRUPOS'
CREATE TABLE [dbo].[GRUPOS] (
    [CODIGO] int IDENTITY(1,1) NOT NULL,
    [DESCRIPCION] nvarchar(max)  NOT NULL,
    [ACTIVO] bit  NOT NULL
);
GO

-- Creating table 'FORMULARIOS'
CREATE TABLE [dbo].[FORMULARIOS] (
    [CODIGO] int IDENTITY(1,1) NOT NULL,
    [DESCRIPCION] nvarchar(max)  NOT NULL,
    [CLASE] nvarchar(max)  NOT NULL,
    [ACTIVO] bit  NOT NULL,
    [MENU] bit  NOT NULL,
    [SUBMODULO_CODIGO] int  NOT NULL
);
GO

-- Creating table 'ACCIONES'
CREATE TABLE [dbo].[ACCIONES] (
    [CODIGO] int IDENTITY(1,1) NOT NULL,
    [DESCRIPCION] nvarchar(max)  NOT NULL,
    [CONTROL] nvarchar(max)  NOT NULL,
    [FORMULARIO_CODIGO] int  NOT NULL
);
GO

-- Creating table 'MODULOS'
CREATE TABLE [dbo].[MODULOS] (
    [CODIGO] int IDENTITY(1,1) NOT NULL,
    [DESCRIPCION] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SUBMODULOS'
CREATE TABLE [dbo].[SUBMODULOS] (
    [CODIGO] int IDENTITY(1,1) NOT NULL,
    [DESCRIPCION] nvarchar(max)  NOT NULL,
    [MODULO_CODIGO] int  NOT NULL
);
GO

-- Creating table 'PARAMETROS'
CREATE TABLE [dbo].[PARAMETROS] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [DIRECTORIO_IMAGENES] nvarchar(max)  NOT NULL,
    [MAIL_HOST] nvarchar(max)  NOT NULL,
    [MAIL_PORT] int  NOT NULL,
    [ENVIO_MAILS] bit  NOT NULL,
    [MAIL_CUENTA] nvarchar(max)  NOT NULL,
    [MAIL_CLAVE] nvarchar(max)  NOT NULL,
    [MAIL_NOMBRE_REMITENTE] nvarchar(max)  NOT NULL,
    [NOMBRE_EQUIPO] nvarchar(max)  NOT NULL,
    [MAIL_SSL] bit  NOT NULL
);
GO

-- Creating table 'USUARIOGRUPO'
CREATE TABLE [dbo].[USUARIOGRUPO] (
    [USUARIO_CODIGO] int  NOT NULL,
    [GRUPO_CODIGO] int  NOT NULL
);
GO

-- Creating table 'GRUPOACCION'
CREATE TABLE [dbo].[GRUPOACCION] (
    [GRUPO_CODIGO] int  NOT NULL,
    [ACCION_CODIGO] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CODIGO] in table 'USUARIOS'
ALTER TABLE [dbo].[USUARIOS]
ADD CONSTRAINT [PK_USUARIOS]
    PRIMARY KEY CLUSTERED ([CODIGO] ASC);
GO

-- Creating primary key on [CODIGO] in table 'GRUPOS'
ALTER TABLE [dbo].[GRUPOS]
ADD CONSTRAINT [PK_GRUPOS]
    PRIMARY KEY CLUSTERED ([CODIGO] ASC);
GO

-- Creating primary key on [CODIGO] in table 'FORMULARIOS'
ALTER TABLE [dbo].[FORMULARIOS]
ADD CONSTRAINT [PK_FORMULARIOS]
    PRIMARY KEY CLUSTERED ([CODIGO] ASC);
GO

-- Creating primary key on [CODIGO] in table 'ACCIONES'
ALTER TABLE [dbo].[ACCIONES]
ADD CONSTRAINT [PK_ACCIONES]
    PRIMARY KEY CLUSTERED ([CODIGO] ASC);
GO

-- Creating primary key on [CODIGO] in table 'MODULOS'
ALTER TABLE [dbo].[MODULOS]
ADD CONSTRAINT [PK_MODULOS]
    PRIMARY KEY CLUSTERED ([CODIGO] ASC);
GO

-- Creating primary key on [CODIGO] in table 'SUBMODULOS'
ALTER TABLE [dbo].[SUBMODULOS]
ADD CONSTRAINT [PK_SUBMODULOS]
    PRIMARY KEY CLUSTERED ([CODIGO] ASC);
GO

-- Creating primary key on [ID] in table 'PARAMETROS'
ALTER TABLE [dbo].[PARAMETROS]
ADD CONSTRAINT [PK_PARAMETROS]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [USUARIO_CODIGO], [GRUPO_CODIGO] in table 'USUARIOGRUPO'
ALTER TABLE [dbo].[USUARIOGRUPO]
ADD CONSTRAINT [PK_USUARIOGRUPO]
    PRIMARY KEY CLUSTERED ([USUARIO_CODIGO], [GRUPO_CODIGO] ASC);
GO

-- Creating primary key on [GRUPO_CODIGO], [ACCION_CODIGO] in table 'GRUPOACCION'
ALTER TABLE [dbo].[GRUPOACCION]
ADD CONSTRAINT [PK_GRUPOACCION]
    PRIMARY KEY CLUSTERED ([GRUPO_CODIGO], [ACCION_CODIGO] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MODULO_CODIGO] in table 'SUBMODULOS'
ALTER TABLE [dbo].[SUBMODULOS]
ADD CONSTRAINT [FK_MODULOSUBMODULO]
    FOREIGN KEY ([MODULO_CODIGO])
    REFERENCES [dbo].[MODULOS]
        ([CODIGO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MODULOSUBMODULO'
CREATE INDEX [IX_FK_MODULOSUBMODULO]
ON [dbo].[SUBMODULOS]
    ([MODULO_CODIGO]);
GO

-- Creating foreign key on [SUBMODULO_CODIGO] in table 'FORMULARIOS'
ALTER TABLE [dbo].[FORMULARIOS]
ADD CONSTRAINT [FK_SUBMODULOFORMULARIO]
    FOREIGN KEY ([SUBMODULO_CODIGO])
    REFERENCES [dbo].[SUBMODULOS]
        ([CODIGO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SUBMODULOFORMULARIO'
CREATE INDEX [IX_FK_SUBMODULOFORMULARIO]
ON [dbo].[FORMULARIOS]
    ([SUBMODULO_CODIGO]);
GO

-- Creating foreign key on [FORMULARIO_CODIGO] in table 'ACCIONES'
ALTER TABLE [dbo].[ACCIONES]
ADD CONSTRAINT [FK_FORMULARIOACCION]
    FOREIGN KEY ([FORMULARIO_CODIGO])
    REFERENCES [dbo].[FORMULARIOS]
        ([CODIGO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FORMULARIOACCION'
CREATE INDEX [IX_FK_FORMULARIOACCION]
ON [dbo].[ACCIONES]
    ([FORMULARIO_CODIGO]);
GO

-- Creating foreign key on [USUARIO_CODIGO] in table 'USUARIOGRUPO'
ALTER TABLE [dbo].[USUARIOGRUPO]
ADD CONSTRAINT [FK_USUARIOGRUPO_USUARIO]
    FOREIGN KEY ([USUARIO_CODIGO])
    REFERENCES [dbo].[USUARIOS]
        ([CODIGO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [GRUPO_CODIGO] in table 'USUARIOGRUPO'
ALTER TABLE [dbo].[USUARIOGRUPO]
ADD CONSTRAINT [FK_USUARIOGRUPO_GRUPO]
    FOREIGN KEY ([GRUPO_CODIGO])
    REFERENCES [dbo].[GRUPOS]
        ([CODIGO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_USUARIOGRUPO_GRUPO'
CREATE INDEX [IX_FK_USUARIOGRUPO_GRUPO]
ON [dbo].[USUARIOGRUPO]
    ([GRUPO_CODIGO]);
GO

-- Creating foreign key on [GRUPO_CODIGO] in table 'GRUPOACCION'
ALTER TABLE [dbo].[GRUPOACCION]
ADD CONSTRAINT [FK_GRUPOACCION_GRUPO]
    FOREIGN KEY ([GRUPO_CODIGO])
    REFERENCES [dbo].[GRUPOS]
        ([CODIGO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ACCION_CODIGO] in table 'GRUPOACCION'
ALTER TABLE [dbo].[GRUPOACCION]
ADD CONSTRAINT [FK_GRUPOACCION_ACCION]
    FOREIGN KEY ([ACCION_CODIGO])
    REFERENCES [dbo].[ACCIONES]
        ([CODIGO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GRUPOACCION_ACCION'
CREATE INDEX [IX_FK_GRUPOACCION_ACCION]
ON [dbo].[GRUPOACCION]
    ([ACCION_CODIGO]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------