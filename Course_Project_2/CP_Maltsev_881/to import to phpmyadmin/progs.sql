-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Мар 21 2022 г., 05:57
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
-- База данных: `progs`
--

-- --------------------------------------------------------

--
-- Структура таблицы `orderprogs`
--

CREATE TABLE `orderprogs` (
  `id` int UNSIGNED NOT NULL,
  `Программа` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Количество` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

-- --------------------------------------------------------

--
-- Структура таблицы `progs1`
--

CREATE TABLE `progs1` (
  `id` int UNSIGNED NOT NULL,
  `Программа` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Количество` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `orderprogs`
--
ALTER TABLE `orderprogs`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `progs1`
--
ALTER TABLE `progs1`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `orderprogs`
--
ALTER TABLE `orderprogs`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `progs1`
--
ALTER TABLE `progs1`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
