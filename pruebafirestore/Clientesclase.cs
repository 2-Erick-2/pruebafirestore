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

        [FirestoreProperty]
        public String Accesorios { get; set; }

        [FirestoreProperty]
        public String Contraseña { get; set; }

        [FirestoreProperty]
        public String Descripcion { get; set; }

        [FirestoreProperty]
        public String Fechayhora { get; set; }

        [FirestoreProperty]
        public int ID { get; set; }

        [FirestoreProperty]
        public String Modelo { get; set; }

        [FirestoreProperty]
        public String Nombre { get; set; }

        [FirestoreProperty]
        public String Numero { get; set; }

        [FirestoreProperty]
        public String Tiempodeespera { get; set; }
    }
}
