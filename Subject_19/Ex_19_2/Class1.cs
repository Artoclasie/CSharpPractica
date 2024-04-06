using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_19_2
{
    /// <summary>
    /// Делегат для функций, вычисляющих характеристики фигур.
    /// </summary>
    /// <param name="radius">Радиус фигуры.</param>
    /// <returns>Значение характеристики фигуры.</returns>
    delegate double CalcFigure(double radius);

    internal class Class1
    {
        /// <summary>
        /// Метод для вычисления длины окружности.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        /// <returns>Длина окружности.</returns>
        public double Get_Length(double radius)
        {
            return 2 * Math.PI * radius;
        }

        /// <summary>
        /// Метод для вычисления площади круга.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <returns>Площадь круга.</returns>
        public double Get_Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Метод для вычисления объема шара.
        /// </summary>
        /// <param name="radius">Радиус шара.</param>
        /// <returns>Объем шара.</returns>
        public double Get_Volume(double radius)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
        }
    }
}

