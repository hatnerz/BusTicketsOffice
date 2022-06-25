using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public static class Constants
    {
        public static string Directory = "data";
        public static string ErrorHead = "Помилка";
        public static string SuccessHead = "Успіх";
        public static string ConfirmHead = "Підтвердження";
        public static string ErrorPassangers = "Сталася помилка при завантаженні файлу (інформація про пасажирів). Файл не знайдено або некоректні дані";
        public static string ErrorCities = "Сталася помилка при завантаженні файлу (назви зупинок). Файл не знайдено або некоректні дані";
        public static string ErrorRoutes = "Сталася помилка при завантаженні файлу (інформація про рейси). Файл не знайдено або некоректні дані";
        public static string PathCities = Directory + "\\cities.json";
        public static string PathRoutes = Directory + "\\routes.json";
        public static string PathPassangers = Directory + "\\passangers.json";
    }
}
