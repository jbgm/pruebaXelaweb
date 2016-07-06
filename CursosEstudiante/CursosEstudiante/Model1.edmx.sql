




-- -----------------------------------------------------------
-- Entity Designer DDL Script for MySQL Server 4.1 and higher
-- -----------------------------------------------------------
-- Date Created: 07/06/2016 11:36:44
-- Generated from EDMX file: C:\Users\jorge\Documents\visual studio 2013\Projects\PruebaXelaweb\CursosEstudiante\CursosEstudiante\Model1.edmx
-- Target version: 3.0.0.0
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------

--    ALTER TABLE `Asignacions` DROP CONSTRAINT `FK_EstudianteAsignacion`;
--    ALTER TABLE `Asignacions` DROP CONSTRAINT `FK_CursoAsignacion`;
--    ALTER TABLE `Tareas` DROP CONSTRAINT `FK_AsignacionTarea`;

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
SET foreign_key_checks = 0;
    DROP TABLE IF EXISTS `Estudiantes`;
    DROP TABLE IF EXISTS `Cursos`;
    DROP TABLE IF EXISTS `Tareas`;
    DROP TABLE IF EXISTS `Asignacions`;
SET foreign_key_checks = 1;

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

CREATE TABLE `Estudiantes`(
	`IdEstudiante` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`nombre` longtext NOT NULL);

ALTER TABLE `Estudiantes` ADD PRIMARY KEY (`IdEstudiante`);




CREATE TABLE `Cursos`(
	`IdCurso` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Nombre` longtext NOT NULL);

ALTER TABLE `Cursos` ADD PRIMARY KEY (`IdCurso`);




CREATE TABLE `Tareas`(
	`IdTarea` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Tipo` longtext NOT NULL, 
	`Nota` int NOT NULL, 
	`AsignacionIdAsignacion` int NOT NULL, 
	`CursoIdCurso` int NOT NULL);

ALTER TABLE `Tareas` ADD PRIMARY KEY (`IdTarea`);




CREATE TABLE `Asignacions`(
	`IdAsignacion` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`EstudianteIdEstudiante` int NOT NULL, 
	`CursoIdCurso` int NOT NULL, 
	`notaFinal` int NOT NULL);

ALTER TABLE `Asignacions` ADD PRIMARY KEY (`IdAsignacion`);






-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on `EstudianteIdEstudiante` in table 'Asignacions'

ALTER TABLE `Asignacions`
ADD CONSTRAINT `FK_EstudianteAsignacion`
    FOREIGN KEY (`EstudianteIdEstudiante`)
    REFERENCES `Estudiantes`
        (`IdEstudiante`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EstudianteAsignacion'

CREATE INDEX `IX_FK_EstudianteAsignacion` 
    ON `Asignacions`
    (`EstudianteIdEstudiante`);

-- Creating foreign key on `CursoIdCurso` in table 'Asignacions'

ALTER TABLE `Asignacions`
ADD CONSTRAINT `FK_CursoAsignacion`
    FOREIGN KEY (`CursoIdCurso`)
    REFERENCES `Cursos`
        (`IdCurso`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CursoAsignacion'

CREATE INDEX `IX_FK_CursoAsignacion` 
    ON `Asignacions`
    (`CursoIdCurso`);

-- Creating foreign key on `CursoIdCurso` in table 'Tareas'

ALTER TABLE `Tareas`
ADD CONSTRAINT `FK_CursoTarea`
    FOREIGN KEY (`CursoIdCurso`)
    REFERENCES `Cursos`
        (`IdCurso`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CursoTarea'

CREATE INDEX `IX_FK_CursoTarea` 
    ON `Tareas`
    (`CursoIdCurso`);

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
