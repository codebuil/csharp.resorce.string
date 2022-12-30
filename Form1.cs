using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x=0;
            int y = 0;
            byte[] b;
            String gs="";
            String fname = "";
            button1.Text= "loading wait...";
            openFileDialog1.ShowDialog();
            fname = openFileDialog1.FileName;

            Application.DoEvents();
            gs = File.ReadAllText(fname);
            gs = gs.Replace("\\", "\\\\");
            gs = gs.Replace("\0", "\\0");
            gs = gs.Replace("   ", "\\t");
            gs = gs.Replace("\n", "\\n");
            gs = gs.Replace("\r", "\\r");
            gs = gs.Replace("\"", "\\\"");

            gs = gs + "";
            textBox1.Text =gs;
            button1.Text = "open resource";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}