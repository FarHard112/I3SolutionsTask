
# Used Technologies
## Programming Language: C# ,Typescript
## Testing Framework: NUnit ,JEST
## IDE: Visual Studio

# Walking in the City Task 1
## The task simulates a walk in the city. A walk is considered valid if it takes exactly 10 minutes and the walker returns to the starting point.

### Methods
### IsValidWalk(char[] walk)
Takes an array of characters as an argument. Each character represents a direction ('n' for North, 's' for South, 'e' for East, and 'w' for West). The function returns true if the walk is valid, otherwise false.



# Find Outliner Task 2
## The objective is to find the outlier in an array of integers. The array contains either odd numbers and one even number, or even numbers and one odd number.

### Methods
### FindOutlinerMethod(int[] arr)
Takes an array of integers as an argument and returns the outlier.






# Connect 4 Task 3
## The goal of this task is to simulate a game of Connect 4 between two players.

### Methods
### Play(int column)
Drops a disc into a specified column. The function returns the status of the game after the move, indicating whose turn it is or if a player has won.
### Reset()
Resets the game board to its initial empty state.
### IsWinningMove(int row, int col)
 Checks whether the last move resulted in a win for the current player.
### IsGameFinished()
Checks whether the game has ended due to a win or a full board.
