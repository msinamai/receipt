namespace receipt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            resulttxtbx.Clear();
           
            resulttxtbx.Text += "**********************************************************\n";
            resulttxtbx.Text += "***** Cinamai  Fess Receipt    ***************************\n";
            resulttxtbx.Text += "**********************************************************\n\n\n";
            resulttxtbx.Text += "           Date: " + DateTime.Now + "\n\n";
            resulttxtbx.Text += "First Name: " + firstnametxt.Text + "\n\n ";
             resulttxtbx.Text += "Reg no: " + regnotxt.Text + "\n\n";
            resulttxtbx.Text += "Level: " + leveltxt.Text + " \n\n";
            resulttxtbx.Text += "Program: " + progrmtxt.Text + "\n\n";
            resulttxtbx.Text += "Amount: " + amnttxt.Text +  "\n\n";
            resulttxtbx.Text += "Signature:  ...............................................\n\n\n";

            resulttxtbx.Text += "******** Thank You for Working With Us *******\n";

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            resulttxtbx.Text = "";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(resulttxtbx.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Italic), Brushes.Blue, new Point(10, 10));

        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
