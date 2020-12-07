namespace Day05
{
    public class Seat
    {
        public int Column { get; set; }
        public int Row { get; set; }

        public int Id => Row * 8 + Column;
    }
}