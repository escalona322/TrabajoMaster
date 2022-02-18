using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Providers
{
    public enum Folders
    {
        Uploads = 0, Images = 1, Documents = 2, Temp = 3
    }
    public class PathProvider
    {
        private IWebHostEnvironment hostEnvironment;

        public PathProvider(IWebHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment;
        }

        public string MapPath(string filename, Folders folder)
        {
            string carpeta = "";
            if (folder == Folders.Uploads)
            {
                carpeta = "uploads";
            }
            else if (folder == Folders.Images)
            {
                carpeta = "images";
            }
            else if (folder == Folders.Documents)
            {
                carpeta = "documents";
            }
            string path = Path.Combine(this.hostEnvironment.WebRootPath
                , carpeta, filename);
            return path;
        }
    }
}
