using System;
using System.IO;
using System.Xml;
using static System.Console;
using static System.Environment;
using static System.IO.Path;
using  System.IO.Compression;
namespace workingWithStreams
{
    class Program
    {
        static string[] callsigns = new string []{
                "Husker", "Starbuck", "Apollo", "Boomer",
                "Bulldog", "Athena", "Helo", "Racetrack"
            };

        static void WorkWithText(){
            //define  a file to write to 
            string textFile = Combine(CurrentDirectory, "streams.txt");

            //create a text file and return  a helper writer
            StreamWriter text= File.CreateText(textFile);

            //enumerate the strings, writing each one 
            // to the stream  on a  separte line 
            foreach(string item in callsigns){
                text.WriteLine(item);
            }
            text.Close();//release resourcese

            //output the contents of the file 
            WriteLine($"{textFile} contains {textFile.Length } bytes");
            WriteLine(File.ReadAllText(textFile));
        



        }

         static void workingWithXml(){
             //define file to write to 
            FileStream xmlFileStream = null;
            XmlWriter xml = null;

            try{


             string xmlFile= Combine(CurrentDirectory,"streams.xml");

            //create a file stream
              xmlFileStream= File.Create(xmlFile);

            //wrap the file stream in an xml writer helper
            // and automatically indent nested elements
             xml = XmlWriter.Create(xmlFileStream,
            new XmlWriterSettings{Indent= true});

            //write the xml declaration
            xml.WriteStartDocument();
        
            //write a root element
            xml.WriteStartElement("callsigns");

            //enumarate the strings writing each one to the stream 
            foreach(string item in callsigns){
                xml.WriteElementString("callsign", item);
            }

            //write the close root element
            xml.WriteEndElement();

            //close helper stream
            
            xml.Close();
            xmlFileStream.Close();

            //output all the contents of the file
            WriteLine("{0} contains {1:N0} bytes.", 
            arg0:xmlFile,
            arg1: new FileInfo (xmlFile).Length);

            WriteLine(File.ReadAllText(xmlFile));
         }catch(Exception ex)   {
             // if the path doesnt exist the exception will be caught 
             WriteLine($"{ex.GetType()} says {ex.Message}");
         }finally{
             if(xml !=null){
                 xml.Dispose();
                 WriteLine("The Xml writer's unmanaged resources have been disposed.");
             }
             if (xmlFileStream != null){
                 xmlFileStream.Dispose();
                 WriteLine("The file stream's unmanaged resources have been disposed. ");
             }
         }

         }

         static void WorkWithCompression(bool useBrotli = false){
             
             string fileExt = useBrotli? "brotli" : "gzip";

             //compress the xml output 
            string filepath = Combine(CurrentDirectory,$"streams.{fileExt}");

            FileStream file = File.Create(filepath);

            Stream compressor;

            if (useBrotli){
                compressor = new BrotliStream(file,CompressionMode.Compress);
            }
            else{
                compressor = new GZipStream(file,CompressionMode.Compress);
            }




            using( compressor){

                using(XmlWriter xml = XmlWriter.Create(compressor)){
                    xml.WriteStartDocument();
                    xml.WriteStartElement("callsigns");

                    foreach(string item in callsigns){
                        xml.WriteElementString("callsigns", item );
                    }
                    //the normal to writeEndElement is not necessary because the 
                    //xmlwriter disposes , it will automatically end any elements of any depth

                }
            }//also closes the underlying stream 

            //output all the contents of the compressed file 
            WriteLine("{0} contains {1:N0} by bytes.", 
            filepath, new FileInfo(filepath).Length);


            WriteLine(File.ReadAllText(filepath));

        

            //read a compressed file
            WriteLine("Reading the compressed XML file");
            file = File.Open(filepath,FileMode.Open);

            Stream decompressor;

            if (useBrotli){
                decompressor = new BrotliStream(
                    file,CompressionMode.Decompress
                );
            }else
            {
                decompressor = new GZipStream(file,CompressionMode.Decompress);

            }
                using (decompressor)
                {
                using (XmlReader reader = XmlReader.Create(decompressor))
                {
                while (reader.Read())
                {
                // check if we are on an element node named callsign
                if ((reader.NodeType == XmlNodeType.Element)
                && (reader.Name == "callsign"))
                {
                reader.Read(); // move to the text inside element
                WriteLine($"{reader.Value}"); // read its value
                }
                }   
                }
                }
                
         }
        static void Main(string[] args)
        {
            //define an array of Viper pilot call signs
            
        // WorkWithText();

         workingWithXml();

        WorkWithCompression();


        }
    }
}
