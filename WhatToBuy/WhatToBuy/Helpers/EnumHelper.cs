using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WhatToBuy.Helpers
{
    /// <summary>
    /// Класс-помошник для работы с перечислениями.
    /// </summary>
    public class EnumHelper
    {
        /// <summary>
        /// Получение описания элемента перечисления.
        /// </summary>
        /// <param name="value">Элемент перечисления.</param>
        /// <returns>Описание элемента перечисления.</returns>
        public static string GetEnumDescription(Enum value)
        {
            var fi = value.GetType().GetField(value.ToString());
            var attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes.Length > 0)
                return ((DescriptionAttribute)attributes[0]).Description;
            else
                return value.ToString();
        }

        /// <summary>
        /// Получение элемента перечисления по его описанию.
        /// </summary>
        /// <typeparam name="T">Тип перечисления.</typeparam>
        /// <param name="stringValue">Описание элемента перечисления.</param>
        /// <returns>Значение элемента перечисления.</returns>
        public static T GetEnumFromDescription<T>(string stringValue)
            where T : struct
        {
            foreach (object e in Enum.GetValues(typeof(T)))
                if (GetEnumDescription((Enum)e).ToLower().Equals(stringValue.ToLower()))
                    return (T)e;
            throw new ArgumentException("No matching enum value found.");
        }

        /// <summary>
        /// Получение списка описаний всех элементов перечисления.
        /// </summary>
        /// <param name="enumType">Тип перечисления.</param>
        /// <returns>Список описаний всех элементов перечисления.</returns>
        public static IEnumerable<string> GetEnumDescriptions(Type enumType)
        {
            var strings = new Collection<string>();
            foreach (Enum e in Enum.GetValues(enumType))
                strings.Add(GetEnumDescription(e));
            return strings;
        }

        /// <summary>
        /// Получить список значений перечислений с их описанием
        /// </summary>
        /// <param name="type">Тип перечисления</param>
        /// <returns>Список значений перечисления с их описанием</returns>
        public static List<KeyValuePair<Enum, string>> ToList(Type type)
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }

            List<KeyValuePair<Enum, string>> list = new List<KeyValuePair<Enum, string>>();
            Array enumValues = Enum.GetValues(type);

            foreach (Enum value in enumValues)
            {
                list.Add(new KeyValuePair<Enum, string>(value, GetEnumDescription(value)));
            }

            return list;
        }
    }
}
