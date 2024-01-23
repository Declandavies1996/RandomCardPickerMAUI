namespace RandomCardPickerMAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PickCardsButton_Clicked(object sender, EventArgs e)
        {
            if(int.TryParse(NumberOfCards.Text,out int amountOfCards))
            {
                string[] cardsPicked = CardPicker.PickSomeCards(amountOfCards);

                foreach(string card in cardsPicked)
                {
                    PickedCards.Text = PickedCards.Text + Environment.NewLine + card;
                }
            }
            else
            {
                PickedCards.Text = "Please Enter A Valid Number";
            }
        }
    }

}
