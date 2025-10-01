using ConsoleApp2;

namespace Zusammenfassung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player(new Position(5, 5), 'P', ConsoleColor.Yellow);
            Player mySecondPlayer = new Player(new Position(7, 7), 'D', ConsoleColor.Cyan);

            Player[] players = { myPlayer, mySecondPlayer };

            for (int i = 0; i < players.Length; i++)
            {
                players[i].PrintPlayer();
            }


            Map map = new Map(5, 'W');

            if (map.mapData[4, 4] == 'K')
            {
                myPlayer.GetKey();
            }
        }
    }
}
