using FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        // Instantiate PayPal gateway using its factory
        IPaymentGatewayFactory payPalFactory = new PayPalGatewayFactory();
        IPaymentGateway payPalGateway = payPalFactory.CreatePaymentGateway();
        payPalGateway.ProcessPayment(100.50);

        // Instantiate Stripe gateway using its factory
        IPaymentGatewayFactory stripeFactory = new StripeGatewayFactory();
        IPaymentGateway stripeGateway = stripeFactory.CreatePaymentGateway();
        stripeGateway.ProcessPayment(75.25);
    }
}