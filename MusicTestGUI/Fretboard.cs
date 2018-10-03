using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using MusicTest;
using SvgNet;

namespace MusicTestGUI
{
    public partial class Fretboard : Form
    { 
        public Fretboard()
        {
            InitializeComponent();
               
        }

        private void Fretboard_Load(object sender, EventArgs e)
        {
            Notes n = new Notes();      // create new Notes object

            // Build and load data for instrument selection drop down menu.
            const int INSTRUMENTS_SIZE = 2;
            string[] instruments = new string[INSTRUMENTS_SIZE];            
            instruments[0] = "Guitar";
            instruments[1] = "Bass";
            CbInstruments.Items.AddRange(instruments);

            // Load data for Key selection drop down menu.
            CbKey.Items.AddRange(n.NoteDict.Values.ToArray());

            // Clear labels in 'scale' section
            ClearLabels();

            // Clear and load fretboard .xml file. 
            ClearFretboard();
            LoadFretBoard();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            ClearFretboard();           // clear fretboard
            Notes n = new Notes();      // create new Notes object

            // Create new list to hold the scale the user selects.
            List<string> scale = new List<string>();
            string root = CbKey.Text;               // variable to store user input for root value. 

            // If Radiobutton 'RbMajor' is selected, store THAT scale in the 'scale' list.
            if (RbMajor.Enabled == true)
            {
                scale = n.BuildMajorScale(root).ToList();
                LblFirst.Text = scale[0];
                LblSecond.Text = scale[1];
                LblThird.Text = scale[2];
                LblFourth.Text = scale[3];
                LblFifth.Text = scale[4];
                LblSixth.Text = scale[5];
                LblSeventh.Text = scale[6];

                // Create new XML document and load the selected fretboard into the XML document.
                XmlDocument FretboardXML = new XmlDocument();
                FretboardXML.Load("C:\\Users\\Ashton\\source\\repos\\MusicTest\\MusicTestGUI\\Images\\Fretboard_Guitar.svg");

                // Make note markers in the scale list visible. 
                foreach (XmlNode x in FretboardXML.LastChild.LastChild)
                {
                    if (x.Attributes["note"].Value == "\"" + scale[0] + "\"")
                        x.Attributes["style"].InnerText = "fill:#3fb1ea;fill-opacity:1;stroke:none";
                    if (x.Attributes["note"].Value == "\"" + scale[1] + "\"")
                        x.Attributes["style"].InnerText = "fill:#0f389a;fill-opacity:1;stroke:none";
                    if (x.Attributes["note"].Value == "\"" + scale[2] + "\"")
                        x.Attributes["style"].InnerText = "fill:#0f389a;fill-opacity:1;stroke:none";
                    if (x.Attributes["note"].Value == "\"" + scale[3] + "\"")
                        x.Attributes["style"].InnerText = "fill:#0f389a;fill-opacity:1;stroke:none";
                    if (x.Attributes["note"].Value == "\"" + scale[4] + "\"")
                        x.Attributes["style"].InnerText = "fill:#0f389a;fill-opacity:1;stroke:none";
                    if (x.Attributes["note"].Value == "\"" + scale[5] + "\"")
                        x.Attributes["style"].InnerText = "fill:#0f389a;fill-opacity:1;stroke:none";
                    if (x.Attributes["note"].Value == "\"" + scale[6] + "\"")
                        x.Attributes["style"].InnerText = "fill:#0f389a;fill-opacity:1;stroke:none";
                }

                // Save the modified document and load it into the GUI
                FretboardXML.Save("C:\\Users\\Ashton\\source\\repos\\MusicTest\\MusicTestGUI\\Images\\Fretboard_Guitar.svg");
                LoadFretBoard();
            }            
        }

        // Disables markers the XML image 'Fretboard' and resets the UI
        private void BtnClear_Click(object sender, EventArgs e)
        {
            CbInstruments.SelectedItem = CbInstruments.Items[0];
            CbKey.SelectedItem = CbKey.Items[0];
            ClearLabels();
            ClearFretboard();
            LoadFretBoard();
        }

        // Clears the Scale labels on the UI
        private void ClearLabels()
        {
            LblFirst.Text = "";
            LblSecond.Text = "";
            LblThird.Text = "";
            LblFourth.Text = "";
            LblFifth.Text = "";
            LblSixth.Text = "";
            LblSeventh.Text = "";
        }

        // Hides the markers on the XML image 'Fretboard' document.
        private void ClearFretboard()
        {
            // make fretboard note markers transparent
            XmlDocument FretboardXML = new XmlDocument();
            FretboardXML.Load("C:\\Users\\Ashton\\source\\repos\\MusicTest\\MusicTestGUI\\Images\\Fretboard_Guitar.svg");

            foreach (XmlNode x in FretboardXML.LastChild.LastChild)
            {
                x.Attributes["style"].InnerText = x.Attributes["style"].InnerText + ";opacity:0";
            }

            // Save XML document with modifications.
            FretboardXML.Save("C:\\Users\\Ashton\\source\\repos\\MusicTest\\MusicTestGUI\\Images\\Fretboard_Guitar.svg");
        }

        // Loads the XML image 'Fretboard' into the webdisplay component in the GUI
        private void LoadFretBoard()
        {
            // load XML image
            System.Uri fretboardURI = new Uri("C:\\Users\\Ashton\\source\\repos\\MusicTest\\MusicTestGUI\\Images\\Fretboard_Guitar.svg");
            WbDisplay.Url = fretboardURI;
        }
    }
}
