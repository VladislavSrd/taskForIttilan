﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace taskForIttilan.models
{
    public class FakeDataSource
    {
        private static readonly List<string> _dataSource = new List<string> { 
            "Австралия", "Австрия", "Азербайджан", "Албания", "Алжир", "Англия",
            "Ангола", "Андорра", "Антигуа и Барбуда", "Аргентина", "Армения", "Афганистан",
            "Багамы", "Бангладеш", "Барбадос", "Бахрейн", "Белиз", "Белоруссия", "Бельгия", 
            "Бенин", "Болгария", "Боливия", "Босния и Герцеговина", "Ботсвана", "Бразилия", 
            "Бруней", "Буркина Фасо", "Бурунди", "Бутан", "Вануату", "Ватикан", "Великобритания", 
            "Венгрия", "Венесуэла", "Восточный Тимор", "Вьетнам", "Габон", "Гаити", "Гайана", "Гамбия",
            "Гана", "Гватемала", "Гвинея", "Гвинея-Бисау", "Германия", "Гондурас", "Гонконг", "Гренада",
            "Греция", "Грузия", "Дания", "Джибути", "Доминика", "Доминиканская Республика", "ДР Конго", 
            "Евросоюз", "Египет", "Замбия", "Зимбабве", "Израиль", "Индия", "Индонезия", "Иордания", "Ирак",
            "Иран", "Ирландия", "Исландия", "Испания", "Италия", "Йемен", "Кабо-Верде", "Казахстан", "Камбоджа",
            "Камерун", "Канада", "Катар", "Кения", "Кипр", "Киргизия", "Кирибати", "Китай", "Колумбия", "Коморские Острова", 
            "Косово", "Коста-Рика", "Кот-д’Ивуар", "Куба", "Кувейт", "Лаос", "Латвия", "Лесото", "Либерия", "Ливан", "Ливия", 
            "Литва", "Лихтенштейн", "Люксембург", "Маврикий", "Мавритания", "Мадагаскар", "Макао", "Македония", "Малави", "Малайзия",
            "Мали", "Мальдивы", "Мальта", "Марокко", "Маршалловы Острова", "Мексика", "Микронезия, Федеративные штаты", "Мозамбик",
            "Молдавия", "Монако", "Монголия", "Мьянма", "Намибия", "Науру", "Непал", "Нигер", "Нигерия", "Нидерланды", "Никарагуа", 
            "Новая Зеландия", "Норвегия", "Объединённые Арабские Эмираты", "Оман", "Остров Мэн", "Пакистан", "Палау", "Панама", 
            "Папуа-Новая Гвинея", "Парагвай", "Перу", "Польша", "Португалия", "Пуэрто-Рико", "Республика Конго", "Россия", 
            "Руанда", "Румыния", "Сальвадор", "Самоа", "Сан-Марино", "Сан-Томе и Принсипи", "Саудовская Аравия", "Свазиленд",
            "Северная Корея", "Сейшелы", "Сенегал", "Сент-Винсент и Гренадины", "Сент-Киттс и Невис", "Сент-Люсия", "Сербия", 
            "Сингапур", "Сирия", "Словакия", "Словения", "Соломоновы Острова", "Сомали", "СССР", "Судан", "Суринам", "США", 
            "Сьерра-Леоне", "Таджикистан", "Таиланд", "Тайвань", "Танзания", "Того", "Тонга", "Тринидад и Тобаго", "Тувалу", 
            "Тунис", "Туркмения", "Турция", "Уганда", "Узбекистан", "Украина", "Уругвай", "Уэльс", "Фареры", "Фиджи", "Филиппины", 
            "Финляндия", "Франция", "Хорватия", "Центрально-Африканская Республика", "Чад", "Черногория", "Чехия", "Чили",
            "Швейцария", "Швеция", "Шотландия", "Шри-Ланка", "Эквадор", "Экваториальная Гвинея", "Эритрея", "Эстония", "Эфиопия",
            "Южная Корея", "Южно-Африканская Республика", "Ямайка", "Япония"
        };

        public List<string> Get(string term)
        {
            if (_dataSource.Any(o => o.ToLower().StartsWith(term.ToLower())))
            {
                return _dataSource.Where(o => o.ToLower().StartsWith(term.ToLower())).ToList();
            }

            List<string> tmp = new List<string>();
            return tmp;
        }
    }
}