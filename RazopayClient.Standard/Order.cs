using System.Collections.Generic;

namespace Razorpay.Api
{
    public class Order : Entity
    {
        public new Order Fetch(string id)
        {
            return (Order)base.Fetch(id);
        }

        public new List<Order> All(Dictionary<string, object>? options = null)
        {
            List<Entity> entities = base.All(options);
            List<Order> orders = new List<Order>();
            foreach (Entity entity in entities)
            {
                orders.Add(entity as Order);
            }
            return orders;
        }

        public Order Create(Dictionary<string, object> data)
        {
            string relativeUrl = GetEntityUrl();
            List<Entity> entities = Request(relativeUrl, HttpMethod.POST, data);
            return (Order)entities[0];
        }

        public List<Payment> Payments()
        {
            string relativeUrl = GetEntityUrl() + "/" + this["id"] + "/payments";
            List<Entity> entities = Request(relativeUrl, HttpMethod.GET, null);

            List<Payment> payments = new List<Payment>();
            foreach (Entity entity in entities)
            {
                payments.Add(entity as Payment);
            }

            return payments;
        }
    }
}