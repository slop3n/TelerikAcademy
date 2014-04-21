//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.
using System;
using System.Net;
using System.IO;

class DownloadFileFromInternet
{
    static void Main(string[] args)
    {
        WebClient downloadLogo = new WebClient();
        using (downloadLogo)
        {
            try
            {
                downloadLogo.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "../../logo.jpg");
                Console.WriteLine("File successfully downloaded");
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid adress or empty file!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address cannot be null!");
            }
        } 
    }
}