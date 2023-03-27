namespace WinFormsGrapV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //Pen p1 = new Pen(Color.Blue);
            //Pen p2 = new Pen(Color.Red);
            //p2.Width = 5;
            //Brush b1 = new SolidBrush(Color.Brown);
            //e.Graphics.FillRectangle(b1, 200, 200, 200, 100);
            //e.Graphics.DrawRectangle(p1, 20, 20, 100, 50);
            //e.Graphics.DrawEllipse(p1, 400, 300, 200, 200);
            //e.Graphics.FillEllipse(b1, 500, 20, 100, 50);
            //e.Graphics.DrawLine(p2, 10, 400, 200, 450);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var g1 = panel2.CreateGraphics();
            g1.Clear(Color.White);
        }
    }
}