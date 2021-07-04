using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mechanisms
{
    public class User
    {
        string _nume;
        List<string> _parole;
        string _serviciu;
        string _tag;
      
        public User()
        {
            this._parole = new List<string>();
        }
 
    
        public User(string nume)
        {
            _parole = new List<string>();
            this._nume = nume;
            
        }
        public void Add(string nume, string parola, string serviciu)
        {
            this._nume = nume;
            this._parole.Add(parola);
            string a = this._parole[0];
            this._parole[0] = parola;
            this._parole[this._parole.Count-1] = a;
            this._serviciu = serviciu;
            this._tag = this._nume + " - " + this._serviciu;
        }
       
        public string getnume()
        {
            return _nume;
        }
        public List<string> getparole()
        {
            return this._parole;
        }
        public string getserviciu()
        {
            return _serviciu;
        }
        public string gettag()
        {
            return _nume;
        }
     

    }
}
