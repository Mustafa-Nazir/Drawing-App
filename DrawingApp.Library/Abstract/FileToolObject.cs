using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Abstract
{
    public abstract class FileToolObject:BaseToolObject
    {
        public FileToolObject()
        {
            this.Click += toolOnClick;
        }

        protected virtual void toolOnClick(object sender , EventArgs e)
        {

        }
    }
}
