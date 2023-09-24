using System.Collections.Generic;

namespace Razorpay.Api
{
    public class RazorpayClient
    {
        const string CurrentVersion = "3.0.2";
        protected const string DefaultBaseUrl = "https://api.razorpay.com/v1/";

        protected static List<Dictionary<string, string>> appsDetails = new List<Dictionary<string, string>>();
        protected static Dictionary<string, string> headers = new Dictionary<string, string>();
        private static string? baseUrl = null;
        private Payment? payment = null;
        private Order? order = null;
        private Refund? refund = null;
        private Customer? customer = null;
        private Invoice? invoice = null;
        private Card? card = null;
        private Transfer? transfer = null;
        private Addon? addon = null;
        private Plan? plan = null;
        private Subscription? subscription = null;
        private VirtualAccount? virtualaccount = null;

        public RazorpayClient(string key, string secret)
        {
            Key = key;
            Secret = secret;
        }

        public RazorpayClient(string baseUrl, string key, string secret)
        {
            BaseUrl = baseUrl;
            Key = key;
            Secret = secret;
        }

        public static string? Key { get; private set; }

        public static string? Secret { get; private set; }

        public static string BaseUrl
        {
            get
            {
                baseUrl ??= DefaultBaseUrl;
                return baseUrl;
            }
            private set
            {
                baseUrl = value;
            }
        }

        public static List<Dictionary<string, string>> AppsDetails
        {
            get
            {
                return appsDetails;
            }
        }

        public static Dictionary<string, string> Headers
        {
            get
            {
                return headers;
            }
        }

        public void SetAppsDetails(string title, string version)
        {
            Dictionary<string, string> appDetail = new Dictionary<string, string>
            {
                { "title", title },
                { "version", version }
            };

            appsDetails.Add(appDetail);
        }

        public void AddHeader(string key, string value)
        {
            headers.Add(key, value);
        }

        public static string Version
        {
            get
            {
                return CurrentVersion;
            }
        }

        public Payment Payment
        {
            get
            {
                payment ??= new Payment();
                return payment;
            }
        }

        public Order Order
        {
            get
            {
                order ??= new Order();
                return order;
            }
        }

        public Refund Refund
        {
            get
            {
                refund ??= new Refund();
                return refund;
            }
        }

        public Customer Customer
        {
            get
            {
                customer ??= new Customer();
                return customer;
            }
        }

        public Invoice Invoice
        {
            get
            {
                invoice ??= new Invoice();
                return invoice;
            }
        }

        public Card Card
        {
            get
            {
                card ??= new Card();
                return card;
            }
        }

        public Transfer Transfer
        {
            get
            {
                transfer ??= new Transfer();
                return transfer;
            }
        }

        public Addon Addon
        {
            get
            {
                addon ??= new Addon();
                return addon;
            }
        }

        public Plan Plan
        {
            get
            {
                plan ??= new Plan();
                return plan;
            }
        }

        public Subscription Subscription
        {
            get
            {
                subscription ??= new Subscription();
                return subscription;
            }
        }

        public VirtualAccount VirtualAccount
        {
            get
            {
                virtualaccount ??= new VirtualAccount();
                return virtualaccount;
            }
        }
    }
}
