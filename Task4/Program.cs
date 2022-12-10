using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pro = "111";
            string exp = "222";

            string userKey = Console.ReadLine();
            DocumentWorker worker = null;
            if (userKey == pro)
            {
                worker = new ProDocumentWorker();
            } else if(userKey == exp)
            {
                worker = new ExpertDocumentWorker();
            } else
            {
                worker = new DocumentWorker();
            }

            worker.DocumentOpen();
            worker.DocumentEdit();
            worker.DocumentSave();

            Console.ReadKey();
        }
    }
}
