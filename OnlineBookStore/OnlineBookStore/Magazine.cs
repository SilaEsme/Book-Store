using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public enum typeMagazine {Culture,Technology,Science,Geography,Caricature,Kids,Society,Art,Entertainment,Other }

    public class Magazine : Product
    {
        string name, issue;
        string price;
        typeMagazine TypeMagazine;

        public typeMagazine _TypeMagazine
        {
            get => TypeMagazine;
            set => TypeMagazine = value;
        }
        public Magazine()
        {

        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Issue
        {
            get => issue;
            set => issue = value;
        }
       
        public string Price
        {
            get => price;
            set => price = value;
        }
    }
}
