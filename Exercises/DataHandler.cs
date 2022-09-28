using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercises
{
    public class DataHandler
    {
        public string DataFileName { get; }

        public DataHandler(string datahandler)
        {
            DataFileName = datahandler;
            if (!File.Exists(DataFileName))
            {
                File.Create(DataFileName).Close();
            }
        }
        public void SavePerson(Person person)
        {
            StreamWriter sw = new StreamWriter(DataFileName);
            sw.WriteLine(person.MakeTitle());
            sw.Close();
        }
        public Person LoadPerson()
        {
            string[] personData;
            try
            {
                StreamReader sr = new StreamReader(DataFileName);
                personData = sr.ReadLine().Split(";");

                sr.Close();


                return new Person(
                    personData[0],
                    DateTime.Parse(personData[1]),
                    double.Parse(personData[2]),
                    bool.Parse(personData[3]),
                    int.Parse(personData[4])
                    ) ;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
