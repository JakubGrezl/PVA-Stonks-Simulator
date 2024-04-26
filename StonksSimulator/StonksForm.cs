namespace StonksSimulator
{
    public partial class StonksForm : Form
    {
        private double penize;
        public double Penize
        {
            get => penize;
            set
            {
                numericUpDown1.Maximum = (decimal)Penize;
                label1.Text = "Peníze v bance: P̵̡̛̜̦̠̭͉̳̼͍͚̖͕̻̮̮̫͕͚̞̺̱̬̫͖̥̮̅́͐̒̀̊́̀̐ͅo̵̢̱̱̘͉̫̺̼̠̘̠̤̺͔͍̦͎̟͍̫̗̭͙̮̤̼̬̥͒͒̏͑̓̈́̅̓́͆̔̈́͆̐͛͘͜͝m̷̨̖̠͔͉̘̠̝̱͎̝̥̝͉̼̻̫̲̪̙̪͕̼̆̿̀̂͛̅͛̀̋́̐̎͋͒̾̋͗͑͗̏̌́̔́̂͘͠ͅo̶̧̢̨̢̥̜̥͉̞̱͈̖̖̺̟͉̥͎̖̯̙̜̲͈͔̥̯͕̔̀͛̃̍̓̄͌͋͜c̷̢̛͇̭̞̰̼̗͎̗̹̙̖̥̺̥͕̹̠̜̥̦͖̰͉̫̼̞̟͚̙̟͔̫̽̋̆͋̑̑̔͌̆́͂̎̍̍̐̈́̈͐̆͆̿̽́̐͗͌̇̆̌̾͘͝͝ $";
            }
        }
        public StonksForm()
        {
            InitializeComponent();
            Penize = 150;
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VlozAkcie();
        }

        private void VlozAkcie()
        {
            
        }
    }
}
