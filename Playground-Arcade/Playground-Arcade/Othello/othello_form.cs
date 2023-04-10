using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Othello
{
    public partial class othello_form : System.Windows.Forms.Form { 
        delegate void draw_form(Panel p,bool b,int s);
        delegate void del_ai_step();
        delegate void display_res_invoke();
        delegate void invoke_show_grade(string s);
        del_ai_step cpu_move_done;
        othello_board board;
        bool flag = false;

        public othello_form() {
            InitializeComponent();
            DoubleBuffered = true;
            cpu_move_done = new del_ai_step(ai_step);
            board_initialize();
        }

        private void board_initialize() {
            board = new othello_board();
            pnl_board.Width = othello_board.w * othello_board.rect_width;
            pnl_board.Height = othello_board.w * othello_board.rect_width;
        }

        private void load_form(object sender, EventArgs e) {
            ai_step();
        }

        private void paint_form(object sender, PaintEventArgs e) { }

        private bool draw_bl = true;

        private void panel1_Paint(object sender, PaintEventArgs e) {
            board.Draw(e.Graphics, false, 0);
        }

	// Do a random step.
        private void ai_step() {
            Random r = new Random();
            List<int[]>l = board.get_possible_moves(-1);

	    if (l.Count > 0) {
		    board.place_disk(l[0][0], l[0][1], -1, true);
	    }
        }

        private void show_result() {
            lbl_humanScore.Text = board.num_player_disks.ToString();
            lbl_cpuScore.Text = board.num_ai_disks.ToString();
        }

        

        private void panel_click(object sender, MouseEventArgs e) {
            if (flag) return;            
            int x = e.X / othello_board.rect_width;
            int y = e.Y / othello_board.rect_width;
            if (board.place_disk(x, y, 1, true) > 0) {
                flag = true;
                board.Draw(pnl_board, draw_bl, -1);
                cpu_move_done.BeginInvoke(new AsyncCallback(end_ai_step), null);
                show_result();
            } else {
                
            }
        }

        private void end_ai_step(object ob) {
            if (pnl_board.InvokeRequired) {
                Invoke(new draw_form(board.Draw), pnl_board, draw_bl, 1);
	    } else {
                board.Draw(pnl_board, draw_bl, 1);
	    }

            int PlayerSteps = board.get_possible_moves(1).Count;
            if (PlayerSteps == 0) {
                if (board.num_ai_disks > board.num_player_disks) {
                    MessageBox.Show("CPU has defeated you!");
                } else {
                    MessageBox.Show("Human wins!");
                }
               
            }

            flag = false;
            if (InvokeRequired) {
                Invoke(new display_res_invoke(show_result));
	    } else {
                show_result();
	    }
        }

        private void button1_Click(object sender, EventArgs e) {
            board_initialize();
            board.Draw(pnl_board, draw_bl, 1);
        }

		
	}
}
