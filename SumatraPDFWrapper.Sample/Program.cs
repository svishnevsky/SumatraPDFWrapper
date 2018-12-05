namespace SumatraPDFWrapper.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var wrapper = new SumatraPDFWrapper();
            wrapper.Print("somefile.pdf", "Microsoft Print to PDF").Wait();
        }
    }
}