using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ruleta_podla_Pala
{
    class Hraci_stol
    {
        Hracie_pole[] HraciePolia = new Hracie_pole[37];
        
        public Hraci_stol()
        {
            Farba[] rozmiestnenieFarieb = new Farba[37]
            {
                Farba.zelena, //0
                Farba.cervena, //1
                Farba.cierna, //2
                Farba.cervena, //3
                Farba.cierna, //4
                Farba.cervena, //5
                Farba.cierna, //6
                Farba.cervena, //7
                Farba.cierna, //8
                Farba.cervena, //9
                Farba.cierna, //10
                Farba.cierna, //11
                Farba.cervena, //12
                Farba.cierna, //13
                Farba.cervena, //14
                Farba.cierna, //15
                Farba.cervena, //16
                Farba.cierna, //17
                Farba.cervena, //18
                Farba.cervena, //19
                Farba.cierna, //20
                Farba.cervena, //21
                Farba.cierna, //22
                Farba.cervena, //23
                Farba.cierna, //24
                Farba.cervena, //25
                Farba.cierna, //26
                Farba.cervena, //27
                Farba.cierna, //28
                Farba.cierna, //29
                Farba.cervena, //30
                Farba.cierna, //31
                Farba.cervena, //32
                Farba.cierna, //33
                Farba.cervena, //34
                Farba.cierna, //35
                Farba.cervena, //36
            };

            for (int i = 0; i < rozmiestnenieFarieb.Length; i++)
            {
                HraciePolia[i].Farba = rozmiestnenieFarieb[i];
                HraciePolia[i].Cislo = i;
                HraciePolia[i].Parnost = vratParnost(i);
                HraciePolia[i].Rada = vratRadu(i);
            }
        }
        
        private Parnost vratParnost(int i)
        {
            if(i == 0) return Parnost.ziadna;
            else if (i % 2 == 0) return Parnost.parna;
            return Parnost.neparna;
        }

        private Rada vratRadu(int i)
        {
            if (i == 1 || (i - 1) % 2 == 0) return Rada.prva;
            else if (i == 2 || (i - 2) % 2 == 0) return Rada.druha;
            else if (i == 3 || (i - 3) % 2 == 0) return Rada.tretia;
            return Rada.ziadna;
        }
    }
}
