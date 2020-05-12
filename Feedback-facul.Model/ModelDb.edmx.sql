
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/12/2020 00:06:01
-- Generated from EDMX file: C:\Users\peped\Desktop\PI\Core\Feedback-facul.core\Feedback-facul.Model\ModelDb.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [glassDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__tb_aluno___id_cu__48CFD27E]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_aluno_matriculado] DROP CONSTRAINT [FK__tb_aluno___id_cu__48CFD27E];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_aluno___id_in__47DBAE45]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_aluno_matriculado] DROP CONSTRAINT [FK__tb_aluno___id_in__47DBAE45];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_aluno___id_us__46E78A0C]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_aluno_matriculado] DROP CONSTRAINT [FK__tb_aluno___id_us__46E78A0C];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_avalia__id_in__534D60F1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_avaliacao] DROP CONSTRAINT [FK__tb_avalia__id_in__534D60F1];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_avalia__id_qu__5165187F]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_avaliacao] DROP CONSTRAINT [FK__tb_avalia__id_qu__5165187F];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_avalia__id_us__52593CB8]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_avaliacao] DROP CONSTRAINT [FK__tb_avalia__id_us__52593CB8];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_consis__id_ca__3D5E1FD2]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_consistencia_categoria] DROP CONSTRAINT [FK__tb_consis__id_ca__3D5E1FD2];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_consis__id_co__3C69FB99]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_consistencia_categoria] DROP CONSTRAINT [FK__tb_consis__id_co__3C69FB99];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_instit__id_ca__403A8C7D]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_instituicao] DROP CONSTRAINT [FK__tb_instit__id_ca__403A8C7D];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_quesit__id_cu__4E88ABD4]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_quesito_curso] DROP CONSTRAINT [FK__tb_quesit__id_cu__4E88ABD4];
GO
IF OBJECT_ID(N'[dbo].[FK__tb_quesit__id_qu__4D94879B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tb_quesito_curso] DROP CONSTRAINT [FK__tb_quesit__id_qu__4D94879B];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[tb_aluno_matriculado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_aluno_matriculado];
GO
IF OBJECT_ID(N'[dbo].[tb_avaliacao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_avaliacao];
GO
IF OBJECT_ID(N'[dbo].[tb_categoria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_categoria];
GO
IF OBJECT_ID(N'[dbo].[tb_consistencia]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_consistencia];
GO
IF OBJECT_ID(N'[dbo].[tb_consistencia_categoria]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_consistencia_categoria];
GO
IF OBJECT_ID(N'[dbo].[tb_curso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_curso];
GO
IF OBJECT_ID(N'[dbo].[tb_instituicao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_instituicao];
GO
IF OBJECT_ID(N'[dbo].[tb_parger]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_parger];
GO
IF OBJECT_ID(N'[dbo].[tb_quesito]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_quesito];
GO
IF OBJECT_ID(N'[dbo].[tb_quesito_curso]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_quesito_curso];
GO
IF OBJECT_ID(N'[dbo].[tb_usuario]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tb_usuario];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'tb_aluno_matriculado'
CREATE TABLE [dbo].[tb_aluno_matriculado] (
    [Usuario] int  NOT NULL,
    [Instituicao] int  NOT NULL,
    [Curso] int  NOT NULL
);
GO

-- Creating table 'tb_avaliacao'
CREATE TABLE [dbo].[tb_avaliacao] (
    [id_quesito] int  NOT NULL,
    [id_usuario] int  NOT NULL,
    [id_instituicao] int  NOT NULL,
    [estrelas] int  NOT NULL,
    [comentario] varchar(250)  NULL,
    [data_inicial] datetime  NOT NULL,
    [data_ultima_atualizacao] datetime  NULL
);
GO

-- Creating table 'tb_categoria'
CREATE TABLE [dbo].[tb_categoria] (
    [id] int IDENTITY(1,1) NOT NULL,
    [descricao] varchar(150)  NULL
);
GO

-- Creating table 'tb_consistencia'
CREATE TABLE [dbo].[tb_consistencia] (
    [id] int IDENTITY(1,1) NOT NULL,
    [consistencia_cod] int  NOT NULL,
    [descricao] varchar(150)  NULL,
    [situacao] varchar(1)  NULL
);
GO

-- Creating table 'tb_curso'
CREATE TABLE [dbo].[tb_curso] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nome] varchar(60)  NOT NULL,
    [tipo_curso] varchar(1)  NULL,
    [formacao] varchar(1)  NULL,
    [quantidade_semestres] int  NOT NULL
);
GO

-- Creating table 'tb_instituicao'
CREATE TABLE [dbo].[tb_instituicao] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nome] varchar(80)  NOT NULL,
    [descricao] varchar(150)  NULL,
    [estado] varchar(70)  NOT NULL,
    [cidade] varchar(70)  NOT NULL,
    [bairro] varchar(70)  NOT NULL,
    [rua] varchar(100)  NOT NULL,
    [campus] varchar(50)  NULL,
    [imagem] varchar(250)  NULL,
    [id_categoria] int  NULL
);
GO

-- Creating table 'tb_parger'
CREATE TABLE [dbo].[tb_parger] (
    [id] int IDENTITY(1,1) NOT NULL,
    [parger_cod] int  NOT NULL,
    [descricao] varchar(150)  NULL,
    [situacao] varchar(1)  NULL
);
GO

-- Creating table 'tb_quesito'
CREATE TABLE [dbo].[tb_quesito] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nome] varchar(80)  NOT NULL,
    [descricao] varchar(150)  NULL,
    [situacao] varchar(1)  NULL
);
GO

-- Creating table 'tb_usuario'
CREATE TABLE [dbo].[tb_usuario] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nome] varchar(80)  NOT NULL,
    [cpf] varchar(11)  NOT NULL,
    [nascimento] datetime  NOT NULL,
    [estado] varchar(70)  NULL,
    [cidade] varchar(70)  NULL,
    [tipo_usuario] varchar(1)  NULL,
    [username] varchar(50)  NOT NULL,
    [senha] varchar(512)  NOT NULL
);
GO

-- Creating table 'tb_consistencia_categoria'
CREATE TABLE [dbo].[tb_consistencia_categoria] (
    [tb_categoria_id] int  NOT NULL,
    [tb_consistencia_id] int  NOT NULL
);
GO

-- Creating table 'tb_quesito_curso'
CREATE TABLE [dbo].[tb_quesito_curso] (
    [tb_curso_id] int  NOT NULL,
    [tb_quesito_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Usuario], [Instituicao], [Curso] in table 'tb_aluno_matriculado'
ALTER TABLE [dbo].[tb_aluno_matriculado]
ADD CONSTRAINT [PK_tb_aluno_matriculado]
    PRIMARY KEY CLUSTERED ([Usuario], [Instituicao], [Curso] ASC);
GO

-- Creating primary key on [id_quesito], [id_usuario], [id_instituicao] in table 'tb_avaliacao'
ALTER TABLE [dbo].[tb_avaliacao]
ADD CONSTRAINT [PK_tb_avaliacao]
    PRIMARY KEY CLUSTERED ([id_quesito], [id_usuario], [id_instituicao] ASC);
GO

-- Creating primary key on [id] in table 'tb_categoria'
ALTER TABLE [dbo].[tb_categoria]
ADD CONSTRAINT [PK_tb_categoria]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tb_consistencia'
ALTER TABLE [dbo].[tb_consistencia]
ADD CONSTRAINT [PK_tb_consistencia]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tb_curso'
ALTER TABLE [dbo].[tb_curso]
ADD CONSTRAINT [PK_tb_curso]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tb_instituicao'
ALTER TABLE [dbo].[tb_instituicao]
ADD CONSTRAINT [PK_tb_instituicao]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tb_parger'
ALTER TABLE [dbo].[tb_parger]
ADD CONSTRAINT [PK_tb_parger]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tb_quesito'
ALTER TABLE [dbo].[tb_quesito]
ADD CONSTRAINT [PK_tb_quesito]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tb_usuario'
ALTER TABLE [dbo].[tb_usuario]
ADD CONSTRAINT [PK_tb_usuario]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [tb_categoria_id], [tb_consistencia_id] in table 'tb_consistencia_categoria'
ALTER TABLE [dbo].[tb_consistencia_categoria]
ADD CONSTRAINT [PK_tb_consistencia_categoria]
    PRIMARY KEY CLUSTERED ([tb_categoria_id], [tb_consistencia_id] ASC);
GO

-- Creating primary key on [tb_curso_id], [tb_quesito_id] in table 'tb_quesito_curso'
ALTER TABLE [dbo].[tb_quesito_curso]
ADD CONSTRAINT [PK_tb_quesito_curso]
    PRIMARY KEY CLUSTERED ([tb_curso_id], [tb_quesito_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Curso] in table 'tb_aluno_matriculado'
ALTER TABLE [dbo].[tb_aluno_matriculado]
ADD CONSTRAINT [FK__tb_aluno___id_cu__49C3F6B7]
    FOREIGN KEY ([Curso])
    REFERENCES [dbo].[tb_curso]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__tb_aluno___id_cu__49C3F6B7'
CREATE INDEX [IX_FK__tb_aluno___id_cu__49C3F6B7]
ON [dbo].[tb_aluno_matriculado]
    ([Curso]);
GO

-- Creating foreign key on [Instituicao] in table 'tb_aluno_matriculado'
ALTER TABLE [dbo].[tb_aluno_matriculado]
ADD CONSTRAINT [FK__tb_aluno___id_in__48CFD27E]
    FOREIGN KEY ([Instituicao])
    REFERENCES [dbo].[tb_instituicao]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__tb_aluno___id_in__48CFD27E'
CREATE INDEX [IX_FK__tb_aluno___id_in__48CFD27E]
ON [dbo].[tb_aluno_matriculado]
    ([Instituicao]);
GO

-- Creating foreign key on [Usuario] in table 'tb_aluno_matriculado'
ALTER TABLE [dbo].[tb_aluno_matriculado]
ADD CONSTRAINT [FK__tb_aluno___id_us__47DBAE45]
    FOREIGN KEY ([Usuario])
    REFERENCES [dbo].[tb_usuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id_instituicao] in table 'tb_avaliacao'
ALTER TABLE [dbo].[tb_avaliacao]
ADD CONSTRAINT [FK__tb_avalia__id_in__5441852A]
    FOREIGN KEY ([id_instituicao])
    REFERENCES [dbo].[tb_instituicao]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__tb_avalia__id_in__5441852A'
CREATE INDEX [IX_FK__tb_avalia__id_in__5441852A]
ON [dbo].[tb_avaliacao]
    ([id_instituicao]);
GO

-- Creating foreign key on [id_quesito] in table 'tb_avaliacao'
ALTER TABLE [dbo].[tb_avaliacao]
ADD CONSTRAINT [FK__tb_avalia__id_qu__52593CB8]
    FOREIGN KEY ([id_quesito])
    REFERENCES [dbo].[tb_quesito]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [id_usuario] in table 'tb_avaliacao'
ALTER TABLE [dbo].[tb_avaliacao]
ADD CONSTRAINT [FK__tb_avalia__id_us__534D60F1]
    FOREIGN KEY ([id_usuario])
    REFERENCES [dbo].[tb_usuario]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__tb_avalia__id_us__534D60F1'
CREATE INDEX [IX_FK__tb_avalia__id_us__534D60F1]
ON [dbo].[tb_avaliacao]
    ([id_usuario]);
GO

-- Creating foreign key on [id_categoria] in table 'tb_instituicao'
ALTER TABLE [dbo].[tb_instituicao]
ADD CONSTRAINT [FK__tb_instit__id_ca__412EB0B6]
    FOREIGN KEY ([id_categoria])
    REFERENCES [dbo].[tb_categoria]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__tb_instit__id_ca__412EB0B6'
CREATE INDEX [IX_FK__tb_instit__id_ca__412EB0B6]
ON [dbo].[tb_instituicao]
    ([id_categoria]);
GO

-- Creating foreign key on [tb_categoria_id] in table 'tb_consistencia_categoria'
ALTER TABLE [dbo].[tb_consistencia_categoria]
ADD CONSTRAINT [FK_tb_consistencia_categoria_tb_categoria]
    FOREIGN KEY ([tb_categoria_id])
    REFERENCES [dbo].[tb_categoria]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [tb_consistencia_id] in table 'tb_consistencia_categoria'
ALTER TABLE [dbo].[tb_consistencia_categoria]
ADD CONSTRAINT [FK_tb_consistencia_categoria_tb_consistencia]
    FOREIGN KEY ([tb_consistencia_id])
    REFERENCES [dbo].[tb_consistencia]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_consistencia_categoria_tb_consistencia'
CREATE INDEX [IX_FK_tb_consistencia_categoria_tb_consistencia]
ON [dbo].[tb_consistencia_categoria]
    ([tb_consistencia_id]);
GO

-- Creating foreign key on [tb_curso_id] in table 'tb_quesito_curso'
ALTER TABLE [dbo].[tb_quesito_curso]
ADD CONSTRAINT [FK_tb_quesito_curso_tb_curso]
    FOREIGN KEY ([tb_curso_id])
    REFERENCES [dbo].[tb_curso]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [tb_quesito_id] in table 'tb_quesito_curso'
ALTER TABLE [dbo].[tb_quesito_curso]
ADD CONSTRAINT [FK_tb_quesito_curso_tb_quesito]
    FOREIGN KEY ([tb_quesito_id])
    REFERENCES [dbo].[tb_quesito]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tb_quesito_curso_tb_quesito'
CREATE INDEX [IX_FK_tb_quesito_curso_tb_quesito]
ON [dbo].[tb_quesito_curso]
    ([tb_quesito_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------