using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationUI.Communication
{
    public static class MessageController
    {
        public static void DisplayLabelErrorMessage(Label ReplyMessageLabel, string message)
        {
            ReplyMessageLabel.Text = message;
            ReplyMessageLabel.ForeColor = Color.Red;
        }

        public static void DisplayLabelSuccessMessage(Label ReplyMessageLabel, string message)
        {
            ReplyMessageLabel.Text = message;
            ReplyMessageLabel.ForeColor = Color.Green;
        }

        public static bool ConfirmOperationMessageBox(string message, string windowTitle)
        {
            return MessageBox.Show(
                message,
                windowTitle,
                MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
    }
}
