using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BLL
{
    public class Serializacion
    {
        public void SerializarXML(List<BE.Cliente> clientes, string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<BE.Cliente>));
                    serializer.Serialize(fs, clientes);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al serializar los datos: " + ex.Message);
            }
        }

        public List<BE.Cliente> DeserializarXML(string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<BE.Cliente>));
                    return (List<BE.Cliente>)serializer.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al deserializar los datos: " + ex.Message);
            }
        }
    }
}
