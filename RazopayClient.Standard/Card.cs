namespace Razorpay.Api
{
    public class Card : Entity
    {
        public new Card Fetch(string id)
        {
            return (Card)base.Fetch(id);
        }
    }
}