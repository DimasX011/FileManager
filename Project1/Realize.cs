using System.Collections.Generic;
using System.IO;

namespace Project1
{
    class Realize : IManager
    {
        public void CalculateFile(string name)
        {
            throw new System.NotImplementedException();
        }

        public void Copy(string name)
        {
            throw new System.NotImplementedException();
        }

        public void Create(string name)
        {
            string path = @"C:\Users\Dimon\source\repos\для курсача\";
            FileStream fstream = new FileStream(path + name, FileMode.OpenOrCreate);
            fstream.Close();
        }

        public DataFile Datafile(string filename)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string name)
        {
            throw new System.NotImplementedException();
        }

        public void ReName(string name)
        {
            throw new System.NotImplementedException();
        }

        public void Search(string name)
        {
            throw new System.NotImplementedException();
        }

        public List<string> ShowCatalog(string nameCatalog)
        {
            throw new System.NotImplementedException();
        }
    }
}