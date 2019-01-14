using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCollectionApp.Interface;

namespace StringCollectionApp.Model
{
    public class StringCollection : IStringCollection
    {
        private readonly List<string> _collection = new List<string>();
        private string _lastFoldedString;
        private const string delimiter = ",";

        public virtual void AddString(string s)
        {

            lock (_collection)
            {
                _collection.Add(s);
                _lastFoldedString = _collection.Aggregate((i, j) => i + delimiter + j);
            }
        }

        public override string ToString()
        {
            return _lastFoldedString;
        }
    }
}
