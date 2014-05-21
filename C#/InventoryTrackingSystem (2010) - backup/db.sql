/*
SQLyog Ultimate v8.55 
MySQL - 5.5.25a : Database - hec_its
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`hec_its` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `hec_its`;

/*Table structure for table `its_company` */

DROP TABLE IF EXISTS `its_company`;

CREATE TABLE `its_company` (
  `company_code` varchar(10) NOT NULL,
  `company_name` varchar(255) DEFAULT NULL,
  `company_desc` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`company_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `its_company` */

/*Table structure for table `its_employee` */

DROP TABLE IF EXISTS `its_employee`;

CREATE TABLE `its_employee` (
  `emp_code` int(11) NOT NULL,
  `emp_title` varchar(10) DEFAULT NULL,
  `emp_name` varchar(255) DEFAULT NULL,
  `company_code` varchar(10) DEFAULT NULL,
  `emp_designation` varchar(20) DEFAULT NULL,
  `emp_phone` varchar(10) DEFAULT NULL,
  `emp_email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`emp_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `its_employee` */

/*Table structure for table `its_item_category` */

DROP TABLE IF EXISTS `its_item_category`;

CREATE TABLE `its_item_category` (
  `cat_code` varchar(255) NOT NULL,
  `cat_name` varchar(255) DEFAULT NULL,
  `stock_code` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`cat_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `its_item_category` */

/*Table structure for table `its_location` */

DROP TABLE IF EXISTS `its_location`;

CREATE TABLE `its_location` (
  `location_code` varchar(10) NOT NULL,
  `location_name` varchar(255) DEFAULT NULL,
  `location_desc` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`location_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `its_location` */

/*Table structure for table `its_log` */

DROP TABLE IF EXISTS `its_log`;

CREATE TABLE `its_log` (
  `log_code` int(11) NOT NULL AUTO_INCREMENT,
  `log_desc` varchar(255) DEFAULT NULL,
  `user_code` int(11) DEFAULT NULL,
  `action_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`log_code`),
  KEY `FK_log` (`user_code`),
  CONSTRAINT `FK_log` FOREIGN KEY (`user_code`) REFERENCES `its_users` (`user_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `its_log` */

/*Table structure for table `its_login_history` */

DROP TABLE IF EXISTS `its_login_history`;

CREATE TABLE `its_login_history` (
  `history_code` int(11) NOT NULL AUTO_INCREMENT,
  `user_code` int(11) DEFAULT NULL,
  `login_time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`history_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `its_login_history` */

/*Table structure for table `its_stock` */

DROP TABLE IF EXISTS `its_stock`;

CREATE TABLE `its_stock` (
  `stock_code` varchar(10) NOT NULL,
  `stock_name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`stock_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `its_stock` */

/*Table structure for table `its_stock_trans` */

DROP TABLE IF EXISTS `its_stock_trans`;

CREATE TABLE `its_stock_trans` (
  `trans_code` int(11) NOT NULL,
  `stock_code` varchar(10) NOT NULL,
  `item_cat` varchar(255) DEFAULT NULL,
  `item_name` varchar(50) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `value` float DEFAULT NULL,
  `trans_type` varchar(3) DEFAULT NULL,
  `serial_code` varchar(50) DEFAULT NULL,
  `stick_code` varchar(50) DEFAULT NULL,
  `desc` varchar(500) DEFAULT NULL,
  `belongs_to` int(11) DEFAULT NULL COMMENT 'emp_code',
  `brand` varchar(20) DEFAULT NULL,
  `model` varchar(50) DEFAULT NULL,
  `trans_date` date DEFAULT NULL,
  `location_code` varchar(10) DEFAULT NULL,
  `company_code` varchar(10) DEFAULT NULL,
  `ref_no` varchar(20) DEFAULT NULL,
  `remark` varchar(255) DEFAULT NULL,
  `action_date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`trans_code`,`stock_code`),
  KEY `FK_stock_trans` (`company_code`),
  KEY `FK_stock_trans_emp` (`belongs_to`),
  KEY `FK_stock_trans_stock` (`stock_code`),
  KEY `FK_stock_trans_cat` (`item_cat`),
  KEY `FK_stock_trans_location` (`location_code`),
  CONSTRAINT `FK_stock_trans` FOREIGN KEY (`company_code`) REFERENCES `its_company` (`company_code`),
  CONSTRAINT `FK_stock_trans_cat` FOREIGN KEY (`item_cat`) REFERENCES `its_item_category` (`cat_code`),
  CONSTRAINT `FK_stock_trans_emp` FOREIGN KEY (`belongs_to`) REFERENCES `its_employee` (`emp_code`),
  CONSTRAINT `FK_stock_trans_location` FOREIGN KEY (`location_code`) REFERENCES `its_location` (`location_code`),
  CONSTRAINT `FK_stock_trans_stock` FOREIGN KEY (`stock_code`) REFERENCES `its_stock` (`stock_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `its_stock_trans` */

/*Table structure for table `its_user_role` */

DROP TABLE IF EXISTS `its_user_role`;

CREATE TABLE `its_user_role` (
  `user_role_code` int(2) NOT NULL,
  `user_role_desc` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`user_role_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `its_user_role` */

/*Table structure for table `its_users` */

DROP TABLE IF EXISTS `its_users`;

CREATE TABLE `its_users` (
  `user_code` int(11) NOT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `user_role_id` int(2) DEFAULT NULL,
  PRIMARY KEY (`user_code`),
  KEY `FK_users` (`user_role_id`),
  CONSTRAINT `FK_users` FOREIGN KEY (`user_role_id`) REFERENCES `its_user_role` (`user_role_code`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `its_users` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
