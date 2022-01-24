using System;

namespace OpenClosed
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Open-Closed principle
             * Bir sınıf gelişime AÇIK değişime KAPALI olmalıdır.
             */

            Customer customer = new Customer { Name = "Türkay", Cart = new Premium() };
            PaymentManager paymentManager = new PaymentManager { Customer = customer };
            var totalPrice = paymentManager.CalculatTotalPrice(200);
            Console.WriteLine(totalPrice.ToString()) ;
        }
    }

    public abstract class CartType
    {
        public abstract decimal GetDiscountedPrice(decimal price);
       
    }

    public class Standard : CartType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .95M;
        }
    }

    public class Silver : CartType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .90M;
        }
    }

    public class Gold : CartType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .85M;
        }
    }

    public class Premium : CartType
    {
        public override decimal GetDiscountedPrice(decimal price)
        {
            return price * .80M;
        }
    }

    public class Customer 
    {
        public string Name { get; set; }
        public CartType Cart { get; set; }
    }

    public class PaymentManager
    {
        public Customer Customer { get; set; }
        public decimal CalculatTotalPrice(decimal price)
        {

            return Customer.Cart.GetDiscountedPrice(price);
            //switch (Customer.Cart)
            //{
            //    case CartType.Standard:
            //        return price * 0.95M;
            //    case CartType.Silver:
            //        return price * 0.90M;
            //    case CartType.Gold:
            //        return price * 0.85M;
            //    default:
            //        return price * 1M;
            //}
        }
    }

}
