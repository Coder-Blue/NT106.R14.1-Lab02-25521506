namespace NT106.R14._1_Lab02_25521506
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMenu());
        }
    }
}
