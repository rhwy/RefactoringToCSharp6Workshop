namespace CSharp6Refactorings
{
    using Xunit;
    using NFluent;
    using System;

    public class Sample3Tests
    {
        [Fact] public void
        WHEN_no_listener_THEN_it_should_not_fail()
        {
            var bus = new Sample3();
            Check
                .ThatCode(()=> bus.SaySomething("hello"))
                .DoesNotThrow();
        }
        
        [Fact] public void
        WHEN_listener_THEN_it_should_get_the_message()
        {
            var bus = new Sample3();
            string message = null;
            bus.onNewMessage += m => message = m;
            Check
                .ThatCode(()=> bus.SaySomething("hello"))
                .DoesNotThrow();
                
            Check.That(
                message)
                    .IsNotNull()
                    .And.IsEqualTo("hello");
        }
        
        
    }
    
    public class Sample3
    {
        public event Action<string> onNewMessage;
        public void SaySomething(string message)
        {
            if(onNewMessage != null)
            {
                onNewMessage(message);
            }
        }
    }
}
