using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Othello
{
    public partial class OthelloForm : System.Windows.Forms.Form
    {
        delegate void draw_form(Panel p, bool b, int s);
        delegate void del_ai_step();
        delegate void display_res_invoke();
        delegate void invoke_show_grade(string s);
        del_ai_step cpu_move_done;
        othello_board board;
        bool flag = false;

        public OthelloForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            cpu_move_done = new del_ai_step(ai_step);
            board_initialize();
        }

        private void board_initialize()
        {
            board = new othello_board();
            pnl_board.Width = othello_board.w * othello_board.rect_width;
            pnl_board.Height = othello_board.w * othello_board.rect_width;
        }

        private void load_form(object sender, EventArgs e)
        {
            ai_step();
        }

        private void paint_form(object sender, PaintEventArgs e) { }

        private bool draw_bl = true;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            board.Draw(e.Graphics, false, 0);
        }

        // Do a random step.
        private void ai_step()
        {
            Random r = new Random();
            List<int[]> l = board.get_possible_moves(-1);

            if (l.Count > 0)
            {
                board.place_disk(l[0][0], l[0][1], -1, true);
            }
        }

        private void show_result()
        {
            lbl_humanScore.Text = board.num_player_disks.ToString();
            lbl_cpuScore.Text = board.num_ai_disks.ToString();
        }



        private void panel_click(object sender, MouseEventArgs e)
        {
            if (flag) return;
            int x = e.X / othello_board.rect_width;
            int y = e.Y / othello_board.rect_width;
            if (board.place_disk(x, y, 1, true) > 0)
            {
                flag = true;
                board.Draw(pnl_board, draw_bl, -1);
                cpu_move_done.BeginInvoke(new AsyncCallback(end_ai_step), null);
                show_result();
            }
            else
            {

            }
        }

        private void end_ai_step(object ob)
        {
            if (pnl_board.InvokeRequired)
            {
                Invoke(new draw_form(board.Draw), pnl_board, draw_bl, 1);
            }
            else
            {
                board.Draw(pnl_board, draw_bl, 1);
            }

            int PlayerSteps = board.get_possible_moves(1).Count;
            if (PlayerSteps == 0)
            {
                if (board.num_ai_disks > board.num_player_disks)
                {
                    MessageBox.Show("CPU has defeated you!");
                }
                else
                {
                    MessageBox.Show("Human wins!");
                }

            }

            flag = false;
            if (InvokeRequired)
            {
                Invoke(new display_res_invoke(show_result));
            }
            else
            {
                show_result();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            board_initialize();
            board.Draw(pnl_board, draw_bl, 1);
        }


    }
}

namespace Othello
{

    class othello_board
    {
        public delegate void DelDraw(Panel pan, int p);
        public const int w = 8;
        public const int rect_width = 40;
        private int[,] m;

        public othello_board()
        {
            board_matrix_init();
        }

        public int num_ai_disks = 0;
        public int num_player_disks = 0;
        //calculate the number of player tiles/disks on the board. 
        private void Calc()
        {
            num_player_disks = 0;
            num_ai_disks = 0;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    if (m[i, j] < 0) num_ai_disks++;
                    if (m[i, j] > 0) num_player_disks++;
                }
            }
        }

        public int disk_count;
        //initialize the othello board with the squares, init the number of disks to 0
        private void board_matrix_init()
        {
            num_ai_disks = 0;
            num_player_disks = 0;
            disk_count = 0;
            m = new int[w, w];

            m[w / 2 - 1, w / 2 - 1] = -1;
            m[w / 2, w / 2 - 1] = 1;

            m[w / 2 - 1, w / 2] = 1;
            m[w / 2, w / 2] = -1;

            Calc();
        }
        //draw function
        public void Draw(Panel p, bool draw_help, int step)
        {
            Graphics gr = Graphics.FromHwnd(p.Handle);
            Draw(gr, draw_help, step);
        }
        //draws the board, dependant on if the tile is black or white, and green if there is 
        //no tile on that location.
        internal void Draw(System.Drawing.Graphics graphics, bool draw_help, int step)
        {
            Pen p = new Pen(Color.Black, (float)0.5);
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    int f = m[i, j];
                    Color c = Color.Green;
                    graphics.FillRectangle(new SolidBrush(c), i * rect_width, j * rect_width, rect_width, rect_width);
                    graphics.DrawRectangle(p, i * rect_width, j * rect_width, rect_width, rect_width);
                    if (f == 0)
                    {
                        c = Color.Green;
                    }
                    else
                    {
                        if (f == 1)
                        {
                            c = Color.Black;
                        }
                        else
                        {
                            c = Color.White;
                        }
                        graphics.FillEllipse(new SolidBrush(c), i * rect_width + 3, j * rect_width + 3, rect_width - 6, rect_width - 6);
                    }
                }
            }
        }
        //function to place a disk when clicked on the board panel 
        internal int place_disk(int x, int y, int val, bool IsAdd)
        {
            int result = 0;
            if (m[x, y] == 0)
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int j = -1; j <= 1; j++)
                    {
                        result += directional_checker(x, y, val, IsAdd, i, j);
                    }
                }

                if (result > 0)
                {
                    if (IsAdd)
                    {
                        disk_count++;
                        m[x, y] = val;
                        Calc();
                    }
                }
            }

            return result;
        }

        public int possible_moves;
        //the function finds the possible moves for the current player to 
        //make, it is used in the Random move function. 
        public List<int[]> get_possible_moves(int p)
        {
            List<int[]> l = new List<int[]>(10);
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    int res = place_disk(i, j, p, false);
                    if (res > 0)
                    {
                        l.Add(new int[] { i, j, res });
                    }
                }
            }

            possible_moves = l.Count;
            return l;
        }

        // check each direction of the tile (north, south, east, west, all diagonals)
        // to see what the values are around the tile. 
        int directional_checker(int x, int y, int p, bool f, int d_x, int d_y)
        {
            if (d_x == 0 && d_y == 0) return 0;
            x = x + d_x;
            y = y + d_y;
            bool found = false;
            int c = 0;

            for (int i = x, j = y; i >= 0 && j >= 0 && i < w && j < w; i += d_x, j += d_y)
            {
                if (m[i, j] == 0) return 0;
                if (m[i, j] == -p) c++;
                if (m[i, j] == p)
                {
                    found = c > 0;
                    if (c > 0 && f)
                    {
                        int a = x, b = y;
                        while (!(a == i && b == j))
                        {
                            m[a, b] = p;
                            a += d_x;
                            b += d_y;
                        }
                    }

                    break;
                }
            }

            if (found)
            {
                return c;
            }
            else
            {
                return 0;
            }
        }
    }
}