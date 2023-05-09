using DrawingApp.Library.Concrete;

namespace DrawingApp.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Paint _paint = new Paint(canvas,shapeTools,modifireTools,fileTools,colors); 
        }



    }
}