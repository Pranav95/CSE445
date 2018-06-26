using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Xsl;

namespace Assignment3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void DoWork()
        {
        }
        public string transform(string xmlstring, string xslstring)
        {
            string final = "";
            try
            {
                StringBuilder temp = new StringBuilder("");
                XmlWriterSettings set = new XmlWriterSettings();
                set.ConformanceLevel = ConformanceLevel.Auto;
                XmlWriter writer = XmlWriter.Create(temp, set);
                XslCompiledTransform transform = new XslCompiledTransform();
                transform.Load(xslstring);
                transform.Transform(xmlstring, writer);
                final = temp.ToString();
            }
            catch (Exception e)
            {
                final = e.Message;
            }
            return final;


        }



        


        public string verify(string xmlstring, string xsd)
        {

            string finalString = "Valid";  
            string xml;
            var tempset = new XmlSchemaSet();

            using (var webclient = new WebClient())
            {
                try
                {
                    xml = webclient.DownloadString(xmlstring); 
                }
                catch (WebException e)
                {
                    finalString = "Invalid";
                    return finalString;
                }
            }

            var doc = new XmlDocument(); 
            try
            {
                doc.Load(xmlstring);
            }
            catch (XmlException e)
            {
                finalString = e.ToString();
                return finalString;
            }

            var xdoc = XmlDoc(doc);

            tempset.Add(null, xsd); 

            xdoc.Validate(tempset, (o, e) => 
            {
                finalString = e.Message;
            });

            return finalString;

        }
        private static XDocument XmlDoc(XmlDocument xdoc)
        {
            return XDocument.Load(new XmlNodeReader(xdoc));
        }



    }
}
