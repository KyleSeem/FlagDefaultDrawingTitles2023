using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Viewport = Autodesk.Revit.DB.Viewport;
using View = Autodesk.Revit.DB.View;

namespace FlagDefaultDrawingTitles2023
{
    internal class ClsCollectors
    {
        public List<View> GetAllViews(Document doc)
        {
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            collector.OfCategory(BuiltInCategory.OST_Views);

            List<View> viewList = new List<View>();
            var counter = 0;

            foreach (View view in collector)
            {
                viewList.Add(view);
                counter++;
            }
            return viewList;
        }

        public List<Viewport> GetAllViewports(Document doc)
        {
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            collector.OfCategory(BuiltInCategory.OST_Viewports);

            List<Viewport> vportList = new List<Viewport>();
            var counter = 0;

            foreach (Viewport vp in collector)
            {
                View view = (View)doc.GetElement(vp.ViewId);
                var viewName = view.Name;

                foreach (var c in viewName)
                {
                    if (char.IsLower(c))
                    {
                        vportList.Add(vp);
                        counter++;
                        break;
                    }
                }
            }
            return vportList;
        }
    }
}
