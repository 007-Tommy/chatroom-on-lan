namespace ChatroomOnLAN
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            // Checks and such will be implemented later

            int port;

            if (int.TryParse(Port.Text, out port)) { 
                // Placeholder blah blah
            }
        }
    }
}
