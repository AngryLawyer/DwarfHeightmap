using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace DwarfHeightmap
{
    public static class HeightmapProcessing
    {
        public static bool ProcessMap(string heightMapPath, int finalXSize, int finalYSize, int heightAdjust, float colourToHeightRatio, int type, MapStore gennedTypes, System.Windows.Forms.ListBox gennedTypesWindow) //Eventually, we're going to need to pass arguments!
        {
            //Load our bitmap
            Bitmap heightmap = null;
            try
            {
                heightmap = new Bitmap(heightMapPath);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Failed to load image - are you sure it's a valid bitmap?");
                return false;
            }
            //Resize the image
            Bitmap heightmapResized = new Bitmap(finalXSize, finalYSize);
            Graphics resizer = Graphics.FromImage( (Image) heightmapResized );
            resizer.DrawImage( heightmap, 0, 0, finalXSize, finalYSize );
            
            //TODO: Change the resolution if need be

            //Store it in a legible array
            int[,] imageArray = new int[finalXSize, finalYSize];
            for (int x = 0; x < finalXSize; x++)
            {
                for (int y = 0; y < finalYSize; y++)
                {
                    float averagedPixel = ((heightmapResized.GetPixel(x, y).R) + (heightmapResized.GetPixel(x, y).G) + (heightmapResized.GetPixel(x, y).B)) / 3;
                    averagedPixel = (averagedPixel * colourToHeightRatio) + heightAdjust;
                    imageArray[x, y] = (int)averagedPixel;
                }
            }

            if (gennedTypes.getItem(type) == null)
            {
                switch (type)
                {
                    case (int)ImportType.ELEV:
                        gennedTypesWindow.Items.Add("Elevation");
                        break;
                    case (int)ImportType.RAIN:
                        gennedTypesWindow.Items.Add("Rainfall");
                        break;
                    case (int)ImportType.TEMP:
                        gennedTypesWindow.Items.Add("Temperature");
                        break;
                    case (int)ImportType.DRAIN:
                        gennedTypesWindow.Items.Add("Drainage");
                        break;
                    case (int)ImportType.SAV:
                        gennedTypesWindow.Items.Add("Savagery");
                        break;
                    case (int)ImportType.VOLC:
                        gennedTypesWindow.Items.Add("Volcanicity");
                        break;
                }
            }
            //Stuff it into our storage collection
            gennedTypes.setItem(type, imageArray);
            

            System.Windows.Forms.MessageBox.Show("Added to the array!");
            return true;
        }


        public static void CommitToFile(int finalXSize, int finalYSize, string mapname, MapStore finishedTypes, string worldGenFilePath)
        {

            StreamWriter SW;
            SW = File.AppendText(worldGenFilePath);
            SW.WriteLine();

            int squares = finalXSize * finalYSize;
            if (squares <= 289)
            {
                SW.Write(WorldGenTemplate.GetPocketSettings(mapname, finalXSize, finalYSize));
            }
            else if (squares <= 289)
            {
                SW.Write(WorldGenTemplate.GetSmallerSettings(mapname, finalXSize, finalYSize));
            }
            else if (squares <= 1089)
            {
                SW.Write(WorldGenTemplate.GetSmallSettings(mapname, finalXSize, finalYSize));
            }
            else if (squares <= 4225)
            {
                SW.Write(WorldGenTemplate.GetMediumSettings(mapname, finalXSize, finalYSize));
            }
            else
            {
                SW.Write(WorldGenTemplate.GetLargeSettings(mapname, finalXSize, finalYSize));
            }
            //SW.Write();
            //Now write the remaining types

            for (int i = 0; i < 6; i++)
            {
                int[,] heightMap = finishedTypes.getItem(i);
                if (heightMap != null)
                {
                    string dataType = string.Empty;
                    switch (i)
                    {
                        case (int)ImportType.ELEV:
                            dataType = "[PS_EL";
                            break;
                        case (int)ImportType.RAIN:
                            dataType = "[PS_RF";
                            break;
                        case (int)ImportType.TEMP:
                            dataType = "[PS_TP";
                            break;
                        case (int)ImportType.DRAIN:
                            dataType = "[PS_DR";
                            break;
                        case (int)ImportType.SAV:
                            dataType = "[PS_SV";
                            break;
                        case (int)ImportType.VOLC:
                            dataType = "[PS_VL";
                            break;
                    }

                    for (int y = 0; y < finalYSize; y++)
                    {
                        SW.WriteLine();

                        SW.Write(dataType);
                        for (int x = 0; x < finalXSize; x++)
                        {
                            SW.Write(":");
                            SW.Write(heightMap[x, y]);
                        }
                        SW.Write("]");
                    }
                }
            }
            SW.Close();
            System.Windows.Forms.MessageBox.Show("Saved!");
        }

        public static Bitmap GenerateBitmapFromData(int xSize, int ySize, int type, int[,] data)
        {
            Bitmap generated = new Bitmap(xSize, ySize, PixelFormat.Format24bppRgb);
            //Assume Heightmap - everything below 100 is waaateeerrrr.

            for (int x = 0; x < xSize; x++)
            {
                for (int y = 0; y < ySize; y++)
                {
                    switch (type)
                    {
                        case (int)ImportType.ELEV:

                            if (data[x, y] < 100)
                            {
                                generated.SetPixel(x, y, Color.FromArgb(255, 0, 0, (int)(data[x, y] / Constants.ElevRatio)));
                            }
                            else if (data[x, y] < 300)
                            {
                                generated.SetPixel(x, y, Color.FromArgb(255, 0, (int)(data[x, y] / Constants.ElevRatio), 0));
                            }
                            else if (data[x, y] <= 255 / Constants.ElevRatio)
                            {
                                generated.SetPixel(x, y, Color.FromArgb(255, (int)(data[x, y] / Constants.ElevRatio), (int)(data[x, y] / Constants.ElevRatio), (int)(data[x, y] / Constants.ElevRatio)));
                            }
                            else
                            {
                                generated.SetPixel(x, y, Color.White);
                            }
                            break;
                        case (int)ImportType.RAIN:
                            //<10 - dry, <66 no trees
                            if (data[x, y] < 10)
                            {
                                generated.SetPixel(x, y, Color.FromArgb(255, (int)(data[x, y] / Constants.RainRatio), (int)(data[x, y] / Constants.RainRatio),0)); //FIXME - remove magic numbers
                            }
                            else if (data[x, y] < 66)
                            {
                                generated.SetPixel(x, y, Color.FromArgb(255, 0, (int)(data[x, y] / Constants.RainRatio),0));
                            }
                            else if (data[x, y] <= 255 / Constants.RainRatio)
                            {
                                generated.SetPixel(x, y, Color.FromArgb(255, 0, 0, (int)(data[x, y] / Constants.RainRatio)));
                            }
                            else
                            {
                                generated.SetPixel(x, y, Color.FromArgb(255,0,0,255));
                            }
                            break;
                        case (int)ImportType.DRAIN:
                            //<33, <50
                            if (data[x, y] < 33)
                            {

                            }
                            else if (data[x, y] < 50)
                            {

                            }
                            else if (data[x, y] <= 255 / Constants.DrainRatio)
                            {

                            }
                            break;
                        case (int)ImportType.TEMP:
                                
                            break;
                        case (int)ImportType.SAV:
                            break;
                        case (int)ImportType.VOLC:
                            break;
                    }
                }
            }
            return generated;
        }
    }


}
