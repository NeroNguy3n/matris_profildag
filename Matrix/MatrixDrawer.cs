using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    partial class Program
    {
        /// <summary>
        /// Ritar ut matrisen på den nuvarande platsen där markören är
        /// </summary>
        /// <param name="m00">Det första elementet (rad 1, kolumn 1)</param>
        /// <param name="m01">Det andra elementet (rad 1, kolumn 2)</param>
        /// <param name="m10">Det tredje elementet (rad 2, kolumn 1)</param>
        /// <param name="m11">Det fjärde elementet (rad 2, kolumn 2)</param>
        public static void Draw2x2Matrix(float m00, float m01, float m10, float m11)
        {
            const int VALUE_LENGTH = 4;
            const int SPACER = 2;
            const int N = VALUE_LENGTH * 2 + SPACER + 1;

            const string FORMAT = "{0:0.##}";

            int cursorX = Console.CursorLeft;
            int cursorY = Console.CursorTop;

            Console.Write("┌");

            Console.SetCursorPosition(cursorX + N, cursorY++);
            Console.Write("┐");

            Console.SetCursorPosition(cursorX, cursorY);
            Console.Write("│");

            Console.Write(string.Format("{0,-4}  ", string.Format(FORMAT, m00)));
            Console.Write(string.Format("{0,4}", string.Format(FORMAT, m01)));

            Console.SetCursorPosition(cursorX + N, cursorY++);
            Console.Write("│");

            Console.SetCursorPosition(cursorX, cursorY);
            Console.Write("│");

            Console.SetCursorPosition(cursorX + N, cursorY++);
            Console.Write("│");

            Console.SetCursorPosition(cursorX, cursorY++);
            Console.Write("│");

            Console.Write(string.Format("{0,-4}  ", string.Format(FORMAT, m10)));
            Console.Write(string.Format("{0,4}", string.Format(FORMAT, m11)));
            Console.Write("│");

            Console.SetCursorPosition(cursorX, cursorY);
            Console.Write("└");

            Console.SetCursorPosition(cursorX + N, cursorY);
            Console.Write("┘");
        }

        public static void Draw2x2Matrix(float[,] m)
        {
            Draw2x2Matrix(m[0, 0], m[0, 1], m[1, 0], m[1, 1]);
        }
    }
}
