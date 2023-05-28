using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unidadcinco.jvvi
{
    public class textFieldEvent
    {
        public static void textV(KeyPressEventArgs e)
        {
            
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || 
                (e.KeyChar >= 91 && e.KeyChar <= 96) || 
                (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //MessageBox.Show("Sólo se permiten letras","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        public static void textSpaceV(KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 33 && e.KeyChar <= 64) ||
                (e.KeyChar >= 91 && e.KeyChar <= 96) ||
                (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //MessageBox.Show("Sólo se permiten letras","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        public static void textNumbersV(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) ||
                (e.KeyChar >= 58 && e.KeyChar <= 64) ||
                (e.KeyChar >= 91 && e.KeyChar <= 96) ||
                (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                //MessageBox.Show("Sólo se permiten letras y números","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        public static void decimaleslV(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) ||
                (e.KeyChar >= 45 && e.KeyChar <= 255))
            {
                //MessageBox.Show("Sólo se permiten números con decimal","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        public static void enterosV(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) ||
                (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                //MessageBox.Show("Sólo se permiten números con decimal","Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        public static void nothingV(KeyPressEventArgs e) {
            if (e.KeyChar >= 32 && e.KeyChar <=255)
            {
                e.Handled = true;
            }
        }
    }
}
