namespace battleship_logic.Domain
{
    public class Ship
    {
        public int Size { get; private set; }

        public Ship(int size)
        {
            Size = size;
        }
    }
}