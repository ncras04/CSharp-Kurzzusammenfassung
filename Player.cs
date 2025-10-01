namespace ConsoleApp2
{
    internal struct Player
    {
        public Position Position;
        public char Char;
        public ConsoleColor Color;
        bool HasKey = false;


        public Player(Position _pos, char _char, ConsoleColor _color)
        {
            Position = _pos;
            Char = _char;
            Color = _color;
        }

        public void PrintPlayer()
        {
            Console.SetCursorPosition(Position.x, Position.y);
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.WriteLine(Char);
            Console.ForegroundColor = oldColor;
        }
        public void ChangePlayerPosition(Position _dir)
        {
            Position = new Position(Position.x + _dir.x, Position.y + _dir.y);
        }

        public void GetKey()
        {
            HasKey = true;
        }
    }
}
