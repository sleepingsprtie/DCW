CREATE DATABASE  IF NOT EXISTS dcw /*!40100 DEFAULT CHARACTER SET utf8 */;
USE dcw;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: dcw
-- ------------------------------------------------------
-- Server version	5.5.21

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table beitraege
--

DROP TABLE IF EXISTS beitraege;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE beitraege (
  Bei_lfd int(11) NOT NULL AUTO_INCREMENT,
  Bei_Mgl int(11) DEFAULT '0',
  Bei_Betrag double DEFAULT '0',
  Bei_Datum datetime DEFAULT NULL,
  Bei_Beitragsjahr varchar(50) DEFAULT NULL,
  PRIMARY KEY (Bei_lfd),
  KEY DatenBeitraege (Bei_Mgl),
  CONSTRAINT DatenBeitraege FOREIGN KEY (Bei_Mgl) REFERENCES daten (Daten_Mitgliedsnummer)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table beitraege
--

LOCK TABLES beitraege WRITE;
/*!40000 ALTER TABLE beitraege DISABLE KEYS */;
/*!40000 ALTER TABLE beitraege ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table berliner
--

DROP TABLE IF EXISTS berliner;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE berliner (
  Nachname varchar(255) DEFAULT NULL,
  Vorname varchar(255) DEFAULT NULL,
  Organisationen varchar(255) DEFAULT NULL,
  Addy varchar(50) DEFAULT NULL,
  nenummer int(11) DEFAULT '0',
  KEY nenummer (nenummer)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table berliner
--

LOCK TABLES berliner WRITE;
/*!40000 ALTER TABLE berliner DISABLE KEYS */;
/*!40000 ALTER TABLE berliner ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table berliner_nummern
--

DROP TABLE IF EXISTS berliner_nummern;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE berliner_nummern (
  Addy varchar(255) DEFAULT NULL,
  nenummer double DEFAULT NULL,
  KEY nenummer (nenummer)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table berliner_nummern
--

LOCK TABLES berliner_nummern WRITE;
/*!40000 ALTER TABLE berliner_nummern DISABLE KEYS */;
/*!40000 ALTER TABLE berliner_nummern ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table branchen
--

DROP TABLE IF EXISTS branchen;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE branchen (
  Br_ID int(11) NOT NULL AUTO_INCREMENT,
  BR_Name varchar(255) DEFAULT NULL,
  PRIMARY KEY (Br_ID),
  KEY Br_ID (Br_ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table branchen
--

LOCK TABLES branchen WRITE;
/*!40000 ALTER TABLE branchen DISABLE KEYS */;
/*!40000 ALTER TABLE branchen ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table bundesland
--

DROP TABLE IF EXISTS bundesland;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE bundesland (
  BL_ID int(11) NOT NULL AUTO_INCREMENT,
  BL_Name varchar(255) DEFAULT NULL,
  PRIMARY KEY (BL_ID),
  KEY Br_ID (BL_ID)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table bundesland
--

LOCK TABLES bundesland WRITE;
/*!40000 ALTER TABLE bundesland DISABLE KEYS */;
/*!40000 ALTER TABLE bundesland ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table china_import_muetter_adressen
--

DROP TABLE IF EXISTS china_import_muetter_adressen;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE china_import_muetter_adressen (
  German Parent Company varchar(255) DEFAULT NULL,
  email_glatt varchar(255) DEFAULT NULL,
  German Telephone varchar(255) DEFAULT NULL,
  German City varchar(255) DEFAULT NULL,
  German Postal Code varchar(255) DEFAULT NULL,
  German Address varchar(255) DEFAULT NULL,
  German Facsimile varchar(255) DEFAULT NULL,
  German Website varchar(255) DEFAULT NULL,
  KEY German Postal Code (German Postal Code)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table china_import_muetter_adressen
--

LOCK TABLES china_import_muetter_adressen WRITE;
/*!40000 ALTER TABLE china_import_muetter_adressen DISABLE KEYS */;
/*!40000 ALTER TABLE china_import_muetter_adressen ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table china_import_töc_final
--

DROP TABLE IF EXISTS china_import_töc_final;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE china_import_töc_final (
  Company Name varchar(255) DEFAULT NULL,
  Company Name (zh) varchar(255) DEFAULT NULL,
  Telephone varchar(255) DEFAULT NULL,
  City varchar(255) DEFAULT NULL,
  City (zh) varchar(255) DEFAULT NULL,
  Street varchar(255) DEFAULT NULL,
  Street (zh) varchar(255) DEFAULT NULL,
  Postal Code double DEFAULT NULL,
  Fax varchar(255) DEFAULT NULL,
  Web varchar(255) DEFAULT NULL,
  Business Classification (NACE Rev2) varchar(255) DEFAULT NULL,
  Business Classification (NACE Rev2) (zh) varchar(255) DEFAULT NULL,
  Business Activities varchar(255) DEFAULT NULL,
  Business Activities (zh) varchar(255) DEFAULT NULL,
  Company Type varchar(255) DEFAULT NULL,
  German Parent Company varchar(255) DEFAULT NULL,
  1Fullname varchar(255) DEFAULT NULL,
  Feld20 varchar(255) DEFAULT NULL,
  1Title varchar(255) DEFAULT NULL,
  1Job Title varchar(255) DEFAULT NULL,
  1Email_rein varchar(255) DEFAULT NULL,
  1Telephone varchar(255) DEFAULT NULL,
  1Fax varchar(255) DEFAULT NULL,
  1Mobile Phone varchar(255) DEFAULT NULL,
  KEY Postal Code (Postal Code)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table china_import_töc_final
--

LOCK TABLES china_import_töc_final WRITE;
/*!40000 ALTER TABLE china_import_töc_final DISABLE KEYS */;
/*!40000 ALTER TABLE china_import_töc_final ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table china_toechtermails_import
--

DROP TABLE IF EXISTS china_toechtermails_import;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE china_toechtermails_import (
  Company Name varchar(255) DEFAULT NULL,
  Company Name (zh) varchar(255) DEFAULT NULL,
  Telephone varchar(255) DEFAULT NULL,
  City varchar(255) DEFAULT NULL,
  Street varchar(255) DEFAULT NULL,
  Street (zh) varchar(255) DEFAULT NULL,
  Postal Code double DEFAULT NULL,
  Fax varchar(255) DEFAULT NULL,
  Web varchar(255) DEFAULT NULL,
  Business Classification (NACE Rev2) varchar(255) DEFAULT NULL,
  Business Activities varchar(255) DEFAULT NULL,
  Company Type varchar(255) DEFAULT NULL,
  emails glatt varchar(255) DEFAULT NULL,
  Mutter_mail_rein varchar(255) DEFAULT NULL,
  KEY Postal Code (Postal Code)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table china_toechtermails_import
--

LOCK TABLES china_toechtermails_import WRITE;
/*!40000 ALTER TABLE china_toechtermails_import DISABLE KEYS */;
/*!40000 ALTER TABLE china_toechtermails_import ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table china_weitere_import
--

DROP TABLE IF EXISTS china_weitere_import;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE china_weitere_import (
  Company Name varchar(255) DEFAULT NULL,
  Company Name (zh) varchar(255) DEFAULT NULL,
  2Fullname varchar(255) DEFAULT NULL,
  2Title varchar(255) DEFAULT NULL,
  2Job Title varchar(255) DEFAULT NULL,
  2Email varchar(255) DEFAULT NULL,
  2Telephone varchar(255) DEFAULT NULL,
  2Mobile Phone varchar(255) DEFAULT NULL,
  2Fax varchar(255) DEFAULT NULL,
  mail_gleiche_ebene varchar(255) DEFAULT NULL,
  mail_mutter varchar(255) DEFAULT NULL,
  City varchar(255) DEFAULT NULL,
  Street varchar(255) DEFAULT NULL,
  Street (zh) varchar(255) DEFAULT NULL,
  Postal Code double DEFAULT NULL,
  Web varchar(255) DEFAULT NULL,
  Business Classification (NACE Rev2) varchar(255) DEFAULT NULL,
  Business Activities varchar(255) DEFAULT NULL,
  Company Type varchar(255) DEFAULT NULL,
  KEY Postal Code (Postal Code)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table china_weitere_import
--

LOCK TABLES china_weitere_import WRITE;
/*!40000 ALTER TABLE china_weitere_import DISABLE KEYS */;
/*!40000 ALTER TABLE china_weitere_import ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table clean_mails
--

DROP TABLE IF EXISTS clean_mails;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE clean_mails (
  Email varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table clean_mails
--

LOCK TABLES clean_mails WRITE;
/*!40000 ALTER TABLE clean_mails DISABLE KEYS */;
/*!40000 ALTER TABLE clean_mails ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table ct-beitraege
--

DROP TABLE IF EXISTS ct-beitraege;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE ct_beitraege (
  CT_lfd int(11) NOT NULL AUTO_INCREMENT,
  CT_Mgl int(11) DEFAULT '0',
  CT_Betrag double DEFAULT '0',
  CT_Datum datetime DEFAULT NULL,
  CT_Beitragsjahr varchar(50) DEFAULT NULL,
  PRIMARY KEY (CT_lfd),
  KEY DatenCT_Beitraege (CT_Mgl),
  CONSTRAINT DatenCT_Beitraege FOREIGN KEY (CT_Mgl) REFERENCES daten (Daten_Mitgliedsnummer)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table ct-beitraege
--

LOCK TABLES ct-beitraege WRITE;
/*!40000 ALTER TABLE ct-beitraege DISABLE KEYS */;
/*!40000 ALTER TABLE ct-beitraege ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table daten
--

DROP TABLE IF EXISTS daten;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE daten (
  Id int(11) NOT NULL AUTO_INCREMENT,
  Daten_Mitgliedsnummer int(11) NOT NULL DEFAULT '0',
  Daten_lfd int(11) DEFAULT NULL,
  Daten_Art_Datensatz varchar(50) DEFAULT NULL,
  Daten_Firmenmitglied tinyint(1) DEFAULT NULL,
  Daten_Firmafrei tinyint(1) DEFAULT NULL,
  Daten_Firmasonst tinyint(1) DEFAULT NULL,
  Daten_Tit_Vor_AP varchar(50) DEFAULT NULL,
  Daten_Tit_Vor_AP_CN varchar(45) DEFAULT NULL,
  Daten_Nachname varchar(50) DEFAULT NULL,
  Daten_Nachname_CN varchar(45) DEFAULT NULL,
  Daten_Pos_Abt varchar(50) DEFAULT NULL,
  Daten_Pos_Abt_CN varchar(45) DEFAULT NULL,
  Daten_Firma1 varchar(50) DEFAULT NULL,
  Daten_Firma2 varchar(50) DEFAULT NULL,
  Daten_Firma_chin varchar(255) DEFAULT NULL,
  Daten_Strasse varchar(255) DEFAULT NULL,
  Daten_Strasse_CN varchar(45) DEFAULT NULL,
  Daten_Strasse2 varchar(255) DEFAULT NULL,
  Daten_PLZ varchar(6) DEFAULT NULL,
  Daten_PLZ_CN varchar(45) DEFAULT NULL,
  Daten_Ort varchar(50) DEFAULT NULL,
  Daten_Ort_CN varchar(45) DEFAULT NULL,
  Daten_Land varchar(50) DEFAULT NULL,
  Daten_Land_CN varchar(45) DEFAULT NULL,
  Daten_Bundesland varchar(50) DEFAULT NULL,
  Daten_Telefon varchar(50) DEFAULT NULL,
  Daten_Telefon_CN varchar(45) DEFAULT NULL,
  Daten_Handy varchar(50) DEFAULT NULL,
  Daten_Handy_CN varchar(45) DEFAULT NULL,
  Daten_Fax varchar(50) DEFAULT NULL,
  Daten_Fax_CN varchar(45) DEFAULT NULL,
  Daten_Briefanrede varchar(50) DEFAULT NULL,
  Daten_Briefanrede_CN varchar(45) DEFAULT NULL,
  Daten_Email varchar(100) DEFAULT NULL,
  Daten_Internet varchar(255) DEFAULT NULL,
  Daten_Geschlecht varchar(50) DEFAULT NULL,
  Daten_Login varchar(50) DEFAULT NULL,
  Daten_Passwort varchar(50) DEFAULT NULL,
  Daten_Matchcode varchar(50) DEFAULT NULL,
  Daten_Beitrittsdatum datetime DEFAULT NULL,
  Daten_Kuendigung datetime DEFAULT NULL,
  Daten_Ktonummer varchar(50) DEFAULT NULL,
  Daten_BLZ varchar(50) DEFAULT NULL,
  Daten_Bank varchar(50) DEFAULT NULL,
  Daten_Konto_Inhaber varchar(50) DEFAULT NULL,
  Daten_Jahresbeitrag double DEFAULT '0',
  Daten_vorherweniger double DEFAULT '0',
  Daten_Zahlungsweise varchar(50) DEFAULT NULL,
  Daten_Zahlungsart varchar(50) DEFAULT NULL,
  Daten_Beitrag_Ausgesetzt datetime DEFAULT NULL,
  Daten_Total_Offen double DEFAULT '0',
  Daten_Letzt_Zahl datetime DEFAULT NULL,
  Daten_Mitgliedsbeitrag_Gueltig varchar(50) DEFAULT NULL,
  Daten_Umlage1 double DEFAULT '0',
  Daten_Umlage2 double DEFAULT '0',
  Daten_Umlage3 double DEFAULT '0',
  Daten_Umlage4 double DEFAULT '0',
  Daten_Imlage5 double DEFAULT '0',
  Daten_CT varchar(50) DEFAULT NULL,
  Daten_CT_Menge smallint(6) DEFAULT '0',
  Daten_CT_versendet tinyint(1) DEFAULT '0',
  Daten_CT_Preis double DEFAULT '0',
  Daten_CT_Abo_seit datetime DEFAULT NULL,
  Daten_CT_Gueltig varchar(50) DEFAULT NULL,
  Daten_Bemerkungen longtext,
  Daten_Produkte longtext,
  Daten_InChina longtext,
  Daten_Firmenhandbuch tinyint(1) DEFAULT NULL,
  Daten_Branchencode varchar(50) DEFAULT NULL,
  f_dst_grp int(11) DEFAULT NULL,
  f_prod_branche int(11) DEFAULT NULL,
  Daten_Angelegt datetime DEFAULT NULL,
  Daten_Funktion varchar(50) DEFAULT NULL,
  Daten_Akt tinyint(1) DEFAULT NULL,
  Daten_Hinweis varchar(50) DEFAULT NULL,
  Daten_zuordnungMG varchar(50) DEFAULT NULL,
  f_lfd int(11) DEFAULT NULL,
  f_lfd_gleich int(11) DEFAULT NULL,
  fb_kontakt_email varchar(50) DEFAULT NULL,
  fb_kleinst double DEFAULT '0',
  fb_klein double DEFAULT '0',
  fb_mittel double DEFAULT '0',
  fb_gross double DEFAULT '0',
  fb_kleinst_cn double DEFAULT '0',
  fb_klein_cn double DEFAULT '0',
  fb_mittel_cn double DEFAULT '0',
  fb_gross_cn double DEFAULT '0',
  fb_referenz_web tinyint(1) DEFAULT '0',
  fb_referenz_anfrage tinyint(1) DEFAULT '0',
  fb_jahr_china smallint(6) DEFAULT '0',
  fb_jahr_deutschland smallint(6) DEFAULT '0',
  fb_mitarbeiter_weltweit int(11) DEFAULT '0',
  fb_mitarbeiter_deutschland int(11) DEFAULT '0',
  fb_mitarbeiter_china int(11) DEFAULT '0',
  fb_mitarbeiter_locals int(11) DEFAULT '0',
  fb_anteil_china double DEFAULT '0',
  fb_anteil_deutschland double DEFAULT '0',
  fb_dcw_vortraege tinyint(1) DEFAULT '0',
  fb_dcw_publikationen tinyint(1) DEFAULT '0',
  fb_dcw_studien tinyint(1) DEFAULT '0',
  fb_dcw_foren tinyint(1) DEFAULT '0',
  fb_dcw_beitraege tinyint(1) DEFAULT '0',
  fb_dcw_erstberatung tinyint(1) DEFAULT '0',
  rm_ct tinyint(1) DEFAULT '0',
  rm_dt tinyint(1) DEFAULT '0',
  rm_vd tinyint(1) DEFAULT '0',
  rm_vc tinyint(1) DEFAULT '0',
  rm_sc tinyint(1) DEFAULT '0',
  rm_sd tinyint(1) DEFAULT '0',
  rm_dz tinyint(1) DEFAULT '0',
  PRIMARY KEY (Id),
  UNIQUE KEY Daten_Mitgliedsnummer (Daten_Mitgliedsnummer),
  UNIQUE KEY Daten_Email (Daten_Email),
  UNIQUE KEY fb_kontakt_email (fb_kontakt_email),
  KEY Daten_Branchencode (Daten_Branchencode),
  KEY Daten_Ktonummer (Daten_Ktonummer),
  KEY Daten_Matchcode (Daten_Matchcode),
  KEY Datenf_lfd (f_lfd),
  KEY Datenf_lfd_gleich (f_lfd_gleich)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table daten
--

LOCK TABLES daten WRITE;
/*!40000 ALTER TABLE daten DISABLE KEYS */;
INSERT INTO daten VALUES (1,1,NULL,NULL,0,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'asdfa11111',NULL,NULL,NULL,NULL,'asdfa',NULL,NULL,NULL,NULL,NULL,'zCa@asdf1.de',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,0,NULL,NULL,0,0,0,0,0,NULL,0,0,0,NULL,NULL,NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,0),(2,12297,NULL,NULL,0,1,0,'Hugo',NULL,'Kube',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'Sehr geehrter Herr Kube',NULL,'h.j.kube@t-online.de',NULL,'Herr',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,0,NULL,NULL,0,0,0,0,0,NULL,NULL,1,0,NULL,NULL,NULL,NULL,NULL,0,NULL,NULL,NULL,NULL,NULL,0,'aeae',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,0,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,0,0,0,0,0,1,1,1,1,1,1,0);
/*!40000 ALTER TABLE daten ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table daten_exportfehler
--

DROP TABLE IF EXISTS daten_exportfehler;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE daten_exportfehler (
  Fehler varchar(255) DEFAULT NULL,
  Feld varchar(255) DEFAULT NULL,
  Zeile int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table daten_exportfehler
--

LOCK TABLES daten_exportfehler WRITE;
/*!40000 ALTER TABLE daten_exportfehler DISABLE KEYS */;
INSERT INTO daten_exportfehler VALUES ('Datum außerhalb Bereich','Daten_Angelegt',5643),('Datum außerhalb Bereich','Daten_Angelegt',5643);
/*!40000 ALTER TABLE daten_exportfehler ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table daten_sicherheitskopie
--

DROP TABLE IF EXISTS daten_sicherheitskopie;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE daten_sicherheitskopie (
  Daten_lfd int(11) NOT NULL AUTO_INCREMENT,
  Daten_Art_Datensatz varchar(50) DEFAULT NULL,
  Daten_Firmenmitglied tinyint(1) DEFAULT NULL,
  Daten_Firmafrei tinyint(1) DEFAULT NULL,
  Daten_Firmasonst tinyint(1) DEFAULT NULL,
  Daten_Mitgliedsnummer varchar(50) DEFAULT NULL,
  Daten_Tit_Vor_AP varchar(50) DEFAULT NULL,
  Daten_Nachname varchar(50) DEFAULT NULL,
  Daten_Pos_Abt varchar(50) DEFAULT NULL,
  Daten_Firma1 varchar(50) DEFAULT NULL,
  Daten_Firma2 varchar(50) DEFAULT NULL,
  Daten_Strasse varchar(255) DEFAULT NULL,
  Daten_Strasse2 varchar(255) DEFAULT NULL,
  Daten_PLZ varchar(50) DEFAULT NULL,
  Daten_Ort varchar(50) DEFAULT NULL,
  Daten_Land varchar(50) DEFAULT NULL,
  Daten_Bundesland varchar(50) DEFAULT NULL,
  Daten_Telefon varchar(50) DEFAULT NULL,
  Daten_Handy varchar(50) DEFAULT NULL,
  Daten_Fax varchar(50) DEFAULT NULL,
  Daten_Briefanrede varchar(50) DEFAULT NULL,
  Daten_Email varchar(100) DEFAULT NULL,
  Daten_Internet varchar(50) DEFAULT NULL,
  Daten_Geschlecht varchar(50) DEFAULT NULL,
  Daten_Login varchar(50) DEFAULT NULL,
  Daten_Passwort varchar(50) DEFAULT NULL,
  Daten_Matchcode varchar(50) DEFAULT NULL,
  Daten_Beitrittsdatum datetime DEFAULT NULL,
  Daten_Kündigung datetime DEFAULT NULL,
  Daten_Ktonummer varchar(50) DEFAULT NULL,
  Daten_BLZ varchar(50) DEFAULT NULL,
  Daten_Bank varchar(50) DEFAULT NULL,
  Daten_Konto_Inhaber varchar(50) DEFAULT NULL,
  Daten_Jahresbeitrag double DEFAULT '0',
  Daten_vorherweniger double DEFAULT '0',
  Daten_Zahlungsweise varchar(50) DEFAULT NULL,
  Daten_Zahlungsart varchar(50) DEFAULT NULL,
  Daten_Beitrag_Ausgesetzt datetime DEFAULT NULL,
  Daten_Total_Offen double DEFAULT '0',
  Daten_Letzt_Zahl datetime DEFAULT NULL,
  Daten_Mitgliedsbeitrag_Gültig varchar(50) DEFAULT NULL,
  Daten_Umlage1 double DEFAULT '0',
  Daten_Umlage2 double DEFAULT '0',
  Daten_Umlage3 double DEFAULT '0',
  Daten_Umlage4 double DEFAULT '0',
  Daten_Imlage5 double DEFAULT '0',
  Daten_CT varchar(50) DEFAULT NULL,
  Daten_CT_Preis double DEFAULT '0',
  Daten_CT_Abo_seit datetime DEFAULT NULL,
  Daten_CT_Gültig varchar(50) DEFAULT NULL,
  Daten_Bemerkungen longtext,
  Daten_Produkte longtext,
  Daten_InChina longtext,
  Daten_Firmenhandbuch tinyint(1) DEFAULT NULL,
  Daten_Branchencode varchar(50) DEFAULT NULL,
  Daten_Angelegt datetime DEFAULT NULL,
  Daten_Funktion varchar(50) DEFAULT NULL,
  Daten_Akt tinyint(1) DEFAULT NULL,
  Daten_Hinweis varchar(50) DEFAULT NULL,
  Daten_zuordnungMG varchar(50) DEFAULT NULL,
  PRIMARY KEY (Daten_lfd),
  KEY Daten_Branchencode (Daten_Branchencode),
  KEY Daten_Ktonummer (Daten_Ktonummer),
  KEY Daten_Matchcode (Daten_Matchcode),
  KEY Daten_Mitgliedsnummer (Daten_Mitgliedsnummer)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table daten_sicherheitskopie
--

LOCK TABLES daten_sicherheitskopie WRITE;
/*!40000 ALTER TABLE daten_sicherheitskopie DISABLE KEYS */;
/*!40000 ALTER TABLE daten_sicherheitskopie ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table dokumente
--

DROP TABLE IF EXISTS dokumente;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE dokumente (
  Dok_lfd int(11) NOT NULL AUTO_INCREMENT,
  Dok_Bezeichnung varchar(50) DEFAULT NULL,
  Dok_Name varchar(50) DEFAULT NULL,
  PRIMARY KEY (Dok_lfd)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table dokumente
--

LOCK TABLES dokumente WRITE;
/*!40000 ALTER TABLE dokumente DISABLE KEYS */;
INSERT INTO dokumente VALUES (14,'Brief',NULL),(15,'Rechnung',NULL);
/*!40000 ALTER TABLE dokumente ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table einfügefehler_010414
--

DROP TABLE IF EXISTS einfügefehler_010414;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE einfügefehler_010414 (
  Daten_Mitgliedsnummer int(11) DEFAULT NULL,
  Daten_lfd int(11) DEFAULT NULL,
  Daten_Art_Datensatz varchar(255) DEFAULT NULL,
  Daten_Firmenmitglied tinyint(1) DEFAULT NULL,
  Daten_Firmafrei tinyint(1) DEFAULT NULL,
  Daten_Firmasonst tinyint(1) DEFAULT NULL,
  Daten_Tit_Vor_AP varchar(255) DEFAULT NULL,
  Daten_Nachname varchar(255) DEFAULT NULL,
  Daten_Pos_Abt varchar(255) DEFAULT NULL,
  Daten_Firma1 varchar(255) DEFAULT NULL,
  Daten_Firma2 varchar(255) DEFAULT NULL,
  Daten_Firma_chin varchar(255) DEFAULT NULL,
  Daten_Strasse varchar(255) DEFAULT NULL,
  Daten_Strasse2 varchar(255) DEFAULT NULL,
  Daten_PLZ varchar(255) DEFAULT NULL,
  Daten_Ort varchar(255) DEFAULT NULL,
  Daten_Land varchar(255) DEFAULT NULL,
  Daten_Bundesland varchar(255) DEFAULT NULL,
  Daten_Telefon varchar(255) DEFAULT NULL,
  Daten_Handy varchar(255) DEFAULT NULL,
  Daten_Fax varchar(255) DEFAULT NULL,
  Daten_Briefanrede varchar(255) DEFAULT NULL,
  Daten_Email varchar(255) DEFAULT NULL,
  Daten_Internet varchar(255) DEFAULT NULL,
  Daten_Geschlecht varchar(255) DEFAULT NULL,
  Daten_Login varchar(255) DEFAULT NULL,
  Daten_Passwort varchar(255) DEFAULT NULL,
  Daten_Matchcode varchar(255) DEFAULT NULL,
  Daten_Beitrittsdatum datetime DEFAULT NULL,
  Daten_Kündigung datetime DEFAULT NULL,
  Daten_Ktonummer varchar(255) DEFAULT NULL,
  Daten_BLZ varchar(255) DEFAULT NULL,
  Daten_Bank varchar(255) DEFAULT NULL,
  Daten_Konto_Inhaber varchar(255) DEFAULT NULL,
  Daten_Jahresbeitrag double DEFAULT NULL,
  Daten_vorherweniger double DEFAULT NULL,
  Daten_Zahlungsweise varchar(255) DEFAULT NULL,
  Daten_Zahlungsart varchar(255) DEFAULT NULL,
  Daten_Beitrag_Ausgesetzt datetime DEFAULT NULL,
  Daten_Total_Offen double DEFAULT NULL,
  Daten_Letzt_Zahl datetime DEFAULT NULL,
  Daten_Mitgliedsbeitrag_Gültig varchar(255) DEFAULT NULL,
  Daten_Umlage1 double DEFAULT NULL,
  Daten_Umlage2 double DEFAULT NULL,
  Daten_Umlage3 double DEFAULT NULL,
  Daten_Umlage4 double DEFAULT NULL,
  Daten_Imlage5 double DEFAULT NULL,
  Daten_CT varchar(255) DEFAULT NULL,
  Daten_CT_Menge smallint(6) DEFAULT NULL,
  Daten_CT_versendet tinyint(1) DEFAULT NULL,
  Daten_CT_Preis double DEFAULT NULL,
  Daten_CT_Abo_seit datetime DEFAULT NULL,
  Daten_CT_Gültig varchar(255) DEFAULT NULL,
  Daten_Bemerkungen longtext,
  Daten_Produkte longtext,
  Daten_InChina longtext,
  Daten_Firmenhandbuch tinyint(1) DEFAULT NULL,
  Daten_Branchencode varchar(255) DEFAULT NULL,
  f_dst_grp varchar(255) DEFAULT NULL,
  f_prod_branche varchar(255) DEFAULT NULL,
  Daten_Angelegt datetime DEFAULT NULL,
  Daten_Funktion varchar(255) DEFAULT NULL,
  Daten_Akt tinyint(1) DEFAULT NULL,
  Daten_Hinweis varchar(255) DEFAULT NULL,
  Daten_zuordnungMG varchar(255) DEFAULT NULL,
  f_lfd int(11) DEFAULT NULL,
  f_lfd_gleich int(11) DEFAULT NULL,
  fb_kontakt_email varchar(255) DEFAULT NULL,
  fb_kleinst double DEFAULT NULL,
  fb_klein double DEFAULT NULL,
  fb_mittel double DEFAULT NULL,
  fb_gross double DEFAULT NULL,
  fb_kleinst_cn double DEFAULT NULL,
  fb_klein_cn double DEFAULT NULL,
  fb_mittel_cn double DEFAULT NULL,
  fb_gross_cn double DEFAULT NULL,
  fb_referenz_web tinyint(1) DEFAULT NULL,
  fb_referenz_anfrage tinyint(1) DEFAULT NULL,
  fb_jahr_china smallint(6) DEFAULT NULL,
  fb_jahr_deutschland smallint(6) DEFAULT NULL,
  fb_mitarbeiter_weltweit int(11) DEFAULT NULL,
  fb_mitarbeiter_deutschland int(11) DEFAULT NULL,
  fb_mitarbeiter_china int(11) DEFAULT NULL,
  fb_mitarbeiter_locals int(11) DEFAULT NULL,
  fb_anteil_china double DEFAULT NULL,
  fb_anteil_deutschland double DEFAULT NULL,
  fb_dcw_vortraege tinyint(1) DEFAULT NULL,
  fb_dcw_publikationen tinyint(1) DEFAULT NULL,
  fb_dcw_studien tinyint(1) DEFAULT NULL,
  fb_dcw_foren tinyint(1) DEFAULT NULL,
  fb_dcw_beitraege tinyint(1) DEFAULT NULL,
  fb_dcw_erstberatung tinyint(1) DEFAULT NULL,
  rm_ct tinyint(1) DEFAULT NULL,
  rm_dt tinyint(1) DEFAULT NULL,
  rm_vd tinyint(1) DEFAULT NULL,
  rm_vc tinyint(1) DEFAULT NULL,
  rm_sc tinyint(1) DEFAULT NULL,
  rm_sd tinyint(1) DEFAULT NULL,
  rm_dz tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table einfügefehler_010414
--

LOCK TABLES einfügefehler_010414 WRITE;
/*!40000 ALTER TABLE einfügefehler_010414 DISABLE KEYS */;
/*!40000 ALTER TABLE einfügefehler_010414 ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table falschemail
--

DROP TABLE IF EXISTS falschemail;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE falschemail (
  fm_Vorname varchar(50) DEFAULT NULL,
  fm_Nachname varchar(50) DEFAULT NULL,
  fm_Firma1 varchar(50) DEFAULT NULL,
  fm_Firma2 varchar(50) DEFAULT NULL,
  fm_Strasse varchar(50) DEFAULT NULL,
  fm_PLZ varchar(50) DEFAULT NULL,
  fm_Ort varchar(50) DEFAULT NULL,
  fm_Briefanrede varchar(50) DEFAULT NULL,
  fm_Nummer varchar(50) DEFAULT NULL,
  fm_lfd int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (fm_lfd),
  KEY fm_Nummer (fm_Nummer)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table falschemail
--

LOCK TABLES falschemail WRITE;
/*!40000 ALTER TABLE falschemail DISABLE KEYS */;
/*!40000 ALTER TABLE falschemail ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table gute_mails
--

DROP TABLE IF EXISTS gute_mails;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE gute_mails (
  Daten_lfd double DEFAULT NULL,
  clean_mails varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table gute_mails
--

LOCK TABLES gute_mails WRITE;
/*!40000 ALTER TABLE gute_mails DISABLE KEYS */;
/*!40000 ALTER TABLE gute_mails ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table hong
--

DROP TABLE IF EXISTS hong;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE hong (
  HONG_lfd int(11) NOT NULL AUTO_INCREMENT,
  HONG_MG int(11) DEFAULT '0',
  HONG_KeinAnschluss varchar(50) DEFAULT NULL,
  HONG_PLZ varchar(50) DEFAULT NULL,
  HONG_Status varchar(50) DEFAULT NULL,
  PRIMARY KEY (HONG_lfd)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table hong
--

LOCK TABLES hong WRITE;
/*!40000 ALTER TABLE hong DISABLE KEYS */;
/*!40000 ALTER TABLE hong ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table jahresbericht_berater
--

DROP TABLE IF EXISTS jahresbericht_berater;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE jahresbericht_berater (
  Daten_lfd int(11) NOT NULL AUTO_INCREMENT,
  Daten_Firma1 varchar(50) DEFAULT NULL,
  Daten_Firma2 varchar(50) DEFAULT NULL,
  Daten_Briefanrede varchar(50) DEFAULT NULL,
  Daten_Email varchar(100) DEFAULT NULL,
  jahresbericht tinyint(1) DEFAULT NULL,
  PRIMARY KEY (Daten_lfd)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table jahresbericht_berater
--

LOCK TABLES jahresbericht_berater WRITE;
/*!40000 ALTER TABLE jahresbericht_berater DISABLE KEYS */;
/*!40000 ALTER TABLE jahresbericht_berater ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table ji
--

DROP TABLE IF EXISTS ji;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE ji (
  Ji_lfd int(11) NOT NULL AUTO_INCREMENT,
  Ji_MG int(11) DEFAULT '0',
  Ji_PLZ varchar(50) DEFAULT NULL,
  Ji_Status varchar(50) DEFAULT NULL,
  PRIMARY KEY (Ji_lfd)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table ji
--

LOCK TABLES ji WRITE;
/*!40000 ALTER TABLE ji DISABLE KEYS */;
/*!40000 ALTER TABLE ji ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table jobs
--

DROP TABLE IF EXISTS jobs;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE jobs (
  Joblfd int(11) NOT NULL AUTO_INCREMENT,
  Job_Schlagwort varchar(255) DEFAULT NULL,
  Job_Berufserfahrung varchar(255) DEFAULT NULL,
  Job_Sprachen varchar(255) DEFAULT NULL,
  Job_sonstigeKenntnisse varchar(255) DEFAULT NULL,
  Job_Taetigkeit varchar(255) DEFAULT NULL,
  Job_Standort varchar(255) DEFAULT NULL,
  Job_Eintrittsdatum varchar(255) DEFAULT NULL,
  Job_Gesuch tinyint(1) DEFAULT NULL,
  Job_Kontakt varchar(255) DEFAULT NULL,
  Job_EMail varchar(255) DEFAULT NULL,
  Job_Firma varchar(255) DEFAULT NULL,
  Job_Strasse varchar(255) DEFAULT NULL,
  Job_Ort varchar(255) DEFAULT NULL,
  Job_Studium varchar(255) DEFAULT NULL,
  Job_Tel varchar(50) DEFAULT NULL,
  Job_Fax varchar(50) DEFAULT NULL,
  Job_Erstellungsdatum datetime DEFAULT NULL,
  Job_gültig datetime DEFAULT NULL,
  PRIMARY KEY (Joblfd)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table jobs
--

LOCK TABLES jobs WRITE;
/*!40000 ALTER TABLE jobs DISABLE KEYS */;
/*!40000 ALTER TABLE jobs ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table lauf
--

DROP TABLE IF EXISTS lauf;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE lauf (
  Lauf_lfd int(11) NOT NULL AUTO_INCREMENT,
  Lauf_Datum datetime DEFAULT NULL,
  Lauf_versandt tinyint(1) DEFAULT NULL,
  PRIMARY KEY (Lauf_lfd)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table lauf
--

LOCK TABLES lauf WRITE;
/*!40000 ALTER TABLE lauf DISABLE KEYS */;
/*!40000 ALTER TABLE lauf ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table material
--

DROP TABLE IF EXISTS material;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE material (
  Mat_lfd int(11) NOT NULL AUTO_INCREMENT,
  Mat_Mitgliedsnummer varchar(50) DEFAULT NULL,
  Mat_Bezeichnung varchar(50) DEFAULT NULL,
  Mat_CT tinyint(1) DEFAULT NULL,
  Mat_Datum datetime DEFAULT NULL,
  Mat_Gebühr double DEFAULT '0',
  Mat_Mwst double DEFAULT '0',
  Mat_Gesamtbetrag double DEFAULT '0',
  Mat_Bezahlt_am datetime DEFAULT NULL,
  PRIMARY KEY (Mat_lfd),
  KEY Mat_Mitgliedsnummer (Mat_Mitgliedsnummer)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table material
--

LOCK TABLES material WRITE;
/*!40000 ALTER TABLE material DISABLE KEYS */;
/*!40000 ALTER TABLE material ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table mitglieder_rundmail_verteiler
--

DROP TABLE IF EXISTS mitglieder_rundmail_verteiler;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE mitglieder_rundmail_verteiler (
  Email2 varchar(255) DEFAULT NULL,
  Daten_Briefanrede varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table mitglieder_rundmail_verteiler
--

LOCK TABLES mitglieder_rundmail_verteiler WRITE;
/*!40000 ALTER TABLE mitglieder_rundmail_verteiler DISABLE KEYS */;
/*!40000 ALTER TABLE mitglieder_rundmail_verteiler ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table msyscompacterror
--

DROP TABLE IF EXISTS msyscompacterror;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE msyscompacterror (
  ErrorCode int(11) DEFAULT NULL,
  ErrorDescription longtext,
  ErrorRecid tinyblob,
  ErrorTable varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table msyscompacterror
--

LOCK TABLES msyscompacterror WRITE;
/*!40000 ALTER TABLE msyscompacterror DISABLE KEYS */;
/*!40000 ALTER TABLE msyscompacterror ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table pressesprecher_oder
--

DROP TABLE IF EXISTS pressesprecher_oder;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE pressesprecher_oder (
  Mini_nummi double DEFAULT NULL,
  Firma varchar(255) DEFAULT NULL,
  Kontaktperson varchar(255) DEFAULT NULL,
  Nachnamen varchar(255) DEFAULT NULL,
  Geschlecht varchar(255) DEFAULT NULL,
  Email varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table pressesprecher_oder
--

LOCK TABLES pressesprecher_oder WRITE;
/*!40000 ALTER TABLE pressesprecher_oder DISABLE KEYS */;
/*!40000 ALTER TABLE pressesprecher_oder ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table q_daten_lfd_mitglied_no
--

DROP TABLE IF EXISTS q_daten_lfd_mitglied_no;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE q_daten_lfd_mitglied_no (
  Daten_lfd double DEFAULT NULL,
  Daten_Mitgliedsnummer varchar(255) DEFAULT NULL,
  KEY Daten_Mitgliedsnummer (Daten_Mitgliedsnummer)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table q_daten_lfd_mitglied_no
--

LOCK TABLES q_daten_lfd_mitglied_no WRITE;
/*!40000 ALTER TABLE q_daten_lfd_mitglied_no DISABLE KEYS */;
/*!40000 ALTER TABLE q_daten_lfd_mitglied_no ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table rechnungenct
--

DROP TABLE IF EXISTS rechnungenct;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE rechnungenct (
  RCT_lfd int(11) NOT NULL AUTO_INCREMENT,
  RCT_Jahr int(11) DEFAULT '0',
  RCT_Datum datetime DEFAULT NULL,
  PRIMARY KEY (RCT_lfd)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table rechnungenct
--

LOCK TABLES rechnungenct WRITE;
/*!40000 ALTER TABLE rechnungenct DISABLE KEYS */;
INSERT INTO rechnungenct VALUES (1,2005,'2002-12-30 00:00:00');
/*!40000 ALTER TABLE rechnungenct ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table rechnungenmgb
--

DROP TABLE IF EXISTS rechnungenmgb;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE rechnungenmgb (
  RMGB_lfd int(11) NOT NULL AUTO_INCREMENT,
  RMGB_Jahr int(11) DEFAULT '0',
  RMGB_Datum datetime DEFAULT NULL,
  PRIMARY KEY (RMGB_lfd)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table rechnungenmgb
--

LOCK TABLES rechnungenmgb WRITE;
/*!40000 ALTER TABLE rechnungenmgb DISABLE KEYS */;
INSERT INTO rechnungenmgb VALUES (1,2003,'2003-04-22 00:00:00');
/*!40000 ALTER TABLE rechnungenmgb ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_branchen
--

DROP TABLE IF EXISTS t_branchen;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_branchen (
  branchen_id int(11) NOT NULL AUTO_INCREMENT,
  branchen varchar(50) DEFAULT NULL,
  PRIMARY KEY (branchen_id),
  UNIQUE KEY branchen (branchen),
  KEY branchen_id (branchen_id)
) ENGINE=InnoDB AUTO_INCREMENT=138 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_branchen
--

LOCK TABLES t_branchen WRITE;
/*!40000 ALTER TABLE t_branchen DISABLE KEYS */;
INSERT INTO t_branchen VALUES (106,'Abfallents./Beseitigung v. Umweltverschmutzungen'),(107,'Automobilindustrie'),(108,'Bauwirtschaft, Baustoffindustrie'),(104,'Bildung und Wissenschaft'),(105,'Chemie und Kunststoffe'),(109,'Druckindustrie und Papiererzeugung'),(110,'Elektroindustrie'),(111,'Energiewirtschaft: Kohle, Öl, Gas, Atom'),(112,'Erneuerbare Energien'),(113,'Finanzdienstleistung und Versicherung'),(114,'Gesundheitswesen und Medizintechnik'),(115,'Glasindustrie'),(116,'Holz- und Forstwirtschaft'),(117,'Immobilienservice'),(118,'Kommunikations- und Informationstechnologie'),(119,'Konsumgüter'),(120,'Kunst und Unterhaltung'),(121,'Landwirtschaft'),(122,'Lebensmittelindustrie'),(123,'Maschinen- und Anlagenbau'),(124,'Medien und Werbung'),(125,'Messewesen'),(126,'Metallindustrie'),(127,'Öffentliche Verwaltung'),(128,'Pharmaindustrie'),(129,'Rohstoffgewinnung'),(135,'Sonstige'),(130,'Tourismus'),(131,'Transport und Logistik'),(132,'Verkehrsinfrastruktur'),(133,'Wasserversorgung und Abwasserentsorgung'),(134,'Werkzeugindustrie'),(136,'_Persönliches Mitglied'),(137,'_Verbaende und Einrichtungen');
/*!40000 ALTER TABLE t_branchen ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_daten_export
--

DROP TABLE IF EXISTS t_daten_export;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_daten_export (
  Daten_Email varchar(100) DEFAULT NULL,
  email2 varchar(255) DEFAULT NULL,
  Name varchar(255) DEFAULT NULL,
  Daten_Tit_Vor_AP varchar(50) DEFAULT NULL,
  Daten_Nachname varchar(50) DEFAULT NULL,
  Daten_Pos_Abt varchar(50) DEFAULT NULL,
  Daten_Firma1 varchar(50) DEFAULT NULL,
  Daten_Strasse varchar(255) DEFAULT NULL,
  Daten_PLZ varchar(50) DEFAULT NULL,
  Daten_Ort varchar(50) DEFAULT NULL,
  Daten_Telefon varchar(50) DEFAULT NULL,
  Daten_Handy varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_daten_export
--

LOCK TABLES t_daten_export WRITE;
/*!40000 ALTER TABLE t_daten_export DISABLE KEYS */;
/*!40000 ALTER TABLE t_daten_export ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_dienst_suchprofile
--

DROP TABLE IF EXISTS t_dienst_suchprofile;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_dienst_suchprofile (
  su_profil_id int(11) NOT NULL AUTO_INCREMENT,
  Suchprofil varchar(50) DEFAULT NULL,
  richtung int(11) NOT NULL,
  PRIMARY KEY (su_profil_id),
  KEY su_profil_id (su_profil_id)
) ENGINE=InnoDB AUTO_INCREMENT=40 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_dienst_suchprofile
--

LOCK TABLES t_dienst_suchprofile WRITE;
/*!40000 ALTER TABLE t_dienst_suchprofile DISABLE KEYS */;
INSERT INTO t_dienst_suchprofile VALUES (1,'Gen: heiopeis',1),(2,'Gen: watt',1),(5,'Gen: Laddach',1),(6,'Gen: Hilgenberg',1),(7,'Thi: Plarad',1),(9,'Gen: Sport',1),(10,'Bes:Eloy',1),(11,'Bes: Rhodius',1),(12,'Koc: Teich-Law',1),(13,'Sch: ZAV',1),(14,'Messebauer',1),(15,'Kur: Lederer',1),(16,'Kur: SME Management GmbH',1),(17,'Kur: Taihua',1),(18,'Kur: Trinasco',1),(19,'Kur: Lederer',1),(20,'Kur: CCPIT',1),(22,'Kur: Tracto-Technik',1),(23,'Kur: Wallstein',1),(24,'Kur: MarKo',1),(25,'Kur: Zehnhoff',1),(26,'Kur: Zehnhoff',1),(27,'Kur: BR',1),(28,'Kur: Lederer',1),(29,'Kur: Moseler',1),(30,'Kur: Teich-Law',1),(31,'Sch: Spheretex',1),(32,'Kur: Digatron',1),(33,'Kur: Voigt, YEDI',2),(34,'Wan: CCPIT Peking',2),(35,'Kur: Unternehmensgründung',1),(36,'Sch: WPs und StBs für HvB',1),(37,'Wehr: Referenten K2013',1),(38,'Kur: GSHCG',1),(39,'Kur: Sachs Engineering',1);
/*!40000 ALTER TABLE t_dienst_suchprofile ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_dienstleister
--

DROP TABLE IF EXISTS t_dienstleister;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_dienstleister (
  dd_id int(11) NOT NULL AUTO_INCREMENT,
  dienstleister int(11) NOT NULL,
  dienstleistung int(11) NOT NULL,
  intensitaet int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (dd_id),
  KEY dd_id (dd_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_dienstleister
--

LOCK TABLES t_dienstleister WRITE;
/*!40000 ALTER TABLE t_dienstleister DISABLE KEYS */;
/*!40000 ALTER TABLE t_dienstleister ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_dienstleistungen
--

DROP TABLE IF EXISTS t_dienstleistungen;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_dienstleistungen (
  dienst_id int(11) NOT NULL AUTO_INCREMENT,
  dienstleistung varchar(50) DEFAULT NULL,
  dienst_gruppe int(11) DEFAULT '0',
  PRIMARY KEY (dienst_id),
  KEY dienst_id (dienst_id),
  KEY t_dienstleistungsgruppent_dienstleistungen (dienst_gruppe),
  CONSTRAINT t_dienstleistungsgruppent_dienstleistungen FOREIGN KEY (dienst_gruppe) REFERENCES t_dienstleistungsgruppen (dienst_grp_id)
) ENGINE=InnoDB AUTO_INCREMENT=70 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_dienstleistungen
--

LOCK TABLES t_dienstleistungen WRITE;
/*!40000 ALTER TABLE t_dienstleistungen DISABLE KEYS */;
INSERT INTO t_dienstleistungen VALUES (1,'Markt- und Wettbewerbsanalysen',1),(2,'Machbarkeitsstudien und Markteintrittsstrategien',1),(3,'Unternehmensentwicklung und Restrukturierung',1),(4,'Betreuung bei Geschaeftsanbahnung',1),(5,'Fusionen und Übernahmen (M&A)',1),(6,'Aufbau von Produktionsstaetten',1),(7,'Aufbau von Handelsgeschaeften',1),(8,'Personalberatung | Human Resources',1),(9,'Produktoptimierung (Kosten | Markt)',1),(10,'F&E | Innovationsmanagement',1),(11,'Einkauf und Qualitaetsmanagement',1),(12,'Warehousing und Logisitik',1),(13,'Produktion und Outsourcing',1),(14,'Verkauf und Vertrieb',1),(15,'Branding | Werbung | Public Relations',1),(16,'Prozessorganisation und Controlling',1),(17,'Außenwirtschafts- und Investitionsrecht',2),(18,'Devisenrecht',2),(19,'Gründung von Gemeinschaftsunternehmen (JV)',2),(20,'Lizenzvereinbarungen',2),(21,'Recht zu Fusionen und Übernahmen (M&A)',2),(22,'Corporate Finance',2),(23,'Unternehmensgründung und Gesellschaftsrecht',2),(24,'Restrukturierung-, Sanierungs- und Insolvenzrecht',2),(25,'Kapitalmarktrecht',2),(26,'Medienrecht',2),(27,'Wettbewerbs- und Kartellrecht',2),(28,'Auslaenderrecht | Aufenthalts- und Arbeitserlaubnis',2),(29,'Arbeitsrecht',2),(30,'Umwelt- und Verfahrensrecht',2),(31,'Patent-, Marken- und Warenzeichenrecht',2),(32,'Vertrags- und Handelsrecht',2),(33,'Logistik- und Transportrecht',2),(34,'Schutz vor Wirtschaftskriminalitaet (Forensic Servi',2),(35,'Schlichtung und Schiedsgerichtsverfahren',2),(36,'Einkommens- und Lohnsteuerrecht',2),(37,'Unternehmenssteuerrecht',2),(38,'Umsatzsteuerrecht, Verbrauchssteuer- und Zollrecht',2),(39,'Verrechnungspreise',2),(40,'Buchführung, Kosten- und Leistungsrechnung',2),(41,'Rechnungslegung | Finanzielle Berichterstattung',2),(42,'Jahresabschlussprüfung | Betriebsprüfung',2),(43,'Fremdfinanzierung | Kreditgeschaeft',3),(44,'Öffentliche Investitionsförderung | Gründerzuschüs',3),(45,'Durchführung Zahlungsverkehr',3),(46,'An- und Verkauf von Wertpapieren',3),(47,'Akkreditivgeschaeft (L/C)',3),(48,'Schaden- und Unfallversicherung',3),(49,'Transportversicherung',3),(50,'Gebaeude-/ Immobilienversicherung',3),(51,'Zahlungsausfallversicherungen und Bürgschaften',3),(52,'Import-/ Exportversicherungen',3),(53,'Warenversicherung',3),(54,'Lebens- und Krankenversicherung',3),(55,'Personaltraining | Interkulturelle Beratung',4),(56,'Seminare und Veranstaltungen',4),(57,'Logistik-Dienstleistungen',4),(58,'Warenverzollung',4),(59,'Durchführung von Vertrieb und Handel',4),(60,'IT | SAP',4),(61,'Dolmetschen | Übersetzung',4),(62,'Buchhaltung | Bürodienstleistungen',4),(63,'Architektur | Stadtplanung',4),(64,'Immobilien- und Grundstücksverwaltung',4),(65,'Messe- und Kongressdienstleistungen',4),(66,'Presse und Journalismus',4),(67,'Werbung | Kommunikation | Design',4),(68,'Relocation-Services',4),(69,'Reise | Tourismus | Kunst und Kultur',4);
/*!40000 ALTER TABLE t_dienstleistungen ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_dienstleistungsgruppen
--

DROP TABLE IF EXISTS t_dienstleistungsgruppen;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_dienstleistungsgruppen (
  dienst_grp_id int(11) NOT NULL AUTO_INCREMENT,
  dienst_gruppe varchar(50) DEFAULT NULL,
  PRIMARY KEY (dienst_grp_id),
  KEY dienst_grp_id (dienst_grp_id)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_dienstleistungsgruppen
--

LOCK TABLES t_dienstleistungsgruppen WRITE;
/*!40000 ALTER TABLE t_dienstleistungsgruppen DISABLE KEYS */;
INSERT INTO t_dienstleistungsgruppen VALUES (1,'Wirtschaftsberatung'),(2,'Recht | Steuern | Wirtschaftsprüfung'),(3,'Banken | Finanzierung | Versicherung'),(4,'Sonstige');
/*!40000 ALTER TABLE t_dienstleistungsgruppen ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_filt_dienst_was
--

DROP TABLE IF EXISTS t_filt_dienst_was;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_filt_dienst_was (
  filt_id int(11) NOT NULL AUTO_INCREMENT,
  f_dienstleistung int(11) NOT NULL,
  f_suchprofil int(11) NOT NULL,
  PRIMARY KEY (filt_id),
  KEY filt_id (filt_id),
  KEY t_dienst_suchprofilet_filt_dienst_was (f_suchprofil),
  CONSTRAINT t_dienst_suchprofilet_filt_dienst_was FOREIGN KEY (f_suchprofil) REFERENCES t_dienst_suchprofile (su_profil_id)
) ENGINE=InnoDB AUTO_INCREMENT=171 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_filt_dienst_was
--

LOCK TABLES t_filt_dienst_was WRITE;
/*!40000 ALTER TABLE t_filt_dienst_was DISABLE KEYS */;
INSERT INTO t_filt_dienst_was VALUES (1,17,11),(2,60,1),(3,19,11),(4,28,2),(5,60,2),(6,1,11),(10,33,10),(11,32,11),(12,35,5),(13,34,5),(14,32,11),(15,33,10),(16,35,10),(17,34,6),(18,8,7),(19,69,9),(20,67,9),(21,7,12),(22,12,12),(23,14,12),(24,17,12),(25,19,12),(26,20,12),(27,21,12),(28,23,12),(29,28,12),(30,29,12),(31,30,12),(32,31,12),(33,4,12),(34,29,13),(35,28,13),(36,36,13),(37,55,13),(38,68,13),(39,8,13),(40,67,14),(41,65,14),(42,7,15),(43,8,15),(44,61,16),(46,7,17),(47,6,17),(48,4,17),(49,15,17),(50,11,17),(51,10,17),(52,5,17),(53,2,17),(54,1,17),(55,8,17),(56,13,17),(57,9,17),(58,16,17),(59,3,17),(60,14,17),(61,12,17),(62,19,17),(63,60,18),(64,26,18),(65,67,18),(66,23,19),(67,28,19),(68,32,19),(69,63,20),(70,7,22),(71,4,22),(72,59,22),(73,28,23),(74,29,23),(75,36,23),(76,4,24),(77,7,24),(78,14,24),(79,59,24),(80,28,25),(81,29,25),(82,36,25),(83,32,26),(84,33,26),(85,69,27),(86,8,28),(87,55,28),(88,4,29),(89,7,29),(90,5,30),(91,42,31),(92,40,31),(93,41,31),(94,32,32),(95,45,32),(96,15,33),(97,7,33),(99,1,34),(100,14,34),(102,2,35),(103,1,35),(104,3,35),(105,4,35),(106,7,35),(107,6,35),(108,17,35),(109,18,35),(110,19,35),(111,20,35),(112,21,35),(113,22,35),(114,23,35),(115,25,35),(116,5,35),(117,28,35),(118,29,35),(119,32,35),(120,33,35),(121,36,35),(122,37,35),(123,38,35),(124,40,35),(125,41,35),(126,42,35),(127,47,35),(128,46,35),(129,45,35),(130,43,35),(131,50,35),(132,52,35),(133,54,35),(134,44,35),(135,48,35),(136,53,35),(137,49,35),(138,51,35),(139,59,35),(140,58,35),(141,36,36),(142,42,36),(143,41,36),(144,38,36),(145,62,36),(146,29,36),(147,28,36),(148,22,36),(149,40,36),(150,19,36),(151,21,36),(152,26,36),(153,33,36),(154,16,36),(156,11,37),(157,2,38),(158,4,38),(159,6,38),(160,7,38),(161,9,38),(162,14,38),(163,23,38),(164,59,38),(165,3,39),(166,5,39),(167,19,39),(168,21,39),(169,22,39),(170,64,39);
/*!40000 ALTER TABLE t_filt_dienst_was ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_filt_dienst_wer
--

DROP TABLE IF EXISTS t_filt_dienst_wer;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_filt_dienst_wer (
  filt_id int(11) NOT NULL AUTO_INCREMENT,
  f_branche int(11) NOT NULL,
  f_suchprofil int(11) NOT NULL,
  PRIMARY KEY (filt_id),
  KEY filt_id (filt_id)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_filt_dienst_wer
--

LOCK TABLES t_filt_dienst_wer WRITE;
/*!40000 ALTER TABLE t_filt_dienst_wer DISABLE KEYS */;
INSERT INTO t_filt_dienst_wer VALUES (1,73,1),(2,79,1),(3,83,2),(4,100,4),(5,89,7),(6,72,12),(7,70,12),(8,76,12),(9,84,12),(10,85,12),(11,89,12),(12,96,12),(13,91,14),(14,74,15),(15,100,15),(16,92,15),(17,89,15),(18,71,17),(19,74,20),(20,95,20),(21,76,21),(22,88,24),(23,72,33),(24,99,33),(25,89,39);
/*!40000 ALTER TABLE t_filt_dienst_wer ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_jahresbericht_werbung_nicht_mitglieder
--

DROP TABLE IF EXISTS t_jahresbericht_werbung_nicht_mitglieder;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_jahresbericht_werbung_nicht_mitglieder (
  email varchar(255) DEFAULT NULL,
  UNIQUE KEY email (email)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_jahresbericht_werbung_nicht_mitglieder
--

LOCK TABLES t_jahresbericht_werbung_nicht_mitglieder WRITE;
/*!40000 ALTER TABLE t_jahresbericht_werbung_nicht_mitglieder DISABLE KEYS */;
/*!40000 ALTER TABLE t_jahresbericht_werbung_nicht_mitglieder ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_laender_und_weltregionen
--

DROP TABLE IF EXISTS t_laender_und_weltregionen;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_laender_und_weltregionen (
  laender_id int(11) NOT NULL AUTO_INCREMENT,
  Land varchar(50) DEFAULT NULL,
  PRIMARY KEY (laender_id),
  KEY laender_id (laender_id)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_laender_und_weltregionen
--

LOCK TABLES t_laender_und_weltregionen WRITE;
/*!40000 ALTER TABLE t_laender_und_weltregionen DISABLE KEYS */;
INSERT INTO t_laender_und_weltregionen VALUES (1,'China'),(2,'Deutschland'),(3,'Indien'),(4,'Südostasien'),(5,'Osteuropa'),(6,'Türkei'),(7,'Russland'),(8,'Brasilien'),(9,'Frankreich'),(10,'Großbritannien | Irland'),(11,'Italien'),(12,'Spanien | Portugal'),(13,'Benelux-Staaten'),(14,'Skandinavien'),(15,'Österreich | Schweiz | Liechtenstein'),(16,'Polen | Tschechien'),(17,'Rumaenien | Bulgarien | Slowakei | Ungarn'),(18,'Griechenland | Ex-Jugoslawische Staaten'),(19,'Baltische Staaten'),(20,'Russland | GUS'),(21,'Afrika'),(22,'USA | Kanada'),(23,'Lateinamerika'),(24,'Japan | Korea'),(25,'Naher und Mittlerer Osten');
/*!40000 ALTER TABLE t_laender_und_weltregionen ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_no_more_mails
--

DROP TABLE IF EXISTS t_no_more_mails;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_no_more_mails (
  tabu_addy varchar(100) NOT NULL,
  UNIQUE KEY mail_addy (tabu_addy)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_no_more_mails
--

LOCK TABLES t_no_more_mails WRITE;
/*!40000 ALTER TABLE t_no_more_mails DISABLE KEYS */;
/*!40000 ALTER TABLE t_no_more_mails ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_standorte
--

DROP TABLE IF EXISTS t_standorte;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_standorte (
  standorte int(11) NOT NULL AUTO_INCREMENT,
  Standort varchar(50) DEFAULT NULL,
  f_laender int(11) NOT NULL,
  PRIMARY KEY (standorte),
  KEY t_laender_und_weltregionent_standorte (f_laender),
  CONSTRAINT t_laender_und_weltregionent_standorte FOREIGN KEY (f_laender) REFERENCES t_laender_und_weltregionen (laender_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_standorte
--

LOCK TABLES t_standorte WRITE;
/*!40000 ALTER TABLE t_standorte DISABLE KEYS */;
/*!40000 ALTER TABLE t_standorte ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_wer_fuer_wen
--

DROP TABLE IF EXISTS t_wer_fuer_wen;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_wer_fuer_wen (
  wfw_id int(11) NOT NULL AUTO_INCREMENT,
  f_mitglied int(11) NOT NULL,
  f_branche int(11) NOT NULL,
  D_CN tinyint(3) unsigned NOT NULL DEFAULT '0',
  CN_D tinyint(3) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (wfw_id),
  UNIQUE KEY wmw (f_mitglied,f_branche),
  KEY wmw_id (wfw_id),
  KEY t_branchent_wer_fuer_wen (f_branche),
  CONSTRAINT Datent_wer_fuer_wen FOREIGN KEY (f_mitglied) REFERENCES daten (Daten_Mitgliedsnummer),
  CONSTRAINT t_branchent_wer_fuer_wen FOREIGN KEY (f_branche) REFERENCES t_branchen (branchen_id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_wer_fuer_wen
--

LOCK TABLES t_wer_fuer_wen WRITE;
/*!40000 ALTER TABLE t_wer_fuer_wen DISABLE KEYS */;
/*!40000 ALTER TABLE t_wer_fuer_wen ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_wer_internat_maerkte
--

DROP TABLE IF EXISTS t_wer_internat_maerkte;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_wer_internat_maerkte (
  int_markt_id int(11) NOT NULL AUTO_INCREMENT,
  f_mitglied int(11) NOT NULL,
  f_laender int(11) NOT NULL,
  intensitaet tinyint(3) unsigned NOT NULL,
  PRIMARY KEY (int_markt_id),
  KEY int_markt_id (int_markt_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_wer_internat_maerkte
--

LOCK TABLES t_wer_internat_maerkte WRITE;
/*!40000 ALTER TABLE t_wer_internat_maerkte DISABLE KEYS */;
/*!40000 ALTER TABLE t_wer_internat_maerkte ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_wer_ist_wo
--

DROP TABLE IF EXISTS t_wer_ist_wo;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_wer_ist_wo (
  wer_wo_id int(11) NOT NULL AUTO_INCREMENT,
  f_mitglied int(11) NOT NULL,
  f_standort int(11) DEFAULT NULL,
  PRIMARY KEY (wer_wo_id),
  KEY wer_wo_id (wer_wo_id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_wer_ist_wo
--

LOCK TABLES t_wer_ist_wo WRITE;
/*!40000 ALTER TABLE t_wer_ist_wo DISABLE KEYS */;
/*!40000 ALTER TABLE t_wer_ist_wo ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table t_wer_macht_was
--

DROP TABLE IF EXISTS t_wer_macht_was;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE t_wer_macht_was (
  wmw_id int(11) NOT NULL AUTO_INCREMENT,
  f_mitglied int(11) NOT NULL,
  f_dienstleistung int(11) NOT NULL,
  D_CN tinyint(3) unsigned NOT NULL DEFAULT '0',
  CN_D tinyint(3) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (wmw_id),
  UNIQUE KEY wmw (f_mitglied,f_dienstleistung),
  KEY wmw_id (wmw_id),
  KEY t_dienstleistungent_wer_macht_was (f_dienstleistung),
  CONSTRAINT Datent_wer_macht_was FOREIGN KEY (f_mitglied) REFERENCES daten (Daten_Mitgliedsnummer),
  CONSTRAINT t_dienstleistungent_wer_macht_was FOREIGN KEY (f_dienstleistung) REFERENCES t_dienstleistungen (dienst_id)
) ENGINE=InnoDB AUTO_INCREMENT=1773 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table t_wer_macht_was
--

LOCK TABLES t_wer_macht_was WRITE;
/*!40000 ALTER TABLE t_wer_macht_was DISABLE KEYS */;
INSERT INTO t_wer_macht_was VALUES (1772,1,40,0,0);
/*!40000 ALTER TABLE t_wer_macht_was ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table teilnehmerveranstaltung
--

DROP TABLE IF EXISTS teilnehmerveranstaltung;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE teilnehmerveranstaltung (
  Teil_lfd int(11) NOT NULL AUTO_INCREMENT,
  Teil_TeilnehmerMgl int(11) DEFAULT '0',
  Teil_Veranstaltunglfd int(11) DEFAULT '0',
  Teil_Veranstaltung_Titel varchar(255) DEFAULT NULL,
  Teil_Veranstaltung_Datum datetime DEFAULT NULL,
  Teil_Veranstaltung_Ort varchar(50) DEFAULT NULL,
  Teil_Gebühr double DEFAULT '0',
  Teil_Mwst double DEFAULT '0',
  Teil_Gesamtbetrag double DEFAULT '0',
  Teil_Anmeldung_Datum datetime DEFAULT NULL,
  Teil_Essen tinyint(1) DEFAULT NULL,
  Teil_Rechtzeitig_Abmeldung tinyint(1) DEFAULT NULL,
  Teil_Bezahlt_Am datetime DEFAULT NULL,
  Teil_Zahlung_Betrag double DEFAULT '0',
  PRIMARY KEY (Teil_lfd),
  KEY Teil_TeilnehmerMitgliedsnummer (Teil_TeilnehmerMgl),
  KEY VeranstaltungenTeilnehmerVeranstaltung (Teil_Veranstaltunglfd),
  CONSTRAINT DatenTeilnehmerVeranstaltung FOREIGN KEY (Teil_TeilnehmerMgl) REFERENCES daten (Daten_Mitgliedsnummer),
  CONSTRAINT VeranstaltungenTeilnehmerVeranstaltung FOREIGN KEY (Teil_Veranstaltunglfd) REFERENCES veranstaltungen (Ver_lfd)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table teilnehmerveranstaltung
--

LOCK TABLES teilnehmerveranstaltung WRITE;
/*!40000 ALTER TABLE teilnehmerveranstaltung DISABLE KEYS */;
/*!40000 ALTER TABLE teilnehmerveranstaltung ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table todo
--

DROP TABLE IF EXISTS todo;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE todo (
  To_lfd int(11) NOT NULL AUTO_INCREMENT,
  To_wer varchar(50) DEFAULT NULL,
  To_abwann datetime DEFAULT NULL,
  To_biswann datetime DEFAULT NULL,
  To_kurz varchar(255) DEFAULT NULL,
  To_lang longtext,
  To_erledigt tinyint(1) DEFAULT NULL,
  PRIMARY KEY (To_lfd)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table todo
--

LOCK TABLES todo WRITE;
/*!40000 ALTER TABLE todo DISABLE KEYS */;
/*!40000 ALTER TABLE todo ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table tote_mails
--

DROP TABLE IF EXISTS tote_mails;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE tote_mails (
  tote_mails varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table tote_mails
--

LOCK TABLES tote_mails WRITE;
/*!40000 ALTER TABLE tote_mails DISABLE KEYS */;
/*!40000 ALTER TABLE tote_mails ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table veranstaltungen
--

DROP TABLE IF EXISTS veranstaltungen;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE veranstaltungen (
  Ver_lfd int(11) NOT NULL AUTO_INCREMENT,
  Ver_Datum datetime DEFAULT NULL,
  Ver_Uhrzeit varchar(50) DEFAULT NULL,
  Ver_Titel varchar(255) DEFAULT NULL,
  Ver_Ort varchar(50) DEFAULT NULL,
  Ver_Tagungsstaette varchar(50) DEFAULT NULL,
  Ver_Preis_Mitglied double DEFAULT '0',
  Ver_Preis_Nichtmitglied double DEFAULT '0',
  Ver_Veranstalter1 varchar(50) DEFAULT NULL,
  Ver_Veranstalter2 varchar(50) DEFAULT NULL,
  Ver_Rechnung_versandt_am datetime DEFAULT NULL,
  PRIMARY KEY (Ver_lfd)
) ENGINE=InnoDB AUTO_INCREMENT=276 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table veranstaltungen
--

LOCK TABLES veranstaltungen WRITE;
/*!40000 ALTER TABLE veranstaltungen DISABLE KEYS */;
INSERT INTO veranstaltungen VALUES (275,'2014-11-12 00:00:00','9','essen','essen',NULL,0,0,NULL,NULL,NULL);
/*!40000 ALTER TABLE veranstaltungen ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-12-13 14:27:52
