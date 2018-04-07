using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;
using XMLParsers.Helpers;
using XMLParsers.Models;

namespace XMLParsers.Presentation
{
    public partial class frmTask1 : Form
    {
        XDocument xdoc = null;
        public frmTask1()
        {
            InitializeComponent();
        }
         
        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            string strXMLPath = txtXMLPath.Text;

            if (strXMLPath != "" && System.IO.File.Exists(strXMLPath))
            { 
                DataSet ds = new DataSet();
                // Create new FileStream with which to read the schema.
                System.IO.FileStream fsReadXml = new System.IO.FileStream
                    (strXMLPath, System.IO.FileMode.Open);
                try
                {
                    var xx=fsReadXml.ToString();
                    ds.ReadXml(fsReadXml);
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "TenancyContract";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    fsReadXml.Close();
                }
                ReadXMLAndUpdatexDoc();
                
            }
            else
            {
                MessageBox.Show("Enter Type Proper XML file Path");
            }
        }

        private void ReadXMLAndUpdatexDoc()
        {
            xdoc = new XDocument();
            using (StreamReader sr = new StreamReader(txtXMLPath.Text, true))
            {
                xdoc = XDocument.Load(sr);
            }
            //string xmlcontents = xdoc.InnerXml;
            //btnParseSave.Enabled = true;
        }

        private void btnParseSave_Click(object sender, EventArgs e)
        {
            string strXMLPath = txtXMLPath.Text;
            if (strXMLPath != "" && System.IO.File.Exists(strXMLPath))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<TenancyContract>));
                TextReader textReader = new StreamReader(@strXMLPath);
                List<TenancyContract> lstTenancyContract = (List<TenancyContract>)deserializer.Deserialize(textReader);
                textReader.Close();
            }
        }
        private PropertyDetails ConvertXElementToModel(XElement objXmlNode)
        {
            PropertyDetails objPropertyDetails = new PropertyDetails();

            #region Temp1
            string strXML = objXmlNode.InnerXML();
             XElement xElement = XElement.Parse(strXML); 

            StringReader reader = new StringReader(xElement.ToString());
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PropertyDetails));
            objPropertyDetails = (PropertyDetails)xmlSerializer.Deserialize(reader);
            #endregion



            var PropertyCode = objXmlNode.Element("PropertyCode").Value;
            var AnnualRent = objXmlNode.Element("AnnualRent").Value;
            var BuiltArea = objXmlNode.Element("BuiltArea").Value;
            var IsRented = objXmlNode.Element("IsRented").Value;
            return (objPropertyDetails);
        }
    }
}
