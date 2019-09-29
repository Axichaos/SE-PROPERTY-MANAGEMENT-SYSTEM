-- phpMyAdmin SQL Dump
-- version 4.8.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 29, 2019 at 10:08 AM
-- Server version: 10.1.34-MariaDB
-- PHP Version: 7.2.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `propertymanagementdb`
--
CREATE DATABASE IF NOT EXISTS `propertymanagementdb` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `propertymanagementdb`;

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `acccheck` (IN `un` VARCHAR(255), IN `pass` VARCHAR(255))  NO SQL
SELECT * FROM tbluser WHERE tbluser.uname = un AND tbluser.password = pass$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `dispdelete` (IN `did` INT)  NO SQL
DELETE FROM tbldisposal WHERE tbldisposal.disp_id = did$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `dispedit` (IN `did` INT, IN `ddate` VARCHAR(255), IN `dmeth` VARCHAR(255), IN `drem` VARCHAR(255))  NO SQL
UPDATE tbldisposal SET tbldisposal.d_date = ddate, tbldisposal.d_meth = dmeth, tbldisposal.d_remarks = drem WHERE tbldisposal.disp_id = did$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `dispgen` (IN `invno` VARCHAR(255), IN `ddate` VARCHAR(255), IN `dmeth` VARCHAR(255), IN `dremark` VARCHAR(255))  NO SQL
INSERT INTO tbldisposal(tbldisposal.inv_no,tbldisposal.d_date,tbldisposal.d_meth,tbldisposal.d_remarks) VALUES(invno,ddate,dmeth,dremark)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `displbl` (IN `did` INT)  NO SQL
SELECT tbldisposal.d_date,tbldisposal.d_meth,tbldisposal.d_remarks FROM tbldisposal WHERE tbldisposal.disp_id = did$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `disptblshow` ()  NO SQL
SELECT tbldisposal.disp_id,tbldisposal.inv_no,tblproperty.name FROM tbldisposal INNER JOIN tblproperty ON tbldisposal.disp_id = tblproperty.disp_no ORDER BY disp_id ASC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `disptoin` (IN `invno` VARCHAR(255))  NO SQL
UPDATE tblproperty SET tblproperty.disp_no = null, tblproperty.status = "UNDISPOSED" WHERE tblproperty.inven_no = invno$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `empadd` (IN `name` VARCHAR(255), IN `cont` VARCHAR(255), IN `email` VARCHAR(255), IN `piclink` VARCHAR(255))  NO SQL
INSERT INTO tblemployee(tblemployee.name,tblemployee.contactno,tblemployee.email_add,tblemployee.pic_source) VALUES(name,cont,email,piclink)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `empdelete` (IN `empid` INT)  NO SQL
DELETE FROM tblemployee WHERE tblemployee.emp_id = empid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `empedit` (IN `empid` INT, IN `name` VARCHAR(255), IN `cont` VARCHAR(255), IN `email` VARCHAR(255), IN `piclink` VARCHAR(255))  NO SQL
UPDATE tblemployee SET tblemployee.name = name, tblemployee.contactno = cont, tblemployee.email_add = email, tblemployee.pic_source = piclink WHERE tblemployee.emp_id = empid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `empinvlink` (IN `empid` INT)  NO SQL
SELECT tblproperty.inven_no,tblproperty.name FROM tblproperty INNER JOIN tblemployee ON tblproperty.accp_id = tblemployee.emp_id WHERE tblemployee.emp_id = empid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `emplblshow` (IN `empid` INT)  NO SQL
SELECT * FROM tblemployee WHERE tblemployee.emp_id = empid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `empselectemp` (IN `eid` INT)  NO SQL
SELECT * FROM tblemployee WHERE tblemployee.emp_id = eid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `emptblshow` ()  NO SQL
SELECT tblemployee.emp_id,tblemployee.name FROM tblemployee$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eqpcardchildcount` (IN `caid` INT)  NO SQL
SELECT COUNT(tbleqplog.log_id) FROM tbleqpcardid RIGHT JOIN tbleqplog ON tbleqpcardid.card_id = tbleqplog.card_id WHERE tbleqpcardid.card_id = caid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eqpcarddelete` (IN `caid` INT)  NO SQL
DELETE FROM tbleqpcardid WHERE tbleqpcardid.card_id = caid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eqpcarddispdel` (IN `piid` INT)  NO SQL
DELETE FROM tbleqplog WHERE (tbleqplog.r_status = "DISPOSAL" OR tbleqplog.r_status = "DRETURN") AND tbleqplog.inv_no = piid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eqpcardedit` (IN `caid` INT, IN `cname` VARCHAR(255), IN `cdate` VARCHAR(255))  NO SQL
UPDATE tbleqpcardid SET tbleqpcardid.card_name = cname, tbleqpcardid.card_date = cdate WHERE tbleqpcardid.card_id = caid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eqpcardgen` (IN `cdate` VARCHAR(255), IN `name` VARCHAR(255))  NO SQL
INSERT INTO tbleqpcardid(tbleqpcardid.card_date,tbleqpcardid.card_name) VALUES(cdate,name)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eqpcardsetcurr` (IN `lid` INT)  NO SQL
UPDATE tbleqplog SET tbleqplog.r_current = "Current" WHERE tbleqplog.log_id = lid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eqpcardshow` ()  NO SQL
SELECT * FROM tbleqpcardid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eqpcardview` (IN `cardid` INT)  NO SQL
SELECT 
tbleqplog.r_date,
IF(tbleqplog.r_status = "CHANGE" OR tbleqplog.r_status = "SENT" OR tbleqplog.r_status = "RETURN" OR tbleqplog.r_status = "DRETURN","",tbleqplog.Balance) AS "Unit Cost",
IF(tbleqplog.r_status = "DISPOSAL",@runbal := @runbal - tbleqplog.Balance,
@runbal := @runbal + tbleqplog.Balance) AS "Total Balance",
IF(tbleqplog.r_status = "GENERATED" OR tbleqplog.r_status = "RETURN" OR tbleqplog.r_status = "DRETURN",1,IF(tbleqplog.r_status = "SENT" OR tbleqplog.r_status = "DISPOSAL","-1","")) AS "Quantity",
IF (tbleqplog.r_status = "GENERATED" OR tbleqplog.r_status = "RETURN" OR tbleqplog.r_status = "DRETURN",@runquan := @runquan+1,IF(tbleqplog.r_status = "SENT" OR tbleqplog.r_status = "DISPOSAL",@runquan := @runquan - 1, @runquan := @runquan + 0)) AS "Total Quantity",
tbleqplog.mrd_to,tbleqplog.inv_no,tbleqplog.remarks,tbleqplog.r_current,tbleqplog.r_status
FROM tbllinkcardtolog 
INNER JOIN tbleqplog ON tbllinkcardtolog.inven_no = tbleqplog.inv_no
INNER JOIN (SELECT @runbal := 0) r
INNER JOIN (SELECT @runquan := 0) q
WHERE tbllinkcardtolog.card_id = cardid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eqpindlogshow` (IN `invno` VARCHAR(255))  NO SQL
SELECT * FROM tbleqplog WHERE tbleqplog.inv_no = invno ORDER BY tbleqplog.inv_no ASC$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eqplogadd` (IN `ldate` VARCHAR(255), IN `mrt` VARCHAR(255), IN `inv` VARCHAR(255), IN `rem` VARCHAR(255), IN `stat` VARCHAR(255), IN `bal` INT)  NO SQL
INSERT INTO tbleqplog(tbleqplog.r_date,tbleqplog.mrd_to,tbleqplog.inv_no,tbleqplog.remarks,tbleqplog.r_status,tbleqplog.r_current,tbleqplog.Balance) VALUES (ldate,mrt,inv,rem,stat,"Current",bal)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eqplogbalchange` (IN `invid` VARCHAR(255), IN `cost` FLOAT)  NO SQL
UPDATE tbleqplog SET tbleqplog.Balance = cost WHERE tbleqplog.inv_no = invid AND tbleqplog.Balance > 0$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eqplogcheck` (IN `inv` VARCHAR(255), IN `caid` INT)  NO SQL
SELECT COUNT(tbleqplog.log_id) FROM tbleqplog WHERE tbleqplog.inv_no = inv AND tbleqplog.card_id = caid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eqplogcurrreset` (IN `invno` VARCHAR(255))  NO SQL
UPDATE tbleqplog SET tbleqplog.r_current = "Past" WHERE tbleqplog.inv_no = invno AND tbleqplog.r_current = "Current"$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `eqplogcurrshow` (IN `caid` INT)  NO SQL
SELECT * FROM tbleqplog WHERE tbleqplog.card_id = caid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `invadd` (IN `un` VARCHAR(255), IN `typ` VARCHAR(255), IN `rem` VARCHAR(255), IN `art` VARCHAR(255), IN `co` FLOAT, IN `des` VARCHAR(255), IN `locid` INT, IN `serial` VARCHAR(255), IN `accpid` INT, IN `accc` VARCHAR(255), IN `name` VARCHAR(255), IN `sign` VARCHAR(255), IN `rct` VARCHAR(255), IN `rci` VARCHAR(255), IN `dateacq` VARCHAR(255), IN `inv` VARCHAR(255))  NO SQL
INSERT INTO tblproperty(tblproperty.inven_no,tblproperty.name,tblproperty.unit,tblproperty.type,tblproperty.remarks,tblproperty.article,tblproperty.cost,tblproperty.description,tblproperty.loc_id,tblproperty.serialno_plateno,tblproperty.accp_id,tblproperty.acc_code,tblproperty.status,tblproperty.signed,tblproperty.rcpt_type,tblproperty.rcpt_iss,tblproperty.date_acq) VALUES(inv,name,un,typ,rem,art,co,des,locid,serial,accpid,accc,"UNDISPOSED",sign,rct,rci,dateacq)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `invdelete` (IN `pk` VARCHAR(255))  NO SQL
DELETE FROM tblproperty WHERE tblproperty.inven_no = pk$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `invdispid` (IN `invno` VARCHAR(255))  NO SQL
SELECT tbldisposal.disp_id FROM tbldisposal WHERE tbldisposal.inv_no = invno$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `invretmr` (IN `invno` VARCHAR(255))  NO SQL
SELECT tblproperty.loc_id,tblproperty.accp_id,tblproperty.cost FROM tblproperty WHERE tblproperty.inven_no = invno$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `invshowd` (IN `invno` VARCHAR(255))  NO SQL
SELECT * FROM tblproperty WHERE tblproperty.inven_no = invno$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `invshowout` ()  NO SQL
SELECT inven_no,name,description,serialno_plateno FROM tblproperty WHERE status = "UNDISPOSED"$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `invshowout1` ()  NO SQL
SELECT inven_no,name,description,serialno_plateno FROM tblproperty$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `invshowout2` ()  NO SQL
SELECT * FROM tblproperty$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `invtodispo` (IN `pk` VARCHAR(255), IN `dpk` INT)  NO SQL
UPDATE tblproperty SET tblproperty.disp_no = dpk,tblproperty.status = "DISPOSED" WHERE tblproperty.inven_no = pk$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `invupdate` (IN `un` VARCHAR(255), IN `typ` VARCHAR(255), IN `rem` VARCHAR(255), IN `art` VARCHAR(255), IN `co` FLOAT, IN `des` VARCHAR(255), IN `locid` INT, IN `serial` VARCHAR(255), IN `accpid` INT, IN `accc` VARCHAR(255), IN `pk` VARCHAR(255), IN `name` VARCHAR(255), IN `sign` VARCHAR(255), IN `rct` VARCHAR(255), IN `rci` VARCHAR(255), IN `dateacq` VARCHAR(255))  NO SQL
UPDATE tblproperty SET tblproperty.name = name,tblproperty.unit = un,tblproperty.type = typ,tblproperty.remarks = rem,tblproperty.article = art,tblproperty.cost = co,tblproperty.description = des,tblproperty.loc_id = locid, tblproperty.serialno_plateno = serial, tblproperty.accp_id = accpid, tblproperty.acc_code = accc, tblproperty.signed = sign, tblproperty.rcpt_type = rct, tblproperty.rcpt_iss = rci, tblproperty.date_acq = dateacq WHERE tblproperty.inven_no = pk$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `linkcardlogadd` (IN `cardid` INT, IN `invno` VARCHAR(255))  NO SQL
INSERT INTO tbllinkcardtolog(tbllinkcardtolog.card_id,tbllinkcardtolog.inven_no) VALUES(cardid,invno)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `locadd` (IN `loc` VARCHAR(255), IN `pro` VARCHAR(255), IN `room` VARCHAR(255))  NO SQL
INSERT INTO tbllocation(tbllocation.location,tbllocation.province,tbllocation.l_room) VALUES(loc,pro,room)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `locdelete` (IN `locid` INT)  NO SQL
DELETE FROM tbllocation WHERE tbllocation.loc_id = locid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `locedit` (IN `loc` VARCHAR(255), IN `prov` VARCHAR(255), IN `room` VARCHAR(255), IN `locid` INT)  NO SQL
UPDATE tbllocation SET tbllocation.location = loc,tbllocation.province = prov, tbllocation.l_room = room WHERE tbllocation.loc_id = locid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `loceditret` (IN `locid` INT)  NO SQL
SELECT * FROM tbllocation WHERE tbllocation.loc_id = locid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `locinvonloc` (IN `locid` INT)  NO SQL
SELECT tblproperty.inven_no,tblproperty.name FROM tblproperty INNER JOIN tbllocation ON tblproperty.loc_id = tbllocation.loc_id WHERE tblproperty.loc_id = locid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `locinvonprov` (IN `prov` VARCHAR(255))  NO SQL
SELECT tblproperty.inven_no,tblproperty.name FROM tbllocation INNER JOIN tblproperty ON tbllocation.loc_id = tblproperty.loc_id WHERE tbllocation.province = prov$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `loclblshow` (IN `locid` INT)  NO SQL
SELECT * from tbllocation WHERE tbllocation.loc_id = locid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `locselectloc` ()  NO SQL
SELECT tbllocation.location,tbllocation.loc_id FROM tbllocation$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `loctblshow` ()  NO SQL
SELECT * FROM tbllocation$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `logadd` (IN `ipk` INT, IN `typ` VARCHAR(255), IN `da` VARCHAR(255), IN `ldesc` VARCHAR(255))  NO SQL
INSERT INTO tbleqphistory(tbleqphistory.chg_type,tbleqphistory.chg_date,tbleqphistory.chg_desc,tbleqphistory.inven_no) VALUES(typ,da,ldesc,ipk)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `logdelete` (IN `ipk` INT, IN `lpk` INT)  NO SQL
DELETE FROM tbleqphistory WHERE tbleqphistory.log_id = lpk AND tbleqphistory.inven_no = ipk$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `logdescshow` (IN `lid` INT)  NO SQL
SELECT tbleqphistory.chg_desc FROM tbleqphistory WHERE tbleqphistory.log_id = lid$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `logedit` (IN `ipk` INT, IN `lpk` INT, IN `typ` VARCHAR(255), IN `da` VARCHAR(255), IN `ldesc` VARCHAR(255))  NO SQL
UPDATE tbleqphistory SET tbleqphistory.chg_type = typ,tbleqphistory.chg_date = da,tbleqphistory.chg_desc = ldesc WHERE tbleqphistory.log_id = lpk AND tbleqphistory.inven_no = ipk$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `logeditret` (IN `ipk` INT, IN `lpk` INT)  NO SQL
SELECT 
tbleqphistory.chg_type,tbleqphistory.chg_date,tbleqphistory.chg_desc
FROM tbleqphistory INNER JOIN tblproperty
ON tbleqphistory.inven_no = tblproperty.inven_no WHERE tbleqphistory.inven_no = ipk AND tbleqphistory.log_id = lpk$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `loginvshow` ()  NO SQL
SELECT tblproperty.inven_no,tblproperty.name,tblproperty.serialno_plateno FROM tblproperty$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `logtblshow` (IN `ipk` INT)  NO SQL
SELECT 
tbleqphistory.log_id,tbleqphistory.chg_type,tbleqphistory.chg_date 
FROM tbleqphistory INNER JOIN tblproperty
ON tbleqphistory.inven_no = tblproperty.inven_no WHERE tbleqphistory.inven_no = ipk$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `logupdate` (IN `ipk` INT, IN `lpk` INT, IN `typ` VARCHAR(255), IN `da` VARCHAR(255), IN `ldesc` VARCHAR(255))  NO SQL
UPDATE tbleqphistory SET tbleqphistory.chg_type = type,tbleqphistory.chg_date = da,tbleqphistory.chg_desc = ldesc WHERE tbleqphistory.log_id = lpk AND tbleqphistory.inven_no = ipk$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `recadd` (IN `sign` VARCHAR(255), IN `rt` VARCHAR(255), IN `iss` VARCHAR(255), IN `da` VARCHAR(255))  NO SQL
INSERT INTO `tblprecord` (`property_no`, `signed`, `receipt_type`, `par_ics_issued`, `date_acq`) VALUES (NULL,sign,rt,iss,da)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `recdelchild` (IN `rpk` INT)  NO SQL
SELECT COUNT(tblproperty.inven_no) FROM tblprecord INNER JOIN tblproperty ON tblprecord.property_no = tblproperty.prop_no WHERE tblprecord.property_no = rpk$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `recdelete` (IN `rcpk` INT)  NO SQL
DELETE FROM tblprecord WHERE tblprecord.property_no = rcpk$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `receditret` (IN `rpk` INT)  NO SQL
SELECT * FROM tblprecord WHERE tblprecord.property_no = rpk$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `recidshow` ()  NO SQL
SELECT tblprecord.property_no FROM tblprecord$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `recinvshow` (IN `rpk` INT)  NO SQL
SELECT tblproperty.inven_no,tblproperty.name,tblproperty.cost,tblproperty.status FROM tblprecord INNER JOIN tblproperty ON tblprecord.property_no = tblproperty.prop_no WHERE tblprecord.property_no = rpk$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `recshow` ()  NO SQL
SELECT tblprecord.property_no,tblprecord.signed,
ROUND(SUM(IF(tblproperty.status="UNDISPOSED",tblproperty.cost,0)),2) 
AS "Total Cost",COUNT(tblproperty.inven_no) AS "Quantity",tblprecord.receipt_type,tblprecord.par_ics_issued,tblprecord.date_acq FROM tblprecord LEFT JOIN tblproperty ON tblprecord.property_no = tblproperty.prop_no GROUP BY (tblprecord.property_no)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `recupdate` (IN `prpk` INT, IN `sign` VARCHAR(255), IN `rt` VARCHAR(255), IN `iss` VARCHAR(255), IN `da` VARCHAR(255))  NO SQL
UPDATE tblprecord SET tblprecord.signed = sign,tblprecord.receipt_type = rt,tblprecord.par_ics_issued = iss,tblprecord.date_acq = da WHERE tblprecord.property_no = prpk$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tbldisposal`
--

CREATE TABLE `tbldisposal` (
  `disp_id` int(11) NOT NULL,
  `inv_no` varchar(255) NOT NULL,
  `d_date` varchar(255) NOT NULL,
  `d_meth` varchar(255) NOT NULL,
  `d_remarks` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblemployee`
--

CREATE TABLE `tblemployee` (
  `emp_id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `contactno` varchar(255) NOT NULL,
  `email_add` varchar(255) NOT NULL,
  `pic_source` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblemployee`
--

INSERT INTO `tblemployee` (`emp_id`, `name`, `contactno`, `email_add`, `pic_source`) VALUES
(1, 'Axichaoss', '966488658765', 'Jibreels50@gmail.com', 'C:\\Users\\jibre\\Pictures\\53860951_1821530097951887_5658815649535754240_n.jpg'),
(4, 'asdasdasd', '9000', 'jibreels50@gmail.com', 'C:\\Users\\jibre\\Pictures\\Album Art\\TeamContribution.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `tbleqpcardid`
--

CREATE TABLE `tbleqpcardid` (
  `card_id` int(11) NOT NULL,
  `card_name` varchar(255) NOT NULL,
  `card_date` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbleqphistory`
--

CREATE TABLE `tbleqphistory` (
  `log_id` int(11) NOT NULL,
  `inven_no` int(11) NOT NULL,
  `chg_type` varchar(255) NOT NULL,
  `chg_date` varchar(255) NOT NULL,
  `chg_desc` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbleqplog`
--

CREATE TABLE `tbleqplog` (
  `log_id` int(11) NOT NULL,
  `r_date` varchar(255) NOT NULL,
  `mrd_to` varchar(255) NOT NULL,
  `inv_no` varchar(255) NOT NULL,
  `remarks` varchar(255) NOT NULL,
  `r_status` varchar(255) NOT NULL,
  `r_current` varchar(255) DEFAULT NULL,
  `Balance` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbleqplog`
--

INSERT INTO `tbleqplog` (`log_id`, `r_date`, `mrd_to`, `inv_no`, `remarks`, `r_status`, `r_current`, `Balance`) VALUES
(155, '9/27/2019', 'Axichaoss/DICT-BUILDING-ZC-Supply Room', 'INV-NOTE-92720192F', 'Property Record Created at 4:00 AM', 'GENERATED', 'Current', 50),
(156, '9/27/2019', 'Axichaoss/DICT-BUILDING-ZC-Supply Room', 'INV-NOTE-92720193O', 'Property Record Created at 4:00 AM', 'GENERATED', 'Current', 50),
(157, '9/27/2019', 'Axichaoss/DICT-BUILDING-ZC-Supply Room', 'INV-NOTE-92720194C', 'Property Record Created at 4:00 AM', 'GENERATED', 'Current', 50),
(158, '9/27/2019', 'Axichaoss/DICT-BUILDING-ZC-Supply Room', 'INV-NOTE-92720195U', 'Property Record Created at 4:00 AM', 'GENERATED', 'Current', 50),
(159, '9/27/2019', 'Axichaoss/DICT-BUILDING-ZC-Supply Room', 'INV-NOTE-92720196X', 'Property Record Created at 4:00 AM', 'GENERATED', 'Current', 50);

-- --------------------------------------------------------

--
-- Table structure for table `tbllinkcardtolog`
--

CREATE TABLE `tbllinkcardtolog` (
  `linkid` int(11) NOT NULL,
  `card_id` int(11) DEFAULT NULL,
  `inven_no` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbllocation`
--

CREATE TABLE `tbllocation` (
  `loc_id` int(11) NOT NULL,
  `location` varchar(255) NOT NULL,
  `province` varchar(255) NOT NULL,
  `l_room` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbllocation`
--

INSERT INTO `tbllocation` (`loc_id`, `location`, `province`, `l_room`) VALUES
(1, 'DICT-BUILDING-ZC', 'Zamboanga del Sur', 'Supply Room'),
(2, 'Sulu Harbourfront', 'Sulu', 'Docking Bay'),
(3, 'adasd', 'Zamboanga del Norte', 'ddd');

-- --------------------------------------------------------

--
-- Table structure for table `tblprecord`
--

CREATE TABLE `tblprecord` (
  `property_no` int(11) NOT NULL,
  `signed` varchar(255) NOT NULL,
  `receipt_type` varchar(255) NOT NULL,
  `par_ics_issued` varchar(255) NOT NULL,
  `date_acq` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tblproperty`
--

CREATE TABLE `tblproperty` (
  `inven_no` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `unit` varchar(255) NOT NULL,
  `type` varchar(255) NOT NULL,
  `remarks` varchar(255) NOT NULL,
  `article` varchar(255) NOT NULL,
  `cost` float NOT NULL,
  `description` varchar(255) NOT NULL,
  `loc_id` int(11) NOT NULL,
  `serialno_plateno` varchar(255) NOT NULL,
  `accp_id` int(11) NOT NULL,
  `acc_code` varchar(255) NOT NULL,
  `status` varchar(255) NOT NULL,
  `disp_no` int(11) DEFAULT NULL,
  `signed` varchar(255) NOT NULL,
  `rcpt_type` varchar(255) NOT NULL,
  `rcpt_iss` varchar(255) NOT NULL,
  `date_acq` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblproperty`
--

INSERT INTO `tblproperty` (`inven_no`, `name`, `unit`, `type`, `remarks`, `article`, `cost`, `description`, `loc_id`, `serialno_plateno`, `accp_id`, `acc_code`, `status`, `disp_no`, `signed`, `rcpt_type`, `rcpt_iss`, `date_acq`) VALUES
('INV-NOTE-92720192F', 'Notebooks', 'Piece', 'Furniture', 'Notebook for meeting', 'ART-9087612', 50, 'A 50 page notebook', 1, 'SN-456-2019', 1, '1-06-05-070', 'UNDISPOSED', NULL, 'Yes', 'PAR', 'Yes', '9/27/2019'),
('INV-NOTE-92720193O', 'Notebooks', 'Piece', 'Furniture', 'Notebook for meeting', 'ART-9087612', 50, 'A 50 page notebook', 1, 'SN-587-2019', 1, '1-06-05-070', 'UNDISPOSED', NULL, 'Yes', 'PAR', 'Yes', '9/27/2019'),
('INV-NOTE-92720194C', 'Notebooks', 'Piece', 'Furniture', 'Notebook for meeting', 'ART-9087612', 50, 'A 50 page notebook', 1, 'SN-387-2019', 1, '1-06-05-070', 'UNDISPOSED', NULL, 'Yes', 'PAR', 'Yes', '9/27/2019'),
('INV-NOTE-92720195U', 'Notebooks', 'Piece', 'Furniture', 'Notebook for meeting', 'ART-9087612', 50, 'A 50 page notebook', 1, 'SN-901-2019', 1, '1-06-05-070', 'UNDISPOSED', NULL, 'Yes', 'PAR', 'Yes', '9/27/2019'),
('INV-NOTE-92720196X', 'Notebooks', 'Piece', 'Furniture', 'Notebook for meeting', 'ART-9087612', 50, 'A 50 page notebook', 1, 'SN-607-2019', 1, '1-06-05-070', 'UNDISPOSED', NULL, 'Yes', 'PAR', 'Yes', '9/27/2019');

-- --------------------------------------------------------

--
-- Table structure for table `tbluser`
--

CREATE TABLE `tbluser` (
  `uname` varchar(255) NOT NULL,
  `password` varchar(255) DEFAULT NULL,
  `type` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbluser`
--

INSERT INTO `tbluser` (`uname`, `password`, `type`) VALUES
('admin', 'admin', 'PROP_OFFICER');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbldisposal`
--
ALTER TABLE `tbldisposal`
  ADD PRIMARY KEY (`disp_id`),
  ADD KEY `inv_no` (`inv_no`);

--
-- Indexes for table `tblemployee`
--
ALTER TABLE `tblemployee`
  ADD PRIMARY KEY (`emp_id`);

--
-- Indexes for table `tbleqpcardid`
--
ALTER TABLE `tbleqpcardid`
  ADD PRIMARY KEY (`card_id`);

--
-- Indexes for table `tbleqphistory`
--
ALTER TABLE `tbleqphistory`
  ADD PRIMARY KEY (`log_id`),
  ADD KEY `inven_no_2` (`inven_no`);

--
-- Indexes for table `tbleqplog`
--
ALTER TABLE `tbleqplog`
  ADD PRIMARY KEY (`log_id`),
  ADD KEY `inv_no` (`inv_no`);

--
-- Indexes for table `tbllinkcardtolog`
--
ALTER TABLE `tbllinkcardtolog`
  ADD PRIMARY KEY (`linkid`),
  ADD KEY `card_link` (`card_id`),
  ADD KEY `inv_link` (`inven_no`);

--
-- Indexes for table `tbllocation`
--
ALTER TABLE `tbllocation`
  ADD PRIMARY KEY (`loc_id`);

--
-- Indexes for table `tblprecord`
--
ALTER TABLE `tblprecord`
  ADD PRIMARY KEY (`property_no`);

--
-- Indexes for table `tblproperty`
--
ALTER TABLE `tblproperty`
  ADD PRIMARY KEY (`inven_no`),
  ADD KEY `disp_no` (`disp_no`);

--
-- Indexes for table `tbluser`
--
ALTER TABLE `tbluser`
  ADD PRIMARY KEY (`uname`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbldisposal`
--
ALTER TABLE `tbldisposal`
  MODIFY `disp_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tblemployee`
--
ALTER TABLE `tblemployee`
  MODIFY `emp_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbleqpcardid`
--
ALTER TABLE `tbleqpcardid`
  MODIFY `card_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbleqphistory`
--
ALTER TABLE `tbleqphistory`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbleqplog`
--
ALTER TABLE `tbleqplog`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=160;

--
-- AUTO_INCREMENT for table `tbllinkcardtolog`
--
ALTER TABLE `tbllinkcardtolog`
  MODIFY `linkid` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbllocation`
--
ALTER TABLE `tbllocation`
  MODIFY `loc_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tblprecord`
--
ALTER TABLE `tblprecord`
  MODIFY `property_no` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbldisposal`
--
ALTER TABLE `tbldisposal`
  ADD CONSTRAINT `tbldisposal_ibfk_1` FOREIGN KEY (`inv_no`) REFERENCES `tblproperty` (`inven_no`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `tbllinkcardtolog`
--
ALTER TABLE `tbllinkcardtolog`
  ADD CONSTRAINT `card_link` FOREIGN KEY (`card_id`) REFERENCES `tbleqpcardid` (`card_id`) ON DELETE CASCADE ON UPDATE NO ACTION,
  ADD CONSTRAINT `inv_link` FOREIGN KEY (`inven_no`) REFERENCES `tblproperty` (`inven_no`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
