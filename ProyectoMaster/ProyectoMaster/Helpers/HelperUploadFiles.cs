using Microsoft.AspNetCore.Http;
using ProyectoMaster.Providers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMaster.Helpers
{
    public class HelperUploadFiles
    {
        private PathProvider pathProvider;

        public HelperUploadFiles(PathProvider pathProvider)
        {
            this.pathProvider = pathProvider;
        }

        public async Task<string> UploadFileAsync(IFormFile formFile,
            Folders folder)
        {
            string fileName = formFile.FileName;
            string path = this.pathProvider.MapPath(fileName, folder);
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                await formFile.CopyToAsync(stream);
            }
            return fileName;
        }
    }
}
