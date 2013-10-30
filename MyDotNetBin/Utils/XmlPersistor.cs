using System.ComponentModel.Composition;
using System.IO;
using System.Xml.Serialization;
using System;

namespace MyDotNetBin.Utils
{
    /// <summary>
    /// A class to read and write an object to disk as XML
    /// </summary>
    public static class XmlPersistor
    {
        /// <summary>
        /// Write an object to disk
        /// </summary>
        /// <typeparam name="T">The type of the object to write</typeparam>
        /// <param name="filename">The XML file (with path) to which to save the object</param>
        /// <param name="obj">The object to save</param>
        public static void WriteXml<T>(string filename, T obj)
        {
            TextWriter writer = null;

            try
            {
                writer = new StreamWriter(filename);
                XmlSerializer x = new XmlSerializer(typeof(T));
                x.Serialize(writer, obj);
            }
            finally
            {
                if (null != writer)
                    writer.Close();
            }
        }

        /// <summary>
        /// Read an XML file to an object
        /// </summary>
        /// <typeparam name="T">The type of object to be read</typeparam>
        /// <param name="filename">The XML file (with path) to read</param>
        /// <param name="obj">The object to read into</param>
        public static void ReadXml<T>(string filename, ref T obj)
        {
            TextReader reader = null;

            try
            {
                reader = new StreamReader(filename);
                XmlSerializer x = new XmlSerializer(typeof(T));
                obj = (T)x.Deserialize(reader);
            }
            finally
            {
                if (null != reader)
                    reader.Close();
            }
        }
    }
}
