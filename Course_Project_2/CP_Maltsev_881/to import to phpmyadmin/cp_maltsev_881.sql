-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Апр 02 2022 г., 04:46
-- Версия сервера: 8.0.24
-- Версия PHP: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `cp_maltsev_881`
--

-- --------------------------------------------------------

--
-- Структура таблицы `clients`
--

CREATE TABLE `clients` (
  `id` int UNSIGNED NOT NULL,
  `id сотрудника` int NOT NULL,
  `Наименование предприятия` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ФИО клиента` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Контакты` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Структура таблицы `info`
--

CREATE TABLE `info` (
  `id` int UNSIGNED NOT NULL,
  `id клиента` int NOT NULL,
  `id сотрудника` int NOT NULL,
  `id программы` int NOT NULL,
  `Дата принятия заказа` date NOT NULL,
  `Телефон` varchar(32) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Адрес подразделения` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Оформление` int NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Структура таблицы `progs`
--

CREATE TABLE `progs` (
  `id` int UNSIGNED NOT NULL,
  `Программа` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Количество` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Структура таблицы `staff`
--

CREATE TABLE `staff` (
  `id` int UNSIGNED NOT NULL,
  `id клиента` int NOT NULL,
  `ФИО` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Должность` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Контакты` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id сотрудника` (`id сотрудника`);

--
-- Индексы таблицы `info`
--
ALTER TABLE `info`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id клиента` (`id клиента`),
  ADD KEY `id сотрудника` (`id сотрудника`) USING BTREE,
  ADD KEY `id программы` (`id программы`) USING BTREE;

--
-- Индексы таблицы `progs`
--
ALTER TABLE `progs`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`id`),
  ADD KEY `id сотрудника` (`id клиента`),
  ADD KEY `id клиента` (`id клиента`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `info`
--
ALTER TABLE `info`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `progs`
--
ALTER TABLE `progs`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `staff`
--
ALTER TABLE `staff`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
