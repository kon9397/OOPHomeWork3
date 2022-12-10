using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class ProDocumentWorker : DocumentWorker
    {
        public override void DocumentOpen()
        {
            Console.WriteLine("Документ открыт");
        }

        public override void DocumentEdit()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public override void DocumentSave()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в других форматах есть в версии Эксперт");
        }
    }
}
