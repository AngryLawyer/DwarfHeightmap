namespace DwarfHeightmap
{
    public class MapStore
    {
        private int[,] elev;
        private int[,] rain;
        private int[,] temp;
        private int[,] drain;
        private int[,] sav;
        private int[,] volc;

        public int[,] getItem(int item)
        {
            switch (item)
            {
                case (int)ImportType.ELEV:
                    return elev;
                case (int)ImportType.RAIN:
                    return rain;
                case (int)ImportType.TEMP:
                    return temp;
                case (int)ImportType.DRAIN:
                    return drain;
                case (int)ImportType.SAV:
                    return sav;
                case (int)ImportType.VOLC:
                    return volc;
            }
            return null;
        }
        public void setItem(int itemNumber, int[,] itemData)
        {
            switch (itemNumber)
            {
                case (int)ImportType.ELEV:
                    elev = itemData;
                    break;
                case (int)ImportType.RAIN:
                    rain = itemData;
                    break;
                case (int)ImportType.TEMP:
                    temp = itemData;
                    break;
                case (int)ImportType.DRAIN:
                    drain = itemData;
                    break;
                case (int)ImportType.SAV:
                    sav = itemData;
                    break;
                case (int)ImportType.VOLC:
                    volc = itemData;
                    break;
            }
        }
        public bool isEmpty()
        {
            for (int i = 0; i < 6; i++)
            {
                if (getItem(i) != null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}