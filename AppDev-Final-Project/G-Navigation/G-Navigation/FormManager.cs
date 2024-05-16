using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Navigation
{
    public static class FormManager
    {
        private static Form previousForm;
        private static Panel homePanel;

        // Property to get the previously visible form
        public static Form PreviousForm
        {
            get { return previousForm; }
        }

        public static Panel HomePanel
        {
            get { return homePanel; }
        }


        // Method to update the previously visible form
        public static void UpdatePreviousForm(Form form)
        {
            previousForm = form;
        }

        public static void RegisterHomeForm(Panel panel)
        {
            homePanel = panel;
        }
    }
}
