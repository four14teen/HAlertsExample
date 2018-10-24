using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tangine;
using HAlerts;
using Sulakore.Modules;

namespace HAlertsTest
{
    public partial class MainFrm : ExtensionForm
    {
        [MessageId("3ed1b2efef33a502709fdf49436f3e37")]
        public ushort Header { get; set; }

        public override bool IsRemoteModule => true;
        public MainFrm()
        {
            InitializeComponent();
        }

        private async void SendAlertBtn_Click(object sender, EventArgs e)
        {
            HAlert alert = HAlertBuilder.CreateAlert(PopUpAlertCbx.Checked ? HAlertType.PopUp : HAlertType.Bubble, MessageTxt.Text)
                .Title(TitleTxt.Text)
                .EventUrl(EventTxt.Text, EventTxt.Text.StartsWith("http"))
                .EventTitle(EventTitleTxt.Text)
                .ImageUrl(ImageTxt.Text);

            await Connection.SendToClientAsync(alert.ToPacket(Header));
        }

        private void PopUpAlertCbx_CheckedChanged(object sender, EventArgs e)
            => MessageLbl.Text = PopUpAlertCbx.Checked ? "Alert Message (supports basic HTML)" : "Alert Message (Bubble does NOT support basic HTML)";
    }
}
