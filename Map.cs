using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Map
    {
        public char[,] mapData;
        char WallChar = 'W';
        char FloorChar = ' ';

        public Map(int _size, char _wallChar)
        {
            mapData = new char[_size, _size];
            InitMap();
        }

        private void InitMap()
        {
            //Alles hier drin macht die Map ready to go
            Position oldCursorPosition = new Position(Console.GetCursorPosition().Top, Console.GetCursorPosition().Left);
            Console.SetCursorPosition(0, 0);
            Console.Write("Die Map wurde generiert");
            Console.SetCursorPosition(oldCursorPosition.y, oldCursorPosition.x);
        }
    }
}
