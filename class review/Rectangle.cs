namespace class_review
{
    public class Rectangle
    {
        public decimal Length { get; set; }
        public decimal Width { get; set; }

        public Rectangle(decimal length, decimal width)
        {
            Length = length;
            Width = width;
        }
        public decimal Perim()
        {
            return 2 * Length + 2 * Width;
        }
        public decimal area()
        {
            return Length * Width;
        }
        public override string ToString()
        {
            return $"Rectangle: Length {Length}, Width{Width}";
        }
    }
}
