CREATE DATABASE IF NOT EXISTS csta_sched_db;
USE csta_sched_db;

-- 1. Users Table (Handles logins for Admin and Faculty/Instructor)
CREATE TABLE IF NOT EXISTS tbl_users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    full_name VARCHAR(100) NOT NULL,
    role VARCHAR(20) NOT NULL DEFAULT 'Faculty',
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- 2. Classrooms Table
CREATE TABLE IF NOT EXISTS tbl_classrooms (
    room_id INT AUTO_INCREMENT PRIMARY KEY,
    room_name VARCHAR(50) NOT NULL UNIQUE,
    building VARCHAR(50),
    capacity INT,
    status VARCHAR(20) DEFAULT 'Available'
);

-- 3. Schedules Table (Core module for schedule management and conflict checking)
CREATE TABLE IF NOT EXISTS tbl_schedules (
    schedule_id INT AUTO_INCREMENT PRIMARY KEY,
    room_id INT NOT NULL,
    instructor_id INT NOT NULL,
    subject_code VARCHAR(20) NOT NULL,
    subject_description VARCHAR(100),
    day_of_week VARCHAR(15) NOT NULL,
    time_start TIME NOT NULL,
    time_end TIME NOT NULL,
    FOREIGN KEY (room_id) REFERENCES tbl_classrooms(room_id) ON DELETE CASCADE,
    FOREIGN KEY (instructor_id) REFERENCES tbl_users(user_id) ON DELETE CASCADE
);

-- Insert Default Admin and Faculty Test Accounts
INSERT INTO tbl_users (username, password, full_name, role) VALUES 
('admin', 'admin123', 'System Administrator', 'Admin'),
('faculty1', 'faculty123', 'Sample Instructor', 'Faculty');

-- Insert Sample Classrooms
INSERT INTO tbl_classrooms (room_name, building, capacity) VALUES 
('Lab 1', 'Main Building', 40),
('Lab 2', 'Main Building', 40),
('Room 301', 'Annex Building', 50);

ALTER TABLE tbl_classrooms CHANGE COLUMN building room_type VARCHAR(50);

SHOW databases 
USE csta_sched_db
SHOW TABLES

SELECT COUNT(*) FROM tbl_schedules WHERE day_of_week = @day_of_week AND 
(room_id = @room_id OR instructor_id = @instructor_id) AND 
(@time_start < time_end AND @time_end > time_start)

CREATE TABLE tbl_logs (
    log_id INT AUTO_INCREMENT PRIMARY KEY,
    action VARCHAR(255) NOT NULL,
    details TEXT,
    log_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

INSERT INTO tbl_logs (action, details) VALUES ('Test Action', 'Manually inserted test log');

ALTER TABLE tbl_logs ADD COLUMN performed_by VARCHAR(100) DEFAULT 'Unknown';

TRUNCATE TABLE tbl_logs;
