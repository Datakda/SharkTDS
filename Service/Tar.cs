using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Tar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SharkTDS.Service
{
    public static class Tar
    {

        public static bool UnzipGz(string filePath, string outfile,string path) 
        {

            FileStream fstream = File.OpenRead(filePath);

            FileStream sr = File.Create(outfile);

            GZip.Decompress(fstream, sr, true);
            fstream.Close();
            sr.Close();
            Stream inStream = File.OpenRead(outfile);
            TarArchive tarArchive = TarArchive.CreateInputTarArchive(inStream);
            tarArchive.ExtractContents(path);
            tarArchive.Close();

            inStream.Close();
            return true;

        }
       

    }
}
