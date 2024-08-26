using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1_ThietKeGiaoDien
{
    internal class Handle_CaroTable
    {
        Label lb_number = new Label();
        TextBox numberTextBox = new TextBox();
        Button btn_submit = new Button();
        Panel panel;
        int matrixLevel = 0;
        ProgressBar progressBar_Col = new ProgressBar();
        ProgressBar progressBar_Row = new ProgressBar();

        string[,] nodes;
        //fasle = X
        //true = O
        bool currentPlayer = true;
        public void addComponents(Panel panel)
        {
            this.panel = panel;
            panel.Width = 500;
            panel.Height = 500;

            int labelWidth = 50;
            int txtBoxWidth = 50;
            int btnWidth = 50;
            int leftPosition = 10;

            lb_number.Text = "Nhap n = ";
            lb_number.Left = leftPosition;
            lb_number.Width = labelWidth;
            leftPosition += labelWidth;

            numberTextBox.Left = leftPosition;
            numberTextBox.Width = txtBoxWidth;
            leftPosition += txtBoxWidth;

            btn_submit.Text = "Tao ban co";
            btn_submit.Left = leftPosition;
            btn_submit.Width = btnWidth;
            leftPosition += btnWidth;
            btn_submit.Click += new EventHandler(btn_submit_Click);

            panel.Controls.Add(btn_submit);
            panel.Controls.Add(lb_number);
            panel.Controls.Add(numberTextBox);
        }
        public void btn_submit_Click(object sender, EventArgs e)
        {
            int number = int.Parse(numberTextBox.Text);
            panel.Controls.Clear();
            panel.Controls.Add(lb_number);
            panel.Controls.Add(numberTextBox);
            panel.Controls.Add(btn_submit);
            
            if (number >= 15)
            {
                panel.Width = number * 35;
                panel.Height = number * 35;
            }
            matrixLevel = number;
            nodes = new string[matrixLevel, matrixLevel];
            initTable(panel, number);
        }
        public void player_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            if (clickedButton.Text != "") 
                return;

            // Vị trí cột và hàng hiện tại
            // 50 là Top của button được click
            // 10 là Left của button được click
            int rowPosition = (clickedButton.Top - 50) / (clickedButton.Height + 5);
            int colPosition = (clickedButton.Left - 10) / (clickedButton.Width + 5);

            clickedButton.Text = currentPlayer ? "O" : "X";
            nodes[rowPosition, colPosition] = clickedButton.Text;
            

            if (checkWin(clickedButton, rowPosition, colPosition))
            {
                string winner = currentPlayer ? "O" : "X";
                MessageBox.Show(winner + " thắng!");
                resetGame();
            }
            currentPlayer = !currentPlayer;
        }
        public void resetGame()
        {
            // Xóa tất cả các ô trên panel, ngoại trừ btn_submit
            foreach (Control control in panel.Controls)
            {
                if (control is Button && control != btn_submit)
                {
                    Button btn = control as Button;
                    btn.Text = "";
                }
            }

            // Đặt lại mảng nodes (trạng thái người chơi) về null
            for (int i = 0; i < matrixLevel; i++)
            {
                for(int j = 0; j < matrixLevel; j++)
                {
                    nodes[i, j] = null;
                }
            }
            // Đặt lại người chơi đầu tiên là '0'
            currentPlayer = true;
        }
        public void initTable(Panel panel, int number)
        {
            int btnSize = 20;
            int spacing = 5;
            int leftStart = 10;
            int topPosition = 50;
            int bottomTable = topPosition + (btnSize + spacing) * number;
            progressBar_Col.Value = 0;
            progressBar_Row.Value = 0;

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    nodes[i, j] = "";
                    progressBar_Col.Value = (j + 1) * 100 / number;
                    progressBar_Col.Refresh();
                    Thread.Sleep(10);

                    Button btn = new Button();
                    btn.Width = btnSize;
                    btn.Height = btnSize;
                    btn.Left = leftStart + (btnSize + spacing) * j;
                    btn.Top = topPosition + (btnSize + spacing) * i;
                    btn.Click += new EventHandler(player_Click);
                    btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    panel.Controls.Add(btn);
                }
                progressBar_Row.Value = (i + 1) * 100 / number;
                progressBar_Row.Refresh();
            }
            int progressBarSize = 25;
            progressBar_Col.Width = 50;
            progressBar_Col.Height = progressBarSize;
            progressBar_Col.Top = bottomTable;
            progressBar_Col.Left = 10;

            progressBar_Row.Width = 250;
            progressBar_Row.Height = progressBarSize;
            progressBar_Row.Top = bottomTable + spacing + progressBarSize;
            progressBar_Row.Left = 10;


            panel.Controls.Add(progressBar_Col);
            panel.Controls.Add(progressBar_Row);
        }
        public bool checkWin(Button clickedButton, int rowPosition, int colPosition)
        {
            int rows = matrixLevel;
            int cols = matrixLevel;

            string player = clickedButton.Text;

            return handle(player, rowPosition, colPosition, 1, 0) || handle(player, rowPosition, colPosition, 0, 1) || handle(player, rowPosition, colPosition, 1, 1) || handle(player, rowPosition, colPosition, 1, -1);
        }
        // (dCol, dRow)
        // (1, 0) là kiểm tra hàng ngang
        // (0, 1) là kiểm tra hàng dọc
        // (1, 1) là kiểm tra đường chéo chính
        // (1, -1) là kiểm tra đường chéo phụ
        public bool handle(string player, int rowPosition, int colPosition, int dRow, int dCol)
        {
            int numberWin = 5;
            int count = 1;
            
            // Kiểm tra các nodes tiếp theo
            for (int k = 1; k < numberWin; k++)
            {
                int nextRowPosition = rowPosition + k * dRow;
                int nextColPosition = colPosition + k * dCol;
                
                if (nextRowPosition <= matrixLevel && nextColPosition <= matrixLevel)
                {
                    if (nodes[nextRowPosition, nextColPosition] == player)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            // Kiểm tra các nodes tiếp theo (chiều ngược lại)
            for (int k = 1; k < numberWin; k++)
            {
                int nextRowPosition = rowPosition - k * dRow;
                int nextColPosition = colPosition - k * dCol;

                if (nextRowPosition >= 0 && nextColPosition >= 0)
                {
                    if (nodes[nextRowPosition, nextColPosition] == player)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return count >= 5;
        }
    }
}
