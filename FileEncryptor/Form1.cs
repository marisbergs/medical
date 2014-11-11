using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace FileEncryptor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dlgFile.DefaultExt = "xml";
            if (dlgFile.ShowDialog() == DialogResult.OK)
            {
                EncryptFile(dlgFile.FileName);
                MessageBox.Show("Fails veiksmīgi sašifrēts!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dlgFile.DefaultExt = "xml";
            if (dlgFile.ShowDialog() == DialogResult.OK)
            {
                DecryptFile(dlgFile.FileName);
                MessageBox.Show("Fails veiksmīgi atšifrēts!");
            }
        }

        //when change keys or encrypt decrypt procs, be sure to make the same changes in Core.Dal.Manager 
        private static byte[] desIV = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
        private static byte[] desKey = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };


        public static string Encrypt(string PlainText)
        {
            MemoryStream ms = new MemoryStream();
            // Create a CryptoStream using the memory stream and the CSP DES key.  
            CryptoStream encStream = new CryptoStream(ms, (new DESCryptoServiceProvider()).CreateEncryptor(desKey, desIV), CryptoStreamMode.Write);
            // Create a StreamWriter to write a string to the stream.
            StreamWriter sw = new StreamWriter(encStream);

            // Write the plaintext to the stream.
            sw.WriteLine(PlainText);

            // Close the StreamWriter and CryptoStream.
            sw.Flush();
            sw.Close();
            encStream.Close();

            // Get an array of bytes that represents the memory stream.
            byte[] buffer = ms.ToArray();
            ms.Close();

            // Return the encrypted byte array as string
            return Convert.ToBase64String(buffer);
        }

        // Decrypt the byte array.
        public static string Decrypt(string CypherText)
        {
            // Create a memory stream to the passed string converted to byte[] buffer.
            MemoryStream ms = new MemoryStream(Convert.FromBase64String(CypherText));
            // Create a CryptoStream using the memory stream and the CSP DES key. 
            CryptoStream encStream = new CryptoStream(ms, (new DESCryptoServiceProvider()).CreateDecryptor(desKey, desIV), CryptoStreamMode.Read);
            // Create a StreamReader for reading the stream.
            StreamReader sr = new StreamReader(encStream);
            // Read the stream as a string.
            string val = sr.ReadLine();

            // Close the streams.
            sr.Close();
            encStream.Close();
            ms.Close();
            return val;
        }

        public static void EncryptFile(String fileName)
        {
            //Create the streams to handle the input and output
            FileStream inStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader inReader = new StreamReader(inStream);
            FileStream outStream = new FileStream(fileName + "_", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter outWriter = new StreamWriter(outStream);

            while (inReader.Peek() > -1)
            {
                String input = inReader.ReadLine();
                outWriter.WriteLine(Encrypt(input));
            }
            inReader.Close();
            inStream.Close();

            outWriter.Flush();
            outWriter.Close();
            outStream.Close();
            System.IO.File.Replace(fileName + "_", fileName, null);
            System.IO.File.Delete(fileName + "_");
        }

        public static void DecryptFile(String fileName)
        {
            //Create the streams to handle the input and output
            FileStream inStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader inReader = new StreamReader(inStream);
            FileStream outStream = new FileStream(fileName + "_", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter outWriter = new StreamWriter(outStream);

            while (inReader.Peek() > -1)
            {
                String input = inReader.ReadLine();
                outWriter.WriteLine(Decrypt(input));
            }
            inReader.Close();
            inStream.Close();

            outWriter.Flush();
            outWriter.Close();
            outStream.Close();
            System.IO.File.Replace(fileName + "_", fileName, null);
            System.IO.File.Delete(fileName + "_");
        }


    }
}