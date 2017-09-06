using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Music
    {
        public Music()
        {

        }
 


        private string highestSelling = "0";
        private string lowestSellling = "0";
        private int totalSales;
        private int totalTracks;
        private Dictionary<string, int> musicData = new Dictionary<string,int>();
    
        

        public void addMusic(string songArtist, int sales) {
            musicData.Add(songArtist, sales);
            totalSales += sales;
            totalTracks++;
            if (!musicData.ContainsKey(highestSelling))
            {
                highestSelling = songArtist;
                lowestSellling = songArtist;
            }
            else
            {
                if (sales >= musicData[highestSelling])
                {
                    highestSelling = songArtist;
                }

                if (sales <= musicData[lowestSellling])
                {
                    lowestSellling = songArtist;
                }
            }
        }
        public string getHighestSelling()
        {
            return highestSelling + "\t" + musicData[highestSelling];
            
        }
        public string getLowestSelling()
        {
            return lowestSellling + " \t" + musicData[lowestSellling];
        }
        public int getSales()
        {
            return totalSales;
                        
        }
        public int getTotalTracks()
        {
            return totalTracks;
        }
        public Dictionary<string, int> getDictionary()
        {
            return musicData;
        }

    }


}
