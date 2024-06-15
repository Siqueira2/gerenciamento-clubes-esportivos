using GerenciamentoClubesEsportivos.Controllers;
using GerenciamentoClubesEsportivos.Models.Repositories;

namespace GerenciamentoClubesEsportivos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            MemberController controller = new MemberController(new MemberRepository());

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            controller.ImportFromXmlFile(@"C:\Users\walys\source\repos\newwww\testeee.xml");


        }
    }
}