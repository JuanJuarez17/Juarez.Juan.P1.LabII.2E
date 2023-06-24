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
        public T ParseRow(DataRow inputRow);
        public List<T> Import();
        public void Create(T inputInstance);
        public T Read(string primaryKey);
        public void Update(string primaryKey, string attribute, string value);
        public void Delete(string primaryKey);
        public int Count();
        public string GetLast(string parameter);
    }
}
