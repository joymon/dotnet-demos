using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Http;
using JSONReferenceDemo.Models;
using JSONReferenceDemo.Repositories;

namespace JSONReferenceDemo.Controllers
{
    public class FilesController : ApiController
    {
        // GET api/values
        public IEnumerable<FileInformation> Get()
        {
            FolderInformation folder = new FolderInformation()
            {
                Machine = Environment.MachineName,
                Path = @"..\TestServer\Files" //Use proper path here base on hosting
            };

            return Directory.GetFiles(folder.Path).Select((filePath) => new FileInformation() {Name = Path.GetFileName(filePath),Folder= folder });
        }

        // GET api/values/5
        public string Get(int id)
        {
            return new DataRepository().GetTestData(id);
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
