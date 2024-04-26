namespace StonksSimulator
{
    public partial class StonksForm : Form
    {
        double earned;


        private double penize;
        public double Penize
        {
            get => penize;
            set
            {
                if (value < 0)
                {
                    MessageBox.Show("Prohrál jsi");
                    Application.Exit();
                }
                penize = value;
                numericUpDown1.Maximum = (int)Penize;
                label1.Text = $"Peníze v bance: {((int)value)} $";
            }
        }
        public StonksForm()
        {
            InitializeComponent();
            Penize = 150;
            numericUpDown1.Minimum = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VlozAkcie();
        }

        private void VlozAkcie()
        {
            if (flowLayoutPanel1.Controls.Count >= 5)
            {
                MessageBox.Show("Můžeš mít maximálně 5 akcií");
                return;
            }
            double selectedNumber = (double)numericUpDown1.Value;
            Akcie akcie = new Akcie(selectedNumber);
            akcie.delete += this.DeleteStocks;
            flowLayoutPanel1.Controls.Add(akcie);
            this.Penize -= selectedNumber;
        }

        private void DeleteStocks(Akcie akcie)
        {
            var diff = FindDifference((decimal)akcie.AktualniCena, (decimal)akcie.porizovaciCena);
            if (diff >= 200)
            {
                foreach (Akcie tmp in flowLayoutPanel1.Controls)
                {
                    earned += tmp.AktualniCena;
                }
                earned += Penize;

                MessageBox.Show($"TY JSI BŮH AKCIÍ, Nyní vlastníš částku {earned} $, dej to na točku dělej");
                Application.Exit();
            }
            this.Penize += akcie.AktualniCena;
            flowLayoutPanel1.Controls.Remove(akcie);
        }

        public decimal FindDifference(decimal nr1, decimal nr2)
        {
            return Math.Abs(nr1 - nr2);
        }

        private void cheatmodeBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Akcie tmp in flowLayoutPanel1.Controls)
            {
                tmp.cheatmode = cheatmodeBox.Checked;
            }
            
        }
    }
}
