namespace I3SolutionsTask3;

public static class Connect4
{

    private static int[,] board = new int[6, 7];
    private static int currentPlayer = 1;

    public static string Play(int column)
    {
        if (column < 0 || column >= 7)
            return "Invalid column!";


        if (IsGameFinished())
            return "Game has finished!";

        for (int row = 5; row >= 0; row--)
        {
            if (board[row, column] == 0)
            {
                board[row, column] = currentPlayer;


                string result = $"Player {currentPlayer} has a turn";


                if (IsWinningMove(row, column))
                    return $"Player {currentPlayer} wins!";


                currentPlayer = 3 - currentPlayer;


                return result;
            }
        }

        // Column is full
        return "Column full!";
    }

    public static void Reset()
    {
        board = new int[6, 7];
        currentPlayer = 1;
    }

    private static bool IsWinningMove(int row, int col)
    {//Checking all directions

        // Check horizontally
        for (int i = -3; i <= 0; ++i)
        {
            if (col + i < 0 || col + i + 3 > 6) continue;
            if (board[row, col + i] == currentPlayer &&
                board[row, col + i + 1] == currentPlayer &&
                board[row, col + i + 2] == currentPlayer &&
                board[row, col + i + 3] == currentPlayer)
            {
                return true;
            }
        }

        // Check vertically
        for (int i = -3; i <= 0; ++i)
        {
            if (row + i < 0 || row + i + 3 > 5) continue;
            if (board[row + i, col] == currentPlayer &&
                board[row + i + 1, col] == currentPlayer &&
                board[row + i + 2, col] == currentPlayer &&
                board[row + i + 3, col] == currentPlayer)
            {
                return true;
            }
        }

        // Check diagonally from top-left to bottom-right
        for (int i = -3; i <= 0; ++i)
        {
            if (row + i < 0 || row + i + 3 > 5 || col + i < 0 || col + i + 3 > 6) continue;
            if (board[row + i, col + i] == currentPlayer &&
                board[row + i + 1, col + i + 1] == currentPlayer &&
                board[row + i + 2, col + i + 2] == currentPlayer &&
                board[row + i + 3, col + i + 3] == currentPlayer)
            {
                return true;
            }
        }

        // Check diagonally from bottom-left to top-right
        for (int i = -3; i <= 0; ++i)
        {
            if (row - i > 5 || row - i - 3 < 0 || col + i < 0 || col + i + 3 > 6) continue;
            if (board[row - i, col + i] == currentPlayer &&
                board[row - i - 1, col + i + 1] == currentPlayer &&
                board[row - i - 2, col + i + 2] == currentPlayer &&
                board[row - i - 3, col + i + 3] == currentPlayer)
            {
                return true;
            }
        }

        return false;
    }


    private static bool IsGameFinished()
    {
        // Check if any player has won
        for (int row = 0; row < 6; ++row)
        {
            for (int col = 0; col < 7; ++col)
            {
                if (board[row, col] != 0 && IsWinningMove(row, col))
                {
                    return true;
                }
            }
        }

        // Check if board is full
        for (int col = 0; col < 7; ++col)
        {
            if (board[0, col] == 0)
            {
                return false;
            }
        }

        return true;
    }
}