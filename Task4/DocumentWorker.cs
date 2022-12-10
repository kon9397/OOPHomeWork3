using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class DocumentWorker
    {
        public virtual void DocumentOpen()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void DocumentEdit()
        {
            Console.WriteLine("Документ отредактирован");
        }

        public virtual void DocumentSave()
        {
            Console.WriteLine("Документ сохранен");
        }
    }
}
