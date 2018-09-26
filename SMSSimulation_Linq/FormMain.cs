using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ClassLibraryMobile;
using CSharpCourse;
using CSharpCourse.KeyBoards;
using CSharpCourse.Screens;
using SMSSimulation;
using Message = ClassLibraryMobile.Message;
using ClassLibraryMobile.Messages;

namespace SMSSimulation_Linq {
    public partial class FormMain :Form
    {
        private SimCorpMobile mobile = new SimCorpMobile(3, new RetinaScreen(), new KeyBoardGBoard(layout: Layouts.English, theme: Themes.FeatherDarkBlue));

        private Formats formats;    
        private delegate string FormatDelegate(string text);
        private FormatDelegate formatter;

       // private WinFormRTBOutput winFormRtbOutput;

        private static int iCountReceived, iCountSent = 0;

        //private List<ClassLibraryMobile.Message> messages;

        static System.Windows.Forms.Timer myTimerReceive = new System.Windows.Forms.Timer();
        static System.Windows.Forms.Timer myTimerSend = new System.Windows.Forms.Timer();


        public FormMain()
        {
            InitializeComponent();

            //messages = new List<Message>();
            //mobile.SmsProvider.SMSMessageReceived += OnSmsReceived;

            formats = new Formats();
            formatter += formats.FormatNone;

            myTimerReceive.Tick += new EventHandler(TimerEventReceiveProcessor);
            myTimerReceive.Interval = 1000;
            myTimerReceive.Start();

            myTimerSend.Tick += new EventHandler(TimerEventSendProcessor);
            myTimerSend.Interval = 2000;
            myTimerSend.Start();

            mobile.Store.MessageAdded += UpdateListViewMsg;
            mobile.Store.MessageRemoved += UpdateListViewMsg;

            dateTimePicker1.Value = DateTime.Now.AddDays(-1);
            dateTimePicker2.Value = DateTime.Now.AddDays(+1);

            checkedListBox1.SetItemChecked(2,true); 
        }

        private void TimerEventReceiveProcessor(Object myObject, EventArgs myEventArgs) {
            mobile.SmsProvider.GetSms(new ClassLibraryMobile.Message(formatter($"Message #{++iCountReceived} received!"),true));
        }

        private void TimerEventSendProcessor(Object myObject, EventArgs myEventArgs) {
            mobile.SmsProvider.SendSms(new ClassLibraryMobile.Message(formatter($"Message #{++iCountSent} sent!"),false));
        }

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

       
        /*public void OnSmsReceived(ClassLibraryMobile.Message message) {
            if (InvokeRequired)
            {
                Invoke(new SMSProvider.SMSMessageReceivedDelegate(OnSmsReceived), message);
                return;
            }

            string formattedMessage = formatter($"{message.Text}");
            message.Text = formattedMessage;
            message.ReceivingTime = DateTime.Now;
            messages.Add(message);
        }*/


        private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
            myTimerReceive.Stop();
            myTimerReceive.Dispose();

            myTimerSend.Stop();
            myTimerSend.Dispose();
        }

        private void richTextBoxMessages_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateListViewMsg();
        }

        private void UpdateListViewMsg()
        {
            Filter filter = new Filter(subscriber: comboBoxUser.SelectedItem?.ToString(),
                messagePattern: textBoxMsgPattern.Text,
                dateFrom: dateTimePicker1.Value, dateTo: dateTimePicker2.Value,
                isSubscriber: (checkedListBox1.CheckedItems.Contains("subscriber") ? true : false),
                isMessagePattern: (checkedListBox1.CheckedItems.Contains("message") ? true : false),
                isPeriod: (checkedListBox1.CheckedItems.Contains("period") ? true : false),
                isOr: radioButton1.Checked);

            listViewMsg.Items.Clear();
            listViewMsg.View = View.Details;
            foreach (ClassLibraryMobile.Message msg in filter.GetFilteredList(mobile.Store.Messages))
            {
                listViewMsg.Items.Add(new ListViewItem(new[] {msg.User, msg.Text, msg.ReceivingTime.ToString()}));
            }
        }

        private void listViewMsg_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e) {
     
        }

        private void comboBoxUser_Click(object sender, EventArgs e) {
            comboBoxUser.Items.Clear();
            var rez = mobile.Store.Messages.GroupBy(m => m.User).Select(m => m).ToList();
            foreach (var item in rez) {
                comboBoxUser.Items.Add(item.Key);
            }
        }

        private void button1_Click_1(object sender, EventArgs e) {
            foreach (Message msg in listViewMsg.SelectedItems)
            {
                mobile.Store.RemoveMessage(msg);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {
            
        }
    }
}
