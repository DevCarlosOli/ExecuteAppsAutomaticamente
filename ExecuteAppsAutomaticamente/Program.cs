using System;
using System.Diagnostics;

namespace ExcuteAppsAutomaticamente
{
    class Program
    {
        static void Main(string[] args)
        {
			// Caminhos dos .exe do Google Chrome e do Visual Studio
			string caminhoChrome = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
			string caminhoVS = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe";

			try
			{
				// Abrir o Google Chrome
				Process.Start(caminhoChrome);

				// Intervalo para que o Chrome possa abrir.
				Thread.Sleep(2000);

				// Abrir o Visual Studio 2022
				Process.Start(caminhoVS);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Ocorreu um erro ao tentar abrir os programas!");
                Console.WriteLine(ex.Message);
			}

        }
    }

}
