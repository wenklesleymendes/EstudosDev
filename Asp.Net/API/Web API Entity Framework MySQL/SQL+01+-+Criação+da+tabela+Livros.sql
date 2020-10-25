CREATE TABLE `livros` (
  `Id` int(11) NOT NULL,
  `Nome` longtext NOT NULL,
  `Edicao` longtext,
  `NumeroPagina` int(11) NOT NULL,
  `Preco` decimal(18,2) NOT NULL,
  `Editora` longtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `livros`
  ADD PRIMARY KEY (`Id`);

ALTER TABLE `livros`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;