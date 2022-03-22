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
-- База данных: `operator`
--

-- --------------------------------------------------------

--
-- Структура таблицы `info`
--

CREATE TABLE `info` (
  `id` int UNSIGNED NOT NULL,
  `ФИО` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Программа` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Дата принятия заказа` date NOT NULL,
  `Телефон` varchar(32) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Адрес подразделения` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Оформление` int NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Дамп данных таблицы `info`
--

INSERT INTO `info` (`id`, `ФИО`, `Программа`, `Дата принятия заказа`, `Телефон`, `Адрес подразделения`, `Оформление`) VALUES
(1, 'АНЮТКА МАЛЬЦЕВА', 'АВАСТ', '2022-03-31', '+79534913828', 'СЫРТЛАНОВОЙ', 1),
(2, '123', '123', '2022-03-31', '123', '123', 0),
(3, '1', '1', '2022-03-31', '1', '1', 0);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `info`
--
ALTER TABLE `info`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `info`
--
ALTER TABLE `info`
  MODIFY `id` int UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
