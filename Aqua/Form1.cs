namespace Aqua
{
    public partial class Form1 : Form
    {
        private bool _moveRight_1 = true;
        private bool _moveRight_2 = true;
        private bool _moveRight_3 = true;

        private PictureBox _fishPictureBox1;
        private PictureBox _fishPictureBox2;
        private PictureBox _fishPictureBox3;

        private int _fishHungry_1 = 0;
        private int _fishHungry_2 = 0;
        private int _fishHungry_3 = 0;


        public Form1()
        {
            InitializeComponent();
            
            this.Load += Form1_Load;
            FishMoveTimer.Tick += FishMoveTimer_Tick;
            
        }
        private void FishMoveTimer_Tick(object? sender, EventArgs e)
        {
            FishMoving_1();
            FishMoving_2();
            FishMoving_3();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            FishTypes();

            FishMoveTimer.Interval = 20;
            FishMoveTimer.Start();
        }

        private async void FishMoving_1()
        {
            await Task.Delay(1);
            if(_fishHungry_1 >= 255)
            {
                this.Controls.Remove(_fishPictureBox1);
            }
            else
            {
                _fishHungry_1 += 1;
                _fishPictureBox1.BackColor = Color.FromArgb(_fishHungry_1, 0,0);
            }
            if(_moveRight_1)
            {              
                _fishPictureBox1.Location = new Point(_fishPictureBox1.Location.X + 5, _fishPictureBox1.Location.Y);
            }          
            else
            {
                _fishPictureBox1.Location = new Point(_fishPictureBox1.Location.X - 5, _fishPictureBox1.Location.Y);
            }
            if(_fishPictureBox1.Location.X >= 1800)
            {
                _moveRight_1 = false;
                _fishPictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            else if (_fishPictureBox1.Location.X <= 0)
            {
                _moveRight_1 = true;
                _fishPictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
        }
        private void FishMoving_2()
        {
            if (_fishHungry_2 >= 255)
            {
                this.Controls.Remove(_fishPictureBox2);
            }
            else
            {
                _fishHungry_2 += 1;
                _fishPictureBox2.BackColor = Color.FromArgb(_fishHungry_2, 0, 0);
            }
            if (_moveRight_2)
            {
                _fishPictureBox2.Location = new Point(_fishPictureBox2.Location.X + 10, _fishPictureBox2.Location.Y + 5);
            }
            else
            {
                _fishPictureBox2.Location = new Point(_fishPictureBox2.Location.X - 10, _fishPictureBox2.Location.Y - 5);
            }
            if (_fishPictureBox2.Location.X >= 1700)
            {
                _moveRight_2 = false;
                _fishPictureBox2.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            else if (_fishPictureBox2.Location.X <= 100)
            {
                _moveRight_2 = true;
                _fishPictureBox2.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
        }
        private async void FishMoving_3()
        {
            await Task.Delay(5);
            if (_fishHungry_3 >= 255)
            {
                this.Controls.Remove(_fishPictureBox3);
            }
            else
            {
                _fishHungry_3 += 1;
                _fishPictureBox3.BackColor = Color.FromArgb(_fishHungry_3, 0, 0);
            }
            if (_moveRight_3)
            {
                _fishPictureBox3.Location = new Point(_fishPictureBox3.Location.X + 10, _fishPictureBox3.Location.Y);
            }
            else
            {
                _fishPictureBox3.Location = new Point(_fishPictureBox3.Location.X - 10, _fishPictureBox3.Location.Y);
            }
            if (_fishPictureBox3.Location.X >= 1700)
            {
                _moveRight_3 = false;
                _fishPictureBox3.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            else if (_fishPictureBox3.Location.X <= 100)
            {
                _moveRight_3 = true;
                _fishPictureBox3.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
        }

        private void FishTypes()
        {
            _fishPictureBox1 = new PictureBox()
            {
                Location = new Point(50, 50),
                Size = new Size(120, 120),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Properties.Resources.fish
            };

            _fishPictureBox2 = new PictureBox()
            {
                Location = new Point(150, 150),
                Size = new Size(120, 120),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Properties.Resources.fish
            };

            _fishPictureBox3 = new PictureBox()
            {
                Location = new Point(1650, 250),
                Size = new Size(120, 120),
                BackColor = Color.Transparent,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Properties.Resources.fish
            };        

            this.Controls.Add(_fishPictureBox1);
            this.Controls.Add(_fishPictureBox2);
            this.Controls.Add(_fishPictureBox3);
            _fishPictureBox1.Click += _fishPictureBox1_Click;
            _fishPictureBox2.Click += _fishPictureBox2_Click;
            _fishPictureBox3.Click += _fishPictureBox3_Click;
        }
        private void _fishPictureBox1_Click(object? sender, EventArgs e) { _fishHungry_1 = 0; }
        private void _fishPictureBox2_Click(object? sender, EventArgs e) { _fishHungry_2 = 0; }
        private void _fishPictureBox3_Click(object? sender, EventArgs e) { _fishHungry_3 = 0; }

    }
    
}