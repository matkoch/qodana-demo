namespace ClassLibrary1
{
    public class Utility
    {
        public int SomeProperty { get; set; }
        public int Property { get; internal set; }

        public void Foo(string word)
        {
            var lastChar = word[^1];

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
