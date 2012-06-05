using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DwarfHeightmap
{
    public partial class Main : Form
    {
        public MapStore gennedTypes;
        private AboutBox about;
        private Visualiser visualiser;

        public Main()
        {
            InitializeComponent();
        }

        private void openInitButton_Click(object sender, EventArgs e)
        {
            openWorldgenFile.ShowDialog();
        }

        private void openHeightmapButton_Click(object sender, EventArgs e)
        {
            openHeightmapFile.ShowDialog();
        }

        private void openHeightmapFile_FileOk(object sender, CancelEventArgs e)
        {
            heightmapFileNameTextbox.Text = openHeightmapFile.FileName;
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (gennedTypes == null)
            {
                gennedTypes = new MapStore();
            }

            int conversionType = 0;
            switch (TypeComboBox.SelectedItem.ToString())
            {
                case "Elevation":
                    conversionType = (int)ImportType.ELEV;
                    break;
                case "Rainfall":
                    conversionType = (int)ImportType.RAIN;
                    break;
                case "Temperature":
                    conversionType = (int)ImportType.TEMP;
                    break;
                case "Drainage":
                    conversionType = (int)ImportType.DRAIN;
                    break;
                case "Savagery":
                    conversionType = (int)ImportType.SAV;
                    break;
                case "Volcanicity":
                    conversionType = (int)ImportType.VOLC;
                    break;
                default:
                    conversionType = (int)ImportType.ELEV;
                    break;
            }

            if (HeightmapProcessing.ProcessMap(heightmapFileNameTextbox.Text, int.Parse(xComboBox.SelectedItem.ToString()), int.Parse(yComboBox.SelectedItem.ToString()), int.Parse(offsetTextBox.Text), float.Parse(ratioTextBox.Text), conversionType, gennedTypes, TypesListBox) == true)
            {
                heightmapFileNameTextbox.Text = string.Empty;
                if (gennedTypes.isEmpty() != true)
                {
                    commitButton.Enabled = true;
                    xComboBox.Enabled = false;
                    yComboBox.Enabled = false;
                }
                else
                {
                    commitButton.Enabled = false;
                    xComboBox.Enabled = true;
                    yComboBox.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Failed to process map!");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            xComboBox.SelectedIndex = 0; //Initialise our comboboxes
            yComboBox.SelectedIndex = 0;
            TypeComboBox.SelectedIndex = 0;
        }

        private void commitButton_Click(object sender, EventArgs e)
        {
            if (gennedTypes == null)
            {
                gennedTypes = new MapStore();
            }
            //Open world_gen.txt
            openWorldgenFile.ShowDialog();

            //Save it!
            if (openWorldgenFile.FileName == "world_gen.txt") //Having the default name means you've not specified a path
            {
                MessageBox.Show("Cancelled");
            }
            else if (gennedTypes.isEmpty() == true)
            {
                MessageBox.Show("You've not imported any map data!");
            }
            else if (openWorldgenFile.FileName.Substring(openWorldgenFile.FileName.Length - 4, 4) != ".txt")
            {
                string x = openWorldgenFile.FileName.Substring(openWorldgenFile.FileName.Length - 4, 4);
                MessageBox.Show("That doesn't appear to be a text file");
            }
            else
            {
                HeightmapProcessing.CommitToFile(int.Parse(xComboBox.SelectedItem.ToString()), int.Parse(yComboBox.SelectedItem.ToString()), nameTextBox.Text, gennedTypes, openWorldgenFile.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            gennedTypes = new MapStore(); //Flush out old gennedTypes
            TypesListBox.Items.Clear();
            commitButton.Enabled = false;
            xComboBox.Enabled = true;
            yComboBox.Enabled = true;
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TypeComboBox.SelectedItem.ToString())
            {
                case "Elevation":
                    ratioTextBox.Text = Constants.ElevRatio.ToString(); //0-400
                    offsetTextBox.Text = Constants.ElevOffset.ToString();
                    break;
                case "Rainfall":
                    ratioTextBox.Text = Constants.RainRatio.ToString(); //0-100
                    offsetTextBox.Text = Constants.RainOffset.ToString();
                    break;
                case "Temperature":
                    ratioTextBox.Text = Constants.TempRatio.ToString(); //0-50
                    offsetTextBox.Text = Constants.TempOffset.ToString();
                    break;
                case "Drainage":
                    ratioTextBox.Text = Constants.DrainRatio.ToString(); //0-100
                    offsetTextBox.Text = Constants.DrainOffset.ToString();
                    break;
                case "Savagery":
                    ratioTextBox.Text = Constants.SavRatio.ToString(); //0-100
                    offsetTextBox.Text = Constants.SavOffset.ToString();
                    break;
                case "Volcanicity":
                    ratioTextBox.Text = Constants.VolcRatio.ToString(); //0-100
                    offsetTextBox.Text = Constants.VolcOffset.ToString();
                    break;
                default:
                    ratioTextBox.Text = "1.56863"; //0-400
                    offsetTextBox.Text = "0";
                    break;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new AboutBox();
            }

            try
            {
                about.Show();
            }
            catch (ObjectDisposedException ex) //This is a really aroundabout way of doing it, but I can't figure out how to stop it opening more than once
            {
                about = new AboutBox();
                about.Show();
            }
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TypesListBox_DoubleClick(object sender, EventArgs e)
        {
            if (visualiser == null)
            {
                visualiser = new Visualiser();
            }
            if (TypesListBox.SelectedIndex != -1)
            {
                int type = 0;

                switch (TypesListBox.SelectedItem.ToString())
                {
                    case "Elevation":
                        type = (int)ImportType.ELEV;
                        break;
                    case "Rainfall":
                        type = (int)ImportType.RAIN;
                        break;
                    case "Temperature":
                        type = (int)ImportType.TEMP;
                        break;
                    case "Drainage":
                        type = (int)ImportType.DRAIN;
                        break;
                    case "Savagery":
                        type = (int)ImportType.SAV;
                        break;
                    case "Volcanicity":
                        type = (int)ImportType.VOLC;
                        break;
                }
                try
                {
                    visualiser.DisplayMap(int.Parse(xComboBox.SelectedItem.ToString()), int.Parse(yComboBox.SelectedItem.ToString()), type, gennedTypes);
                }
                catch (ObjectDisposedException ex) //This is a really aroundabout way of doing it, but I can't figure out how to stop it opening more than once
                {
                    visualiser = new Visualiser();
                    visualiser.DisplayMap(int.Parse(xComboBox.SelectedItem.ToString()), int.Parse(yComboBox.SelectedItem.ToString()), type, gennedTypes);
                }


            }
        }
    }
}
