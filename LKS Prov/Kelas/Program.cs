using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace LKS_Prov.Kelas
{
    class Program:Query
    {

        public String GetHas(String str)
        {
            var crp = new SHA256Managed();
            String hash = String.Empty;
            byte[] byt = crp.ComputeHash(Encoding.ASCII.GetBytes(str));
            foreach (byte bt in byt)
            {
                hash += bt.ToString();
            }
            return hash;
        }

        public string GetCod(String query,String fild)
        {
            String cod = GetData(query,fild);
            int cont = int.Parse(cod)+1;
            if (cod==null)
            {
                return "001";
            }
            if (cod.Length == 3)
            {
                return cod.ToString();
            }
            else if (cod.Length == 2)
            {
                return "0" + cod.ToString();
            }
            else
            {
                return "00" + cod.ToString();
            }
        }


    }
}
