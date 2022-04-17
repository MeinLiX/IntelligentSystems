using MazeGen_L3.Source;
using System.Drawing.Drawing2D;

namespace MazeGen_L3
{
    public partial class FormMain : Form
    {
        private int CellWidth, CellHeight;
        Maze Mz = new(10, 10);
        Bitmap Bm = new(1, 1);
        Bitmap BmWithoutSolve = new(1, 1);

        public FormMain()
        {
            InitializeComponent();
        }

        private void Button_solve_Click(object sender, EventArgs e)
        {

            Bm = new(BmWithoutSolve);
            Mz.BuildSolve();
            using (Graphics gr = Graphics.FromImage(Bm))
            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                if (checkBoxFullSolvePath.Checked)
                    foreach (Cell c in Mz.Visited)
                        gr.FillRectangle(new SolidBrush(Color.IndianRed), new Rectangle(new Point(c.X * CellWidth, c.Y * CellWidth), new Size(CellWidth, CellWidth)));
                foreach (Cell c in Mz.Solve)
                    gr.FillRectangle(new SolidBrush(Color.LightGreen), new Rectangle(new Point(c.X * CellWidth, c.Y * CellWidth), new Size(CellWidth, CellWidth)));
                gr.FillRectangle(new SolidBrush(Color.Green), new Rectangle(new Point(Mz.Start.X * CellWidth, Mz.Start.Y * CellWidth), new Size(CellWidth, CellWidth)));
                gr.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(Mz.Finish.X * CellWidth, Mz.Finish.Y * CellWidth), new Size(CellWidth, CellWidth)));
            }
            pictureBoxMaze.Image = Bm;
        }

        private void Button_generate_Click(object sender, EventArgs e)
        {
            int wid = int.Parse(textBox_width.Text) + 2;
            int hgt = int.Parse(textBox_height.Text) + 2;

            int oddW = (wid % 2 != 0 && wid != 0) ? 1 : 0;
            int oddH = (hgt % 2 != 0 && hgt != 0) ? 1 : 0;

            CellWidth = pictureBoxMaze.ClientSize.Width / (wid + 2);
            CellHeight = pictureBoxMaze.ClientSize.Height / (hgt + 2);

            int CellMin = 20;
            if (CellWidth < CellMin)
            {
                CellWidth = CellMin;
                CellHeight = CellWidth;
            }
            else if (CellHeight < CellMin)
            {
                CellHeight = CellMin;
                CellWidth = CellHeight;
            }
            else if (CellWidth > CellHeight) CellWidth = CellHeight;
            else CellHeight = CellWidth;
            Mz = new Maze(wid, hgt);
            Mz.Finish.X += oddW;
            Mz.Finish.Y += oddH;
            Mz.Build();

            Bm.Dispose();
            Bitmap bm = new(CellWidth * (Mz.Finish.X + 2), CellHeight * (Mz.Finish.Y + 2), System.Drawing.Imaging.PixelFormat.Format16bppRgb555);

            using (Graphics gr = Graphics.FromImage(bm))
            {
                for (var i = 0; i < Mz.Cells.GetUpperBound(0) + oddW; i++)
                    for (var j = 0; j < Mz.Cells.GetUpperBound(1) + oddH; j++)
                    {
                        Rectangle rec = new(new Point(i * CellWidth, j * CellWidth), new Size(CellWidth, CellWidth));
                        if (!Mz.Cells[i, j].Wall) gr.FillRectangle(new SolidBrush(Color.White), rec);
                        else gr.FillRectangle(new SolidBrush(Color.Black), rec);
                    }
                gr.FillRectangle(new SolidBrush(Color.Green), new Rectangle(new Point(Mz.Start.X * CellWidth, Mz.Start.Y * CellWidth), new Size(CellWidth, CellWidth)));
                gr.FillRectangle(new SolidBrush(Color.Red), new Rectangle(new Point(Mz.Finish.X * CellWidth, Mz.Finish.Y * CellWidth), new Size(CellWidth, CellWidth)));
            }
            pictureBoxMaze.Image = bm;
            Bm = bm;
            BmWithoutSolve = new(Bm);
        }

        private void TextBox_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}