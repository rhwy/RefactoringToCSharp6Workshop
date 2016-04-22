namespace CSharp6Refactorings
{
    using Xunit;
    using NFluent;

    public class Sample2Tests
    {
        [Fact] public void
        my_first_test()
        {
            var sample = new Sample2()
                .GetPrettyName("hellO la confERENCE à lyON");
            var expected = "Hello La Conference À Lyon";
            Check.That(sample).IsEqualTo(expected);
        }
        
        
    }
    
    public class Sample2
    {
        public string GetPrettyName(string title)
		{
			if(title!=null)
			{
				if(title.Contains(" "))
				{
					string result="";
					var items=title.Split(' ');
					foreach(var word in items)
					{
                        if(word.Length>0)
                        {
                            result+=word.Substring(0,1).ToUpper()
						              +word.Substring(1).ToLower()
						              + " ";
                        }
					}
					return result.Trim();
				}
			}
			return "";
		}
    }
}
