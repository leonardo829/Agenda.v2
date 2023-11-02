using System;
namespace AgendaBE
{
    public class NuevoContacto
    {
        public string Nombre { get; set; }
        public long Telefono { get; set; }
        public string Mail { get; set; }

        public void Agregar(string aNombre,
                            string aTelefono,
                            string aMail)

        {
            Nombre = aNombre;
            Telefono = Convert.ToInt64(aTelefono);
            Mail = aMail;



        }

        public string Listar()
        {
            string Res = "";
            Res = Nombre + " - " + Telefono + " - " + Mail;

            return Res;
        }
    }
}
