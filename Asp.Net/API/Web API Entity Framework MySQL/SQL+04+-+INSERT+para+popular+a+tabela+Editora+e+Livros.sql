/* EDITORA */
INSERT INTO `Editoras` (`Id`, `Nome`, `Site`) VALUES ('1786e916-5871-4b49-8aeb-68befe8ff90b', 'Sextante', 'http://sextante.com.br'), ('47cd297b-2ca3-45f5-a180-1682f3504b1c', 'Rocco', 'http://rocco.com.br');

/* LIVRO COM EDITORA RELACIONADA */
INSERT INTO `cursodb`.`Livros` (`Nome`, `Edicao`, `NumeroPagina`, `Preco`, `CodigoEditora`, `SiteLivro`, `EmailAutor`) 
VALUES ('Fortaleza Digital', '1º Edição', '433', '34.55', '1786e916-5871-4b49-8aeb-68befe8ff90b', 'http://fortalezadigital.com.br', 'danbrown@yahoo.com');

INSERT INTO `cursodb`.`Livros` (`Nome`, `Edicao`, `NumeroPagina`, `Preco`, `CodigoEditora`, `SiteLivro`, `EmailAutor`) 
VALUES ('O Código da Vinci', '7º Edição', '445', '39.00', '1786e916-5871-4b49-8aeb-68befe8ff90b', 'http://ocodigodavinci.com.br', 'danbrown@gmail.com');

INSERT INTO `cursodb`.`Livros` (`Nome`, `Edicao`, `NumeroPagina`, `Preco`, `CodigoEditora`, `SiteLivro`, `EmailAutor`) 
VALUES ('Origem', '1º Edição', '525', '29.99', '1786e916-5871-4b49-8aeb-68befe8ff90b', 'http://origem.com.br', 'danbrown@yahoo.com');

INSERT INTO `cursodb`.`Livros` (`Nome`, `Edicao`, `NumeroPagina`, `Preco`, `CodigoEditora`, `SiteLivro`, `EmailAutor`) 
VALUES ('A Pedra Filosofal', '6º Edição', '321', '9.90', '47cd297b-2ca3-45f5-a180-1682f3504b1c', 'http://harrypotter.com.br', 'jkrowling@hotmail.com');

INSERT INTO `cursodb`.`Livros` (`Nome`, `Edicao`, `NumeroPagina`, `Preco`, `CodigoEditora`, `SiteLivro`, `EmailAutor`) 
VALUES ('A Ordem da Fênix', '2º Edição', '451', '9.90', '47cd297b-2ca3-45f5-a180-1682f3504b1c', 'http://harrypotter.com.br', 'jkrowling@hotmail.com');