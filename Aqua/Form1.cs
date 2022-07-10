namespace Aqua
{
    public partial class Form1 : Form
    {
        private bool _moveRight = true;
        public Form1()
        {
            InitializeComponent();
            
            this.Load += Form1_Load;
            FishMoveTimer.Tick += FishMoveTimer_Tick;
        }

        private void FishMoveTimer_Tick(object? sender, EventArgs e)
        {
            FishMoving();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            FishPictureBox.Size = new Size(100, 100);
            FishPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            FishMoveTimer.Interval = 1;
            FishMoveTimer.Start();
        }

        private void FishMoving()
        {
            if(_moveRight)
            {
                FishPictureBox.Location = new Point(FishPictureBox.Location.X + 10, FishPictureBox.Location.Y);                                 
            }          
            else
            {
                FishPictureBox.Location = new Point(FishPictureBox.Location.X - 10, FishPictureBox.Location.Y);
            }
            if(FishPictureBox.Location.X >= 1800)
            {
                _moveRight = false;
                FishPictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            else if (FishPictureBox.Location.X <= 0)
            {
                _moveRight = true;
                FishPictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
        }
    }
}