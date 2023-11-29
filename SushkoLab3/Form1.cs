using SushkoLab3.CLasses;

namespace SushkoLab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                Drawer.CreateGraphics(MainPictureBox);
                Drawer.DrawCoordinateSystem();

                Calculator.t = Convert.ToDouble(textBox1.Text);

                Calculator.SolveRungeKutta2(Drawer.xMin, Drawer.xMax);
                Calculator.SolveMilnaSimpsona(Drawer.xMin, Drawer.xMax);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}