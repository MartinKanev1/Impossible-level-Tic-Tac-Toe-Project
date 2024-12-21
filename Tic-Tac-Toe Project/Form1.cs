using System;
using System.Diagnostics;

namespace Tic_Tac_Toe_Project
{
    public partial class Form1 : Form
    {

        private string[,] board = new string[3, 3];
        private Random rnd = new Random();
        private Difficulty gameDifficulty;
        private PlayerType Player;
        private PlayerType AIPlayer;
        private Button[,] buttonGrid = new Button[3, 3];

        public Form1()
        {
            InitializeComponent();

        }

        public enum Difficulty
        {
            easy,
            hard
        }

        public enum PlayerType
        {
            X,
            O
        }


        private void InitializeGame()
        {
            
            bool isXSelected = checkedListBox2.GetItemCheckState(0) == CheckState.Checked;
            bool isOSelected = checkedListBox2.GetItemCheckState(1) == CheckState.Checked;

            if (isXSelected && !isOSelected)
            {
                Player = PlayerType.X;
                AIPlayer = PlayerType.O;
            }
            else if (isOSelected && !isXSelected)
            {
                Player = PlayerType.O;
                AIPlayer = PlayerType.X;
            }
            else
            {
                MessageBox.Show("Please select exactly one option: X or O.");
                return;
            }

           
            bool isEasySelected = checkedListBox1.GetItemCheckState(0) == CheckState.Checked;
            bool isHardSelected = checkedListBox1.GetItemCheckState(1) == CheckState.Checked;

            if (isEasySelected && !isHardSelected)
            {
                gameDifficulty = Difficulty.easy;
            }
            else if (isHardSelected && !isEasySelected)
            {
                gameDifficulty = Difficulty.hard;
            }
            else
            {
                MessageBox.Show("Please select exactly one option: easy or hard.");
                return;
            }

            
            if (Player == PlayerType.O)
            {
                AIMove(); 
            }
        }









        private bool CheckGameStatus()
        {
            
            for (int i = 0; i < 3; i++)
            {
                
                if (!string.IsNullOrEmpty(board[i, 0]) && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    MessageBox.Show($"Row {i} victory: {board[i, 0]}");
                    EndGame($"{board[i, 0]} wins!");
                    return true;
                }

                
                if (!string.IsNullOrEmpty(board[0, i]) && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    MessageBox.Show($"Column {i} victory: {board[0, i]}");
                    EndGame($"{board[0, i]} wins!");
                    return true;
                }
            }

            
            if (!string.IsNullOrEmpty(board[0, 0]) && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                MessageBox.Show($"Diagonal 1 victory: {board[0, 0]}");
                EndGame($"{board[0, 0]} wins!");
                return true;
            }

            if (!string.IsNullOrEmpty(board[0, 2]) && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                MessageBox.Show($"Diagonal 2 victory: {board[0, 2]}");
                EndGame($"{board[0, 2]} wins!");
                return true;
            }

            
            foreach (string cell in board)
            {
                if (string.IsNullOrEmpty(cell))
                {
                    return false; 
                }
            }

            MessageBox.Show("Draw");
            EndGame("It's a draw!");
            return true;
        }




        private void EndGame(string message)
        {
            MessageBox.Show(message, "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RestartGame();
        }




        private void btn_restart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void RestartGame()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    buttonGrid[row, col].Enabled = true;
                    buttonGrid[row, col].Text = string.Empty;
                    board[row, col] = null; 
                }
            }
        }




        private void PlayerMove(object sender, EventArgs e)
        {
            var button = (Button)sender;

            
            button.Text = Player.ToString();
            button.Enabled = false;

            // Намираме реда и колоната на бутона в buttonGrid
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (buttonGrid[row, col] == button)
                    {
                        
                        board[row, col] = Player.ToString();

                       

                        
                        if (!CheckGameStatus())
                        {
                            AIMove();
                        }
                        return;
                    }
                }
            }
        }







        private void AIMove()
        {
            if (gameDifficulty == Difficulty.easy)
            {
                
                List<Button> freeButtons = new List<Button>();
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        if (string.IsNullOrEmpty(board[row, col])) 
                        {
                            freeButtons.Add(buttonGrid[row, col]);
                        }
                    }
                }

                if (freeButtons.Count > 0)
                {
                    
                    int index = rnd.Next(freeButtons.Count);
                    Button aiButton = freeButtons[index];

                    
                    aiButton.Text = AIPlayer.ToString();
                    aiButton.Enabled = false;

                    
                    for (int row = 0; row < 3; row++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            if (buttonGrid[row, col] == aiButton)
                            {
                                board[row, col] = AIPlayer.ToString();

                                

                                CheckGameStatus();
                                return;
                            }
                        }
                    }
                }
            }
            else
            {
                
                AIMoveHard();
            }
        }




        private void EnableGameButtons()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    buttonGrid[row, col].Enabled = true;
                }
            }
        }



        private void btm_start_Click(object sender, EventArgs e)
        {

            EnableGameButtons();

            
            btm_start.Enabled = false;

            
            InitializeGame();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            buttonGrid[0, 0] = button1;
            buttonGrid[0, 1] = button2;
            buttonGrid[0, 2] = button3;
            buttonGrid[1, 0] = button4;
            buttonGrid[1, 1] = button5;
            buttonGrid[1, 2] = button6;
            buttonGrid[2, 0] = button7;
            buttonGrid[2, 1] = button8;
            buttonGrid[2, 2] = button9;

            
            foreach (Button button in buttonGrid)
            {
                button.Enabled = false;
            }

            
            btm_start.Enabled = true;
        }


        

        private int EvaluateBoard()
        {
            
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    if (board[i, 0] == AIPlayer.ToString()) return +10;
                    if (board[i, 0] == Player.ToString()) return -10;
                }
            }

            
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    if (board[0, i] == AIPlayer.ToString()) return +10;
                    if (board[0, i] == Player.ToString()) return -10;
                }
            }

            
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                if (board[0, 0] == AIPlayer.ToString()) return +10;
                if (board[0, 0] == Player.ToString()) return -10;
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                if (board[0, 2] == AIPlayer.ToString()) return +10;
                if (board[0, 2] == Player.ToString()) return -10;
            }

            
            return 0;
        }





        private bool IsMovesLeft()
        {
            foreach (string cell in board)
            {
                if (string.IsNullOrEmpty(cell))
                    return true;
            }
            return false;
        }





        private int Minimax(int depth, bool isMaximizingPlayer, int alpha, int beta)
        {
            int score = EvaluateBoard();

            
            if (score == 10) return score - depth; 
            if (score == -10) return score + depth; 

            
            if (!IsMovesLeft()) return 0;

            if (isMaximizingPlayer)
            {
                int best = int.MinValue;

                
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        if (string.IsNullOrEmpty(board[row, col]))
                        {
                            board[row, col] = AIPlayer.ToString();
                            best = Math.Max(best, Minimax(depth + 1, false, alpha, beta));
                            board[row, col] = null;

                            alpha = Math.Max(alpha, best);
                            if (beta <= alpha)
                                break;
                        }
                    }
                }
                return best;
            }
            else
            {
                int best = int.MaxValue;

               
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        if (string.IsNullOrEmpty(board[row, col]))
                        {
                            board[row, col] = Player.ToString();
                            best = Math.Min(best, Minimax(depth + 1, true, alpha, beta));
                            board[row, col] = null;

                            beta = Math.Min(beta, best);
                            if (beta <= alpha)
                                break;
                        }
                    }
                }
                return best;
            }
        }



        private void AIMoveHard()
        {
            int bestValue = int.MinValue;
            int bestRow = -1, bestCol = -1;

            
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (string.IsNullOrEmpty(board[row, col]))
                    {
                        board[row, col] = AIPlayer.ToString();
                        int moveValue = Minimax(0, false, int.MinValue, int.MaxValue);
                        board[row, col] = null;

                        if (moveValue > bestValue)
                        {
                            bestValue = moveValue;
                            bestRow = row;
                            bestCol = col;
                        }
                    }
                }
            }

            
            buttonGrid[bestRow, bestCol].Text = AIPlayer.ToString();
            buttonGrid[bestRow, bestCol].Enabled = false;
            board[bestRow, bestCol] = AIPlayer.ToString();

            
            CheckGameStatus();
        }





    }



}
