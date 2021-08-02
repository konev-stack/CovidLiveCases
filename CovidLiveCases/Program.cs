using System;


namespace CovidLive
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                HtmlAgilityPack.HtmlWeb website = new HtmlAgilityPack.HtmlWeb();

                //loading website
                HtmlAgilityPack.HtmlDocument htmlDocument = website.Load("https://www.worldometers.info/coronavirus/");

                var dataList = htmlDocument.DocumentNode.SelectNodes("//div[@class='maincounter-number']");


                int num = 0;
                foreach (var content in dataList)
                {
                    if (num == 0)
                    {
                        Console.WriteLine("Coronavirus Cases:");
                        num++;
                    }
                    else if (num == 1)
                    {
                        Console.WriteLine("Deaths:");
                        num++;
                    }
                    else if (num == 2)
                    {
                        Console.WriteLine("Recovered:");
                        num++;
                    }

                    Console.WriteLine(content.InnerText);

                }
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
            }


        }
    }
}
