
//-- phpMyAdmin SQL Dump
//-- version 4.4.15.10
//-- https://www.phpmyadmin.net
//--
//-- Хост: localhost
//-- Время создания: Окт 26 2018 г., 07:46
//-- Версия сервера: 5.5.60-MariaDB
//-- Версия PHP: 5.4.16

//SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
//SET time_zone = "+00:00";


///*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
///*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
///*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
///*!40101 SET NAMES utf8mb4 */;
///*
//--
//-- База данных: `simple`
//--

//-- --------------------------------------------------------

//--
//-- Структура таблицы `simple`
//--

//CREATE TABLE IF NOT EXISTS `simple` (
//  `id` int (11) NOT NULL,
//  `simple` int (11) NOT NULL
//) ENGINE=InnoDB DEFAULT CHARSET=latin1;

//-- --------------------------------------------------------

//--
//-- Структура таблицы `simpleBackup`
//--

//CREATE TABLE IF NOT EXISTS `simpleBackup` (
//  `id` int (11) NOT NULL,
//  `simple` int (11) NOT NULL
//) ENGINE=InnoDB DEFAULT CHARSET=latin1;

//--
//-- Индексы сохранённых таблиц
//--

//--
//-- Индексы таблицы `simple`
//--
//ALTER TABLE `simple`
//  ADD PRIMARY KEY(`id`);

//--
//-- Индексы таблицы `simpleBackup`
//--
//ALTER TABLE `simpleBackup`
//  ADD PRIMARY KEY(`id`);

//--
//-- AUTO_INCREMENT для сохранённых таблиц
//--

//--
//-- AUTO_INCREMENT для таблицы `simple`
//--
//ALTER TABLE `simple`
//  MODIFY `id` int (11) NOT NULL AUTO_INCREMENT;
//--
//-- AUTO_INCREMENT для таблицы `simpleBackup`
//--
//ALTER TABLE `simpleBackup`
//  MODIFY `id` int (11) NOT NULL AUTO_INCREMENT;
///*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
///*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
///*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;