using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

namespace Progetto.TestFileSystemIO
{
    class Program
    {

        static void Main(string[] args)
        {
            #region prova stream writer
            //// Esempio di scrittura di un file
            //var SW1 = new StreamWriter("Prova1.txt");
            //var SW2 = new StreamWriter("C:\\Temp\\Prova2.txt");
            //var SW3 = new StreamWriter(@"C:\Temp\Prova3.txt");
            //var SW4 = new StreamWriter($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Prova4.txt");
            //var SW5 = new StreamWriter(@"C:\Temp\Prova5.txt");
            //var SW6 = new StreamWriter($@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\Prova6.txt");



            //for (int i = 0; i < 100000; i++)
            //{
            //    SW1.WriteLine(i.ToString());
            //    SW2.WriteLine((2*i).ToString());
            //    SW3.WriteLine((i + 5).ToString());
            //    SW4.WriteLine((i + 6).ToString());
            //    SW5.WriteLine((i + 7).ToString());
            //    SW6.WriteLine((i + 8).ToString());
            //}
            //SW1.Close();
            //SW2.Close();
            //SW3.Close();
            //SW4.Close();
            //SW5.Close();
            //SW6.Close();
            #endregion

            var Ciclo = Properties.Settings.Default.Ciclo;
            var PathFile = Properties.Settings.Default.PathFile;
            var PathFileDate = Properties.Settings.Default.PathFileDate;

            //var LInteri = new List<int>();

            //using (var SWU1 = new StreamWriter(PathFile, false, Encoding.Default))
            //{
            //    for (int i = 0; i < Ciclo; i++)
            //    {
            //        SWU1.Write((i * 10).ToString());
            //        SWU1.WriteLine(("{0:000000}"), i * 10);
            //    }
            //    SWU1.WriteLine("non è un numero");
            //}

            ScriviDate(Ciclo, PathFileDate);

            //try
            //{
            //    LeggiNumeri(PathFile, LInteri);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}

            try
            {
                LeggiData(PathFileDate);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadLine();
        }

        private static void LeggiNumeri(string PathFile, List<int> LInteri)
        {
            if (File.Exists(PathFile))
            {
                using (var SR = new StreamReader(PathFile, Encoding.Default))
                {
                    //var ContenutodelFile = SR.ReadToEnd();

                    while (!SR.EndOfStream)
                    {
                        var Riga = SR.ReadLine();
                        int n;
                        if (int.TryParse(Riga, out n))
                        {
                            LInteri.Add(n);
                            Console.WriteLine(Riga);
                        }
                        else
                            throw new Exception($"{Riga} non è valido");

                    }
                }
            }
        }

        private static void LeggiData(string PathFile)
        {

            var C = new System.Globalization.CultureInfo("en-US");

            using (var SR = new StreamReader(PathFile, Encoding.Default))
            {
                while (!SR.EndOfStream)
                {
                    var Riga = SR.ReadLine();

                    var DT = new DateTime();
                    if (DateTime.TryParseExact(Riga, "yyyyMMdd", C, System.Globalization.DateTimeStyles.AssumeLocal, out DT))
                    {
                        Console.WriteLine(DT.ToString( ));
                    }
                }
            }
        }

        private static void ScriviDate(int Ciclo, string PathFile)
        {
            var DataOggi = DateTime.Today;

            using (var SWU1 = new StreamWriter(PathFile, false, Encoding.Default))
            {
                for (int i = 0; i < Ciclo; i++)
                {
                    var DT2 = DataOggi.AddDays(i).AddHours(i + 2);

                    //SWU1.Write($"{DT2.Year}{DT2.Month.ToString("00")}{DT2.Day.ToString("00")}");
                    SWU1.WriteLine(String.Format("{0:yyyyMMdd}", DT2));
                }
                SWU1.WriteLine("non è una data");
            }
        }
    }
}
