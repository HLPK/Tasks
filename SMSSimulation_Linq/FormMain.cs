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

namespace SMSSimulation_Linq {
    public partial class FormMain :Form
    {
        private SimCorpMobile mobile = new SimCorpMobile(3, new RetinaScreen(), new KeyBoardGBoard(layout: Layouts.English, theme: Themes.FeatherDarkBlue), new SMSProvider());

        private Formats formats;    
        private delegate string FormatDelegate(string text);
        private FormatDelegate formatter;

       // private WinFormRTBOutput winFormRtbOutput;

        private static int iCount = 0;

        private List<ClassLibraryMobile.Message> messages;

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();


        public FormMain()
        {
            InitializeComponent();
            //winFormRtbOutput = new WinFormRTBOutput(richTextBoxMessages);
            messages = new List<Message>();

            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1000;
            myTimer.Start();

            mobile.SmsProvider.SMSMessageReceived += OnSmsReceived;

            formats = new Formats();
            formatter += formats.FormatNone;
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs) {
            mobile.SmsProvider.GetSms(new ClassLibraryMobile.Message($"Message #{++iCount} received!"));
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

       
        public void OnSmsReceived(ClassLibraryMobile.Message message) {
            if (InvokeRequired)
            {
                Invoke(new SMSProvider.SMSMessageReceivedDelegate(OnSmsReceived), message);
                return;
            }

            string formattedMessage = formatter($"{message.Text}");
            message.Text = formattedMessage;
            message.ReceivingTime = DateTime.Now;
            messages.Add(message);
            //winFormRtbOutput.WriteLine($"{formattedMessage} from {message.User}");
        }


        private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
            myTimer.Stop();
            myTimer.Dispose();
        }

        private void richTextBoxMessages_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            listViewMsg.Items.Clear();
            listViewMsg.View = View.Details;
            foreach (ClassLibraryMobile.Message msg in messages)
            {
                listViewMsg.Items.Add(new ListViewItem(new[] { msg.User, msg.Text, msg.ReceivingTime.ToString()}));
            }
            
        }

        private void listViewMsg_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
