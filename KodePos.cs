using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL4_103022400012
{
    internal class KodePos
    {

        private Dictionary<string, string> tabelKodePos = new Dictionary<string, string>()
    {
        {"Batununggal","40266"},
        {"Kujangsari","40287"},
        {"Mengger","40267"},
        {"Wates","40256"},
        {"Cijagra","40287"},
        {"Jatisari","40286"},
        {"Margasari","40286"},
        {"Sekejati","40286"},
        {"Kebonwaru","40272"},
        {"Maleer","40274"}
    };

        public string getKodePos(string kelurahan)
        {
            return tabelKodePos[kelurahan];
        }
    }
}