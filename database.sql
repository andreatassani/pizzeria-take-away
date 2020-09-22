-- *********************************************
-- * Standard SQL generation                   
-- *--------------------------------------------
-- * DB-MAIN version: 11.0.1              
-- * Generator datetime: Dec  4 2018              
-- * Generation datetime: Thu Jul  4 17:20:49 2019 
-- * LUN file: D:\Università\2° anno\Basi di dati\Progetto\logico.lun 
-- * Schema: SCHEMA LOGICO FINALE COMPLETO_3luglio/SQL3 
-- ********************************************* 


-- Database Section
-- ________________ 

DROP DATABASE IF EXISTS PIZZERIA_ASPORTO;

CREATE DATABASE IF NOT EXISTS PIZZERIA_ASPORTO;

USE PIZZERIA_ASPORTO;

-- DBSpace Section
-- _______________


-- Tables Section
-- _____________ 

create table ALLERGENI (
     Codice int(2) primary key,
     Descrizione char(20) not null);

create table BEVERAGE (
     IDBeverage int(2) not null,
     Prezzo_di_vendita decimal(5,2),
     constraint ID_BEVER_PRODO_ID primary key (IDBeverage)
);

create table CLIENTI (
     Codice_cliente char(5) not null,
     IDtessera int(3),
     Nome varchar(20) not null,
     Cognome varchar(20) not null,
     Cellulare char(10) not null CHECK(LENGTH(Cellulare)=10),
     Via varchar(30),
     Civico varchar(5),
     CAP int(5) CHECK (LENGTH(CAP) = 5),
     Citta varchar(10),
     constraint ID_CLIENTI_ID primary key (Codice_cliente),
     constraint SID_CLIEN_TESSE_ID unique (IDtessera));

create table DETTAGLI_ORDINI (
     ID_Prodotto int(2) not null,
     ID_Ordine int(3) not null,
     Data datetime not null,
     Riga int(2) not null,
     Descrizione varchar(30) not null,
     Quantita int(2) not null default'1' CHECK (Quantita > 0),
     Costo_unitario decimal(5,2) not null CHECK (Costo_unitario > 0), 
     Imponibile decimal(5,2) not null CHECK ((Imponibile > 0) AND (Imponibile = Costo_unitario * Quantita)),
     Importo decimal(5,2) not null CHECK ((Importo > 0) AND (Importo = Imponibile + Aliquota_IVA)),
     Aliquota_IVA decimal(5,2) not null,
     constraint ID_DETTAGLI_ORDINI_ID primary key (ID_Ordine, Data, ID_Prodotto, Riga));

create table DIPENDENTI (
     IdDipendente char(2) not null,
     Data_assunzione datetime not null,
     CF char(16) not null CHECK (LENGTH (CF) = 16),
     Nome varchar(20) not null,
     Cognome varchar(20) not null,
     Telefono_fisso char(10) CHECK (LENGTH (Telefono_fisso) = 10),
     Cellulare char(10) not null CHECK (LENGTH (Cellulare) = 10),
     Via varchar(50) not null,
     Civico varchar(5) not null,
     CAP char(5) not null CHECK (LENGTH (CAP) = 5),
     Citta varchar(20) not null,
     Tipologia varchar(20) not null CHECK (Tipologia IN ('Cassiere', 'Fattorino', 'Pizzaiolo')),
     Num_protoc_HACCP int(10),
     ID_patente char(10) CHECK (LENGTH (ID_patente) = 10),
     Tariffa_oraria decimal(5,2) not null,
     constraint ID_DIPENDENTI_ID primary key (IdDipendente),
     constraint SID_DIPENDENTI_ID unique (CF));

create table FARCITURE (
     IDIngrediente int(2) not null,
     Codice_pizza int(3) not null,
     constraint ID_FARCITURE_ID primary key (IDIngrediente, Codice_pizza));

create table FATTURE (
     Numero int(3) not null,
     Importo decimal(5,2) not null,
     Data_Emissione datetime not null,
     Termine_di_pagamento datetime not null,
     Pagato boolean not null default 0,
     IdFornitore varchar(3) not null,
     constraint ID_FATTURE_ID primary key (Numero));
	 
create table FORMATI (
     Codice int(1) not null,
     Descrizione varchar(20) not null,
     Costo_margherita decimal(5,2) not null CHECK(Costo_margherita > 0),
     Costo_farcita decimal(5,2) not null CHECK(Costo_farcita > 0),
     constraint ID_FORMATI_ID primary key (Codice));

create table FORNITORI (
     IdFornitore char(3) not null,
     Partita_IVA char(11) not null CHECK (LENGTH (Partita_IVA) = 11),
     Ragione_Sociale varchar(50) not null,
     Telefono char(10) not null CHECK (LENGTH (Telefono) = 10),
     IBAN char(27) CHECK (LENGTH (IBAN) = 27),
     Via varchar(50) not null,
     Civico varchar(5) not null,
     CAP char(5) not null CHECK (LENGTH (CAP) = 5),
     Citta char(10) not null,
     constraint ID_FORNITORI_ID primary key (IdFornitore),
     constraint SID_FORNITORI_1_ID unique (Partita_IVA),
     constraint SID_FORNITORI_ID unique (IBAN));

create table IMPASTI (
     Codice int(1) not null,
     Descrizione varchar(30) not null,
     Costo decimal(5,2) not null CHECK (Costo >= 0),
     constraint ID_IMPASTI_ID primary key (Codice));

create table INGREDIENTI (
     IDIngrediente int(2) not null,
     Costo_aggiunta decimal(5,2),
     constraint ID_INGRE_MATER_ID primary key (IDIngrediente));

create table MATERIE_PRIME (
     IDMateriaPrima int(2) not null,
     Tipo varchar(30) CHECK(Tipo IN ('ingrediente per impasto', 'ingrediente')),
     constraint ID_MATER_PRODO_ID primary key (IDMateriaPrima));

create table MODIFICHE (
     IDIngrediente int(2) not null,
     IDOrdine int(3) not null,
     Data datetime not null,
     Numero_pizza_ordinata int(1) not null,
     Eliminazione_Aggiunta boolean not null,
     constraint ID_MODIFICHE_ID primary key (IDIngrediente, IDOrdine, Data, Numero_pizza_ordinata));

create table ORDINI (
     IDOrdine int(3) not null,
     Data datetime not null,
     Ora time not null,
     Numero_pizze_ordinate int(2) not null,
     Importo_ordine decimal(5,2) not null CHECK(Importo_ordine > 0),
     Totale decimal(5,2) not null CHECK(Totale > 0),
     Pagato boolean not null default 0,
     Tipologia_pagamento varchar(20) not null CHECK( Tipologia_pagamento IN ('Contanti', 'Bancomat', 'Carta di credito')),
     CodCliente char(5)  not null,
     IdCassiere char(2) not null,
     IdFattorino char(2),
     Importo_consegna decimal(5,2),
     constraint ID_ORDINI_ID primary key (IDOrdine, Data));

create table ORDINI_BEVANDE (
     IDOrdine int(3) not null,
     Data datetime not null,
     IDBeverage int(2) not null,
     Quantita int(2) not null default '1' CHECK(Quantita > 0) ,
     constraint ID_ORDINI_BEVANDE_ID primary key (IDBeverage, IDOrdine, Data));

create table ORDINI_FORNITORI (
     ID_Ordine int(3) not null,
     Data datetime not null,
     ImportoTotale decimal(5,2) not null CHECK(ImportoTotale > 0),
     IdFornitore varchar(3) not null,
     constraint ID_ORDINI_FORNITORI_ID primary key (ID_Ordine, Data));

create table PIZZE (
     CodiceListino int(3) not null auto_increment,
     Nome varchar(20) not null,
     Prezzo decimal(5,2) not null CHECK(Prezzo > 0),
     constraint ID_PIZZE_ID primary key (CodiceListino),
     constraint SID_PIZZE_ID unique (Nome));

create table PIZZE_ORDINATE (
     IDOrdine int(5) not null,
     Data datetime not null,
     Numero int(2) not null,
     Quantita int(2) not null default '1' CHECK(Quantita > 0),
     Costo decimal(5,2) not null,
     Totale decimal(5,2) not null CHECK ( Totale = Quantita * Costo),
     Codice_formato int(1),
     Codice_impasto int(1) not null,
     Codice_listino_pizza int(3) not null,
     constraint ID_PIZZE_ORDINATE_ID primary key (IDOrdine, Data, Numero));

create table PRESENZA_ALLERGENI (
     CodiceAllergene int(2) not null,
     IDMateriaPrima int(2) not null,
     constraint ID_PRESENZA_ALLERGENI_ID primary key (CodiceAllergene, IDMateriaPrima));

create table PRODOTTI (
     ID_Prodotto int(2) not null,
     Descrizione varchar(30) not null unique,
     Tipo varchar(20) not null CHECK( Tipo IN ('beverage', 'materia prima', 'packaging')),
     constraint ID_PRODOTTI_ID primary key (ID_Prodotto),
     constraint SID_PRODOTTI_ID unique (Descrizione));

create table REALIZZAZIONE_IMPASTI (
     IDMateriaPrima int(2) not null,
     CodiceImpasto int(2) not null,
     constraint ID_REALIZZAZIONE_IMPASTI_ID primary key (IDMateriaPrima, CodiceImpasto));

create table TESSERE (
     IDtessera int(3) not null,
     Numero_pizze int(2) default '15',
     constraint ID_TESSERE_ID primary key (IDtessera));

create table TURNI (
     IdDipendente varchar(2) not null,
     Data datetime not null,
     Ora_inizio time not null,
     Ora_fine time,
     constraint ID_TURNI_ID primary key (Data, IdDipendente));


-- Constraints Section
-- ___________________ 

/*alter table ALLERGENI add constraint ID_ALLERGENI_CHK
     check(exists(select * from PRESENZA_ALLERGENI
                  where PRESENZA_ALLERGENI.CodiceAllergene = Codice));*/

alter table BEVERAGE add constraint ID_BEVER_PRODO_FK 
	foreign key (IDBeverage) references PRODOTTI (ID_Prodotto)
		ON DELETE CASCADE
        ON UPDATE NO ACTION;

alter table CLIENTI add constraint SID_CLIEN_TESSE_FK
     foreign key (IDtessera) references TESSERE (IDtessera)
		ON DELETE SET NULL
        ON UPDATE NO ACTION;
        
alter table DETTAGLI_ORDINI add constraint EQU_DETTA_ORDIN
     foreign key (ID_Ordine, Data) references ORDINI_FORNITORI (ID_Ordine, Data)
		ON DELETE CASCADE
        ON UPDATE NO ACTION;

alter table DETTAGLI_ORDINI add constraint EQU_DETTA_PRODO_FK
     foreign key (ID_Prodotto) references PRODOTTI (ID_Prodotto)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

alter table FARCITURE add constraint EQU_FARCI_PIZZE_FK
     foreign key (Codice_pizza) references PIZZE (CodiceListino)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

alter table FARCITURE add constraint EQU_FARCI_INGRE
     foreign key (IDIngrediente) references PRODOTTI (ID_Prodotto)
		ON DELETE CASCADE
        ON UPDATE NO ACTION;

alter table FATTURE add constraint REF_FATTU_FORNI_FK
     foreign key (IdFornitore) references FORNITORI (IdFornitore)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

/*alter table IMPASTI add constraint ID_IMPASTI_CHK
     check(exists(select * from REALIZZAZIONE_IMPASTI
                  where REALIZZAZIONE_IMPASTI.CodiceImpasto = Codice));

alter table INGREDIENTI add constraint ID_INGRE_MATER_CHK
     check(exists(select * from FARCITURE
                  where FARCITURE.IDIngrediente = IDIngrediente)); */

alter table INGREDIENTI add constraint ID_INGRE_MATER_FK
     foreign key (IDIngrediente) references MATERIE_PRIME (IDMateriaPrima)
		ON DELETE CASCADE
        ON UPDATE NO ACTION;

alter table MATERIE_PRIME add constraint ID_MATER_PRODO_FK
     foreign key (IDMateriaPrima) references PRODOTTI (ID_Prodotto)
		ON DELETE CASCADE
        ON UPDATE NO ACTION;

alter table MODIFICHE add constraint REF_MODIF_PIZZE_FK
     foreign key (IDOrdine, Data, Numero_pizza_ordinata) references PIZZE_ORDINATE (IDOrdine, Data, Numero)
		ON DELETE CASCADE
        ON UPDATE NO ACTION;

alter table MODIFICHE add constraint REF_MODIF_INGRE
     foreign key (IDIngrediente) references INGREDIENTI (IDIngrediente)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

/*alter table ORDINI add constraint ID_ORDINI_CHK
     check(exists(select * from PIZZE_ORDINATE
                  where PIZZE_ORDINATE.IDOrdine = IDOrdine and PIZZE_ORDINATE.Data = Data));*/

alter table ORDINI add constraint REF_ORDIN_CLIEN_FK
     foreign key (CodCliente) references CLIENTI (Codice_cliente)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

alter table ORDINI add constraint REF_ORDIN_DIPEN_1_FK
     foreign key (IdCassiere) references DIPENDENTI (IdDipendente) 
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

alter table ORDINI add constraint REF_ORDIN_DIPEN_FK
     foreign key (IdFattorino)	references DIPENDENTI (IdDipendente)
		ON DELETE NO ACTION 
        ON UPDATE NO ACTION;

alter table ORDINI_BEVANDE add constraint REF_ORDIN_BEVER
     foreign key (IDBeverage) references BEVERAGE (IDBeverage)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

alter table ORDINI_BEVANDE add constraint REF_ORDIN_ORDIN_FK
     foreign key (IDOrdine, Data) references ORDINI (IDOrdine, Data)
		ON DELETE CASCADE
        ON UPDATE NO ACTION;

/*alter table ORDINI_FORNITORI add constraint ID_ORDINI_FORNITORI_CHK
     check(exists(select * from DETTAGLI_ORDINI
                  where DETTAGLI_ORDINI.ID_Ordine = ID_Ordine and DETTAGLI_ORDINI.Data = Data));*/

alter table ORDINI_FORNITORI add constraint REF_ORDIN_FORNI_FK
     foreign key (IdFornitore) references FORNITORI (IdFornitore)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

/*alter table PIZZE add constraint ID_PIZZE_CHK
     check(exists(select * from FARCITURE
                  where FARCITURE.Codice_pizza = CodiceListino));*/

alter table PIZZE_ORDINATE add constraint REF_PIZZE_FORMA_FK
     foreign key (Codice_formato) references FORMATI (Codice)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

alter table PIZZE_ORDINATE add constraint REF_PIZZE_IMPAS_FK
     foreign key (Codice_impasto) references IMPASTI (Codice)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

alter table PIZZE_ORDINATE add constraint EQU_PIZZE_ORDIN
     foreign key (IDOrdine, Data) references ORDINI (IDOrdine, Data)
		ON DELETE CASCADE
        ON UPDATE NO ACTION;

alter table PIZZE_ORDINATE add constraint REF_PIZZE_PIZZE_FK
     foreign key (Codice_listino_pizza) references PIZZE (CodiceListino)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

alter table PRESENZA_ALLERGENI add constraint REF_M_A_MATER_FK
     foreign key (IDMateriaPrima) references MATERIE_PRIME (IDMateriaPrima)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

alter table PRESENZA_ALLERGENI add constraint EQU_M_A_ALLER
     foreign key (CodiceAllergene) references ALLERGENI (Codice)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

/*alter table PRODOTTI add constraint ID_PRODOTTI_CHK
     check(exists(select * from DETTAGLI_ORDINI
                  where DETTAGLI_ORDINI.ID_Prodotto = ID_Prodotto));*/

alter table REALIZZAZIONE_IMPASTI add constraint EQU_REALI_IMPAS_FK
     foreign key (CodiceImpasto) references IMPASTI (Codice)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

alter table REALIZZAZIONE_IMPASTI add constraint REF_REALI_MATER
     foreign key (IDMateriaPrima) references MATERIE_PRIME (IDMateriaPrima)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;

alter table TURNI add constraint REF_TURNI_DIPEN_FK
     foreign key (IdDipendente) references DIPENDENTI (IdDipendente)
		ON DELETE NO ACTION
        ON UPDATE NO ACTION;


-- Index Section
-- _____________ 

create unique index ID_ALLERGENI_IND
     on ALLERGENI (Codice);

create unique index ID_BEVER_PRODO_IND
     on BEVERAGE (IDBeverage);

create unique index ID_CLIENTI_IND
     on CLIENTI (Codice_cliente);

create unique index SID_CLIEN_TESSE_IND
     on CLIENTI (IDtessera);

create unique index ID_DETTAGLI_ORDINI_IND
     on DETTAGLI_ORDINI (ID_Ordine, Data, ID_Prodotto, Riga);

create index EQU_DETTA_PRODO_IND
     on DETTAGLI_ORDINI (ID_Prodotto);

create unique index ID_DIPENDENTI_IND
     on DIPENDENTI (IdDipendente);

create unique index SID_DIPENDENTI_IND
     on DIPENDENTI (CF);

create unique index ID_FARCITURE_IND
     on FARCITURE (IDIngrediente, Codice_pizza);

create index EQU_FARCI_PIZZE_IND
     on FARCITURE (Codice_pizza);

create unique index ID_FATTURE_IND
     on FATTURE (Numero);

create index REF_FATTU_FORNI_IND
     on FATTURE (IdFornitore);

create unique index ID_FORMATI_IND
     on FORMATI (Codice);

create unique index ID_FORNITORI_IND
     on FORNITORI (IdFornitore);

create unique index SID_FORNITORI_1_IND
     on FORNITORI (Partita_IVA);

create unique index SID_FORNITORI_IND
     on FORNITORI (IBAN);

create unique index ID_IMPASTI_IND
     on IMPASTI (Codice);

create unique index ID_INGRE_MATER_IND
     on INGREDIENTI (IDIngrediente);

create unique index ID_MATER_PRODO_IND
     on MATERIE_PRIME (IDMateriaPrima);

create unique index ID_MODIFICHE_IND
     on MODIFICHE (IDIngrediente, IDOrdine, Data, Numero_pizza_ordinata);

create index REF_MODIF_PIZZE_IND
     on MODIFICHE (IDOrdine, Data, Numero_pizza_ordinata);

create unique index ID_ORDINI_IND
     on ORDINI (IDOrdine, Data);

create index REF_ORDIN_CLIEN_IND
     on ORDINI (CodCliente);

create index REF_ORDIN_DIPEN_1_IND
     on ORDINI (IdCassiere);

create index REF_ORDIN_DIPEN_IND
     on ORDINI (IdFattorino);

create unique index ID_ORDINI_BEVANDE_IND
     on ORDINI_BEVANDE (IDBeverage, IDOrdine, Data);

create index REF_ORDIN_ORDIN_IND
     on ORDINI_BEVANDE (IDOrdine, Data);

create unique index ID_ORDINI_FORNITORI_IND
     on ORDINI_FORNITORI (ID_Ordine, Data);

create index REF_ORDIN_FORNI_IND
     on ORDINI_FORNITORI (IdFornitore);

create unique index ID_PIZZE_IND
     on PIZZE (CodiceListino);

create unique index SID_PIZZE_IND
     on PIZZE (Nome);

create unique index ID_PIZZE_ORDINATE_IND
     on PIZZE_ORDINATE (IDOrdine, Data, Numero);

create index REF_PIZZE_FORMA_IND
     on PIZZE_ORDINATE (Codice_formato);

create index REF_PIZZE_IMPAS_IND
     on PIZZE_ORDINATE (Codice_impasto);

create index REF_PIZZE_PIZZE_IND
     on PIZZE_ORDINATE (Codice_listino_pizza);

create unique index ID_PRESENZA_ALLERGENI_IND
     on PRESENZA_ALLERGENI (CodiceAllergene, IDMateriaPrima);

create index REF_M_A_MATER_IND
     on PRESENZA_ALLERGENI (IDMateriaPrima);

create unique index ID_PRODOTTI_IND
     on PRODOTTI (ID_Prodotto);

create unique index ID_REALIZZAZIONE_IMPASTI_IND
     on REALIZZAZIONE_IMPASTI (IDMateriaPrima, CodiceImpasto);

create index EQU_REALI_IMPAS_IND
     on REALIZZAZIONE_IMPASTI (CodiceImpasto);

create unique index ID_TESSERE_IND
     on TESSERE (IDtessera);

create unique index ID_TURNI_IND
     on TURNI (Data, IdDipendente);

create index REF_TURNI_DIPEN_IND
     on TURNI (IdDipendente);



INSERT INTO `ALLERGENI` (`Codice`, `Descrizione`) 
VALUES	('0', 'cereali e glutine'), ('1', 'frutta a guscio'), ('2', 'latticini'), ('3', 'molluschi'), 
		('4', 'pesce'), ('5', 'sesamo'), ('6', 'soia'), ('7', 'sedano'), ('8', 'solfiti');

INSERT INTO `DIPENDENTI` (`IdDipendente`, `Data_assunzione`, `CF`, `Nome`, `Cognome`, `Telefono_fisso`, `Cellulare`, `Via`, `Civico`, `CAP`, `Citta`, `Tipologia`, `Num_protoc_HACCP`, `ID_patente`, `Tariffa_oraria`) 
VALUES 	('C1', '2019-04-04 18:00:00', 'STRLCU98B49D704Y', 'Lucia', 'Sternini', '0544786421', '3457898331', 'Immacolata', '99', '47122', 'Forlì', 'Cassiere', '1298586888', NULL, '7.00'),
		('F1', '2019-05-02 18:00:00', 'TSSNDR96M04D704L', 'Andrea', 'Tassani', '0543728766', '3393536457', 'Cervese', '234', '47122', 'Forlì', 'Fattorino', NULL, 'AD679DRDJE', '7.00'),
		('P1', '2017-01-01 18:00:00', 'PZZVNI70M04D704R', 'Ivan', 'Pazzani', '0543790054', '3457892113', 'Frigido', '2', '47122', 'Forlì', 'Pizzaiolo', '1893300567', NULL, '10.00'),
		('C2', '2017-01-02 18:00:00', 'TRNSMN89M04D704O', 'Samanta', 'Troni', '0544896578', '3324578251', 'Secante', '6', '47122', 'Forlì', 'Cassiere', '0098776329', NULL, '7.00'),
		('F2', '2016-07-12 18:00:00', 'PRTLXA94M04D704U', 'Alex', 'Portici', '0543782323', '3394565213', 'Imolese', '34', '47122', 'Forlì', 'Fattorino', NULL, 'AR999RTYUG', '7.00'),
		('P2', '2017-09-09 18:00:00', 'GRFMRC95M04D704Y', 'Marco', 'Graffi', '0543768779', '3321456443', 'Regadi', '77', '47122', 'Forlì', 'Pizzaiolo', '7897895590', NULL, '10.00');

INSERT INTO `TESSERE` (`IDtessera`, `Numero_pizze`) 
VALUES	('0', '15'), ('1', '15'), ('2', '15'), ('3', '15'), ('4', '15'), 
		('5', '15'), ('6', '15'), ('7', '15'), ('8', '15'), ('9', '15');

INSERT INTO `CLIENTI` (`Codice_cliente`, `IDtessera`, `Nome`, `Cognome`, `Cellulare`, `Via`, `Civico`, `CAP`, `Citta`) 
VALUES 	('0', '0', 'Paolo', 'Neri', '3465748333', 'Morgagni', '9', '47121', 'Forlì'), ('1', '1', 'Giovanni', 'Rosi', '3473412567', 'Bagnoli', '4', '47121', 'Forlì'), 
		('2', '2', 'Lorenzo', 'Verdi', '3348907665', 'Ponti', '231', '47121', 'Forlì'), ('3', '3', 'Filippo', 'Bianchi', '3497065443', 'Romagna', '76', '47121', 'Forlì'), ('4', '4', 'Fabio', 'Rossi', '3312456877', 'Cervese', '50', '47121', 'Forlì');

INSERT INTO `PIZZE` (`CodiceListino`, `Nome`, `Prezzo`)
VALUES 	('1', 'alpina', '5.80'), ('2', 'biancaneve', '4.50'), ('3', 'bresaola', '6.80'), ('4', 'buongustaio', '6.60'), ('5', 'calzone', '6.00'), ('6', 'capricciosa', '6.50'), ('7', 'ciclista', '5.70'), ('8', 'diavola', '4.80'), ('9', 'formaggi', '5.60'),('10', 'funghi', '4.80'),
		('11', 'genuina', '5.50'), ('12', 'maialona', '6.60'), ('13', 'margherita', '3.80'), ('14', 'marinara', '3.30'), ('15', 'melanzane', '4.80'), ('16', 'napoli', '4.80'), ('17', 'parmigiana', '6.60'), ('18', 'porcini', '5.80'), ('19', 'wurstel', '4.80'), ('20', 'americana', '5.60');

INSERT INTO `TURNI` (`IdDipendente`, `Data`, `Ora_inizio`, `Ora_fine`)
VALUES 	('C1', '2019-06-01', '18:00:00', '21:30:00'), ('C2', '2019-06-04', '18:00:00', '21:30:00'), ('P1', '2019-06-14', '17:30:00', NULL),
		('P2', '2019-06-21', '17:30:00', '21:30:00'), ('F1', '2019-06-14', '18:00:00', NULL), ('F2', '2019-06-18', '18:00:00', '21:30:00'),
		('C1', '2019-06-11', '18:00:00', '21:30:00'), ('C1', '2019-06-14', '18:00:00', NULL), ('F1', '2019-06-28', '18:30:00', '21:30:00'),
		('F2', '2019-06-28', '18:30:00', '21:30:00');
       
INSERT INTO `PRODOTTI` (`ID_Prodotto`, `Descrizione`, `Tipo`) 
VALUES 	('0', 'pomodoro', 'materia prima'), ('1', 'mozzarella', 'materia prima'),
		('2', 'wurstel', 'materia prima'), ('3', 'patatine fritte', 'materia prima'), ('4', 'taleggio', 'materia prima'), 
		('5', 'zucchine', 'materia prima'), ('6', 'bresaola', 'materia prima'),('7', 'rucola', 'materia prima'), 
		('8', 'grana', 'materia prima'), ('9', 'olio tartufato', 'materia prima'), ('10', 'funghi trifolati', 'materia prima'),
		('11', 'salsiccia', 'materia prima'), ('12', 'gorgonzola', 'materia prima'), ('13', 'funghi freschi', 'materia prima'),
		('14', 'prosciutto cotto ', 'materia prima'), ('15', 'bufala', 'materia prima'), ('16', 'pomodorini', 'materia prima'),
		('17', 'origano', 'materia prima'), ('18', 'basilico', 'materia prima'), ('19', 'carciofi', 'materia prima'),
		('20', 'olive nere', 'materia prima'), ('21', 'asparagi', 'materia prima'), ('22', 'peperoni sott\'olio', 'materia prima'),
		('23', 'peperoni', 'materia prima'), ('24', 'fagioli', 'materia prima'), ('25', 'pancetta', 'materia prima'),
		('26', 'cipolla', 'materia prima'), ('27', 'panna', 'materia prima'), ('28', 'salame piccante', 'materia prima'),
		('29', 'prosciutto crudo', 'materia prima'), ('30', 'salame', 'materia prima'), ('31', 'pecorino', 'materia prima'),
		('32', 'austriaco', 'materia prima'), ('33', 'aceto balsamico', 'materia prima'), ('34', 'olio all\'aglio', 'materia prima'),
		('35', 'fricò', 'materia prima'), ('36', 'porcini', 'materia prima'), ('37', 'frutti di mare', 'materia prima'),
		('38', 'prezzemolo', 'materia prima'), ('39', 'pancetta affumicata', 'materia prima'), ('40', 'scamorza', 'materia prima'),
		('41', 'speck', 'materia prima'), ('42', 'gamberi', 'materia prima'), ('43', 'squacquerone', 'materia prima'),
		('44', 'melanzane', 'materia prima'), ('45', 'radicchio', 'materia prima'), ('46', 'acciughe', 'materia prima'),
		('47', 'capperi', 'materia prima'), ('48', 'mais', 'materia prima'), ('49', 'patate lesse', 'materia prima'),
		('50', 'zucca', 'materia prima'), ('51', 'olive', 'materia prima'), ('52', 'verdi', 'materia prima'),
		('53', 'pomodorini secchi', 'materia prima'), ('54', 'noci rosmarino', 'materia prima'), ('56', 'nutella', 'materia prima'),
		('57', 'tonno', 'materia prima'), ('58', 'spinaci', 'materia prima'), ('59', 'piselli', 'materia prima'),
		('60', 'sale', 'materia prima'), ('61', 'olio', 'materia prima'), ('62', 'lievito di birra', 'materia prima'),
		('63', 'acqua', 'materia prima'), ('64', 'farina 00', 'materia prima'), ('67', 'farina integrale ', 'materia prima'), 
		('68', 'farina kamut', 'materia prima'), ('69', 'farina 7 cereali', 'materia prima'),
		('70', 'farina curcuma', 'materia prima'), ('71', 'latte', 'materia prima'), ('72', 'acqua maturale', 'beverage'),
		('73', 'acqua frizzante', 'beverage'), ('74', 'coca cola', 'beverage'), ('75', 'coca cola zero', 'beverage'), ('76', 'fanta', 'beverage'),
		('77', 'sprite', 'beverage'), ('78', 'chinotto', 'beverage'), ('79', 'cedrata', 'beverage'), ('80', 'thè al limone', 'beverage'),
		('81', 'thè alla pesca', 'beverage'), ('82', 'ichnusa', 'beverage'),('83', 'poretti', 'beverage'), ('84', 'faxe', 'beverage'), 
		('85', 'erdinger', 'beverage'), ('86', 'guinness', 'beverage'), ('87', 'slalom', 'beverage'), ('88', 'moretti', 'beverage'),
		('89', 'nastro azzurro', 'beverage'), ('90', 'bestbrau', 'beverage'), ('91', 'scatole per pizze', 'packaging'),
		('92', 'coperchi per pizze', 'packaging'), ('93', 'portapizze termici', 'packaging'), ('94', 'tennent\'s', 'beverage');

INSERT INTO `IMPASTI` (`Codice`, `Descrizione`, `Costo`) 
VALUES 	('0', 'classico', '0'), ('1', 'kamut', '2'), ('2', '7 cereali', '2'),
		('3', 'lievitazione naturale', '1'), ('4', 'integrale', '1'), ('5', 'curcuma', '1');

insert into MATERIE_PRIME (IDMateriaPrima)
	SELECT PRODOTTI.ID_Prodotto
	FROM PRODOTTI
	WHERE PRODOTTI.Tipo = 'materia prima';

UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente per impasto' WHERE (`IDMateriaPrima` = '60');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente per impasto' WHERE (`IDMateriaPrima` = '61');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente per impasto' WHERE (`IDMateriaPrima` = '62');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente per impasto' WHERE (`IDMateriaPrima` = '63');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente per impasto' WHERE (`IDMateriaPrima` = '64');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente per impasto' WHERE (`IDMateriaPrima` = '67');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente per impasto' WHERE (`IDMateriaPrima` = '68');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente per impasto' WHERE (`IDMateriaPrima` = '69');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente per impasto' WHERE (`IDMateriaPrima` = '70');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente per impasto' WHERE (`IDMateriaPrima` = '71');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '59');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '0');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '1');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '2');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '3');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '4');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '5');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '6');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '7');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '8');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '9');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '10');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '11');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '12');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '13');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '14');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '15');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '16');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '17');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '18');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '19');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '20');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '21');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '22');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '23');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '24');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '25');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '26');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '27');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '28');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '29');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '30');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '31');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '32');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '33');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '34');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '35');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '36');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '37');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '38');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '39');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '40');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '41');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '42');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '43');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '44');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '45');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '46');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '47');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '48');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '49');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '50');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '51');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '52');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '53');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '54');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '56');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '57');
UPDATE `pizzeria_asporto`.`materie_prime` SET `Tipo` = 'ingrediente' WHERE (`IDMateriaPrima` = '58');

insert into BEVERAGE (IDBeverage)
	SELECT PRODOTTI.ID_Prodotto
	FROM PRODOTTI
	WHERE PRODOTTI.Tipo = 'beverage';
    
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '1.00' WHERE (`IDBeverage` = '72');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '1.00' WHERE (`IDBeverage` = '73');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '2.00' WHERE (`IDBeverage` = '74');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '2.00' WHERE (`IDBeverage` = '75');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '2.00' WHERE (`IDBeverage` = '76');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '3.00' WHERE (`IDBeverage` = '77');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '2.00' WHERE (`IDBeverage` = '78');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '2.00' WHERE (`IDBeverage` = '79');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '2.50' WHERE (`IDBeverage` = '80');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '2.50' WHERE (`IDBeverage` = '81');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '2.50' WHERE (`IDBeverage` = '82');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '2.00' WHERE (`IDBeverage` = '83');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '3.00' WHERE (`IDBeverage` = '84');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '5.00' WHERE (`IDBeverage` = '85');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '4.00' WHERE (`IDBeverage` = '86');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '3.50' WHERE (`IDBeverage` = '87');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '3.00' WHERE (`IDBeverage` = '88');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '3.00' WHERE (`IDBeverage` = '89');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '3.50' WHERE (`IDBeverage` = '90');
UPDATE `pizzeria_asporto`.`beverage` SET `Prezzo_di_vendita` = '3.00' WHERE (`IDBeverage` = '94');


insert into INGREDIENTI (IDIngrediente)
	SELECT MATERIE_PRIME.IDMateriaPrima
	FROM MATERIE_PRIME
	WHERE MATERIE_PRIME.Tipo = 'ingrediente';

UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '0.00' WHERE (`IDIngrediente` = '0');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '0.00' WHERE (`IDIngrediente` = '1');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '2');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '3');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '2.00' WHERE (`IDIngrediente` = '4');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '5');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '2.00' WHERE (`IDIngrediente` = '6');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '7');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '2.00' WHERE (`IDIngrediente` = '8');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '9');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '10');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '11');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '2.00' WHERE (`IDIngrediente` = '12');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '2.00' WHERE (`IDIngrediente` = '13');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '14');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '0.00' WHERE (`IDIngrediente` = '15');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '0.00' WHERE (`IDIngrediente` = '16');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '17');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '18');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '19');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '20');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '21');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '22');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '23');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '24');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '0.00' WHERE (`IDIngrediente` = '25');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '26');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '2.00' WHERE (`IDIngrediente` = '27');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '28');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.50' WHERE (`IDIngrediente` = '29');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '30');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '0.00' WHERE (`IDIngrediente` = '31');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '0.00' WHERE (`IDIngrediente` = '32');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '33');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '2.00' WHERE (`IDIngrediente` = '34');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '35');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '0.00' WHERE (`IDIngrediente` = '36');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '37');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '38');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '39');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.50' WHERE (`IDIngrediente` = '40');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '41');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '42');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '43');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '0.50' WHERE (`IDIngrediente` = '44');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '0.50' WHERE (`IDIngrediente` = '45');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '0.50' WHERE (`IDIngrediente` = '46');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.50' WHERE (`IDIngrediente` = '47');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.50' WHERE (`IDIngrediente` = '48');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '49');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '50');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.50' WHERE (`IDIngrediente` = '51');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '52');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '0.00' WHERE (`IDIngrediente` = '53');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '54');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '56');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '59');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.50' WHERE (`IDIngrediente` = '58');
UPDATE `pizzeria_asporto`.`ingredienti` SET `Costo_aggiunta` = '1.00' WHERE (`IDIngrediente` = '57');

INSERT INTO `FORNITORI` (`IdFornitore`, `Partita_IVA`, `Ragione_Sociale`, `Telefono`, `Via`, `Civico`, `CAP`, `Citta`) 
VALUES 		('F01', '01134567819', 'gardini', '0543967835', 'Prato Verde', '3', '47121', 'Forli'),
			('F02', '45619203672', 'arca spa', '0543985762', 'Via Virgilio', '30', '47122', 'Forli'),
			('F03', '23716403982', 'mordenti', '0543672456', 'Via Dante', '6', '47121', 'Forli');

INSERT INTO `pizzeria_asporto`.`fatture` (`Numero`,`Importo`, `Data_Emissione` , `Termine_di_pagamento`,`Pagato`,`IdFornitore`) 
VALUES		('1','197.60','2019-06-03 00:00:00', '2019-07-03 00:00:00','0','F01');

INSERT INTO `pizzeria_asporto`.`ordini_fornitori` (`ID_Ordine`, `Data`, `ImportoTotale`, `IdFornitore`)
VALUES 		('1', '2019-06-01', '89.60', 'F01');

INSERT INTO `pizzeria_asporto`.`dettagli_ordini` (`ID_Prodotto`, `ID_Ordine`, `Data`, `Riga`, `Descrizione`, `Quantita`, `Costo_unitario`, `Imponibile`, `Importo`, `Aliquota_IVA`)
VALUES 		('0', '1', '2019-06-01', '1', 'passata mutti', '70', '1.00', '70.00', '72.80', '2.80'),
			('1', '1', '2019-06-01', '2', 'mozzarella galbani', '2', '6.00', '12.00', '12.48', '0.48');
            
/*calcolo retribuzione dipendente per una data settimana*/
CREATE VIEW Totale_ore(IdDipendente,Cognome,Ore,Tariffa_oraria)
AS  SELECT D.IdDipendente, D.Cognome,
	CAST(SUM(T.Ora_fine-T.Ora_inizio) as time) as Ore, D.Tariffa_oraria
	FROM DIPENDENTI D, TURNI T
	WHERE D.IdDipendente=T.IdDipendente 
	AND T.Data BETWEEN '2019-06-01' AND '2019-06-07'
	GROUP BY T.IdDipendente, D.Cognome;
    
 SELECT t.Cognome, minute(t.Ore)/60*t.Tariffa_oraria+hour(t.Ore)*t.Tariffa_oraria as Retribuzione
 FROM Totale_ore as t, Dipendenti
 GROUP BY t.Cognome;
 
/*MATERIE PRIME*/
SELECT IDMateriaPrima,p.Descrizione,p.Tipo as TipoProdotto,m.tipo as TipoMateriaPrima
FROM pizzeria_asporto.materie_prime m, prodotti p
WHERE m.IDMateriaPrima=p.ID_Prodotto;

/*MATERIE PRIME CON ALLERGENI*/
SELECT a.Descrizione as Allergene, pr.Descrizione as MateriaPrima
FROM pizzeria_asporto.presenza_allergeni p, allergeni a, prodotti pr
WHERE a.Codice=p.CodiceAllergene and pr.ID_Prodotto=p.IDMateriaPrima;

/*per sapere INGREDIENTI PER CIASCUNA PIZZA*/
CREATE VIEW Ingredienti_pizze(Pizza,Ingrediente)
AS SELECT p.Nome, pr.Descrizione
FROM PIZZE p, FARCITURE f, INGREDIENTI i, PRODOTTI pr
WHERE p.CodiceListino=f.Codice_pizza and i.IDIngrediente=f.IDIngrediente 
	and pr.ID_prodotto=f.IDIngrediente 
GROUP BY p.CodiceListino, i.IDIngrediente;





