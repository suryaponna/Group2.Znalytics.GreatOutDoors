//--------------------Surya
using System.Collections.Generic;
using System.Collections;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Group2.Znalytics.GreetOutDoors.DataLayer;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using System.ComponentModel;
using System.Diagnostics;
/// <summary>
/// Data Access Logic for Address
/// </summary>
namespace Znalytics.Group2.GreatOutDoor.Entity

{
    
    public class AddressDataLayer:IEnumerable,IList,IAddressDataLayer
    {
        /// <summary>
        /// Creating static list
        /// </summary>
        private static List<AddressDetail> _customerAddressesList;
        //string[] Copy =(string[]) _customerAddressesList.ToArray();



        /// <summary>
        /// Creating List only once memory is allocated 
        /// </summary>
        //StreamReader streamreader = new StreamReader(@"E:\project\myself.txt");
        //public FileStream fs = new FileStream(@"E:\project\myself.txt",FileMode.Open,FileAccess.Read);
        //string s = streamreader.ReadToEnd();
        //BinaryFormatter bf = new BinaryFormatter();
        //bf.Serialize(fs,AddressDetail);

        static AddressDataLayer()
        {
            _customerAddressesList = new List<AddressDetail>();
        }
        public List<AddressDetail> CustomerAddressList {
            get {
                return _customerAddressesList;
            }
            set {
                _customerAddressesList = value;
            }
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

        int ICollection.Count => _customerAddressesList.Count;

        public object this[int index] { 
            get => _customerAddressesList[index]; 
            set => _customerAddressesList[index] = (AddressDetail)value; }

        public void UpdateExistingAddress(int Id,AddressDetail ad) {
            for (int i=0; i < _customerAddressesList.Count; i++){
                if (_customerAddressesList[i].CustomerId == Id) {
                    _customerAddressesList[i] = ad;
                }   
            }
            
        }
        /// <summary>
        /// Returning Default Address of the Customer
        /// </summary>
        /// <param name="ad">Address Object</param>
        /// <returns></returns>
        public AddressDetail RetunDefaultAddress(AddressDetail ad) {
            AddressDetail sample=null;
            foreach (var item in _customerAddressesList) {
                if (item.CustomerId == ad.CustomerId  && item.AddressId == ad.AddressId) {
                    sample= item;
                }
            }
            if (sample != null)
            {
                return sample;
            }
            else {
                throw new AddressException("No default Address you Might not enteres your address while singup");
            }
        }
        /// <summary>
        /// Returning Particular Address Of a Customer
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public AddressDetail ReturnAddress(AddressDetail ad,int Id) {
            AddressDetail samp=null;
            foreach (var temp in _customerAddressesList) {
                if (temp.CustomerId == ad.CustomerId && Id == (int)temp.AddressId) {
                    samp = temp;
                }
            }
            if (samp != null)
            {
                return samp;
            }
            else {
                throw new AddressException("Requested Address Not Found");
            }
        }

        /// <summary>
        /// Returning All addresses Of a Customer
        /// </summary>
        /// <param name="ad"></param>
        /// <returns></returns>
        public List<AddressDetail> CustomerAllAddress(AddressDetail ad) {
            List<AddressDetail> samp = _customerAddressesList.FindAll(temp => temp.CustomerId == ad.CustomerId);
            return samp;
        }
        /// <summary>
        /// Add Another Address TO Existing Customer
        /// </summary>
        /// <param name="ad"></param>
        public void AddressAnotherAddressToCustomer(AddressDetail ad) {
            if (ad != null) {
                foreach (var temp in _customerAddressesList) {
                    if (temp.CustomerId == ad.CustomerId) {
                        ad.AddressId += 1;
                        _customerAddressesList.Add(ad);
                    }
                }
            }
        }
        /// <summary>
        /// Remove Particular Address Of The Customer
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="Id"></param>
        public void RemoveAddress(AddressDetail ad,int Id) {
            _customerAddressesList.RemoveAll(samp => samp.CustomerId == ad.CustomerId && Id == (int)samp.AddressId);
        }
        

    }
}

