﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace RealEstateAgent
{
    public class ListManager<T> : IListManager<T>
    {
        private List<T> list;

        public ListManager() {
            list = new List<T>();
        }
        
        //Returns the number of items in the list
        public int Count
        {
            get { return list.Count; }
        }

        //Add new item to the list
        public bool Add(T aType)
        {
            bool ok = false;
            if(aType != null)
            {
                list.Add(aType);
                Debug.WriteLine(" Last Added: " + list[Count-1]);
                ok = true;
            }
            return ok;
        }

        //Removes an item att a given index
        public bool DeleteAt(int anIndex)
        {
            bool ok = false;
            if(CheckIndex(anIndex))
            {
                Debug.WriteLine("Innan radering: " + list[anIndex]);
                list.RemoveAt(anIndex);
                ok = true;
            }
            return ok;
        }

        // Control that a given index is >= 0 and less than the number of items in 
        // the collection.
        public bool CheckIndex(int index)
        {
            bool ok = false;
            if (index >= 0 & index < list.Count)
            {
                ok = true;
            }
            Debug.WriteLine("CheckIndex " + ok);
            return ok;
        }

        // Replace an object from the collection at a given index by a new object.
        public bool ChangeAt(T aType, int anIndex)
        {
          bool ok = false;
           if(CheckIndex(anIndex))
            {
                Debug.WriteLine("Före: " + list[anIndex]);
                list[anIndex] = aType;
                Debug.WriteLine("Efter: " + list[anIndex]);
                ok = true;
            }
            return ok;
        }

        // Return an object at a given position from the collection list.
        public T GetAt(int anIndex)
        {
            if (CheckIndex(anIndex))
            {
                return list[anIndex];
                Debug.WriteLine(list[anIndex]);
            } else {

                return default(T);
            }
 
        }

        //Prepare an array of strings where each string represents info
        // about an object in the collection. The info can typically come
        // from the object's ToString method.
        public string[] ToStringArray()
        {
            string[] arrayOut = new string[Count];

            for (int i = 0; i < Count; i++)
            {
                arrayOut[i] = list[i].ToString();
                Debug.WriteLine("ToStringArray(): " + arrayOut[i]);
            }

            return arrayOut;
        }

        //Prepare a list of strings where each string represents info
        // about an object in the collection. The info can typically come
        // from the object's ToString method.
        public List<string> ToStringList()
        {
            List<string> listOut = new List<string>();

            for (int i = 0; i < Count; i++)
            {
                listOut.Add(list[i].ToString());
                Debug.WriteLine("ToStringList: " + listOut[i].ToString());
            }

            return listOut;
        }


        public bool BinaryDeSerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        public bool BinarySerialize(string fileName)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public bool XMLSerialize(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}