using Eto.Forms;
using OxyPlot;
using OxyPlot.GtkSharp;

namespace Eto.OxyPlot.Gtk
{
    public class PlotHandler : GtkSharp.Forms.GtkControl<PlotView, Plot, Control.ICallback>, Plot.IHandler
    { 
        public PlotModel Model
        {
            get { return Control.Model; }
            set { Control.Model = value; }
        }

        public PlotHandler()
        {
            Control = new global::OxyPlot.GtkSharp.PlotView()
            {
            };
        }
    }
}
