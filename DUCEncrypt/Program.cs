using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUCEncrypt
{
    class Program
    {
        static void Main(string[] args)
        {

            string test = "metadata=res://*/MobServiceModel.csdl|res://*/MobServiceModel.ssdl|res://*/MobServiceModel.msl;provider=Oracle.DataAccess.Client;provider connection string=&quot;data source=172.28.28.64:1521/SMARTTSTdr;password=clone2019;persist security info=True;user id=CMS&quot;";

            string fsdfs = DUC.Utilities.CryptoEngine.CryptoEngine.Encrypt(test, true);
            Console.WriteLine(fsdfs);
            Console.WriteLine(DUC.Utilities.CryptoEngine.CryptoEngine.Decrypt(fsdfs,true));
            Console.ReadLine();
        }
    }
}
