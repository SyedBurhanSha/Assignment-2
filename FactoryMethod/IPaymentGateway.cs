using FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IPaymentGateway
    {
        void ProcessPayment(double amount);
    }
}
public class PayPalGateway : IPaymentGateway
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment of ${amount} via PayPal.");
        // Implementation specific to PayPal
    }
}
public class StripeGateway : IPaymentGateway
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing payment of ${amount} via Stripe.");
        // Implementation specific to Stripe
    }
}

// Creator interface
public interface IPaymentGatewayFactory
{
    IPaymentGateway CreatePaymentGateway();
}

// Concrete factories for each payment gateway
public class PayPalGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentGateway CreatePaymentGateway()
    {
        return new PayPalGateway();
    }
}

public class StripeGatewayFactory : IPaymentGatewayFactory
{
    public IPaymentGateway CreatePaymentGateway()
    {
        return new StripeGateway();
    }
}