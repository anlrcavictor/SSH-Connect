using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHDeneme
{
     public class Atomik
    {
        public static string SatırSonunaKadarKes(string satır,string aranan,int a)
        {
            int index = satır.IndexOf(aranan);
            string sonuc = satır.Substring((index + a), (satır.Length-(index+a)));
            return sonuc;
        }

        public static string belirttiginYereKadarKes(string satır, string aranan, int a,int b)
        {
            int index = satır.IndexOf(aranan);
            string sonuc = satır.Substring((index + a), b);
            return sonuc;
        }
    }
}
