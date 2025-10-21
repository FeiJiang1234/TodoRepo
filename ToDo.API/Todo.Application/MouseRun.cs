namespace Todo.Application
{
    public class CatShoutEventArgs : EventArgs
    {
        public string Name { get; set; }
    }

    public class Cat
    {
        public delegate void CatShoutHandler(object sender, CatShoutEventArgs args);
        public event CatShoutHandler CatShouted;

        public void Shout()
        {
            Console.WriteLine("Cat Shout");

            var e = new CatShoutEventArgs
            {
                Name = "Kitty"
            };
            CatShouted(this, e);
        }
    }

    public class Mouse
    {
        public void Run(object sender, CatShoutEventArgs args)
        {
            Console.WriteLine("Run");
        }
    }
}
