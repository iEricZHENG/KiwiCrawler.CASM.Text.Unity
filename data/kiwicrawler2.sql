/*
Navicat MySQL Data Transfer

Source Server         : Kiwi
Source Server Version : 50624
Source Host           : localhost:3306
Source Database       : kiwicrawler2

Target Server Type    : MYSQL
Target Server Version : 50624
File Encoding         : 65001

Date: 2016-05-26 15:12:05
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for capturedata_k
-- ----------------------------
DROP TABLE IF EXISTS `capturedata_k`;
CREATE TABLE `capturedata_k` (
  `kId` int(11) NOT NULL AUTO_INCREMENT,
  `kUrl` text NOT NULL,
  `kContent` longtext NOT NULL,
  `kType` varchar(255) DEFAULT NULL,
  `kCaptureDateTime` datetime NOT NULL,
  `kNumber` int(11) DEFAULT NULL,
  `kExtracted` int(11) NOT NULL DEFAULT '0',
  `kPageMD5` varchar(32) DEFAULT NULL,
  `kIndexId` int(11) NOT NULL,
  `kUpdateTime` datetime DEFAULT NULL,
  `kIsUpdated` int(11) NOT NULL DEFAULT '0',
  `kNotes` text,
  PRIMARY KEY (`kId`)
) ENGINE=InnoDB AUTO_INCREMENT=30431 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for deletedrecord_k
-- ----------------------------
DROP TABLE IF EXISTS `deletedrecord_k`;
CREATE TABLE `deletedrecord_k` (
  `kId` int(11) NOT NULL AUTO_INCREMENT,
  `kCapturedataId` int(11) NOT NULL,
  `kDeleteDatetime` datetime NOT NULL,
  `kNotes` text COLLATE utf8_unicode_ci,
  PRIMARY KEY (`kId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

-- ----------------------------
-- Table structure for extractionconfig_k
-- ----------------------------
DROP TABLE IF EXISTS `extractionconfig_k`;
CREATE TABLE `extractionconfig_k` (
  `kId` int(11) NOT NULL,
  `kUrl` text NOT NULL,
  `kTitle` text,
  `kPublishDateTime` text,
  `kContent` text,
  `kExtracionType` text,
  `kAddressBusinessType` text,
  `kKeywords` text,
  `kPercent` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for extractioncontent_k
-- ----------------------------
DROP TABLE IF EXISTS `extractioncontent_k`;
CREATE TABLE `extractioncontent_k` (
  `KId` int(11) NOT NULL,
  `KUrl` text,
  `KTitle` text,
  `KPublishDateTime` datetime DEFAULT NULL,
  `KContent` text,
  `KAddressBusinessType` text,
  `KKeyword` text,
  `KExtracionType` text,
  `KExtra` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Table structure for urlconfigs_k
-- ----------------------------
DROP TABLE IF EXISTS `urlconfigs_k`;
CREATE TABLE `urlconfigs_k` (
  `kId` int(11) NOT NULL AUTO_INCREMENT,
  `kUrl` text NOT NULL,
  `kPageTotal` int(11) DEFAULT NULL,
  `kCaptureType` text,
  `kDetailPattern` text,
  `kDetailPatternType` varchar(255) DEFAULT NULL,
  `kNextPagePattern` text,
  `kNextPagePatternType` varchar(255) DEFAULT NULL,
  `kComplateDegree` float DEFAULT '0',
  `kAddressBusinessType` text,
  `kKeyWords` text,
  `kNotes` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`kId`)
) ENGINE=InnoDB AUTO_INCREMENT=70 DEFAULT CHARSET=utf8;
