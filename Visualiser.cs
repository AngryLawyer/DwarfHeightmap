using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DwarfHeightmap
{
    public partial class Visualiser : Form
    {
        public Visualiser()
        {
            InitializeComponent();
        }

        public void DisplayMap(int xSize, int ySize, int type, MapStore gennedTypes)
        {
            visualisedPictureBox.Image = (Image)HeightmapProcessing.GenerateBitmapFromData(xSize, ySize, type, gennedTypes.getItem(type));
            this.Show();
        }
    }
}