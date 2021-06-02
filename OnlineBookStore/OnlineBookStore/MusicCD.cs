using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public enum typeCD { Rock, Classical, Pop, Country, Jazz, Rap, Punk, Metal }
    public class MusicCD : Product 
    {
        string name, singer;
        static int ID;
        string price;

        typeCD typecd;

        public typeCD Type
        {
            get => typecd;
            set => typecd = value;
        }
        public MusicCD()
        {

        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Singer
        {
            get => singer;
            set => singer = value;
        }
        public int MusicCDID
        {
            get => ID;
            set => ID = value;
        }
        public string Price
        {
            get => price;
            set => price = value;
        }


    }
}
