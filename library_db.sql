-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 12, 2026 at 05:32 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `book_id` int(10) UNSIGNED NOT NULL,
  `isbn` varchar(30) NOT NULL,
  `title` varchar(255) NOT NULL,
  `author` varchar(150) NOT NULL,
  `category_id` int(10) UNSIGNED NOT NULL,
  `total_quantity` int(11) NOT NULL DEFAULT 1,
  `available_qty` int(11) NOT NULL DEFAULT 1,
  `is_deleted` tinyint(1) NOT NULL DEFAULT 0,
  `added_by` int(10) UNSIGNED DEFAULT NULL
) ;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`book_id`, `isbn`, `title`, `author`, `category_id`, `total_quantity`, `available_qty`, `is_deleted`, `added_by`) VALUES
(1, '978-0-13-468599-1', 'Introduction to Algorithms', 'Thomas H. Cormen', 6, 5, 2, 0, 2),
(2, '978-0-13-235088-4', 'Clean Code: A Handbook of Agile Software Craftsmanship', 'Robert C. Martin', 4, 3, 2, 0, 2),
(3, '978-1-59327-928-8', 'Python Crash Course', 'Eric Matthes', 4, 4, 3, 0, 3),
(4, '978-0-134-68599-9', 'Database System Concepts', 'Abraham Silberschatz', 4, 3, 1, 0, 2),
(5, '978-0-262-03384-8', 'Artificial Intelligence: A Modern Approach', 'Stuart Russell', 3, 2, 0, 1, 3),
(6, 'asd', 'asd', 'asd', 1, 1, 1, 0, 4);

-- --------------------------------------------------------

--
-- Table structure for table `borrow_records`
--

CREATE TABLE `borrow_records` (
  `record_id` int(10) UNSIGNED NOT NULL,
  `user_id` int(10) UNSIGNED NOT NULL,
  `book_id` int(10) UNSIGNED NOT NULL,
  `borrow_date` date NOT NULL,
  `due_date` date NOT NULL,
  `return_date` date DEFAULT NULL,
  `status` enum('Borrowed','Returned','Overdue') NOT NULL DEFAULT 'Borrowed',
  `processed_by` int(10) UNSIGNED DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `updated_at` datetime NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `borrow_records`
--

INSERT INTO `borrow_records` (`record_id`, `user_id`, `book_id`, `borrow_date`, `due_date`, `return_date`, `status`, `processed_by`, `remarks`, `created_at`, `updated_at`) VALUES
(1, 4, 1, '2026-02-07', '2026-02-14', NULL, 'Borrowed', NULL, NULL, '2026-02-07 09:30:00', '2026-02-07 09:30:00'),
(2, 5, 2, '2026-02-07', '2026-02-14', NULL, 'Borrowed', NULL, NULL, '2026-02-07 10:15:00', '2026-02-07 10:15:00'),
(3, 6, 3, '2026-02-08', '2026-02-15', '2026-02-10', 'Returned', 2, 'Returned in good condition', '2026-02-08 11:20:00', '2026-02-10 14:30:00'),
(4, 7, 4, '2026-02-09', '2026-02-16', NULL, 'Borrowed', NULL, NULL, '2026-02-09 13:45:00', '2026-02-09 13:45:00'),
(5, 8, 5, '2026-02-10', '2026-02-17', NULL, 'Borrowed', NULL, NULL, '2026-02-10 08:00:00', '2026-02-10 08:00:00'),
(6, 9, 1, '2026-02-12', '2026-02-19', NULL, 'Borrowed', NULL, NULL, '2026-02-12 12:28:58', '2026-02-12 12:28:58');

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `category_id` int(10) UNSIGNED NOT NULL,
  `category_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`category_id`, `category_name`) VALUES
(1, 'Fiction'),
(5, 'History'),
(7, 'Literature'),
(6, 'Mathematics'),
(2, 'Non-Fiction'),
(8, 'Reference'),
(3, 'Science'),
(4, 'Technology');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `student_id` int(10) UNSIGNED NOT NULL,
  `user_id` int(10) UNSIGNED NOT NULL,
  `student_number` varchar(20) NOT NULL,
  `course` varchar(100) DEFAULT NULL,
  `year_level` tinyint(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`student_id`, `user_id`, `student_number`, `course`, `year_level`) VALUES
(1, 4, '2024-0001', 'Computer Science', 3),
(2, 5, '2024-0002', 'Information Technology', 2),
(3, 6, '2024-0003', 'Computer Engineering', 4),
(4, 7, '2024-0004', 'Data Science', 1),
(5, 8, '2024-0005', 'Software Engineering', 3);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(10) UNSIGNED NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `full_name` varchar(100) NOT NULL,
  `role` enum('Admin','Librarian','Student') NOT NULL,
  `is_active` tinyint(1) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password`, `full_name`, `role`, `is_active`) VALUES
(1, 'admin', 'admin123', 'System Administrator', 'Admin', 1),
(2, 'librarian', '321321', 'Maria Santos', 'Librarian', 1),
(3, 'librarian1', '123123', 'Juan Dela Cruz', 'Librarian', 1),
(4, 'liblib', '123123', 'Anna Reyes', 'Librarian', 1),
(5, 'stud001', '456456', 'Carlos Mendoza', 'Student', 1),
(6, 'stud002', '456456', 'Sofia Garcia', 'Student', 1),
(7, 'stud003', '234234', 'Miguel Torres', 'Student', 1),
(8, 'stud004', '234234', 'Isabella Ramos', 'Student', 1),
(9, 'stud005', '123123', 'Diego Morales', 'Student', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`book_id`),
  ADD UNIQUE KEY `uq_isbn` (`isbn`),
  ADD KEY `fk_books_category` (`category_id`),
  ADD KEY `fk_books_added_by` (`added_by`);

--
-- Indexes for table `borrow_records`
--
ALTER TABLE `borrow_records`
  ADD PRIMARY KEY (`record_id`),
  ADD KEY `fk_br_user` (`user_id`),
  ADD KEY `fk_br_book` (`book_id`),
  ADD KEY `fk_br_processed_by` (`processed_by`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`category_id`),
  ADD UNIQUE KEY `uq_category_name` (`category_name`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`student_id`),
  ADD UNIQUE KEY `uq_student_number` (`student_number`),
  ADD UNIQUE KEY `uq_student_user` (`user_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `uq_username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `books`
--
ALTER TABLE `books`
  MODIFY `book_id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `borrow_records`
--
ALTER TABLE `borrow_records`
  MODIFY `record_id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `category_id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `student_id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `books`
--
ALTER TABLE `books`
  ADD CONSTRAINT `fk_books_added_by` FOREIGN KEY (`added_by`) REFERENCES `users` (`user_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_books_category` FOREIGN KEY (`category_id`) REFERENCES `categories` (`category_id`) ON UPDATE CASCADE;

--
-- Constraints for table `borrow_records`
--
ALTER TABLE `borrow_records`
  ADD CONSTRAINT `fk_br_book` FOREIGN KEY (`book_id`) REFERENCES `books` (`book_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_br_processed_by` FOREIGN KEY (`processed_by`) REFERENCES `users` (`user_id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_br_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON UPDATE CASCADE;

--
-- Constraints for table `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `fk_students_user` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
