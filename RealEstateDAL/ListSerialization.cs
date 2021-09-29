using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace RealEstateAgent
{
    public class ListSerialization<T>
    {

        public bool BinaryDeSerialize(string fileName, List<T> list)
        {


            bool ok = false;
            FileStream file = null;

            try
            {
                file = new FileStream(fileName, FileMode.Open);
                IFormatter formatter = new BinaryFormatter();
               // list = new List<T>();
                list = formatter.Deserialize(file) as List<T>;
                ok = true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);

            }
            finally
            {
                file.Close();
            }

            return ok;
        }

        public bool BinarySerialize(string fileName, List<T> list)
        {
            bool ok = false;
            FileStream file = null;

            try
            {
                file = new FileStream(fileName, FileMode.Create);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(file, list);
                ok = true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                file.Close();
            }

            return ok;
        }

    }
}
