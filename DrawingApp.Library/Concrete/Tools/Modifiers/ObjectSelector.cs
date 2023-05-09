using DrawingApp.Library.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Library.Concrete.Tools.Modifiers
{
    public class ObjectSelector:ModifierToolObject
    {
        private static ObjectSelector? _instance;
        public static ObjectSelector Instance
        {
            get
            {
                if( _instance == null ) _instance = new ObjectSelector();
                return _instance;
            }
        }

        public ObjectSelector()
        {
            this.Image = Image.FromFile(RootPath+@"\images\touch.png");
        }

        public void SetActive()
        {
            this.IsSelect = true;
            BorderStyleToEnable();
        }

        protected override void ObjectOnClick(object sender, EventArgs e)
        {
            disable();
            changeSelection();
        }

        private void changeSelection()
        {
            if (this.IsSelect) BorderStyleToDisable();
            else BorderStyleToEnable();
        }

        private void disable()
        {
            if(this.IsSelect && ActiveElement.Instance.ActiveObject != null) ActiveElement.Instance.ActiveObject.Disable();
        }
    }
}
