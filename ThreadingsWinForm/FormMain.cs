using System;
using System.Linq;
using System.Windows.Forms;
using ClassLibraryMobile.Messages;
using CSharpCourse;
using CSharpCourse.KeyBoards;
using CSharpCourse.Screens;
using SMSSimulation;
using Message = ClassLibraryMobile.Message;
using System.Threading;
using ClassLibraryMobile.Provider;

namespace ThreadingsWinForm
{
    public partial class FormMain : Form
    {
       // private static int iCountReceived, iCountSent;

        private readonly Formats formats;
        private Func<string, string> formatter;

        private readonly SimCorpMobile mobile = new SimCorpMobile(4, new RetinaScreen(),
            new KeyBoardGBoard(Layouts.English, Themes.FeatherDarkBlue));

//        private static ManualResetEvent waitHandlerSend = new ManualResetEvent(false);

        public FormMain()
        {
            InitializeComponent();

            formats = new Formats();
            formatter += formats.FormatNone;

//            threadsend = new Thread(SendSMS);
//            threadsend.IsBackground = true;


            mobile.Store.MessageAdded += UpdateListViewMsg;
            mobile.Store.MessageRemoved += UpdateListViewMsg;

            dateTimePicker1.Value = DateTime.Now.AddDays(-1);
            dateTimePicker2.Value = DateTime.Now.AddDays(+1);

            checkedListBox1.SetItemChecked(2, true);
        }


//        private void SendSMS()
//        {
//            while (true)
//            {
//                waitHandlerSend.WaitOne();
//                mobile.SmsProvider.SendSms(new Message(formatter($"Message #{++iCountSent} sent!"), false));
//                Thread.Sleep(2000);
//            }
 //       }

        private void comboBoxSelectFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            Delegate.RemoveAll(formatter, formatter);
            switch (comboBoxSelectFormat.SelectedIndex)
            {
                case 0:
                    formatter += formats.FormatNone;
                    break;
                case 1:
                    formatter += formats.FormatWithTime;
                    break;
                case 2:
                    formatter += formats.FormatWithTimeEnd;
                    break;
                case 3:
                    formatter += formats.FormatCustom;
                    break;
                case 4:
                    formatter += formats.FormatLowerCase;
                    break;
                case 5:
                    formatter += formats.FormatUpperCase;
                    break;
                default:
                    formatter += formats.FormatNone;
                    break;
            }
        }


        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
        }


        private void UpdateListViewMsg()
        {
            var filter = new Filter(comboBoxUser.SelectedItem?.ToString(),
                textBoxMsgPattern.Text,
                dateTimePicker1.Value, dateTimePicker2.Value,
                checkedListBox1.CheckedItems.Contains("subscriber") ? true : false,
                checkedListBox1.CheckedItems.Contains("message") ? true : false,
                checkedListBox1.CheckedItems.Contains("period") ? true : false,
                radioButton1.Checked);

            listViewMsg.Items.Clear();
            listViewMsg.View = View.Details;
            foreach (var msg in filter.GetFilteredList(mobile.Store.Messages))
            {
                listViewMsg.Items.Add(new ListViewItem(new[] {msg.User, msg.Text, msg.ReceivingTime.ToString()}));
            }
        }

        private void listViewMsg_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxUser_Click(object sender, EventArgs e)
        {
            comboBoxUser.Items.Clear();
            var rez = mobile.Store.Messages.GroupBy(m => m.User).Select(m => m).ToList();
            foreach (var item in rez)
            {
                comboBoxUser.Items.Add(item.Key);
            }
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonSendSMSStartStop_Click(object sender, EventArgs e)
        {
            //StartSMS(waitHandlerSend);
            if (radioButtonSendSMSThread.Checked) mobile.SmsProvider = new SMSByThread(mobile.Store, formatter);
                else mobile.SmsProvider = new SMSByTask(mobile.Store, formatter);

            buttonSendSMSStart.Enabled = false;
            buttonSendSMSStop.Enabled = true;
            radioButtonSendSMSThread.Enabled = false;
            radioButtonSendSMSByTask.Enabled = false;
        }

//        private void StartSMS(ManualResetEvent waitHandler) {
////            if (thre.ThreadState == (ThreadState.Background | ThreadState.Unstarted)) {
////                waitHandler.Set();
////                thre.Start();
////            } else {
//                waitHandler.Set();
//           // }
//        }

//        private void StopSMS(ManualResetEvent waitHandler) {
//            waitHandler.Reset();
//        }

        private void radioButtonSendSMSThread_CheckedChanged(object sender, EventArgs e) {

        }

        private void radioButtonSendSMSByTask_CheckedChanged(object sender, EventArgs e) {

        }

        

        private void buttonSendSMSStop_Click(object sender, EventArgs e) {
            //  StopSMS(providerSendCurrent.waitHandlerSend);
            mobile.SmsProvider.StopSubProvider();
            buttonSendSMSStart.Enabled = true;
            buttonSendSMSStop.Enabled = false;
            radioButtonSendSMSThread.Enabled = true;
            radioButtonSendSMSByTask.Enabled = true;
        }

    }
}