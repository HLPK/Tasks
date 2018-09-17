using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpCourse;
using CSharpCourse.AddDictionary;
using CSharpCourse.Factory;

namespace WinFormProject {
    public partial class FormMain : Form
    {
        public int selectedItem = 0, curItem;
        public IOutput output;
        private FactoryDict factory;

        public FormMain() {
            InitializeComponent();

            output = new WinFormOutput(textBoxRes);
            curItem = 0;

            factory = new FactoryDict(output: output);
            radioButton1.Text = factory.GetFactoryItem(curItem).ToString();
            radioButton2.Text = factory.GetFactoryItem(++curItem).ToString();
            radioButton3.Text = factory.GetFactoryItem(++curItem).ToString();
            radioButton4.Text = factory.GetFactoryItem(++curItem).ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selectedItem = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selectedItem = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selectedItem = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            selectedItem = 3;
        }

        private void buttonApply_Click(object sender, EventArgs e) {
            textBoxRes.Clear();

            ITranslate choise_item = factory.GetFactoryItem(selectedItem);
            output.WriteLine($"{choise_item.ToString()} selected \n");
            output.WriteLine(" Set Dictionary to Mobile... \n");
            output.WriteLine(" Start translating... \n");
            choise_item.Translate("test");
        }
    }
}
