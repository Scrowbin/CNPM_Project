using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GUI
{
    public partial class HomePageUser : Form
    {
        private Bitmap gradientBackground;

        public HomePageUser()
        {
            InitializeComponent();
            // Enable double buffering
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            // Create gradient background once
            GenerateGradientBackground();

            // Handle resizing to regenerate gradient when needed
            this.Resize += (s, e) => GenerateGradientBackground();


        }
        private void GenerateGradientBackground()
        {
            // Dispose old bitmap if it exists
            gradientBackground?.Dispose();

            // Create a new bitmap with the form size
            gradientBackground = new Bitmap(this.Width, this.Height);

            using (Graphics g = Graphics.FromImage(gradientBackground))
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new Rectangle(0, 0, this.Width, this.Height),
                Color.FromArgb(3, 186, 252),
                Color.FromArgb(3, 65, 252),
                45f))
            {
                g.FillRectangle(brush, 0, 0, this.Width, this.Height);
            }

            // Force a repaint
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the pre-rendered gradient background
            if (gradientBackground != null)
            {
                e.Graphics.DrawImage(gradientBackground, 0, 0);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Do nothing to prevent flickering
        }

        private void HomePageUser_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
