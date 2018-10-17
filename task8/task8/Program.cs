using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text("Жила была маша и была у неё каша Был хоккеист и любил он играть под подъездом Владимир пил молоко вместе со своей лайкой");
            //Text text = new Text("был");
            Console.WriteLine("Raw text: " + text.GetText());
            Console.WriteLine(text.SplitSyllables());
        }
    }
}
