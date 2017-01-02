using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    [Serializable]
    public class Client : IEnumerable
    {
        // Medlemsvariabler
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string persnr { get; set; }
        public string street { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public List<Account> accountList = new List<Account>();

        // Konstruktor
        public Client() { }

        public Client(int _id, string _first_name, string _last_name, string _persnr, string _street,
                      string _zip, string _city, string _phone, string _mobile)
        {
            id = _id;
            first_name = _first_name;
            last_name = _last_name;
            persnr = _persnr;
            street = _street;
            zip = _zip;
            city = _city;
            phone = _phone;
            mobile = _mobile;
            accountList = new List<Account>();
        }

        // Setter & getter for accountList
        public List<Account> AccountList
        {
            get
            {
                return accountList;
            }
            set
            {
                accountList = value;
            }
        }

        // Change address of a client
        public void changeAddress(string _street, string _zip, string _city)
        {
            street = _street;
            zip = _zip;
            city = _city;
        }

        // Add account object to a List
        //public void addAccount(int _accountid, double _interest_rate, double _balance, string _persnr)
        //{
        //    Account acc = new Account(_accountid, _interest_rate, _balance, _persnr);
        //    accountList.Add(acc);
        //}

        public void addAccountToList(Account _a)
        {
            accountList.Add(_a);
        }

        public void delAccount(int _index)
        {
            accountList.RemoveAt(_index);
        }

        public List<Account> getAccountList()
        {
            return accountList;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerator<Account> GetEnumerator()
        {
            return accountList.GetEnumerator();
        }
    }
}
