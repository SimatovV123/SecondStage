using System.Collections.Generic;

namespace SecondStage
{
    //Класс Place описывает некую точку в пространстве относительно чего-то. Убрал избыточные направления
    //За положительные направления взял Северное, Западное и Вверх (правосторонняя ск)
    //Юг, Восток и Вниз - это те же направления соответсвтенно, но со знаком минус
    //Исходный метод разбил на три
    internal class Place
    {
        internal int North { get; private set; }
        internal int West { get; private set; }
        internal int Height { get; private set; }

        /// <summary>
        /// Задаем ось Север - Юг
        /// </summary>
        internal void ChangeNorthAxis(int newLocationReference, bool opposite)
        {
            North += opposite ? -newLocationReference : newLocationReference;
        }
        /// <summary>
        /// Задаем ось Запад - Восток
        /// </summary>
        internal void ChangeWestAxis(int newLocationReference, bool opposite)
        {
            West += opposite ? -newLocationReference : newLocationReference;
        }
        /// <summary>
        /// Задаем высотную ось
        /// </summary>
        internal void ChangeHeightAxis(int newLocationReference, bool opposite)
        {
            Height += opposite ? -newLocationReference : newLocationReference;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Place> places = new List<Place>();
            places.Add(new Place());

            places[0].ChangeNorthAxis(1, false);
            places[0].ChangeWestAxis(2, true);
            places[0].ChangeHeightAxis(5, true);

        }
    }
}
