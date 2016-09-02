using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Drawing;

namespace CONTROLADORA
{
    public class funciones_compartidas
    {
        public static string EncriparClave(string clave)
        {
            byte[] passBytes = Encoding.Unicode.GetBytes(clave);
            SHA1 sha = SHA1.Create();
            byte[] hash = sha.ComputeHash(passBytes);
            string hashString = Encoding.Unicode.GetString(hash);
            return hashString;
        }//Encripta la clave

        public static string ClaveAleatoria()
        {
            char[] ValueAfanumeric = { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            Random random = new Random();
            int longitud = 6;
            string ClaveAleat = String.Empty;
            for (int i = 0; i < longitud; i++)
            {
                int rm = random.Next(0, 2);
                if (rm == 0)
                {
                    ClaveAleat += random.Next(0, 10);
                }
                else
                {
                    ClaveAleat += ValueAfanumeric[random.Next(0, 59)];
                }
            }
            return ClaveAleat;
        }
        public static bool ValidarEmail(string mail)
        {
            string expresion;
            expresion = @"\A(\w+\.?\w*\@\w+\.)(com)\Z";
            System.Text.RegularExpressions.Regex automata = new Regex(expresion);
            return automata.IsMatch(mail);
        }//expresion Regular para Mail

        public static bool EnviarEmail(string Destinatario, string Asunto, string Mensaje)
        {
            MODELO.PARAMETRO oPAR = OBTENER_PARAMETROS();
            MailMessage msg = new MailMessage();
            msg.To.Add(Destinatario);
            msg.From = new MailAddress(oPAR.MAIL_CUENTA, oPAR.MAIL_NOMBRE_REMITENTE, System.Text.Encoding.UTF8);
            msg.Subject = Asunto;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = Mensaje;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = false;
            SmtpClient cliente = new SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential(oPAR.MAIL_CUENTA, oPAR.MAIL_CLAVE);
            cliente.Port = oPAR.MAIL_PORT;
            cliente.Host = oPAR.MAIL_HOST;
            cliente.EnableSsl = oPAR.MAIL_SSL;
            try
            {
                cliente.Send(msg);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Boolean VERIFICA_ENVIO_MAIL()
        {
            string NOMBRE_EQUIPO = Environment.MachineName;
            MODELO.PARAMETRO oPARAMETRO = MODELO.CATALOGO.obtener_instancia().PARAMETROS.FirstOrDefault(p => p.NOMBRE_EQUIPO == NOMBRE_EQUIPO);
            if (oPARAMETRO == null)
                return false;
            else
                return oPARAMETRO.ENVIO_MAILS;
        }
        public static string DIRECTORIO_IMAGENES()
        {
            string NOMBRE_EQUIPO = Environment.MachineName;
            MODELO.PARAMETRO oPARAMETRO = MODELO.CATALOGO.obtener_instancia().PARAMETROS.FirstOrDefault(p => p.NOMBRE_EQUIPO == NOMBRE_EQUIPO);
            if (oPARAMETRO != null)
                return oPARAMETRO.DIRECTORIO_IMAGENES;
            else
                return string.Empty;
        }

        public static MODELO.PARAMETRO OBTENER_PARAMETROS()
        {
            string NOMBRE_EQUIPO = Environment.MachineName;
            MODELO.PARAMETRO oPARAMETRO = MODELO.CATALOGO.obtener_instancia().PARAMETROS.FirstOrDefault(p => p.NOMBRE_EQUIPO == NOMBRE_EQUIPO);

            return oPARAMETRO;
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public static void copiar_archivo(string dir_destino, string file_name)
        {
            string destFile  = System.IO.Path.Combine(funciones_compartidas.DIRECTORIO_IMAGENES(), file_name);
            string sourceFile = System.IO.Path.Combine(dir_destino, file_name);

            if (sourceFile != destFile)
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
        }
    }
}
