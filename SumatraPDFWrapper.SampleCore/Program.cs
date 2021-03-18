namespace SumatraPDFWrapper.SampleCore
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var wrapper = new SumatraPDFWrapper();
            wrapper.Print("somefile.pdf", "Microsoft Print to PDF").Wait();
        }
    }
}
