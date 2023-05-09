using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Abstract
{
    public abstract class ModifierToolObject:BaseToolObject
    {
        public ModifierToolObject()
        {
            this.Click += toolOnClik;
        }

        protected virtual void toolOnClik(object sender , EventArgs e)
        {

        }
    }
}
