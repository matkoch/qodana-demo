namespace ClassLibrary1
{
    public class Utility
    {
        public int property2 { get; set; }
        public int Property { get; internal set; }

        public void Foo(string word)
        {
            foreach (var c in word)
            {
                foreach (var c1 in word)
                {
                    foreach (var c2 in word)
                    {
                        foreach (var c3 in word)
                        {
                        }
                    }
                }
            }
        }
    }
}
