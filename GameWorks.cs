using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace GameLib
{
    public class GameFactory
    {
        StreamWriter sw;
        XmlSerializer serial;
        public List<Game> GameList;
        //public string FilePath;
        //const string FilePath = @"..\..\games.xml";


        //public string GameFactory(string FilePath)
        public string FilePath { get; set; }
        public GameFactory(string FilePath)
        {
            this.FilePath = FilePath;
        }

        public void CreateGameList()
        {

            GameList = new List<Game>();

            Game Crate = new Game("Hornets", "Bulldogs", 60, 70);
            GameList.Add(Crate);

            Game Base = new Game("Wasps", "Panthers", 90, 65);
            GameList.Add(Base);

            Game Foot = new Game("Bulls", "Bears", 11, 23);
            GameList.Add(Foot);

            Game Socc = new Game("Unicorns", "DireBears", 55, 32);
            GameList.Add(Socc);

            Game Crick = new Game("Cricket", "Zebras", 23, 11);
            GameList.Add(Crick);

            Game Hock = new Game("Lacets", "Zombies", 44, 50);
            GameList.Add(Hock);

            //return CreateGameList();
        }

        public bool SerializeGameList()
        {
            // try
            //  {


            //GameList = new List<Game>();

                serial = new XmlSerializer(GameList.GetType());
                sw = new StreamWriter(FilePath);
                serial.Serialize(sw, GameList);
                sw.Close();
                return true;
           // }
            //catch(Exception ex)
          //  {
           //     return false;
           // }
        }


    }
}
