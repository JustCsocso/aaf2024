create database nyilvantartas;
use nyilvantartas;
DROP TABLE IF EXISTS `barlang`;
CREATE TABLE `barlang` (
  `id` int(11) NOT NULL,
  `nev` varchar(50) NOT NULL,
  `hossz` int(11) NOT NULL,
  `kiterjedes` int(11) NOT NULL,
  `melyseg` int(11) NOT NULL,
  `magassag` int(11) NOT NULL,
  `telepules` varchar(30) NOT NULL);


ALTER TABLE `barlang`
  ADD PRIMARY KEY (`id`);


ALTER TABLE `barlang`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;


/*2. feladat*/
SELECT nev from barlang WHERE melyseg > 100 ORDER BY nev;

/*3. feladat*/

SELECT nev from barlang Where nev Like '%lyuk%' Or nev Like "%lik%" Or nev Like "%zsomboly%";

/*4. feladat*/

SELECT nev from barlang 