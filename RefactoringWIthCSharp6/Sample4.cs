namespace CSharp6Refactorings
{
    using Xunit;
    using NFluent;
    using System.Collections.Generic;
    using System.Linq;

    public class Sample4Tests
    {
        [Fact] public void
        my_first_test()
        {
            var basket = new Sample4();
            basket.Prices.Add(2.5);
            basket.Prices.Add(3.7);
            Check.That(
                basket.MessageWithTotal)
                .IsEqualTo("Total : 6,2 (2 products)");
           
        }
        
        
    }
    
    public class Sample4
    {
        public List<double> Prices {get;private set;}
        public Sample4()
        {
            Prices = new List<double>();
        }
        
        public string MessageWithTotal 
        {
            get{
                double total = Prices.Sum();
                int quantity = Prices.Count();
                return string.Format("Total : {0} ({1} products)",total,quantity);
            }
        }
    }
}
