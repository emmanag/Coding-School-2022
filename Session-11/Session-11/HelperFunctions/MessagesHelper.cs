using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_11.HelperFunctions
{
    public class MessagesHelper
    {
        public MessagesHelper()
        {

        }

        public void MessageInfo(string message)
        {
            MessageBox.Show(message, "Operation Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MessageError(string message)
        {
            MessageBox.Show(message, "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
