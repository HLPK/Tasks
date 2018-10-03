using CSharpCourse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ClassLibraryMobile;
using CSharpCourse.KeyBoards;
using CSharpCourse.Screens;
using System.Threading;

namespace ContactsWinForm {
    public partial class FormMain :Form {

        private static string[] oper = new string[] { "+3098", "+3066", "+3095", "+3073" };
        private static string symb = "0123456789";
        private static Random rnd = new Random();
       // private static Random rnd2 = new Random();

        private readonly SimCorpMobile mobile = new SimCorpMobile(4, new RetinaScreen(),
            new KeyBoardGBoard(Layouts.English, Themes.FeatherDarkBlue));

        public FormMain() {
            InitializeComponent();
        }

        private void buttonGenerateContacts_Click(object sender, EventArgs e)
        {
            if (mobile.Contacts.Count > 0) return;

            mobile.Contacts.Add(new Contact("Vasya", new List<string>() { GenRandomPhoneNumber(), GenRandomPhoneNumber(), GenRandomPhoneNumber() }));
            mobile.Contacts.Add(new Contact("Petya", new List<string>() { GenRandomPhoneNumber(), GenRandomPhoneNumber(), GenRandomPhoneNumber(), GenRandomPhoneNumber() }));
            mobile.Contacts.Add(new Contact("Olya", new List<string>() { GenRandomPhoneNumber() }));
            mobile.Contacts.Add(new Contact("Oleg", new List<string>() { GenRandomPhoneNumber() }));

            foreach (var item in mobile.Contacts)
            {
                TreeNode nodeName = treeView1.Nodes.Add(item.Name);
                foreach (var ph in item.Phones)
                {
                    nodeName.Nodes.Add(ph);
                }
            }
        }

        private static string GenRandomPhoneNumber()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(oper[rnd.Next(0, 3)]);

            for (int i = 0; i < 7; i++)
            {
                stringBuilder.Append(symb[rnd.Next(0, symb.Length - 1)]);
            }

            return stringBuilder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(GeneratingCalls);
           // GeneratingCalls();
        }

        private void GeneratingCalls()
        {
            Random rnd1 = new Random();
            Random rnd2 = new Random();

            DateTime dt = DateTime.Today;
            int i = 0;
            //for (int i = 0; i < 10; i++)

            while (true)
            
            {
                i++;
                 
                Contact rndContact = mobile.Contacts[rnd1.Next(0, mobile.Contacts.Count - 1)];
                string rndContactNumber = rndContact.Phones[rnd1.Next(0, rndContact.Phones.Count - 1)];
                

                if (i % 4 == 0)
                {
                    mobile.Calls.AddCall(new Call(rndContact, rndContactNumber, dt, CallDirections.outcoming, 1.0));
                    mobile.Calls.AddCall(new Call(rndContact, rndContactNumber, dt, CallDirections.outcoming, 2.0));
                }
                /*if (i == 3)
                {
                    mobile.Calls.AddCall(new Call(rndContact, rndContactNumber, DateTime.Now, CallDirections.outcoming, 1.0));
                    mobile.Calls.AddCall(new Call(rndContact, rndContactNumber, DateTime.Now, CallDirections.outcoming, 2.0));
                    mobile.Calls.AddCall(new Call(rndContact, rndContactNumber, DateTime.Now, CallDirections.outcoming, 3.0));
                }*/
                else
                    mobile.Calls.AddCall(new Call(rndContact, rndContactNumber, DateTime.Now, CallDirections.incoming,
                        rnd2.NextDouble()));
                Thread.Sleep(2000);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            listView1.Items.Clear();
            listView1.View = View.Details;
            List<Call> listCalls = mobile.Calls.GetListCalls();
            if (radioButtonNone.Checked) {
                foreach (var item in listCalls)
                    {
                        listView1.Items.Add(new ListViewItem(new []{item.Cont.Name,item.Phone,item.Direction.ToString(),item.CallTime.ToString(), Math.Round(item.Duration,2).ToString(),item.Num.ToString()}));
                    }
            } else
            {
                var Gr = listCalls.GroupBy(l => l.Cont.Name);
                if (radioButtonContact.Checked) Gr = listCalls.GroupBy(l => l.Cont.Name);
                else
                {
                    if (radioButtonNumber.Checked) Gr = listCalls.GroupBy(l => l.Phone);
                    else Gr = listCalls.GroupBy(l => l.Direction.ToString());
                }

                foreach (var group in Gr) {
                    ListViewGroup l = new ListViewGroup(group.Key, HorizontalAlignment.Left);
                    listView1.Groups.Add(l);
                    foreach (var item in group) {
                        listView1.Items.Add(
                            new ListViewItem(
                                new[]
                                {
                                    item.Cont.Name, item.Phone, item.Direction.ToString(), item.CallTime.ToString(),
                                    Math.Round(item.Duration, 2).ToString(), item.Num.ToString()
                                }, 0, l));
                    }

                }
            }

            //            foreach (var item in mobile.Calls.GetListCalls())
            //            {
            //                listView1.Items.Add(new ListViewItem(new []{item.Cont.Name,item.Phone,item.Direction.ToString(),item.CallTime.ToString(), Math.Round(item.Duration,2).ToString(),item.Num.ToString()}));
            //            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e) {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            if (listView1.SelectedIndices.Count == 0) return;

            listViewHistory.Items.Clear();
            listViewHistory.View = View.Details;

            ListViewItem.ListViewSubItemCollection collection = listView1.Items[listView1.SelectedIndices[0]].SubItems;
            //int num = Int32.Parse(collection[5].Text);
            //if (num < 2) return;

            // Current contact
            Contact curCont = new Contact();
            bool fl = false;
            foreach (var item in mobile.Contacts)
            {
                if (item.Name == collection[0].Text)
                {
                    fl = true;
                    curCont = item;
                    break;
                }
            }
            if (fl == false) return;
            foreach (var item in mobile.Calls.GetListHistory(curCont, collection[1].Text,(collection[2].Text == "incoming"?CallDirections.incoming : CallDirections.outcoming), DateTime.Parse(collection[3].Text)))
            {
                listViewHistory.Items.Add(new ListViewItem(new[] { item.Phone, item.Direction.ToString(),item.CallTimeHistory.ToString(), Math.Round(item.Duration,2).ToString() }));
            }


        }
    }
}
