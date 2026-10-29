-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: localhost    Database: csta_sched_db
-- ------------------------------------------------------
-- Server version	8.0.46

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_classrooms`
--

DROP TABLE IF EXISTS `tbl_classrooms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_classrooms` (
  `room_id` int NOT NULL AUTO_INCREMENT,
  `room_name` varchar(50) NOT NULL,
  `room_type` varchar(50) DEFAULT NULL,
  `capacity` int DEFAULT NULL,
  `status` varchar(20) DEFAULT 'Available',
  PRIMARY KEY (`room_id`),
  UNIQUE KEY `room_name` (`room_name`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_classrooms`
--

LOCK TABLES `tbl_classrooms` WRITE;
/*!40000 ALTER TABLE `tbl_classrooms` DISABLE KEYS */;
INSERT INTO `tbl_classrooms` VALUES (1,'Lab 1','Tech Room',40,'Working'),(2,'Lab 2','Comlab',40,'Working'),(3,'Room 301','Lecture',45,'Not Working'),(7,'Lab 3','Laboratory',35,'Maintenance'),(8,'Lab 4','Comlab',35,'Working'),(9,'Room 302','Lecture',40,'Not Working'),(10,'Lab 5','Tech Lab',35,'Working'),(11,'Room 305','Lecture',40,'Working'),(12,'Room 304','Lecture',35,'Working'),(13,'Room 303','Lecture',40,'Working'),(14,'Office 1','Office',15,'Working'),(15,'Office 2','Office',15,'Working'),(16,'Office 3','Office',15,'Working'),(17,'Room 306','Lecture',30,'Working'),(18,'Lab 6','Comlab',30,'Working'),(19,'Lab 7','Comlab',40,'Working');
/*!40000 ALTER TABLE `tbl_classrooms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_logs`
--

DROP TABLE IF EXISTS `tbl_logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_logs` (
  `log_id` int NOT NULL AUTO_INCREMENT,
  `action` varchar(255) NOT NULL,
  `details` text,
  `log_date` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `performed_by` varchar(100) DEFAULT 'Unknown',
  PRIMARY KEY (`log_id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_logs`
--

LOCK TABLES `tbl_logs` WRITE;
/*!40000 ALTER TABLE `tbl_logs` DISABLE KEYS */;
INSERT INTO `tbl_logs` VALUES (1,'Add Schedule','A new class schedule was added.','2026-09-26 09:44:20','System Administrator'),(2,'Add Schedule','A new class schedule was added.','2026-09-26 09:52:55','John Chris Villanueva'),(3,'Add Schedule','A new class schedule was added.','2026-09-26 10:09:54','System Administrator'),(4,'Delete Schedule','Deleted schedule ID 72','2026-09-26 10:10:30','System Administrator'),(5,'Add Schedule','A new class schedule was added.','2026-09-26 11:08:57','John Chris Villanueva'),(6,'Add Schedule','A new class schedule was added.','2026-09-26 11:38:21','System Administrator'),(7,'Add Schedule','A new class schedule was added.','2026-09-27 03:41:16','John Chris Villanueva'),(8,'Add Room','A new room Lab 6 was added.','2026-09-27 03:58:56','Unknown'),(9,'Add Schedule','A new class schedule was added.','2026-09-29 04:32:14','System Administrator'),(10,'Add Room','A new room Lab 7 was added.','2026-10-24 10:13:01','Unknown'),(11,'Add Schedule','A new class schedule was added.','2026-10-24 10:13:31','System Administrator'),(12,'Add Schedule','A new class schedule was added.','2026-10-24 10:14:37','System Administrator');
/*!40000 ALTER TABLE `tbl_logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_schedules`
--

DROP TABLE IF EXISTS `tbl_schedules`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_schedules` (
  `schedule_id` int NOT NULL AUTO_INCREMENT,
  `room_id` int NOT NULL,
  `instructor_id` int NOT NULL,
  `subject_code` varchar(20) NOT NULL,
  `subject_description` varchar(100) DEFAULT NULL,
  `day_of_week` varchar(15) NOT NULL,
  `time_start` time NOT NULL,
  `time_end` time NOT NULL,
  PRIMARY KEY (`schedule_id`),
  KEY `room_id` (`room_id`),
  KEY `instructor_id` (`instructor_id`),
  CONSTRAINT `tbl_schedules_ibfk_1` FOREIGN KEY (`room_id`) REFERENCES `tbl_classrooms` (`room_id`) ON DELETE CASCADE,
  CONSTRAINT `tbl_schedules_ibfk_2` FOREIGN KEY (`instructor_id`) REFERENCES `tbl_users` (`user_id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=97 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_schedules`
--

LOCK TABLES `tbl_schedules` WRITE;
/*!40000 ALTER TABLE `tbl_schedules` DISABLE KEYS */;
INSERT INTO `tbl_schedules` VALUES (57,2,2,'HEHE','','Wednesday','23:41:10','23:50:10'),(67,1,6,'NET2','','Thursday','17:24:11','18:24:10'),(69,2,7,'NWP','','Thursday','17:26:52','18:26:51'),(75,1,8,'AWE','','Saturday','18:29:34','19:29:33'),(77,15,7,'POO','','Saturday','16:06:56','17:06:56'),(78,14,6,'TG','','Saturday','16:27:35','17:27:34'),(80,11,8,'HEH','','Sunday','16:48:42','17:48:41'),(84,1,8,'EAS','','Saturday','21:11:52','23:11:52'),(85,1,2,'WSA','','Sunday','17:18:25','18:18:25'),(86,15,2,'WES','','Saturday','17:19:33','19:19:33'),(87,1,2,'WEA','','Sunday','05:31:25','07:29:25'),(88,8,7,'ERMN','','Saturday','17:44:05','19:44:05'),(89,1,8,'MON','','Monday','17:52:31','19:52:30'),(90,2,1,'HEV','','Saturday','18:09:29','20:09:28'),(91,17,8,'WAD','','Tuesday','19:08:37','21:08:37'),(92,15,6,'AYT','','Saturday','19:38:04','20:38:04'),(93,8,8,'ETA','','Sunday','11:40:55','12:40:54'),(94,1,6,'GEAT','','Tuesday','12:31:31','13:31:31'),(95,19,6,'CUH','','Friday','19:13:06','20:13:06'),(96,16,7,'HEA','','Saturday','20:14:12','20:14:12');
/*!40000 ALTER TABLE `tbl_schedules` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_users`
--

DROP TABLE IF EXISTS `tbl_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_users` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `role` varchar(20) NOT NULL DEFAULT 'Faculty',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_users`
--

LOCK TABLES `tbl_users` WRITE;
/*!40000 ALTER TABLE `tbl_users` DISABLE KEYS */;
INSERT INTO `tbl_users` VALUES (1,'admin','admin','System Administrator','Admin','2026-09-20 04:09:08'),(2,'faculty','faculty','Sample Instructor','Instructor','2026-09-20 04:09:08'),(6,'prof_john','password123','John Professor','Professor','2026-09-21 11:03:16'),(7,'cahrl','cahrl','Cahrl Steven Bajado','Admin','2026-09-22 16:07:30'),(8,'jc','jc','John Chris Villanueva','Instructor','2026-09-22 16:21:04');
/*!40000 ALTER TABLE `tbl_users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-10-29 19:37:42
