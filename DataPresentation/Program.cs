using System.Text.Json;
using System.Xml.Serialization;

namespace DataPresentation
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Ñowshed());
        }
    }
}