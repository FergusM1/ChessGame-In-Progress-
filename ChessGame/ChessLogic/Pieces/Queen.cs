namespace ChessLogic
{
    public class Queen : Piece
    {
        public override PieceType Type => PieceType.Queen;
        public override Player Colour { get; }

        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.Up,
            Direction.Down,
            Direction.Left,
            Direction.Right,
            Direction.Up_Left,
            Direction.Up_Right,
            Direction.Down_Left,
            Direction.Down_Right
        };

        public Queen(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            Queen copy = new Queen(Colour);
            copy.HasMoved = HasMoved;
            return copy;
        }

        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirections(from, board, dirs).Select(to => new NormalMove(from, to));
        }
    }
}
