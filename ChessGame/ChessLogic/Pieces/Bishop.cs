namespace ChessLogic
{
    public class Bishop : Piece
    {
        public override PieceType Type => PieceType.Bishop;
        public override Player Colour { get; }

        private static readonly Direction[] dirs = new Direction[]
        {
            Direction.Up_Left,
            Direction.Up_Right,
            Direction.Down_Left,
            Direction.Down_Right
        };


        public Bishop(Player colour)
        {
            Colour = colour;
        }

        public override Piece Copy()
        {
            Bishop copy = new Bishop(Colour);
            copy.HasMoved = HasMoved;
            return copy;
        }

        public override IEnumerable<Move> GetMoves(Position from, Board board)
        {
            return MovePositionsInDirections(from, board, dirs).Select(to => new NormalMove(from, to));
        }
    }
}
