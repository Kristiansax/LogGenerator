using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogGenerator
{
    class Program
    {
        public static Random random = new Random(Environment.TickCount);
        public static List<string> UniquePersonnelIDs = new List<string>();
        public static List<string> UniquePatientIDs = new List<string>();
        public static List<string> UniqueSensorIDs = new List<string>();

        static void Main(string[] args)
        {
            string filepath = Directory.GetCurrentDirectory();
            for (int i = 0; i < 1000; i++)
            {
                //Generate data
                DateTime starttid = GenerateRandomStartTime();
                DateTime sluttid = starttid.AddSeconds(400);
                Hændelse hændelse = new Hændelse("Alarmen blev trippet", starttid, sluttid);
                Institution institution = new Institution(GenerateRandomAfdeling(), GenerateRandomBolig());
                Patient patient = new Patient(GenerateRandomName(), GenerateRandomLocation(), GenerateRandomUniquePatientID());
                Personale personale = new Personale(GenerateRandomName(), GenerateRandomUniquePersonnelID());
                Sensor sensor = new Sensor(GenerateRandomType(), GenerateRandomSensorID());

                using (StreamWriter outputFile = new StreamWriter(filepath + @"\Log.txt", true))
                {
                    if (i == 0)
                    {
                        outputFile.WriteLine();
                    }
                    //Logfil format
                    outputFile.WriteLine(hændelse.StartTid + "\t" + patient.Navn + "\t" + patient.ID + "\t" + patient.Lokation + "\t" + hændelse.AlarmBeskrivelse + "\t" + sensor.Type + "\t" + sensor.ID + "\t" + hændelse.SlutTid + "\t" + institution.Bolig + "\t" + personale.Navn + "\t" + personale.ID + "\t" + institution.Afdeling);
                    Console.WriteLine(hændelse.StartTid + "\t" + patient.Navn + "\t" + patient.ID + "\t" + patient.Lokation + "\t" + hændelse.AlarmBeskrivelse + "\t" + sensor.Type + "\t" + sensor.ID + "\t" + hændelse.SlutTid + "\t" + institution.Bolig + "\t" + personale.Navn + "\t" + personale.ID + "\t" + institution.Afdeling);
                    Thread.Sleep(100);
                }
            }

            Console.WriteLine("Success!");
            Console.ReadKey();
        }

        public static string GenerateRandomName()
        {
            string fornavn;
            string efternavn;
            string navn;
            string[] fornavne = { "Frederik", "Kristian", "Martin", "Oliver", "Christine", "Christian", "Mahmud", "Julie", "Bodil", "Liselotte", "Kaare", "Johannes", "Frank", "Frans"};
            string[] efternavne = { "Frederiksen", "Andersen", "Kristiansen", "Christiansen", "Elias", "Johannesen", "Mortensen", "Sandbøl", "Hoeck" };

            fornavn = fornavne[random.Next(0, fornavne.Length)];
            efternavn = efternavne[random.Next(0, efternavne.Length)];

            return navn = fornavn + " " + efternavn;
        }

        //Personale
        public static string GenerateRandomUniquePersonnelID()
        {
            string result = random.Next(1000, 9999).ToString();

            while (true)
            {
                if (UniquePersonnelIDs.Contains(result))
                {
                    result = random.Next(1000, 9999).ToString();
                }
                else
                {
                    UniquePersonnelIDs.Add(result);
                    break;
                }
            }
            return result;
        }

        //Patient
        public static string GenerateRandomUniquePatientID()
        {
            string result = random.Next(1000, 9999).ToString();

            while (true)
            {
                if (UniquePatientIDs.Contains(result))
                {
                    result = random.Next(1000, 9999).ToString();
                }
                else
                {
                    UniquePatientIDs.Add(result);
                    break;
                }
            }
            return result;
        }

        public static string GenerateRandomLocation()
        {
            string lokation;
            string[] lokationer = {"Dør A", "Dør B", "Dør C", "Dør D", "Stue 1, 1s", "Stue 2, 1s", "Stue 3, 1s", "Stue 4, 1s", "Stue 1, 2s", "Stue 2, 2s", "Stue 3, 2s", "Stue 4, 2s", };
            lokation = lokationer[random.Next(0, lokationer.Length)];
            return lokation;
        }

        // Institution
        public static string GenerateRandomBolig()
        {
            string bolig;
            string[] boliger = { "Demovej 1", "Demovej 2", "Demovej 3", "Demovej 4", "Demovej 5", "Demovej 6", "Demovej 7", "Demovej 8", "Demovej 9", "Demovej 10" };
            bolig = boliger[random.Next(0, boliger.Length)];
            return bolig;
        }

        public static string GenerateRandomAfdeling()
        {
            string afdeling;
            string[] afdelinger = { "Afdeling 1", "Afdeling 2", "Afdeling 3", "Afdeling 4", "Afdeling 5", "Afdeling 6" };
            afdeling = afdelinger[random.Next(0, afdelinger.Length)];
            return afdeling;
        }

        //Sensor
        public static string GenerateRandomType()
        {
            string type;
            string[] typer = { "Liggesensor", "Bevægelsessensor", "Liggesensor" };
            type = typer[random.Next(0, typer.Length)];
            return type;
        }

        public static string GenerateRandomSensorID()
        {
            string sensorID = random.Next(1000, 9999).ToString();

            while (true)
            {
                if (UniqueSensorIDs.Contains(sensorID))
                {
                    sensorID = random.Next(1000, 9999).ToString();
                }
                else
                {
                    UniquePatientIDs.Add(sensorID);
                    break;
                }
            }
            return sensorID;
        }

        //Hændelse
        public static DateTime GenerateRandomStartTime()
        {
            DateTime startTid;

            DateTime start = new DateTime(2010, 1, 1);
            int range = (DateTime.Today - start).Days;
            startTid = start.AddDays(random.Next(range));
            startTid = startTid.AddMinutes(random.Next(range));
            startTid = startTid.AddSeconds(random.Next(range));

            return startTid;
        }
    }
}