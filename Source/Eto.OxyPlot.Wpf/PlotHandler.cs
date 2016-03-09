using Eto.Drawing;
using Eto.Forms;
using Eto.Wpf;
using Eto.Wpf.Forms;
using OxyPlot;
using OxyPlot.Wpf;

namespace Eto.OxyPlot.Wpf
{
    public class PlotHandler : WpfFrameworkElement<PlotView, Plot, Control.ICallback>, Plot.IHandler
    {
        
        public override Color BackgroundColor
        {
            get
            {
                return Control.Background.ToEtoColor();
            }
            set
            {
                Control.Background = value.ToWpfBrush(Control.Background);
            }
        }

        public PlotModel Model
        {
            get { return Control.Model; }
            set { Control.Model = value; }
        }

        public PlotHandler()
        {
            Control = new PlotView() { };
        }
    }
}
