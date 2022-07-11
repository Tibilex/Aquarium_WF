namespace Aqua
{
    internal class Fish : PictureBox
    {
        public Form1 Form { get; set; }
        public int id;

        Random random = new Random();
     
        public Fish()
        {
            Image = Properties.Resources.fish;
            Location = new Point(50, 50);
            Size = new Size(120, 120);
            BackColor = Color.Transparent;
            SizeMode = PictureBoxSizeMode.StretchImage;
            this.DoubleBuffered = true;
            id = random.Next(1,3);
        }
    }
}
