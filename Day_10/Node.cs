namespace Day_10
{
    public class Node
    {
        public Node(char value, int rowIndex, int columnIndex)
        {
            Value = value;
            Position = new Position(rowIndex, columnIndex);
        }
        
        public char Value { get; set; }
        public Position Position { get; set; }
        public bool IsGround => Value == '.';
    }
}