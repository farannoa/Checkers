using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Ex05.ConsoleUtils;

namespace Ex05.Logic
{
    public class GameLogic
    {
        public static void MovePiece(Player i_Player, Board i_Board, int i_RowLast, int i_ColLast, int i_RowNext, int i_ColNext)
        {
            Tile lastTile = i_Board.GetTile(i_RowLast, i_ColLast);
            Piece lastPiece = lastTile.GetPiece();
            Tile nextTile = i_Board.GetTile(i_RowNext, i_ColNext);
            lastPiece.Location = nextTile;
            lastTile.SetPiece(null);
            nextTile.SetPiece(lastPiece);

            if ((i_RowNext == i_Board.GetSize() - 1) || (i_RowNext == 0))
            {
                lastPiece.SetToKing();
            }

            if (Math.Abs(i_RowLast - i_RowNext) == 2)
            {
                int enemyRow = (i_RowNext + i_RowLast) / 2;
                int enemyCol = (i_ColNext + i_ColLast) / 2;
                Tile tileToRemove = i_Board.GetTile((enemyRow), (enemyCol));
                tileToRemove.GetPiece().GetPlayer().RemoveFromPiecesList(tileToRemove.GetPiece());
                tileToRemove.SetPiece(null);

                if (SinglePieceCanEat(i_Player, i_Board, lastPiece).Any())
                {
                    i_RowLast = lastPiece.Location.GetRow();
                    i_ColLast = lastPiece.Location.GetColumn();
                    if ((i_RowNext == i_Board.GetSize() - 1) || (i_RowNext == 0))
                    {
                        lastPiece.SetToKing();
                    }
                    MovePiece(i_Player, i_Board, i_RowLast, i_ColLast, i_RowNext, i_ColNext);
                }
            }
        }

        public static List<Tile> SinglePieceCanEat(Player i_Player, Board i_Board, Piece i_Piece)
        {
            int boardSize = i_Board.GetSize();
            List<Tile> optionsToMove = new List<Tile>();
            Tile currentTile = i_Piece.Location;
            int currentTileRow = currentTile.GetRow();
            int currentTileColumn = currentTile.GetColumn();
            Tile enemyTile = new Tile(-1, -1);
            Tile targetTile = new Tile(-1, -1);

            if (i_Player.Direction == "Up")
            {
                if ((currentTileRow - 2 >= 0) && (currentTileColumn + 2 < boardSize))
                {
                    enemyTile = i_Board.GetTile(currentTileRow - 1, currentTileColumn + 1);
                    targetTile = i_Board.GetTile(currentTileRow - 2, currentTileColumn + 2);
                    if (CanJumpAndEat(i_Player, enemyTile, targetTile))
                    {
                        optionsToMove.Add(targetTile);
                    }
                }

                if ((currentTileRow - 2 >= 0) && (currentTileColumn - 2 >= 0))
                {
                    enemyTile = i_Board.GetTile(currentTileRow - 1, currentTileColumn - 1);
                    targetTile = i_Board.GetTile(currentTileRow - 2, currentTileColumn - 2);
                    if (CanJumpAndEat(i_Player, enemyTile, targetTile))
                    {
                        optionsToMove.Add(targetTile);
                    }
                }

                if (i_Piece.IsKing())
                {
                    if ((currentTileRow + 2 < boardSize && currentTileColumn + 2 < boardSize))
                    {
                        enemyTile = i_Board.GetTile(currentTileRow + 1, currentTileColumn + 1);
                        targetTile = i_Board.GetTile(currentTileRow + 2, currentTileColumn + 2);
                        if (CanJumpAndEat(i_Player, enemyTile, targetTile))
                        {
                            optionsToMove.Add(targetTile);
                        }
                    }

                    if (currentTileRow + 2 < boardSize && (currentTileColumn - 2 >= 0))
                    {
                        enemyTile = i_Board.GetTile(currentTileRow + 1, currentTileColumn - 1);
                        targetTile = i_Board.GetTile(currentTileRow + 2, currentTileColumn - 2);
                        if (CanJumpAndEat(i_Player, enemyTile, targetTile))
                        {
                            optionsToMove.Add(targetTile);
                        }
                    }
                }
            }
            else
            {
                if ((currentTileRow + 2 < boardSize) && (currentTileColumn + 2 < boardSize))
                {
                    enemyTile = i_Board.GetTile(currentTileRow + 1, currentTileColumn + 1);
                    targetTile = i_Board.GetTile(currentTileRow + 2, currentTileColumn + 2);
                    if (CanJumpAndEat(i_Player, enemyTile, targetTile))
                    {
                        optionsToMove.Add(targetTile);
                    }
                }

                if ((currentTileRow + 2 < boardSize) && (currentTileColumn - 2 >= 0))
                {
                    enemyTile = i_Board.GetTile(currentTileRow + 1, currentTileColumn - 1);
                    targetTile = i_Board.GetTile(currentTileRow + 2, currentTileColumn - 2);
                    if (CanJumpAndEat(i_Player, enemyTile, targetTile))
                    {
                        optionsToMove.Add(targetTile);
                    }
                }

                if (i_Piece.IsKing())
                {
                    if ((currentTileRow - 2 >= 0 && currentTileColumn + 2 < boardSize))
                    {
                        enemyTile = i_Board.GetTile(currentTileRow - 1, currentTileColumn + 1);
                        targetTile = i_Board.GetTile(currentTileRow - 2, currentTileColumn + 2);
                        if (CanJumpAndEat(i_Player, enemyTile, targetTile))
                        {
                            optionsToMove.Add(targetTile);
                        }
                    }

                    if (currentTileRow - 2 >= 0 && (currentTileColumn - 2 >= 0))
                    {
                        enemyTile = i_Board.GetTile(currentTileRow - 1, currentTileColumn - 1);
                        targetTile = i_Board.GetTile(currentTileRow - 2, currentTileColumn - 2);
                        if (CanJumpAndEat(i_Player, enemyTile, targetTile))
                        {
                            optionsToMove.Add(targetTile);
                        }
                    }
                }
            }

            return optionsToMove;
        }

        public static List<Tile> SinglePieceCanMove(Player i_Player, Board i_Board, Piece i_Piece)
        {
            List<Tile> optionsToMove = new List<Tile>();
            int boardSize = i_Board.GetSize();
            Tile currentTile = i_Piece.Location;
            int currentTileRow = currentTile.GetRow();
            int currentTileColumn = currentTile.GetColumn();
            Tile enemyTile = new Tile(-1, -1);
            Tile targetTile = new Tile(-1, -1);

            if (i_Player.Direction == "Up")
            {
                if ((currentTileRow - 1 >= 0) && (currentTileColumn + 1 < boardSize))
                {
                    targetTile = i_Board.GetTile(currentTileRow - 1, currentTileColumn + 1);
                    if (CanJump(i_Player, targetTile))
                    {
                        optionsToMove.Add(targetTile);
                    }
                }

                if ((currentTileRow - 1 >= 0) && (currentTileColumn - 1 >= 0))
                {
                    targetTile = i_Board.GetTile(currentTileRow - 1, currentTileColumn - 1);
                    if (CanJump(i_Player, targetTile))
                    {
                        optionsToMove.Add(targetTile);
                    }
                }

                if (i_Piece.IsKing())
                {
                    if ((currentTileRow + 1 < boardSize && currentTileColumn + 1 < boardSize))
                    {
                        targetTile = i_Board.GetTile(currentTileRow + 1, currentTileColumn + 1);
                        if (CanJump(i_Player, targetTile))
                        {
                            optionsToMove.Add(targetTile);
                        }
                    }

                    if (currentTileRow + 1 < boardSize && (currentTileColumn - 1 >= 0))
                    {
                        targetTile = i_Board.GetTile(currentTileRow + 1, currentTileColumn - 1);
                        if (CanJump(i_Player, targetTile))
                        {
                            optionsToMove.Add(targetTile);
                        }
                    }
                }
            }
            else
            {
                if ((currentTileRow + 1 < boardSize) && (currentTileColumn + 1 < boardSize))
                {
                    targetTile = i_Board.GetTile(currentTileRow + 1, currentTileColumn + 1);
                    if (CanJump(i_Player, targetTile))
                    {
                        optionsToMove.Add(targetTile);
                    }
                }

                if ((currentTileRow + 1 < boardSize) && (currentTileColumn - 1 >= 0))
                {
                    targetTile = i_Board.GetTile(currentTileRow + 1, currentTileColumn - 1);
                    if (CanJump(i_Player, targetTile))
                    {
                        optionsToMove.Add(targetTile);
                    }
                }

                if (i_Piece.IsKing())
                {
                    if ((currentTileRow - 1 >= 0 && currentTileColumn + 1 < boardSize))
                    {
                        targetTile = i_Board.GetTile(currentTileRow - 1, currentTileColumn + 1);
                        if (CanJump(i_Player, targetTile))
                        {
                            optionsToMove.Add(targetTile);
                        }
                    }

                    if (currentTileRow - 1 >= 0 && (currentTileColumn - 1 >= 0))
                    {
                        targetTile = i_Board.GetTile(currentTileRow - 1, currentTileColumn - 1);
                        if (CanJump(i_Player, targetTile))
                        {
                            optionsToMove.Add(targetTile);
                        }
                    }
                }
            }

            return optionsToMove;
        }

        public static bool IsLegalMove(Player i_Player, Board i_Board, int i_RowSource, int i_ColSource, int i_RowDest, int i_ColDest)
        {
            bool isLegal = true;
            int directionOffset = 1;
            int boardSize = i_Board.GetSize();
            Tile sourceTile = i_Board.GetTile(i_RowSource, i_ColSource);
            Tile destTile = i_Board.GetTile(i_RowDest, i_ColDest);

            if (i_Player.Direction == "Up")
            {
                directionOffset = -1;
            }

            if (sourceTile.IsOccupied())
            {
                if (!sourceTile.GetPiece().GetPlayer().Shape.Equals(i_Player.Shape))
                {
                    isLegal = false;
                }

                if (GetHaveToMoves(i_Player, i_Board).Any())
                {

                    if ((Math.Abs(i_RowSource - i_RowDest) != 2) || (Math.Abs(i_ColSource - i_ColDest) != 2))
                    {
                        isLegal = false;
                    }
                    else
                    {
                        int pieceToEatLocationRow = (i_RowSource + i_RowDest) / 2;
                        int pieceToEatLocationCol = (i_ColSource + i_ColDest) / 2;
                        if(!sourceTile.GetPiece().IsKing())
                        {
                            if(i_RowSource + directionOffset != pieceToEatLocationRow)
                            {
                                isLegal = false;
                            }
                            else
                            {
                                isLegal = CanJumpAndEat(
                                    i_Player,
                                    i_Board.GetTile(pieceToEatLocationRow, pieceToEatLocationCol),
                                    destTile);
                            }
                        }
                        else
                        {
                            isLegal = CanJumpAndEat(
                                i_Player,
                                i_Board.GetTile(pieceToEatLocationRow, pieceToEatLocationCol),
                                destTile);
                        }
                    }
                }
                else
                {
                    if (GetLegalMoves(i_Player, i_Board).Any() && (Math.Abs(i_RowSource - i_RowDest) != 1) || (Math.Abs(i_ColSource - i_ColDest) != 1))
                    {
                        isLegal = false;
                    }
                    else
                    {
                        if (!sourceTile.GetPiece().IsKing())
                        {
                            if (i_RowSource + directionOffset != i_RowDest)
                            {
                                isLegal = false;
                            }
                            else
                            {
                                isLegal = CanJump(i_Player, destTile);
                            }
                        }
                        else
                        {
                            isLegal = CanJump(i_Player, destTile);
                        }
                    }
                }
            }
            else
            {
                isLegal = false;
            }

            return isLegal;
        }

        public static bool AnyLegalMoves(Player i_Player, Board i_Board)
        {

            return GetHaveToMoves(i_Player, i_Board).Any() || GetLegalMoves(i_Player, i_Board).Any();
        }

        public static List<Piece> GetHaveToMoves(Player i_Player, Board i_Board)
        {
            List<Piece> validTiles = new List<Piece>();
            List<Piece> playerPieces = i_Player.GetPiecesList();

            foreach (Piece piece in playerPieces)
            {
                if (SinglePieceCanEat(i_Player, i_Board, piece).Any())
                {
                    validTiles.Add(piece);
                }
            }

            return validTiles;
        }

        public static List<Piece> GetLegalMoves(Player i_Player, Board i_Board)
        {
            List<Piece> validTiles = new List<Piece>();
            List<Piece> playerPieces = i_Player.GetPiecesList();
            int boardSize = i_Board.GetSize();

            if(i_Player.Direction == "Up")
            {
                foreach (Piece piece in playerPieces)
                {
                    Tile currentTile = piece.Location;
                    int currentTileRow = currentTile.GetRow();
                    int currentTileColumn = currentTile.GetColumn();

                    if(currentTileColumn + 1 < boardSize && currentTileRow - 1 >= 0)
                    {
                        Tile tileToCheck = i_Board.GetTile(currentTileRow - 1, currentTileColumn + 1);
                        if(!tileToCheck.IsOccupied())
                        {
                            validTiles.Add(piece);
                        }
                    }

                    if(currentTileColumn - 1 >= 0 && currentTileRow - 1 >= 0)
                    {
                        Tile tileToCheck = i_Board.GetTile(currentTileRow - 1, currentTileColumn - 1);
                        if(!tileToCheck.IsOccupied())
                        {

                            validTiles.Add(piece);
                        }
                    }

                    if(currentTile.GetPiece().IsKing())
                    {
                        if(currentTileColumn + 1 < boardSize && currentTileRow + 1 < boardSize)
                        {
                            Tile tileToCheck = i_Board.GetTile(currentTileRow + 1, currentTileColumn + 1);
                            if(!tileToCheck.IsOccupied())
                            {
                                validTiles.Add(piece);
                            }
                        }

                        if(currentTileColumn - 1 >= 0 && currentTileRow + 1 < boardSize)
                        {
                            Tile tileToCheck = i_Board.GetTile(currentTileRow + 1, currentTileColumn - 1);
                            if(!tileToCheck.IsOccupied())
                            {
                                validTiles.Add(piece);
                            }
                        }
                    }
                }
            }
            else
            {
                foreach(Piece piece in playerPieces)
                {
                    Tile currentTile = piece.Location;
                    int currentTileRow = currentTile.GetRow();
                    int currentTileColumn = currentTile.GetColumn();

                    if(currentTileColumn + 1 < boardSize && currentTileRow + 1 < boardSize)
                    {
                        Tile tileToCheck = i_Board.GetTile(currentTileRow + 1, currentTileColumn + 1);
                        if(!tileToCheck.IsOccupied())
                        {
                            validTiles.Add(piece);
                        }
                    }

                    if(currentTileColumn - 1 >= 0 && currentTileRow + 1 < boardSize)
                    {
                        Tile tileToCheck = i_Board.GetTile(currentTileRow + 1, currentTileColumn - 1);
                        if(!tileToCheck.IsOccupied())
                        {
                            validTiles.Add(piece);
                        }
                    }

                    if(currentTile.GetPiece().IsKing())
                    {
                        if(currentTileColumn + 1 < boardSize && currentTileRow - 1 >= 0)
                        {
                            Tile tileToCheck = i_Board.GetTile(currentTileRow - 1, currentTileColumn + 1);
                            if(!tileToCheck.IsOccupied())
                            {
                                validTiles.Add(piece);
                            }
                        }

                        if (currentTileColumn - 1 >= 0 && currentTileRow - 1 >= 0)
                        {
                            Tile tileToCheck = i_Board.GetTile(currentTileRow - 1, currentTileColumn - 1);
                            if (!tileToCheck.IsOccupied())
                            {
                                validTiles.Add(piece);
                            }
                        }
                    }
                }
            }

            return validTiles;
        }

        public static bool IsEnemyTile(Player i_Player, Tile i_TileToCheck)
        {
            bool isEnemy = false;

            if (i_TileToCheck.IsOccupied())
            {
                char tileShape = i_TileToCheck.GetPiece().GetShape();
                if (!i_Player.KingShape.Equals(tileShape) && (!i_Player.Shape.Equals(tileShape)))
                {
                    isEnemy = true;
                }
            }

            return isEnemy;
        }

        public static bool CanJumpAndEat(Player i_Player, Tile i_EnemyTile, Tile i_DestTile)
        {
            bool canJump = IsEnemyTile(i_Player, i_EnemyTile);
            if (i_DestTile.IsOccupied())
            {
                canJump = false;
            }

            return canJump;
        }

        public static bool CanJump(Player i_Player, Tile i_DestTile)
        {

            return !i_DestTile.IsOccupied();
        }

        public static string ComputerPlay(Player i_Computer, Board i_Board)
        {
            string computerMove = "";

            if (AnyLegalMoves(i_Computer, i_Board))
            {
                Random rnd = new Random();
                List<Piece> haveToEatPieces = GetHaveToMoves(i_Computer, i_Board);

                if (haveToEatPieces.Any())
                {
                    Piece randomPiece = haveToEatPieces[rnd.Next(haveToEatPieces.Count() - 1)];
                    List<Tile> options = SinglePieceCanEat(i_Computer, i_Board, randomPiece);
                    Tile tile = options[rnd.Next(options.Count() - 1)];
                    int sourceRow = randomPiece.Location.GetRow();
                    int sourceCol = randomPiece.Location.GetColumn();
                    int targetRow = tile.GetRow();
                    int targetCol = tile.GetColumn();
                    computerMove = ConvertMoveToString(sourceRow, sourceCol, targetRow, targetCol);
                    MovePiece(i_Computer, i_Board, sourceRow, sourceCol, targetRow, targetCol);
                }
                else
                {
                    List<Piece> legalMoves = GetLegalMoves(i_Computer, i_Board);
                    Piece randomPiece = legalMoves[rnd.Next(legalMoves.Count() - 1)];
                    List<Tile> options = SinglePieceCanMove(i_Computer, i_Board, randomPiece);
                    Tile tile = options[rnd.Next(options.Count() - 1)];
                    int sourceRow = randomPiece.Location.GetRow();
                    int sourceCol = randomPiece.Location.GetColumn();
                    int targetRow = tile.GetRow();
                    int targetCol = tile.GetColumn();
                    computerMove = ConvertMoveToString(sourceRow, sourceCol, targetRow, targetCol);
                    MovePiece(i_Computer, i_Board, sourceRow, sourceCol, targetRow, targetCol);
                }
            }
            else
            {
                computerMove = "Q";
            }

            return computerMove;
        }

        public static string ConvertMoveToString(int i_SourceRow, int i_SourceColumn, int i_RowPlacement, int i_ColumnPlacement)
        {
            StringBuilder computerMove = new StringBuilder();

            computerMove.AppendFormat("{0}{1}>{2}{3}", (char)(i_SourceColumn + 65), (char)(i_SourceRow + 97), (char)(i_ColumnPlacement + 65), (char)(i_RowPlacement + 97));

            return computerMove.ToString();
        }
    }
}
