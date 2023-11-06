using System;
using System.Data;
using System.Runtime.ConstrainedExecution;

namespace AgendaBE
{
    public class Contactos
    {

        public DataTable ListaDT { get; set; } = new DataTable();

        public NuevoContacto[] contactos { get; set; } = new NuevoContacto[200];
        private int fila = 0;



        public Contactos()
        {
            ListaDT.TableName = "ListaPersonas";
            ListaDT.Columns.Add("Nombre");
            ListaDT.Columns.Add("Telefono", typeof(Int64));
            ListaDT.Columns.Add("Mail");

            LeerArchivo();
        }

        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Contactos.xml"))
            {
                ListaDT.ReadXml("Contactos.xml");
            }
        }

        public void InsertContacto(NuevoContacto aContacto)
        {

            ListaDT.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["Nombre"] = aContacto.Nombre;
            ListaDT.Rows[NuevoRenglon]["Telefono"] = aContacto.Telefono;
            ListaDT.Rows[NuevoRenglon]["Mail"] = aContacto.Mail;


            ListaDT.WriteXml("Contactos.xml");
        }




        public NuevoContacto Buscar(string aTelefono)
        {
            Int64 Telefono = Convert.ToInt64(aTelefono);

            NuevoContacto cont = new NuevoContacto();


            foreach (DataRow fila in ListaDT.Rows)
            {
                if (Convert.ToInt64(fila["Telefono"]) == Telefono)
                {
                    cont.Nombre = Convert.ToString(fila["Nombre"]);
                    cont.Telefono = Convert.ToInt64(fila["Telefono"]);
                    cont.Mail = fila["Mail"].ToString();

                    break;
                }
            }


            return cont;
        }


    }
}
