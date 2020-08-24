//--------------------Surya
using System.Collections.Generic;
using System.Collections;
using System;
/// <summary>
/// Data Access Logic for Address
/// </summary>
namespace Znalytics.Group2.GreatOutDoor.Entity

{
    public class AddressDataLayer:IEnumerable,IList
    {

        private static List<AddressDetail> _customerAddressesList;
        //string[] Copy =(string[]) _customerAddressesList.ToArray();



        /// <summary>
        /// Creating List only once memory is allocated 
        /// </summary>
        public AddressDataLayer()
        {
            _customerAddressesList = new List<AddressDetail>();
        }
        /// <summary>
        /// Inherinted from Ienumerable Generates Ienumerator which acts as Interator
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator() {
            for (int i = 0; i < _customerAddressesList.Count; i++) {
                yield return _customerAddressesList[i];

            }
        }
        /// <summary>
        /// Adding new Customer Address
        /// </summary>
        /// <param name="address">Attribute to add adddress in to collection</param>
        

        public int Add(object value)
        {
            AddressDetail address = (AddressDetail)value;
            _customerAddressesList.Add(address);
            return _customerAddressesList.Count - 1;
        }

        /// <summary>
        /// clearing the total List 
        /// </summary>
        public void Clear()
        {
            _customerAddressesList.Clear();
        }
        /// <summary>
        /// retriving index  customer Address 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int IndexOf(object value)
        {
            AddressDetail ad = (AddressDetail)value;
            return _customerAddressesList.IndexOf(ad);
            //return ((IList)_customerAddressesList).IndexOf(value);
        }

        public void Insert(int index, object value)
        {
            AddressDetail ad = (AddressDetail)value;
            _customerAddressesList.Insert(index, ad);
            //((IList)_customerAddressesList).Insert(index, value);
        }

        public void Remove(object value)
        {
            AddressDetail ad = (AddressDetail)value;
            _customerAddressesList.Remove(ad);
            //((IList)_customerAddressesList).Remove(value);
        }

        public void RemoveAt(int index)
        {
            //AddressDetail ad = (AddressDetail)value;
            _customerAddressesList.RemoveAt(index);
        }

        public void CopyTo(Array array, int index)
        {
           ((ICollection)_customerAddressesList).CopyTo(array, index);
        }

        public bool Contains(object ad)
        {
            AddressDetail ade=(AddressDetail)ad;  
            return _customerAddressesList.Contains(ade);
        }

        public bool IsReadOnly => ((IList)_customerAddressesList).IsReadOnly;

        public bool IsFixedSize => ((IList)_customerAddressesList).IsFixedSize;



        public object SyncRoot => ((ICollection)_customerAddressesList).SyncRoot;

        public bool IsSynchronized => ((ICollection)_customerAddressesList).IsSynchronized;

        int ICollection.Count => ((ICollection)_customerAddressesList).Count;

        public object this[int index] { get => ((IList)_customerAddressesList)[index]; set => ((IList)_customerAddressesList)[index] = value; }


    }
}

