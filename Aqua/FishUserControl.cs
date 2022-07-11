namespace Aqua
{
    public partial class FishUserControl : UserControl
    {
        private bool _moveHorizont = true;
        private int _fishHungry = 0;
        System.Windows.Forms.Timer Timer = new System.Windows.Forms.Timer();
        public Form1 Form { get; set; }

        public FishUserControl()
        {
            InitializeComponent();
            label1.ForeColor = Color.Transparent;
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = true;

            this.Load += FishUserControl_Load;
            fish1.Click += Fish1_Click;
            Timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            MovingChoise();
        }
        private void FishUserControl_Load(object? sender, EventArgs e)
        {
            Timer.Interval = 10;
            Timer.Start();
        }
        private void Fish1_Click(object? sender, EventArgs e)
        {
            _fishHungry = 0;
        }
        public void FishMoving()
        {
            if (_fishHungry >= 255)
            {
                Form.Controls.Remove(this);
            }
            else
            {
                _fishHungry++;
                label1.ForeColor = Color.FromArgb(_fishHungry, 0, 0);
            }
            if (this.Location.Y <= Form.Height - 100)
            {
                if (_moveHorizont)
                {
                    this.Location = new Point(this.Location.X + 5, this.Location.Y);
                }
                else
                {
                    this.Location = new Point(this.Location.X - 5, this.Location.Y);
                }
                if (this.Location.X >= Form.Width - 100)
                {
                    _moveHorizont = false;
                    fish1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                }
                else if (this.Location.X <= 0)
                {
                    _moveHorizont = true;
                    fish1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                }

            }

        }
        public void FishMoving2()
        {
            if (_fishHungry >= 255)
            {
                Form.Controls.Remove(this);
            }
            else
            {
                _fishHungry++;
                label1.ForeColor = Color.FromArgb(_fishHungry, 0, 0);
            }
            if (_moveHorizont)
            {
                this.Location = new Point(this.Location.X + 10, this.Location.Y + 5);
            }
            else
            {
                this.Location = new Point(this.Location.X - 10, this.Location.Y - 5);
            }
            if (this.Location.Y >= Form.Height - 200)
            {
                _moveHorizont = false;
                fish1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            else if (this.Location.X <= 20)
            {
                _moveHorizont = true;
                fish1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
        }
        private void MovingChoise()
        {
            switch (fish1.id)
            {
                case 1:
                    FishMoving();
                    break;
                case 2:
                    FishMoving2();
                    break;
                default:
                    break;
            }
        }
    }
}
