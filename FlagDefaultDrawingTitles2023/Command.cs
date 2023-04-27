#region Namespaces

using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Application = Autodesk.Revit.ApplicationServices.Application;
using View = Autodesk.Revit.DB.View;

#endregion

namespace FlagDefaultDrawingTitles2023
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            ClsCollectors collector = new ClsCollectors();
            var vpList = collector.GetAllViewports(doc);

            if (vpList.Count == 0)
            {
                TaskDialog.Show("No Default Titles", "There are no viewports with lowercase letters.");
                
            }
            else
            {
                using (frmViewsForm form = new frmViewsForm(doc))
                {
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.Cancel)
                    {
                        // result cancelled
                    }
                    else if (form.DialogResult == DialogResult.OK)
                    {
                        frmViewsForm newForm = new frmViewsForm(doc);
                        if (vpList.Count > 0)
                        {
                            newForm.ShowDialog();
                        }
                    }
                    else
                    {

                    }
                }
            }

            

            return Result.Succeeded;
        }
    }
}
