using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine
{
    public interface User
    {
        public void Create();
        public void Read();
        public void Update();
        public void Delete();
        public void Search();
        public void Save();

    }
}
