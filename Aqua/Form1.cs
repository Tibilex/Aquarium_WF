namespace Aqua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.KeyDown += EscapeProgramm;

            button1.BackColor = Color.FromArgb(152, 195, 121);
        }

        private void EscapeProgramm(object? sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                Application.Exit();
            }
        }
        private void Form1_Load(object? sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void AddFish_Click(object sender, EventArgs e)
        {         
            FishUserControl fish = new FishUserControl();
            fish.Form = this;
            this.Controls.Add(fish);
        }             
       
    } 
}