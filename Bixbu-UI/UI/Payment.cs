using MaterialSkin.Controls;
using Stripe;

namespace Bixbu_UI.UI
{
    public partial class Payment : MaterialForm
    {
        int price;
        public Payment(int price)
        {
            InitializeComponent();
            this.price = price;
        }

        private async Task materialButton1_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                // Retrieve card details from the form
                string cardNumber = materialTextBox1.Text;
                string expirationMonth = materialTextBox2.Text;
                string expirationYear = materialTextBox3.Text;
                string cvc = materialTextBox4.Text;

                // Create the Stripe card token
                var tokenOptions = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = cardNumber,
                        ExpMonth = expirationMonth,
                        ExpYear = expirationYear,
                        Cvc = cvc
                    }
                };

                var tokenService = new TokenService();
                Token token = await tokenService.CreateAsync(tokenOptions);
                string tokenId = token.Id;

                var options = new ChargeCreateOptions
                {
                    Amount = this.price, // Amount in cents
                    Currency = "usd",
                    Source = tokenId, // Use the token ID obtained from the previous step
                    Description = "Test Charge"
                };

                var service = new ChargeService();
                Charge charge = service.Create(options);
                MessageBox.Show("Okay");
            }
            catch (StripeException ex)
            {
                string errorMessage = ex.Message;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
