using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project1
{
    internal interface IManager
    {
        void Create(string name);

        List<string> ShowCatalog(string nameCatalog);

        void Delete(string name);

        void ReName(string name);

        void Copy(string name);

        void CalculateFile(string name);

        void Search(string name);

        DataFile Datafile(string filename);





    }
}
