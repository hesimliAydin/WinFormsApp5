namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Color> colors = new List<Color>
            {
                Color.Red,
                Color.Green,
                Color.Blue,
            };

            comboBox1.DataSource = colors;

            //List<string> todos = new List<string>
            //{
            //    "Read Book",
            //    "Drink Coffee",
            //    "Write Code",
            //    "Write more Code",
            //    "Sleep"
            //};
            //checkedListBox1.Items.AddRange(todos.ToArray());
            
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BackColor = (Color)comboBox1.SelectedItem;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = checkedListBox1.SelectedItem;
            var hasDone = checkedListBox1.CheckedItems.IndexOf(item) >= 0;
            label1.Text = (item as string);
            if (hasDone)
            {
                label1.BackColor = Color.Green;
            }
            else
            {
                label1.BackColor = Color.WhiteSmoke;
            }
        }
    }
}