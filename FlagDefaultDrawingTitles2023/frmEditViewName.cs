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
using Form = Autodesk.Revit.DB.Form;
using View = Autodesk.Revit.DB.View;

namespace FlagDefaultDrawingTitles2023
{
    public partial class frmEditViewName : System.Windows.Forms.Form
    {
        Document _doc;
        public frmEditViewName(Document doc, Element viewToEdit)
        {
            InitializeComponent();

            _doc = doc;
            var view = (View)viewToEdit;

            PopulateViewName(view);
        }

        public View UpdateNewViewName(string i, string n)
        {
            var id = i;
            var newName = n;

            using (Transaction t = new Transaction(_doc, "Change View Name"))
            {
                if (t.Start() == TransactionStatus.Started)
                {
                    ClsCollectors collector = new ClsCollectors();

                    foreach (View view in collector.GetAllViews(_doc))
                    {
                        if (view.Id.ToString() == id)
                        {
                            view.Name = newName;
                        }
                    }
                }
                t.Commit();
                t.Dispose();
            }

            return null;
        }

        private void PopulateViewName(View view)
        {
            lbl_id.Text = view.Id.ToString();
            tb_currentName.Text = view.Name;
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var id = lbl_id.Text;
            var newName = tb_newName.Text;

            // code below needs else statement, but regular if/else statement doesn't work because all forms close when task dialogue is closed

            // if (newName == null)
            // {
            //     TaskDialog.Show("Name Cannot Be Null", "Please enter a valid name")
            // }

            UpdateNewViewName(id, newName);
        }
    }
}
