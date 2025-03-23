namespace ChessLogic
{
    public class Rook : Piece
    {
        public override PieceType Type => PieceType.Rook;
        public override Player Colour { get; }

        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.Up,
            Direction.Down,
            Direction.Left,
            Direction.Right
        };

        public Rook(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            Rook copy = new Rook(Colour);
            copy.HasMoved = HasMoved;
            return copy;
        }

        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirections(from, board, dirs).Select(to => new NormalMove(from, to));
        }
    }
}
