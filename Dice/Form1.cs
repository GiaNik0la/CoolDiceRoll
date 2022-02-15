namespace Dice
{
    public partial class Form1 : Form
    {
        Random rn = new Random();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Jemala.Text) || string.IsNullOrEmpty(UserPrediction.Text))
                {
                    throw new TextBoxEmpty("why are you so stupid, enter text you INBECILE!!! I ALWAYS HATED YOU!!!");

                }

                var diceNumber = Convert.ToInt32(Jemala.Text);
                var userPrediction = Convert.ToInt32(UserPrediction.Text);

                int sum = 0;

                int i = 0;
                while (diceNumber > i)
                {
                    var finalValue = rn.Next(1, 6);
                    string imagePath = @"C:\Users\Admin\source\repos\Dice\Dice\DiceImages\" + finalValue + ".png";
                    Form_2 form2 = new Form_2(imagePath);
                    form2.Show();
                    sum += finalValue;
                    i++;

                }

                if (sum - userPrediction < 5)
                {
                    Win();
                }
                else
                {
                    Loser();
                }

                Result.Text = "IDK" + sum.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Win()
        {
            win.Text = "subzero wins! FATALITY";

        }

        private void Loser()
        {
            MessageBox.Show("YOU LOSE DUMBASS!!! why did you even download this game. fudging idiot");

        }

    }

}
