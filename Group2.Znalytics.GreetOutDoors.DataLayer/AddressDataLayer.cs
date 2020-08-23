//--------------------Surya
using System.Collections.Generic;
using System.Collections;
using System.Configuration;
using Znalytics.Group2.GreatOutDoor.Entity;
using Group2.Znalytics.GreetOutDoors.DataLayer;
using System;
/// <summary>
/// Data Access Logic for Address
/// </summary>
namespace Znalytics.Group2.GreatOutDoor.Entity

{
    public class AddressDataLayer:IEnumerable,IList
    {

        private static List<AddressDetail> _customerAddressesList;

        
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
        public void AddAddress(AddressDetail address)
        {
            _customerAddressesList.Add(address);

        }
        /// <summary>
        /// clearing the total List 
        /// </summary>
        public void Clear() {
            _customerAddressesList.Clear();
        }
        /// <summary>
        /// Adding adddress at end Of the List 
        /// </summary>
        /// <param name="ad"></param>
        /// <returns></returns>
        public int Add(AddressDetail ad) {
            _customerAddressesList.Add(ad);
            int index = _customerAddressesList.FindIndex(ad);
            return index;
        }
        public int IndexOf(AddressDetail ad) {
            int index = _customerAddressesList.IndexOf(ad);
            return index;
        }
        /// <summary>
        /// Finding the address Contains in list or not 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Contains(AddressDetail value) {
            bool b = _customerAddressesList.Contains(value);
            return b;
        }

        /// <summary>
        /// Removing Address through index 
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index) {
            _customerAddressesList.RemoveAt(index);
        }
        /// <summary>
        /// Removinf Particular Object it means a address of a customer
        /// </summary>
        /// <param name="ad"></param>
        public void Remove(AddressDetail ad) {
            _customerAddressesList.Remove(ad);
        }
        public void Insert(int index, AddressDetail ad) {
            _customerAddressesList.Insert(index, ad);
        }

        public int Add(object value)
        {
            throw new NotImplementedException();
        }

        public bool Contains(object value)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(object value)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, object value)
        {
            throw new NotImplementedException();
        }

        public void Remove(object value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
        public bool IsReadOnly => throw new NotImplementedException();

        public bool IsFixedSize => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}

