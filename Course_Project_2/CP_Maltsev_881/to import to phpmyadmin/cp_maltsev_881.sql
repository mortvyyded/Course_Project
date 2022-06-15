-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Июн 08 2022 г., 08:54
-- Версия сервера: 5.7.38
-- Версия PHP: 8.0.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `vkr_maltsev_881`
--

-- --------------------------------------------------------

--
-- Структура таблицы `clients`
--

CREATE TABLE `clients` (
  `id` int(10) UNSIGNED NOT NULL,
  `Наименование предприятия` varchar(100) NOT NULL,
  `ФИО клиента` varchar(100) NOT NULL,
  `Номер телефона` varchar(32) NOT NULL,
  `Адрес электронной почты` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `clients`
--

INSERT INTO `clients` (`id`, `Наименование предприятия`, `ФИО клиента`, `Номер телефона`, `Адрес электронной почты`) VALUES
(1, 'ICL', 'DMITRY', '228-228-228', 'SOBA4KA@MAIL.RU');

-- --------------------------------------------------------

--
-- Структура таблицы `info`
--

CREATE TABLE `info` (
  `id` int(10) UNSIGNED NOT NULL,
  `ФИО клиента` varchar(50) NOT NULL,
  `Дата принятия заказа` date NOT NULL,
  `Программа` varchar(255) NOT NULL,
  `Телефон` varchar(32) NOT NULL,
  `Адрес подразделения` varchar(100) NOT NULL,
  `Адрес электронной почты` varchar(50) NOT NULL,
  `Сообщение` text NOT NULL,
  `Оформление` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `info`
--

INSERT INTO `info` (`id`, `ФИО клиента`, `Дата принятия заказа`, `Программа`, `Телефон`, `Адрес подразделения`, `Адрес электронной почты`, `Сообщение`, `Оформление`) VALUES
(5, 'DMITRY', '2022-06-07', 'DOTA2', '228-228-228', 'KAZAN', 'SOBA4KA@MAIL.RU', 'YA NENAVIZHU ZHIZN\'!', 1),
(6, 'DMITRY', '2022-06-07', 'DOTA2', '228-228-228', 'KAZAN', 'SOBA4KA@MAIL.RU', 'YA NENAVIZHU ZHIZN\'!', 2),
(7, 'DMITRY', '2022-06-07', 'DOTA2', '228-228-228', 'KAZAN', 'SOBA4KA@MAIL.RU', 'YA NENAVIZHU ZHIZN\'!', 0),
(8, '1', '2022-06-08', '1', '1', '1', '1', '0', 0),
(9, '1', '2022-06-08', '1', '1', '1', '1', '123', 0);

-- --------------------------------------------------------

--
-- Структура таблицы `progs`
--

CREATE TABLE `progs` (
  `id` int(10) UNSIGNED NOT NULL,
  `Программа` varchar(100) NOT NULL,
  `Количество` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `progs`
--

INSERT INTO `progs` (`id`, `Программа`, `Количество`) VALUES
(1, 'DOTA2', 1488);

-- --------------------------------------------------------

--
-- Структура таблицы `staff`
--

CREATE TABLE `staff` (
  `id` int(10) UNSIGNED NOT NULL,
  `ФИО сотрудника` varchar(100) NOT NULL,
  `Должность` varchar(100) NOT NULL,
  `Номер телефона` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `staff`
--

INSERT INTO `staff` (`id`, `ФИО сотрудника`, `Должность`, `Номер телефона`) VALUES
(1, 'DMITRY', 'KRUTOY', '228-228-228\r\nSOBA4KA@MAIL.RU');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `clients`
--
ALTER TABLE `clients`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `info`
--
ALTER TABLE `info`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `progs`
--
ALTER TABLE `progs`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `clients`
--
ALTER TABLE `clients`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `info`
--
ALTER TABLE `info`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT для таблицы `progs`
--
ALTER TABLE `progs`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `staff`
--
ALTER TABLE `staff`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
