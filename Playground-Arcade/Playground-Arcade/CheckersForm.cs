using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playground_Arcade
{
    public partial class CheckersForm : Form
    {
        public CheckersForm()
        {
            InitializeComponent();
        }
        int n;
        PictureBox[,] P;
        string color = "r", k = "", B1 = "", B2 = "",k2="";

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you wish to exit?", "Exit?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        int blue =0,red=0;
        private void Checkers_Load(object sender, EventArgs e)
        {
            n = 8;
            P = new PictureBox[n, n];
            int left = 2, top = 2;
            Color[] colors = new Color[] { Color.White, Color.Black };
            for (int i = 0; i < n; i++)
            {
                left = 2;
                if (i % 2 == 0) 
                { 
                    colors[0] = Color.White; colors[1] = Color.Black; 
                }
                else 
                { 
                    colors[0] = Color.Black; colors[1] = Color.White; 
                }

                for (int j = 0; j < n; j++)
                {
                    P[i, j] = new PictureBox();
                    P[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                    P[i, j].Location = new Point(left, top);
                    P[i, j].Size = new Size(60, 60);
                    left += 60;
                    P[i, j].Name = i + " " + j;
                    if (i < (n / 2) - 1 && P[i, j].BackColor == Color.Black) 
                    { 
                        P[i, j].Image = Properties.Resources.RR; P[i, j].Name += " r"; 
                    }
                    else if (i > (n / 2) && P[i, j].BackColor == Color.Black)
                    {
                        P[i, j].Image = Properties.Resources.BR; P[i, j].Name += " b";
                    }
                    P[i, j].SizeMode = PictureBoxSizeMode.CenterImage;
                    P[i, j].MouseHover += (sender2, e2) =>
                    {
                        PictureBox p = sender2 as PictureBox;
                        if (p.Image != null) p.BackColor = Color.FromArgb(255, 64, 64, 64);
                    };
                    P[i, j].MouseLeave += (sender2, e2) =>
                    {
                        PictureBox p = sender2 as PictureBox;
                        if (p.Image != null) p.BackColor = Color.Black;
                    };
                    P[i, j].Click += (sender3, e3) =>
                    {
                        
                        PictureBox p = sender3 as PictureBox;
                        if (p.Image != null)
                        {
                            int c = -1, x, y;
                            F();
                            if (p.Name.Split(' ')[2] == "t")
                            {
                                if (color == "r")
                                {
                                    color = "b";
                                }
                                else
                                {
                                    color = "r";
                                }
                                x = Convert.ToInt32(k.Split(' ')[0]);
                                y = Convert.ToInt32(k.Split(' ')[1]);
                                B1 = "";
                                B2 = "";
                                if (k.Split(' ')[2] == "r")
                                {
                                    p.Image = Properties.Resources.RR;
                                    p.Name = p.Name.Replace("t", "r");
                                }
                                else if (k.Split(' ')[2] == "b")
                                {
                                    p.Image = Properties.Resources.BR;
                                    p.Name = p.Name.Replace("t", "b");
                                }
                                P[x, y].Image = null;
                                if (k2 != "")
                                {
                                    x = Convert.ToInt32(k2.Split(' ')[0]);
                                    y = Convert.ToInt32(k2.Split(' ')[1]);
                                    P[x, y].Image = null;
                                if (k2.Split(' ')[2] == "r")
                                {
                                    red++;
                                }
                                else
                                {
                                    blue++;
                                }
                                    labelp1.Text = blue + "";
                                    labelp2.Text = red + "";
                                    if (red >= 12)
                                    {
                                        Player2Wins();
                                    }
                                    else if (blue >= 12)
                                    {
                                        Player1Wins();
                                    }
                                    k2 = "";
                                }
                                if (lblStatus.Text.ToString() == "Player 1's Turn")
                                {
                                    lblStatus.Text = "Player 2's Turn";
                                }
                                else
                                {
                                    lblStatus.Text = "Player 1's Turn";
                                }
                            }
                            else if (p.Name.Split(' ')[2] == color)
                            {
                                x = Convert.ToInt32(p.Name.Split(' ')[0]);
                                y = Convert.ToInt32(p.Name.Split(' ')[1]);
                                k = p.Name;
                                
                                if (p.Name.Split(' ')[2] == "r") c = 1;
                                {
                                    try
                                    {
                                        if (P[x + c, y + 1].Image == null)
                                        {
                                            P[x + c, y + 1].Image = Properties.Resources.b;
                                            P[x + c, y + 1].Name = (x + c) + " " + (y + 1) + " t";
                                            B1 = (x + c) + " " + (y + 1);
                                        }
                                        else if (P[x + c, y + 1].Name.Split(' ')[2] != p.Name.Split(' ')[2] && P[x + (c * 2), y + 2].Image == null)
                                        {
                                            P[x + (c * 2), y + 2].Image = Properties.Resources.b;
                                            P[x + (c * 2), y + 2].Name = (x + (c * 2)) + " " + (y + 2) + " t";
                                            B1 = (x + (c * 2)) + " " + (y + 2);
                                            k2 = (x + c) + " " + (y + 1) + " " + P[x + c, y + 1].Name.Split(' ')[2];
                                        }
                                    }
                                    catch { }
                                    
                                    try
                                    {
                                        if (P[x + c, y - 1].Image == null)
                                        {
                                            P[x + c, y - 1].Image = Properties.Resources.b;
                                            P[x + c, y - 1].Name = (x + c) + " " + (y - 1) + " t";
                                            B2 = (x + c) + " " + (y - 1);

                                        }
                                        else if (P[x + c, y - 1].Name.Split(' ')[2] != p.Name.Split(' ')[2] && P[x + (c * 2), y - 2].Image == null)
                                        {
                                            P[x + (c * 2), y - 2].Image = Properties.Resources.b;
                                            P[x + (c * 2), y - 2].Name = (x + (c * 2)) + " " + (y - 2) + " t";
                                            B2 = (x + (c * 2)) + " " + (y - 2);
                                            k2 = (x + c) + " " + (y - 1) + " " + P[x + c, y - 1].Name.Split(' ')[2];
                                        }
                                    }
                                    catch { }

                                }

                            }
                            
                        }
                        
                    };
                    
                    G.Controls.Add(P[i, j]);
                }
                
                top += 60;
            }
            
        }
        public void F()
        {
            if (B1 != "")
            {
                int x, y;
                x = Convert.ToInt32(B1.Split(' ')[0]);
                y = Convert.ToInt32(B1.Split(' ')[1]);
                P[x, y].Image = null;
            }
            if (B2 != "")
            {
                int x, y;
                x = Convert.ToInt32(B2.Split(' ')[0]);
                y = Convert.ToInt32(B2.Split(' ')[1]);
                P[x, y].Image = null;
            }
        }

        public void Player1Wins()
        {
            String uScore = lblP1S.Text.ToString();
            int temp = int.Parse(uScore);
            temp += 1;
            uScore = temp.ToString();
            lblP1S.Text = uScore;
            String winner = "Player 1 Wins!";
            lblStatus.Text = winner;
        }

        public void Player2Wins()
        {
            String uScore = lblP2S.Text.ToString();
            int temp = int.Parse(uScore);
            temp += 1;
            uScore = temp.ToString();
            lblP2S.Text = uScore;
            String winner = "Player 2 Wins!";
            lblStatus.Text = winner;
        }

    }
}
