using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentApp1
{
    public static class Utils
    {
        public static bool FormIsOpen(string name)
        {
            //check if window is already open
            var openForms = Application.OpenForms.Cast<Form>();
            var isOpen = openForms.Any(x => x.Name == name);
            return isOpen;
        }
    }
}
