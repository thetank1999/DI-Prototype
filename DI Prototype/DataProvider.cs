using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Prototype
{
    public class DataProvider 
    {
        #region [ Fields ]
        protected readonly string Id;
        protected readonly string Name;
        protected readonly string Description;
        #endregion

        #region [ CTor ]
        public DataProvider() {

        }
        #endregion

        #region [ Public Methods ]
        public string PrintString(string inputString) {
            return this.Id + this.Name + this.Description + $" {inputString}  hehe";
        }
        #endregion
    }
}
