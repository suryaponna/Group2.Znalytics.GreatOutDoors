//--------------------Surya
using System.Collections.Generic;
using System.Collections;
using System;
using System.IO;
using Group2.Znalytics.GreetOutDoors.DataLayer;
using Group2.Znalytics.GreatOutDoors.EntityLayer;
using Znalytics.Group2.GreatOutDoor.Entity;
using Newtonsoft.Json;
using System.Linq;
/// <summary>
/// Data Access Logic for Address
/// </summary>
namespace Group2.Znalytics.GreatOutDoors.DataLayer
{
    
    public class AddressDataLayer:IEnumerable,IList,IAddressInterface
    {
        /// <summary>
        /// Creating static list
        /// </summary>
        private static List<AddressDetail> _customerAddressesList;
        /// <summary>
        /// Declaring Json variable to store 
        /// </summary>
        private static  string _jsonAddresses;

        static StreamWriter streamWriter = new StreamWriter(@"E:\AddressesList.txt");

        /// <summary>
        /// Creating List only once memory is allocated 
        /// </summary>

        static AddressDataLayer()
        {
            _customerAddressesList = new List<AddressDetail>();
            List<AddressDetail> customers2 = JsonConvert.DeserializeObject<List<AddressDetail>>(_jsonAddresses);
            streamWriter.Write(_jsonAddresses);
            streamWriter.Close();

        }
        public List<AddressDetail> CustomerAddressList {
            get {
                return _customerAddressesList;
            }
            set {
                _customerAddressesList = value;
                _jsonAddresses = JsonConvert.SerializeObject(_customerAddressesList);
                streamWriter.Write(_jsonAddresses);
                streamWriter.Close();

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
            _jsonAddresses = JsonConvert.SerializeObject(_customerAddressesList);
            streamWriter.Write(_jsonAddresses);
            streamWriter.Close();
            return _customerAddressesList.Count - 1;

        }

        /// <summary>
        /// clearing the total List 
        /// </summary>
        public void Clear()
        {
            _customerAddressesList.Clear();
            _jsonAddresses = JsonConvert.SerializeObject(_customerAddressesList);
            streamWriter.Write(_jsonAddresses);
            streamWriter.Close();

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
            _jsonAddresses = JsonConvert.SerializeObject(_customerAddressesList);
            streamWriter.Write(_jsonAddresses);
            streamWriter.Close();
            //((IList)_customerAddressesList).Insert(index, value);
        }

        public void Remove(object value)
        {
            AddressDetail ad = (AddressDetail)value;
            _customerAddressesList.Remove(ad);
            _jsonAddresses = JsonConvert.SerializeObject(_customerAddressesList);
            streamWriter.Write(_jsonAddresses);
            streamWriter.Close();
            //((IList)_customerAddressesList).Remove(value);
        }

        public void RemoveAt(int index)
        {
            //AddressDetail ad = (AddressDetail)value;
            _customerAddressesList.RemoveAt(index);
            _jsonAddresses = JsonConvert.SerializeObject(_customerAddressesList);
            streamWriter.Write(_jsonAddresses);
            streamWriter.Close();

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

        public void UpdateExistingAddress(AddressDetail ad) {
            AddressDetail res = (from i in _customerAddressesList
                                    where i.AddressId==ad.AddressId
                                    select i).FirstOrDefault();
            if (res != null) {
                int AddressIndex=_customerAddressesList.IndexOf(res);
                _customerAddressesList[AddressIndex] = ad;
            }
            else {
                throw new AddressException("Address Not Found, add this address as a new one");
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
        public AddressDetail ReturnAddress(AddressDetail ad) {
            AddressDetail samp=null;
            samp = _customerAddressesList.Find(temp=> temp.AddressId==ad.AddressId && temp.CustomerId==ad.CustomerId);
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
        public List<AddressDetail> GetAllCustomerAddresses(AddressDetail ad) {
            List<AddressDetail> samp = _customerAddressesList.FindAll(temp => temp.CustomerId == ad.CustomerId);
            return samp;
        }
        /// <summary>
        /// Add Another Address TO Existing Customer
        /// </summary>
        /// <param name="ad"></param>
        public void AddAnotherAddressToCustomer(AddressDetail ad) {
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
        public void RemoveAddress(AddressDetail ad) {
            _customerAddressesList.RemoveAll(samp => samp.CustomerId == ad.CustomerId && ad.AddressId == samp.AddressId);
        }
        /// <summary>
        /// changing customer Default Address
        /// </summary>
        /// <param name="ad"></param>
        public void ChangeDefaultAddrees(AddressDetail ad) {
            var s = _customerAddressesList.Where(temp => temp.CustomerId == ad.CustomerId).ToList();
            if (s != null)
            {
                AddressDetail sam = _customerAddressesList.Find(temp => temp.DefaultAddressOrNot == true);
                sam.DefaultAddressOrNot = false;
                ad.DefaultAddressOrNot = true;
            }
            else {
                AddressDetail sam = _customerAddressesList.Find(temp => temp.DefaultAddressOrNot == true);
                sam.DefaultAddressOrNot = false;
                ad.DefaultAddressOrNot = true;
                _customerAddressesList.Add(ad);
            }
            
        }



    }
}

