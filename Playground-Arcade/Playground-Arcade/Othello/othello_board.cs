using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Othello {

    class othello_board {
        public delegate void DelDraw(Panel pan, int p);
        public const int w = 8;
        public const int rect_width = 40;
        private int[,] m;

        public othello_board() {
            board_matrix_init();
        }

        public int num_ai_disks = 0;
        public int num_player_disks = 0;
        //calculate the number of player tiles/disks on the board. 
        private void Calc() {
            num_player_disks = 0;
            num_ai_disks = 0;
            for (int i = 0; i < w; i++) {
                for (int j = 0; j < w; j++) {
                    if (m[i, j] < 0) num_ai_disks++;
                    if (m[i, j] > 0) num_player_disks++;
                }
            }
        }

        public int disk_count;
        //initialize the othello board with the squares, init the number of disks to 0
        private void board_matrix_init() {
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
        public void Draw(Panel p, bool draw_help,int step) {
            Graphics gr = Graphics.FromHwnd(p.Handle);
            Draw(gr, draw_help,step);
        }
        //draws the board, dependant on if the tile is black or white, and green if there is 
        //no tile on that location.
        internal void Draw(System.Drawing.Graphics graphics,bool draw_help,int step) {
            Pen p = new Pen(Color.Black,(float)0.5);
            for (int i = 0; i < w; i++) {
                for (int j = 0; j < w; j++) {
                    int f = m[i, j];
                    Color c = Color.Green;
                    graphics.FillRectangle(new SolidBrush(c), i * rect_width, j * rect_width, rect_width, rect_width);
                    graphics.DrawRectangle(p, i * rect_width, j * rect_width, rect_width, rect_width);
                    if (f == 0) {
                        c = Color.Green;
                    } else {
                        if (f == 1) {
                            c = Color.Black;
                        } else {
                            c = Color.White;
                        }
                        graphics.FillEllipse(new SolidBrush(c), i * rect_width + 3, j * rect_width + 3, rect_width - 6, rect_width - 6);
                    }
                }
            }
        }
        //function to place a disk when clicked on the board panel 
        internal int place_disk(int x, int y, int val, bool IsAdd) {
            int result = 0;
            if (m[x, y] == 0) {
                for (int i = -1; i <= 1; i++) {
                    for (int j = -1; j <= 1; j++) {
						result += directional_checker(x, y, val, IsAdd, i, j);
					}
                }

                if (result > 0) {
                    if (IsAdd) {
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
        public List<int[]> get_possible_moves(int p) {
            List<int[]> l = new List<int[]>(10);
            for (int i = 0; i < w; i++) {
                for (int j = 0; j < w; j++) {
                    int res = place_disk(i, j, p, false);
                    if (res > 0) {
                        l.Add(new int[] { i, j, res });
                    }
                }
            }

            possible_moves = l.Count;
            return l;
        }
        
        // check each direction of the tile (north, south, east, west, all diagonals)
        // to see what the values are around the tile. 
		int directional_checker(int x, int y, int p, bool f, int d_x, int d_y) {
            if (d_x == 0 && d_y == 0) return 0;
            x = x + d_x;
            y = y + d_y;
			bool found = false;
			int c = 0;

			for (int i = x, j = y; i >= 0 && j >= 0 && i < w && j < w; i += d_x, j += d_y) {
				if (m[i, j] == 0) return 0;
				if (m[i, j] == -p) c++;
				if (m[i, j] == p) {
					found = c > 0;
					if (c > 0 && f) {
                        int a = x, b = y;
                        while (!(a == i && b == j)) {
                            m[a, b] = p;
                            a += d_x;
                            b += d_y;
                        }
					}

					break;
				}
			}

			if (found) {
                return c;
            } else {
                return 0;
            }
		}
    }
}