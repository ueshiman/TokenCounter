namespace TokenCounter03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            if(args .Length == 0)
            {
                Console.WriteLine("トークンをカウントするファイルの指定が必要です。");
                return;
            }

            var countTokenTextDavinci003 = new CountTokenTextDavinci003();
            var text = System.IO.File.ReadAllText(args[0]);
            var count = countTokenTextDavinci003.CountToken(text);
            Console.WriteLine($"トークン数: {count}");
        }
    }
}
