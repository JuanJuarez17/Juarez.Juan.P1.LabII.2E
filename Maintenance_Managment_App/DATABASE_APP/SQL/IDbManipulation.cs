using ENTITIES_APP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATABASE_APP
{
    public interface IDbManipulation<T> where T : class
    {
        public string[] ArrayProperties(T inputInstance);
        public T ParseRow(DataRow inputRow);
        public List<T> Import();
        public void Create(T inputInstance);
        public T Read(int id);
        public void Update(int id, string attribute, string value);
        public void Delete(int id);
        public int Count();
        public string GetLast(string parameter);
        public string PrintParameter(int id, string parameter);
        public List<T> Sort(string parameter, string criteria);
    }
}
