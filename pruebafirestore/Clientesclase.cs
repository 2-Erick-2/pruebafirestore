using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;


namespace pruebafirestore
{
    [FirestoreData]
   public  class Clientesclase
    {
        [FirestoreProperty]
        public String Calle { get; set; }
        [FirestoreProperty]
        public String Cantidad { get; set; }
        [FirestoreProperty]
        public String Ciudad { get; set; }

    }
}
