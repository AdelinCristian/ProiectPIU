using System;

namespace ProiectPIU
{

    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Masina
    {
        public string Brand_Masina
        { get; set; }

        public string Model_Masina
        { get; set; }

            public int An_Masina
            { get; set; }

            public string Valabilitate
            { get; set; }

        Masina(string bm, string mm, int am, string val)
        {
            Brand_Masina = bm;
            An_Masina = am;
            Model_Masina = mm;
            Valabilitate = val;
        }
    }

    class Client
    {
        public string Nume_Client
        { get; set; }

        private string CNP_Client
        { get; set; }

        public string Varsta_Client
        { get; set; }
    }


}

