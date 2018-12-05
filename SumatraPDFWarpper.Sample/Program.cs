namespace SumatraPDFWarpper.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var wrapper = new SumatraPDFWarpper();
            wrapper.Print("somefile.pdf", "Microsoft Print to PDF").Wait();
        }
    }
}