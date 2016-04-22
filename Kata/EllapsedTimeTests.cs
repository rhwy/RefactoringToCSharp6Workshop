namespace CSharp6Refactorings
{
    using Xunit;
    using NFluent;
    
    public class Kata
    {
        [Fact] public void
        first_test()
        {
            Check.That(true).IsFalse();
        }
    }
}
