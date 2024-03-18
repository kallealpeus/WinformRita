namespace WinformRita
{
    public partial class DrawForm : Form
    {
        public DrawForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var mouse = (MouseEventArgs)e;
            if (drawCircle)
            {
                var circle = new Circle()
                {
                    Color = color,
                    Radie = 15,
                    Center = mouse.Location
                };
                shapes.Push(circle);
            }
            if (drawSqaure)
            {
                var sqaure = new Sqaure()
                {
                    Color = color,
                    Side = 15,
                    Center = mouse.Location
                };
                shapes.Push(sqaure);
            }
            if (drawTriangle)
            {
                var triangle = new Triangle()
                {
                    Color = color,
                    Side = 15,
                    Center = mouse.Location
                };
                shapes.Push(triangle);
            }

            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape s in shapes)
            {
                var pen = new Pen(s.Color);
                s.Draw(pen, e.Graphics);
            }
        }
        private bool drawCircle = false;
        private bool drawSqaure = false;
        private bool drawTriangle = false;
        private Stack<Shape> shapes = new Stack<Shape>();
        private Color color;

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            if (drawCircle == false)
            {
                drawSqaure = false;
                drawTriangle = false;
                drawCircle = true;
            }
            else
            {
                drawCircle = false;
            }
        }
        private void buttonSqaure_Click(object sender, EventArgs e)
        {
            if (drawSqaure == false)
            {
                drawCircle = false;
                drawTriangle = false;
                drawSqaure = true;
            }
            else
            {
                drawSqaure = false;
            }
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            if (drawTriangle == false)
            {
                drawSqaure = false;
                drawCircle = false;
                drawTriangle = true;
            }
            else
            {
                drawSqaure = false;
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = true;//Avgör om man kan ha egna färger, default är true men är med för tydlighets skull
            colorDialog.Color = color;//Gör man ser den färg som är aktiv
            colorDialog.FullOpen = true;//Egna färger rutan är automatiskt öppen
            colorDialog.AnyColor = true;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }

        private void ClearButton1_Click(object sender, EventArgs e)
        {
            ClearButton2.Enabled = true;
            ClearButton2.Visible = true;

            ClearButton1.Enabled = false;
            ClearButton1.Visible = false;
        }
        private void ClearButton2_Click(object sender, EventArgs e)
        {
            ClearButton3.Enabled = true;
            ClearButton3.Visible = true;

            ClearButton2.Enabled = false;
            ClearButton2.Visible = false;
        }
        private void ClearButton3_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            pictureBox1.Refresh();

            ClearButton1.Enabled = true;
            ClearButton1.Visible = true;

            ClearButton3.Enabled = false;
            ClearButton3.Visible = false;
        }

        private void RegretButton_Click(object sender, EventArgs e)
        {
            shapes.Pop();
            pictureBox1.Refresh();
        }
    }
}
