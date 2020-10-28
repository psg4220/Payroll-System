using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.misc
{


    class NoticeDialogues
    {

        public NoticeDialogues(ArraySegment<String> str, String str2, MessageBoxButtons btn, MessageBoxIcon icn)
        {
            StringBuilder builder = new StringBuilder();

            if (str.Equals(""))
            {
                Console.WriteLine("No String Input at str Variable in NoticeDialogue Class");
            }

            for(int x=0;x>str.Count;x++)
            {
                builder = builder.Append(str.Array[x] + "\n");
            }

            
            //Default if leave blank
            if (str2.Equals(""))
            {
                str2 = "Error";
            }
            if (btn.Equals(""))
            {
                btn = MessageBoxButtons.OK;
            }
            if (icn.Equals(""))
            {
                icn = MessageBoxIcon.Error;
            }

            MessageBox.Show(builder.ToString(), str2, btn,icn);

        }

    }
}
