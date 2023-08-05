# MySQL-Front 5.0  (Build 1.191)

/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='UTC' */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE */;
/*!40101 SET SQL_MODE='' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES */;
/*!40103 SET SQL_NOTES='ON' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS */;
/*!40014 SET FOREIGN_KEY_CHECKS=0 */;


# Host: localhost    Database: testdb
# ------------------------------------------------------
# Server version 5.1.41

#
# Table Objects for table bgd_base
#

DROP TABLE IF EXISTS `bgd_base`;
CREATE TABLE `bgd_base` (
  `BH` varchar(10) NOT NULL,
  `YLRBH` varchar(15) DEFAULT NULL,
  `HGBH` varchar(30) DEFAULT NULL,
  `JCKKA` char(4) DEFAULT NULL,
  `BAH` varchar(20) DEFAULT NULL,
  `HTXYH` varchar(100) DEFAULT NULL,
  `JCKRQ` datetime DEFAULT NULL,
  `SBRQ` datetime DEFAULT NULL,
  `JYDW` varchar(15) DEFAULT NULL,
  `YSFS` char(2) DEFAULT NULL,
  `YSGJMC` varchar(30) DEFAULT NULL,
  `SHDW` varchar(40) DEFAULT NULL,
  `FHDW` varchar(15) DEFAULT NULL,
  `SBDW` varchar(15) DEFAULT NULL,
  `HCH` varchar(15) DEFAULT NULL,
  `TYDH` varchar(10) DEFAULT NULL,
  `MYFS` char(4) DEFAULT NULL,
  `ZMXZ` char(3) DEFAULT NULL,
  `JHFS` char(2) DEFAULT NULL,
  `ZSBL` decimal(18,4) DEFAULT NULL,
  `NSDW` varchar(15) DEFAULT NULL,
  `XKZH` varchar(15) DEFAULT NULL,
  `GJ` char(3) DEFAULT NULL,
  `ZYG` char(4) DEFAULT NULL,
  `JND` varchar(20) DEFAULT NULL,
  `PZWH` varchar(15) DEFAULT NULL,
  `CJFS` char(2) DEFAULT NULL,
  `YFFS` char(4) DEFAULT NULL,
  `YFBZ` varchar(12) DEFAULT NULL,
  `YF` decimal(16,4) DEFAULT NULL,
  `BFFS` char(4) DEFAULT NULL,
  `BFBZ` varchar(12) DEFAULT NULL,
  `BF` decimal(16,4) DEFAULT NULL,
  `ZFFS` char(4) DEFAULT NULL,
  `ZFBZ` varchar(12) DEFAULT NULL,
  `ZF` decimal(16,4) DEFAULT NULL,
  `JS` int(11) DEFAULT NULL,
  `BZZL` char(2) DEFAULT NULL,
  `MZ` decimal(16,2) DEFAULT NULL,
  `JZ` decimal(16,2) DEFAULT NULL,
  `JZXH` varchar(20) DEFAULT NULL,
  `SFDZ` varchar(50) DEFAULT NULL,
  `SCCJ` varchar(30) DEFAULT NULL,
  `YT` varchar(20) DEFAULT NULL,
  `BZ` varchar(200) DEFAULT NULL,
  `BGDLX` char(8) DEFAULT NULL,
  `LB` char(2) DEFAULT NULL,
  `HTSJ` datetime DEFAULT NULL,
  `DW` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table bgd_base
#
LOCK TABLES `bgd_base` WRITE;
/*!40000 ALTER TABLE `bgd_base` DISABLE KEYS */;

INSERT INTO `bgd_base` VALUES ('1','1','1','0930','23983','a','2011-11-11','2011-11-10','mydslsd','1','2','sab','aowie','aovkme','23','434','1','11','21',23,'43','2','23',NULL,NULL,NULL,NULL,NULL,NULL,32,'1','3',5,'6','734',4,NULL,'1',4,2,'4','43','3',NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO `bgd_base` VALUES ('2','11110000','11110000','0930','12345','12345','0211-09-14','2000-01-01','ABCD','AB','AB','ABSD','ALSKF','ALSKD','ALKS','ALKS','LK','AL','A',33,'43','323','43',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
INSERT INTO `bgd_base` VALUES ('3','11110001','11110001','0930','1','1','2011-04-22','2011-10-10','XYZ','1','2',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `bgd_base` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table bgd_jzx
#

DROP TABLE IF EXISTS `bgd_jzx`;
CREATE TABLE `bgd_jzx` (
  `BH` varchar(15) NOT NULL,
  `BGDBH` varchar(10) NOT NULL,
  `JZXGG` char(2) DEFAULT NULL,
  `JZXZL` varchar(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table bgd_jzx
#
LOCK TABLES `bgd_jzx` WRITE;
/*!40000 ALTER TABLE `bgd_jzx` DISABLE KEYS */;

INSERT INTO `bgd_jzx` VALUES ('1','1','1','1500');
/*!40000 ALTER TABLE `bgd_jzx` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table bgd_list
#

DROP TABLE IF EXISTS `bgd_list`;
CREATE TABLE `bgd_list` (
  `BH` varchar(12) NOT NULL,
  `BGDBH` varchar(10) DEFAULT NULL,
  `XH` char(2) DEFAULT NULL,
  `SPBH` varchar(15) DEFAULT NULL,
  `SPMC` varchar(50) DEFAULT NULL,
  `SPGG` varchar(150) DEFAULT NULL,
  `SL` decimal(16,4) DEFAULT NULL,
  `ZL` decimal(16,2) DEFAULT NULL,
  `DW` varchar(20) DEFAULT NULL,
  `JS` int(11) DEFAULT NULL,
  `MDG` char(3) DEFAULT NULL,
  `DJ` decimal(16,4) DEFAULT NULL,
  `ZJ` decimal(16,4) DEFAULT NULL,
  `BZ` char(2) DEFAULT NULL,
  `ZM` char(2) DEFAULT NULL,
  `MZ` decimal(18,0) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table bgd_list
#
LOCK TABLES `bgd_list` WRITE;
/*!40000 ALTER TABLE `bgd_list` DISABLE KEYS */;

/*!40000 ALTER TABLE `bgd_list` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table bgd_sf
#

DROP TABLE IF EXISTS `bgd_sf`;
CREATE TABLE `bgd_sf` (
  `BH` varchar(15) NOT NULL,
  `BGDBH` varchar(10) NOT NULL,
  `SFDM` char(2) DEFAULT NULL,
  `SFDZBH` varchar(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table bgd_sf
#
LOCK TABLES `bgd_sf` WRITE;
/*!40000 ALTER TABLE `bgd_sf` DISABLE KEYS */;

INSERT INTO `bgd_sf` VALUES ('1','1','1','343');
/*!40000 ALTER TABLE `bgd_sf` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table pbcatcol
#

DROP TABLE IF EXISTS `pbcatcol`;
CREATE TABLE `pbcatcol` (
  `pbc_tnam` char(193) NOT NULL,
  `pbc_tid` int(11) DEFAULT NULL,
  `pbc_ownr` char(193) NOT NULL,
  `pbc_cnam` char(193) NOT NULL,
  `pbc_cid` smallint(6) DEFAULT NULL,
  `pbc_labl` varchar(254) DEFAULT NULL,
  `pbc_lpos` smallint(6) DEFAULT NULL,
  `pbc_hdr` varchar(254) DEFAULT NULL,
  `pbc_hpos` smallint(6) DEFAULT NULL,
  `pbc_jtfy` smallint(6) DEFAULT NULL,
  `pbc_mask` varchar(31) DEFAULT NULL,
  `pbc_case` smallint(6) DEFAULT NULL,
  `pbc_hght` smallint(6) DEFAULT NULL,
  `pbc_wdth` smallint(6) DEFAULT NULL,
  `pbc_ptrn` varchar(31) DEFAULT NULL,
  `pbc_bmap` char(1) DEFAULT NULL,
  `pbc_init` varchar(254) DEFAULT NULL,
  `pbc_cmnt` varchar(254) DEFAULT NULL,
  `pbc_edit` varchar(31) DEFAULT NULL,
  `pbc_tag` varchar(254) DEFAULT NULL,
  UNIQUE KEY `pbcatc_x` (`pbc_tnam`,`pbc_ownr`,`pbc_cnam`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Dumping data for table pbcatcol
#
LOCK TABLES `pbcatcol` WRITE;
/*!40000 ALTER TABLE `pbcatcol` DISABLE KEYS */;

/*!40000 ALTER TABLE `pbcatcol` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table pbcatedt
#

DROP TABLE IF EXISTS `pbcatedt`;
CREATE TABLE `pbcatedt` (
  `pbe_name` varchar(30) NOT NULL,
  `pbe_edit` varchar(254) DEFAULT NULL,
  `pbe_type` smallint(6) DEFAULT NULL,
  `pbe_cntr` int(11) DEFAULT NULL,
  `pbe_seqn` smallint(6) NOT NULL,
  `pbe_flag` int(11) DEFAULT NULL,
  `pbe_work` char(32) DEFAULT NULL,
  UNIQUE KEY `pbcate_x` (`pbe_name`,`pbe_seqn`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Dumping data for table pbcatedt
#
LOCK TABLES `pbcatedt` WRITE;
/*!40000 ALTER TABLE `pbcatedt` DISABLE KEYS */;

/*!40000 ALTER TABLE `pbcatedt` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table pbcatfmt
#

DROP TABLE IF EXISTS `pbcatfmt`;
CREATE TABLE `pbcatfmt` (
  `pbf_name` varchar(30) NOT NULL,
  `pbf_frmt` varchar(254) DEFAULT NULL,
  `pbf_type` smallint(6) DEFAULT NULL,
  `pbf_cntr` int(11) DEFAULT NULL,
  UNIQUE KEY `pbcatf_x` (`pbf_name`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Dumping data for table pbcatfmt
#
LOCK TABLES `pbcatfmt` WRITE;
/*!40000 ALTER TABLE `pbcatfmt` DISABLE KEYS */;

/*!40000 ALTER TABLE `pbcatfmt` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table pbcattbl
#

DROP TABLE IF EXISTS `pbcattbl`;
CREATE TABLE `pbcattbl` (
  `pbt_tnam` char(193) NOT NULL,
  `pbt_tid` int(11) DEFAULT NULL,
  `pbt_ownr` char(193) NOT NULL,
  `pbd_fhgt` smallint(6) DEFAULT NULL,
  `pbd_fwgt` smallint(6) DEFAULT NULL,
  `pbd_fitl` char(1) DEFAULT NULL,
  `pbd_funl` char(1) DEFAULT NULL,
  `pbd_fchr` smallint(6) DEFAULT NULL,
  `pbd_fptc` smallint(6) DEFAULT NULL,
  `pbd_ffce` char(18) DEFAULT NULL,
  `pbh_fhgt` smallint(6) DEFAULT NULL,
  `pbh_fwgt` smallint(6) DEFAULT NULL,
  `pbh_fitl` char(1) DEFAULT NULL,
  `pbh_funl` char(1) DEFAULT NULL,
  `pbh_fchr` smallint(6) DEFAULT NULL,
  `pbh_fptc` smallint(6) DEFAULT NULL,
  `pbh_ffce` char(18) DEFAULT NULL,
  `pbl_fhgt` smallint(6) DEFAULT NULL,
  `pbl_fwgt` smallint(6) DEFAULT NULL,
  `pbl_fitl` char(1) DEFAULT NULL,
  `pbl_funl` char(1) DEFAULT NULL,
  `pbl_fchr` smallint(6) DEFAULT NULL,
  `pbl_fptc` smallint(6) DEFAULT NULL,
  `pbl_ffce` char(18) DEFAULT NULL,
  `pbt_cmnt` varchar(254) DEFAULT NULL,
  UNIQUE KEY `pbcatt_x` (`pbt_tnam`,`pbt_ownr`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Dumping data for table pbcattbl
#
LOCK TABLES `pbcattbl` WRITE;
/*!40000 ALTER TABLE `pbcattbl` DISABLE KEYS */;

/*!40000 ALTER TABLE `pbcattbl` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table pbcatvld
#

DROP TABLE IF EXISTS `pbcatvld`;
CREATE TABLE `pbcatvld` (
  `pbv_name` varchar(30) NOT NULL,
  `pbv_vald` varchar(254) DEFAULT NULL,
  `pbv_type` smallint(6) DEFAULT NULL,
  `pbv_cntr` int(11) DEFAULT NULL,
  `pbv_msg` varchar(254) DEFAULT NULL,
  UNIQUE KEY `pbcatv_x` (`pbv_name`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

#
# Dumping data for table pbcatvld
#
LOCK TABLES `pbcatvld` WRITE;
/*!40000 ALTER TABLE `pbcatvld` DISABLE KEYS */;

/*!40000 ALTER TABLE `pbcatvld` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_bz
#

DROP TABLE IF EXISTS `zd_bz`;
CREATE TABLE `zd_bz` (
  `BH` varchar(12) NOT NULL,
  `BZ` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_bz
#
LOCK TABLES `zd_bz` WRITE;
/*!40000 ALTER TABLE `zd_bz` DISABLE KEYS */;

INSERT INTO `zd_bz` VALUES ('110','港币');
INSERT INTO `zd_bz` VALUES ('116','日本元');
INSERT INTO `zd_bz` VALUES ('121','澳门元');
INSERT INTO `zd_bz` VALUES ('129','菲律宾比索');
INSERT INTO `zd_bz` VALUES ('132','新加坡元');
INSERT INTO `zd_bz` VALUES ('133','韩国圆');
INSERT INTO `zd_bz` VALUES ('136','泰国铢');
INSERT INTO `zd_bz` VALUES ('142','人民币');
INSERT INTO `zd_bz` VALUES ('300','欧元');
INSERT INTO `zd_bz` VALUES ('302','丹麦克朗');
INSERT INTO `zd_bz` VALUES ('303','英镑');
INSERT INTO `zd_bz` VALUES ('304','德国马克');
INSERT INTO `zd_bz` VALUES ('305','法国法郎');
INSERT INTO `zd_bz` VALUES ('307','意大利里拉');
INSERT INTO `zd_bz` VALUES ('312','西班牙比赛塔');
INSERT INTO `zd_bz` VALUES ('315','奥地利先令');
INSERT INTO `zd_bz` VALUES ('318','芬兰马克');
INSERT INTO `zd_bz` VALUES ('326','挪威克朗');
INSERT INTO `zd_bz` VALUES ('330','瑞典克朗');
INSERT INTO `zd_bz` VALUES ('331','瑞士法郎');
INSERT INTO `zd_bz` VALUES ('501','加拿大元');
INSERT INTO `zd_bz` VALUES ('502','美元');
INSERT INTO `zd_bz` VALUES ('601','澳大利亚元');
INSERT INTO `zd_bz` VALUES ('609','新西兰元');
/*!40000 ALTER TABLE `zd_bz` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_bzzl
#

DROP TABLE IF EXISTS `zd_bzzl`;
CREATE TABLE `zd_bzzl` (
  `BH` varchar(12) NOT NULL,
  `BZZL` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_bzzl
#
LOCK TABLES `zd_bzzl` WRITE;
/*!40000 ALTER TABLE `zd_bzzl` DISABLE KEYS */;

INSERT INTO `zd_bzzl` VALUES ('1','木箱');
INSERT INTO `zd_bzzl` VALUES ('2','纸箱');
INSERT INTO `zd_bzzl` VALUES ('3','桶装');
INSERT INTO `zd_bzzl` VALUES ('4','散装');
INSERT INTO `zd_bzzl` VALUES ('5','托盘');
INSERT INTO `zd_bzzl` VALUES ('6','包');
INSERT INTO `zd_bzzl` VALUES ('7','其它');
/*!40000 ALTER TABLE `zd_bzzl` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_cjfs
#

DROP TABLE IF EXISTS `zd_cjfs`;
CREATE TABLE `zd_cjfs` (
  `BH` varchar(12) NOT NULL,
  `CJFS` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_cjfs
#
LOCK TABLES `zd_cjfs` WRITE;
/*!40000 ALTER TABLE `zd_cjfs` DISABLE KEYS */;

INSERT INTO `zd_cjfs` VALUES ('1','CIF');
INSERT INTO `zd_cjfs` VALUES ('2','C&F');
INSERT INTO `zd_cjfs` VALUES ('3','FOB');
INSERT INTO `zd_cjfs` VALUES ('4','C&I');
INSERT INTO `zd_cjfs` VALUES ('5','市场价');
INSERT INTO `zd_cjfs` VALUES ('6','垫仓');
/*!40000 ALTER TABLE `zd_cjfs` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_ckka
#

DROP TABLE IF EXISTS `zd_ckka`;
CREATE TABLE `zd_ckka` (
  `BH` varchar(12) NOT NULL,
  `CKKA` varchar(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_ckka
#
LOCK TABLES `zd_ckka` WRITE;
/*!40000 ALTER TABLE `zd_ckka` DISABLE KEYS */;

INSERT INTO `zd_ckka` VALUES ('0930','丹东海关');
INSERT INTO `zd_ckka` VALUES ('',NULL);
/*!40000 ALTER TABLE `zd_ckka` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_dw
#

DROP TABLE IF EXISTS `zd_dw`;
CREATE TABLE `zd_dw` (
  `BH` varchar(12) NOT NULL,
  `DW` varchar(50) DEFAULT NULL,
  `LXR` varchar(10) DEFAULT NULL,
  `LXDH` varchar(50) DEFAULT NULL,
  `DZ` varchar(50) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_dw
#
LOCK TABLES `zd_dw` WRITE;
/*!40000 ALTER TABLE `zd_dw` DISABLE KEYS */;

INSERT INTO `zd_dw` VALUES ('1111','CSC_Company','蔡成哲','3940393','sld');
INSERT INTO `zd_dw` VALUES ('2222','RCJ_COMPANY',NULL,'3','3');
INSERT INTO `zd_dw` VALUES ('3333','KCG_COMPANY',NULL,NULL,NULL);
INSERT INTO `zd_dw` VALUES ('4444','ANY_COMPANY',NULL,NULL,NULL);
/*!40000 ALTER TABLE `zd_dw` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_jhfs
#

DROP TABLE IF EXISTS `zd_jhfs`;
CREATE TABLE `zd_jhfs` (
  `BH` varchar(12) NOT NULL,
  `JHFS` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_jhfs
#
LOCK TABLES `zd_jhfs` WRITE;
/*!40000 ALTER TABLE `zd_jhfs` DISABLE KEYS */;

INSERT INTO `zd_jhfs` VALUES ('1','信汇');
INSERT INTO `zd_jhfs` VALUES ('2','电汇');
INSERT INTO `zd_jhfs` VALUES ('3','票汇');
INSERT INTO `zd_jhfs` VALUES ('4','付款交单');
INSERT INTO `zd_jhfs` VALUES ('5','承兑交单');
INSERT INTO `zd_jhfs` VALUES ('6','信用证');
INSERT INTO `zd_jhfs` VALUES ('7','先出后结');
INSERT INTO `zd_jhfs` VALUES ('8','先结后出');
INSERT INTO `zd_jhfs` VALUES ('9','其他');
/*!40000 ALTER TABLE `zd_jhfs` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_jnhyd
#

DROP TABLE IF EXISTS `zd_jnhyd`;
CREATE TABLE `zd_jnhyd` (
  `BH` char(5) NOT NULL,
  `JNHYD` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_jnhyd
#
LOCK TABLES `zd_jnhyd` WRITE;
/*!40000 ALTER TABLE `zd_jnhyd` DISABLE KEYS */;

INSERT INTO `zd_jnhyd` VALUES ('21069','丹东');
INSERT INTO `zd_jnhyd` VALUES ('',NULL);
/*!40000 ALTER TABLE `zd_jnhyd` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_myfs
#

DROP TABLE IF EXISTS `zd_myfs`;
CREATE TABLE `zd_myfs` (
  `BH` varchar(12) NOT NULL,
  `MYFS` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_myfs
#
LOCK TABLES `zd_myfs` WRITE;
/*!40000 ALTER TABLE `zd_myfs` DISABLE KEYS */;

INSERT INTO `zd_myfs` VALUES ('0110','一般贸易');
INSERT INTO `zd_myfs` VALUES ('0214','来料加工');
INSERT INTO `zd_myfs` VALUES ('0615','进料对口');
INSERT INTO `zd_myfs` VALUES ('1200','保税间货物');
INSERT INTO `zd_myfs` VALUES ('1233','保税仓库货物');
INSERT INTO `zd_myfs` VALUES ('1300','修理物品');
INSERT INTO `zd_myfs` VALUES ('4019','边境小额');
/*!40000 ALTER TABLE `zd_myfs` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_sfdm
#

DROP TABLE IF EXISTS `zd_sfdm`;
CREATE TABLE `zd_sfdm` (
  `BH` char(4) NOT NULL,
  `SFDM` char(2) DEFAULT NULL,
  `SFMC` varchar(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_sfdm
#
LOCK TABLES `zd_sfdm` WRITE;
/*!40000 ALTER TABLE `zd_sfdm` DISABLE KEYS */;

INSERT INTO `zd_sfdm` VALUES ('1','1','进口许可证');
INSERT INTO `zd_sfdm` VALUES ('2','2','两用物项和技术进口许可证');
INSERT INTO `zd_sfdm` VALUES ('3','3','两用物项和技术出口许可证');
INSERT INTO `zd_sfdm` VALUES ('4','4','出口许可证');
INSERT INTO `zd_sfdm` VALUES ('5','5','纺织品临时出口许可证');
INSERT INTO `zd_sfdm` VALUES ('6','6','旧机电产品禁止进口');
INSERT INTO `zd_sfdm` VALUES ('7','7','自动进口许可证');
INSERT INTO `zd_sfdm` VALUES ('8','8','禁止出口商品');
INSERT INTO `zd_sfdm` VALUES ('9','9','禁止进口商品');
INSERT INTO `zd_sfdm` VALUES ('10','A','入境货物通关单');
INSERT INTO `zd_sfdm` VALUES ('11','B','出境货物通关单');
INSERT INTO `zd_sfdm` VALUES ('12','D','出/入境货物通关单（毛坯钻石用');
INSERT INTO `zd_sfdm` VALUES ('13','E','濒危物种允许出口证明书');
INSERT INTO `zd_sfdm` VALUES ('14','F','濒危物种允许进口证明书');
INSERT INTO `zd_sfdm` VALUES ('15','G','两用物项和技术出口许可证(定向');
INSERT INTO `zd_sfdm` VALUES ('16','H','港澳OPA纺织品证明');
INSERT INTO `zd_sfdm` VALUES ('17','I','精神药物进(出)口准许证');
INSERT INTO `zd_sfdm` VALUES ('18','J','黄金及其制品进出口准许证或批件');
INSERT INTO `zd_sfdm` VALUES ('19','K','深加工结转申请表');
INSERT INTO `zd_sfdm` VALUES ('20','L','药品进出口准许证');
INSERT INTO `zd_sfdm` VALUES ('21','M','密码产品和设备进口许可证');
INSERT INTO `zd_sfdm` VALUES ('22','O','自动进口许可证(新旧机电产品)');
INSERT INTO `zd_sfdm` VALUES ('23','P','固体废物进口许可证');
INSERT INTO `zd_sfdm` VALUES ('24','Q','进口药品通关单');
INSERT INTO `zd_sfdm` VALUES ('25','R','进口兽药通关单');
INSERT INTO `zd_sfdm` VALUES ('26','S','进出口农药登记证明');
INSERT INTO `zd_sfdm` VALUES ('27','T','银行调运现钞进出境许可证');
INSERT INTO `zd_sfdm` VALUES ('28','U','合法捕捞产品通关证明');
INSERT INTO `zd_sfdm` VALUES ('29','W','麻醉药品进出口准许证');
INSERT INTO `zd_sfdm` VALUES ('30','X','有毒化学品环境管理放行通知单');
INSERT INTO `zd_sfdm` VALUES ('','Y','原产地证明');
INSERT INTO `zd_sfdm` VALUES ('','Z','音像制品进口批准单或节目提取单');
INSERT INTO `zd_sfdm` VALUES ('','c','内销征税联系单');
INSERT INTO `zd_sfdm` VALUES ('','e','关税配额外优惠税率进口棉花配额');
INSERT INTO `zd_sfdm` VALUES ('','q','国别关税配额证明');
INSERT INTO `zd_sfdm` VALUES ('','r','预归类标志');
INSERT INTO `zd_sfdm` VALUES ('','s','适用ITA税率的商品用途认定证');
INSERT INTO `zd_sfdm` VALUES ('','t','关税配额证明');
INSERT INTO `zd_sfdm` VALUES ('','v','自动进口许可证(加工贸易)');
INSERT INTO `zd_sfdm` VALUES ('','x','出口许可证(加工贸易)');
INSERT INTO `zd_sfdm` VALUES ('','y','出口许可证(边境小额贸易)');
/*!40000 ALTER TABLE `zd_sfdm` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_sp
#

DROP TABLE IF EXISTS `zd_sp`;
CREATE TABLE `zd_sp` (
  `BH` varchar(15) NOT NULL,
  `SPBH` varchar(50) DEFAULT NULL,
  `SPMC` varchar(50) DEFAULT NULL,
  `SPGG` varchar(50) DEFAULT NULL,
  `DW` varchar(20) DEFAULT NULL,
  `LRSJ` datetime DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_sp
#
LOCK TABLES `zd_sp` WRITE;
/*!40000 ALTER TABLE `zd_sp` DISABLE KEYS */;

INSERT INTO `zd_sp` VALUES ('1','1','Shangpin1','10*10*10','ge','2011-10-30 09:35:45');
INSERT INTO `zd_sp` VALUES ('2','2','shoes','20*20*20','ge','2011-10-30 09:36:04');
INSERT INTO `zd_sp` VALUES ('1','1','Shangpin1','10*10*10','ge','2011-11-01 00:08:16');
/*!40000 ALTER TABLE `zd_sp` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_user
#

DROP TABLE IF EXISTS `zd_user`;
CREATE TABLE `zd_user` (
  `UID` varchar(16) NOT NULL,
  `PWD` varchar(16) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_user
#
LOCK TABLES `zd_user` WRITE;
/*!40000 ALTER TABLE `zd_user` DISABLE KEYS */;

INSERT INTO `zd_user` VALUES ('csc','123');
INSERT INTO `zd_user` VALUES ('chaesc','caichengzhe');
/*!40000 ALTER TABLE `zd_user` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_ydg
#

DROP TABLE IF EXISTS `zd_ydg`;
CREATE TABLE `zd_ydg` (
  `BH` char(3) NOT NULL,
  `YDG` varchar(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_ydg
#
LOCK TABLES `zd_ydg` WRITE;
/*!40000 ALTER TABLE `zd_ydg` DISABLE KEYS */;

INSERT INTO `zd_ydg` VALUES ('109','朝鲜');
INSERT INTO `zd_ydg` VALUES ('502','中国');
INSERT INTO `zd_ydg` VALUES ('116','日本');
INSERT INTO `zd_ydg` VALUES ('',NULL);
INSERT INTO `zd_ydg` VALUES ('',NULL);
/*!40000 ALTER TABLE `zd_ydg` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_ysfs
#

DROP TABLE IF EXISTS `zd_ysfs`;
CREATE TABLE `zd_ysfs` (
  `BH` char(2) NOT NULL,
  `YSFS` varchar(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_ysfs
#
LOCK TABLES `zd_ysfs` WRITE;
/*!40000 ALTER TABLE `zd_ysfs` DISABLE KEYS */;

INSERT INTO `zd_ysfs` VALUES ('0','非保税区');
INSERT INTO `zd_ysfs` VALUES ('1','监管仓库');
INSERT INTO `zd_ysfs` VALUES ('2','水路运输');
INSERT INTO `zd_ysfs` VALUES ('3','铁路运输');
INSERT INTO `zd_ysfs` VALUES ('4','公路运输');
INSERT INTO `zd_ysfs` VALUES ('5','航空运输');
INSERT INTO `zd_ysfs` VALUES ('6','邮件运输');
INSERT INTO `zd_ysfs` VALUES ('7','保税区  ');
INSERT INTO `zd_ysfs` VALUES ('8','保税仓库');
INSERT INTO `zd_ysfs` VALUES ('9','其它运输');
INSERT INTO `zd_ysfs` VALUES ('A','全部运输方式');
INSERT INTO `zd_ysfs` VALUES ('H','边境特殊海关作业区');
INSERT INTO `zd_ysfs` VALUES ('W','物流中心');
INSERT INTO `zd_ysfs` VALUES ('X','物流园区');
INSERT INTO `zd_ysfs` VALUES ('Y','保税港区');
INSERT INTO `zd_ysfs` VALUES ('Z','出口加工区');
/*!40000 ALTER TABLE `zd_ysfs` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_zm
#

DROP TABLE IF EXISTS `zd_zm`;
CREATE TABLE `zd_zm` (
  `BH` char(2) NOT NULL,
  `ZM` varchar(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_zm
#
LOCK TABLES `zd_zm` WRITE;
/*!40000 ALTER TABLE `zd_zm` DISABLE KEYS */;

INSERT INTO `zd_zm` VALUES ('1','照章征税');
INSERT INTO `zd_zm` VALUES ('2','折半征税');
INSERT INTO `zd_zm` VALUES ('3','全免');
INSERT INTO `zd_zm` VALUES ('4','特案');
INSERT INTO `zd_zm` VALUES ('5','征免性质');
INSERT INTO `zd_zm` VALUES ('6','保证金');
INSERT INTO `zd_zm` VALUES ('7','保函');
INSERT INTO `zd_zm` VALUES ('8','折半补税');
INSERT INTO `zd_zm` VALUES ('9','全额退税');
/*!40000 ALTER TABLE `zd_zm` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_zmxz
#

DROP TABLE IF EXISTS `zd_zmxz`;
CREATE TABLE `zd_zmxz` (
  `BH` int(16) NOT NULL AUTO_INCREMENT,
  `ZMXZ` varchar(20) NOT NULL,
  PRIMARY KEY (`BH`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_zmxz
#
LOCK TABLES `zd_zmxz` WRITE;
/*!40000 ALTER TABLE `zd_zmxz` DISABLE KEYS */;

INSERT INTO `zd_zmxz` VALUES (101,'一般征税');
INSERT INTO `zd_zmxz` VALUES (299,'其他法定');
INSERT INTO `zd_zmxz` VALUES (401,'科教用品');
INSERT INTO `zd_zmxz` VALUES (502,'来料加工');
INSERT INTO `zd_zmxz` VALUES (503,'进料加工');
INSERT INTO `zd_zmxz` VALUES (601,'中外合资');
INSERT INTO `zd_zmxz` VALUES (603,'外资企业');
/*!40000 ALTER TABLE `zd_zmxz` ENABLE KEYS */;
UNLOCK TABLES;

#
# Table Objects for table zd_zyg
#

DROP TABLE IF EXISTS `zd_zyg`;
CREATE TABLE `zd_zyg` (
  `BH` char(4) NOT NULL,
  `ZYG` varchar(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

#
# Dumping data for table zd_zyg
#
LOCK TABLES `zd_zyg` WRITE;
/*!40000 ALTER TABLE `zd_zyg` DISABLE KEYS */;

INSERT INTO `zd_zyg` VALUES ('1037','新义州');
INSERT INTO `zd_zyg` VALUES ('142','中国境内');
INSERT INTO `zd_zyg` VALUES ('2309','鹿特丹');
/*!40000 ALTER TABLE `zd_zyg` ENABLE KEYS */;
UNLOCK TABLES;

/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;
