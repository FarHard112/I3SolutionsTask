export class Connect4 {
  private board: number[][];
  private currentPlayer: number;

  constructor() {
    this.board = Array.from({ length: 6 }, () => new Array<number>(7).fill(0));
    this.currentPlayer = 1;
  }

  public play(column: number): string {
    if (column < 0 || column >= 7) return "Invalid column!";
    if (this.isGameFinished()) return "Game has finished!";

    for (let row = 5; row >= 0; row--) {
      if (this.board[row][column] === 0) {
        this.board[row][column] = this.currentPlayer;
        const result = `Player ${this.currentPlayer} has a turn`;

        if (this.isWinningMove(row, column)) {
          return `Player ${this.currentPlayer} wins!`;
        }

        this.currentPlayer = 3 - this.currentPlayer;
        return result;
      }
    }

    return "Column full!";
  }

  public reset(): void {
    this.board = Array.from({ length: 6 }, () => new Array(7).fill(0));
    this.currentPlayer = 1;
  }

  private isWinningMove(row: number, col: number): boolean {
    for (let i = -3; i <= 0; ++i) {
      // Check horizontally
      if (
        col + i >= 0 &&
        col + i + 3 < 7 &&
        this.board[row][col + i] === this.currentPlayer &&
        this.board[row][col + i + 1] === this.currentPlayer &&
        this.board[row][col + i + 2] === this.currentPlayer &&
        this.board[row][col + i + 3] === this.currentPlayer
      ) {
        return true;
      }

      // Check vertically
      if (
        row + i >= 0 &&
        row + i + 3 < 6 &&
        this.board[row + i][col] === this.currentPlayer &&
        this.board[row + i + 1][col] === this.currentPlayer &&
        this.board[row + i + 2][col] === this.currentPlayer &&
        this.board[row + i + 3][col] === this.currentPlayer
      ) {
        return true;
      }

      // Check diagonally from top-left to bottom-right
      if (
        row + i >= 0 &&
        row + i + 3 < 6 &&
        col + i >= 0 &&
        col + i + 3 < 7 &&
        this.board[row + i][col + i] === this.currentPlayer &&
        this.board[row + i + 1][col + i + 1] === this.currentPlayer &&
        this.board[row + i + 2][col + i + 2] === this.currentPlayer &&
        this.board[row + i + 3][col + i + 3] === this.currentPlayer
      ) {
        return true;
      }

      // Check diagonally from bottom-left to top-right
      if (
        row - i < 6 &&
        row - i - 3 >= 0 &&
        col + i >= 0 &&
        col + i + 3 < 7 &&
        this.board[row - i][col + i] === this.currentPlayer &&
        this.board[row - i - 1][col + i + 1] === this.currentPlayer &&
        this.board[row - i - 2][col + i + 2] === this.currentPlayer &&
        this.board[row - i - 3][col + i + 3] === this.currentPlayer
      ) {
        return true;
      }
    }

    return false;
  } 

  private isGameFinished(): boolean {
    for (let row = 0; row < 6; row++) {
      for (let col = 0; col < 7; col++) {
        if (this.board[row][col] !== 0 && this.isWinningMove(row, col)) {
          return true;
        }
      }
    }
    return false;
  }
}
