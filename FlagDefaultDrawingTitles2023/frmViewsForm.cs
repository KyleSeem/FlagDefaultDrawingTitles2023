using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using View = Autodesk.Revit.DB.View;

namespace FlagDefaultDrawingTitles2023
{
    public partial class frmViewsForm : System.Windows.Forms.Form
    {
        Document _doc;

        public struct StructVp
        {
            public string vpViewName;
            public string vpViewType;
            public string vpSheetNumber;
            public string viewId;
            public Viewport VPort;
        }


        public frmViewsForm(Document doc)
        {
            InitializeComponent();
            _doc = doc;

            List<StructVp> vpList = new List<StructVp>();
            ClsCollectors collector = new ClsCollectors();

            
            foreach (Viewport vp in collector.GetAllViewports(doc))
            {
                StructVp tmpVp;
                View tmpView = (View)doc.GetElement(vp.ViewId);
                ViewSheet tmpViewSheet = (ViewSheet)doc.GetElement(vp.SheetId);

                tmpVp.VPort = vp;
                tmpVp.vpViewName = tmpView.Name;
                tmpVp.vpViewType = tmpView.ViewType.ToString();
                tmpVp.vpSheetNumber = tmpViewSheet.SheetNumber;
                tmpVp.viewId = tmpView.Id.ToString();

                vpList.Add(tmpVp);

                // if (vpList.Count < 1)
                // {
                //     TaskDialog.Show("No Default Titles", "There are no viewports with lowercase letters.");
                //     return;
                // }
            }

            vpList = vpList.OrderBy(x => x.vpViewType).ToList();

            foreach (StructVp tmpVp in vpList)
            {
                string[] tmpRow = { tmpVp.vpSheetNumber, tmpVp.vpViewType, tmpVp.vpViewName, tmpVp.viewId };

                this.dg_views.Rows.Add(tmpRow);
            }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            ClsCollectors collector = new ClsCollectors();
            // get view id from selected view
            var viewId = dg_views.SelectedRows[0].Cells["Id"].Value;

            if (viewId == null)
            {
                TaskDialog.Show("No Default Titles", "There are no viewports with lowercase letters.");
                return;
            }

            foreach (View view in collector.GetAllViews(_doc))
            {
                if (view.Id.ToString() == viewId.ToString())
                {
                    var frmEditViewName = new frmEditViewName(_doc, view);
                    frmEditViewName.MdiParent = this.MdiParent;
                    frmEditViewName.ShowDialog();
                }
            }
        }
    }
}
