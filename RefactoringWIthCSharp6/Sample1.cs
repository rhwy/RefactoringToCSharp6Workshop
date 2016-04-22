namespace CSharp6Refactorings
{
    using Xunit;
    using NFluent;
    using System.Collections.Generic;
    
    public class Sample1Tests
    {
        [Fact] public void
        my_first_test()
        {
            var list = new[]{3,6,9,12,15,24,30,36};
            var compute = new Compute();
            var filteredList = compute.FilterNumbers(list);
            
            Check.That(filteredList).ContainsExactly(6,12,24);
        }
        
        
    }
    
    public class Compute
    {
        public IEnumerable<int> FilterNumbers(int[] source)
        {
            int counter=0;
            var list = new List<int>();
            for (int i = 0; i < source.Length; i++)
            {
                var current = source[i];
                if((current % 2 == 0) && (current % 3 == 0))
                {
                    if(current % 5 != 0)
                    {
                        list.Add(current);
                        counter++;
                    }
                }
                if(counter==3)
                    break;
            }
            return list;
        }
    }
}
