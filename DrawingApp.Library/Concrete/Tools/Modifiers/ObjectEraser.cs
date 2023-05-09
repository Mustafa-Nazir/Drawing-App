using DrawingApp.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Concrete.Tools.Modifiers
{
    public class ObjectEraser:ModifierToolObject
    {
        private static ObjectEraser? _instance;
        public static ObjectEraser Instance
        {
            get
            {
                if( _instance == null ) _instance = new ObjectEraser();
                return _instance;
            }
        }

        public ObjectEraser()
        {
            this.Image = Image.FromFile(@"..\images\delete.png");
        }

        protected override void toolOnClik(object sender, EventArgs e)
        {
            deleteObject();
            BorderStyleToDisable();
        }

        private void deleteObject()
        {
            if (!ObjectSelector.Instance.IsSelect || ActiveElement.Instance.ActiveObject == null) return;
            ActiveElement.Instance.ActiveCanvas.Controls.Remove(ActiveElement.Instance.ActiveObject);
        }
    }
}
