namespace Assignment1
{
    /// <summary>
    /// default class made by visual studio code
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Default constructor made by visual studio
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        ///<summary>
        ///This funcion will display an error message when clicked
        ///</summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // create the dialog object
            DialogResult result;
            // store the result message box in the instance of DialogResult
            result = MessageBox.Show("this textbox contains " + textBox1.Text, "Error!", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            // changes the text of the label to say what the user clicked on
            label2.Text = "the user has clicked: " + result.ToString();
        }
        /// <summary>
        /// This function will display system information
        /// It displays the following:
        /// Machine name, operating system, process path, processor count
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // create the dialog object again
            DialogResult result;

            // strings where the environment variable will be stored for later use.
            string machine = Environment.MachineName;
            string operating_system = Environment.OSVersion.ToString();
            string process_path = Environment.ProcessPath;
            string processor_count = Environment.ProcessorCount.ToString();
            // store result of message box in instance of DialogResult
            result = MessageBox.Show("this textbox contains " + textBox2.Text + "\nmachine name is " + machine + "\nyour os is " + operating_system + "\nprocess_path is " + process_path + "\nprocessor count is " + processor_count, "Informational", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // changes the text of the label to say what the user clicked on.
            label4.Text = "the user has clicked: " + result.ToString();
        }
        /// <summary>
        /// This will display try cancel continue and will change form colors depending on what you click.
        /// Cancel changes the color to cyan
        /// Try changes the color back to the default
        /// Continue will change the color to red
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            // create the dialog object again
            DialogResult result;

            // strings where the environment variable will be stored for later use.
            result = MessageBox.Show("this textbox contains " + textBox3.Text + "\nPress cancel for cyan background\npress try for back to default color\npress continue for red", "Color changer", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Asterisk);

            // a series of if statements to determine the color based on what the user clicked on.
            if (result == DialogResult.Cancel)
            {
                this.BackColor = Color.Cyan;
            }
            else if (result == DialogResult.TryAgain)
            {
                this.BackColor = SystemColors.Control;
            }
            else if (result == DialogResult.Continue)
            {
                this.BackColor = Color.Red;
            }
            // changes the text of the label to say what the user clicked on.
            label6.Text = result.ToString();
        }
    }
}
