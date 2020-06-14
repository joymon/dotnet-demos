using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSONReferenceDemo.Models
{
    public class FileInformation
    {
        public string Name { get; set; }
        public FolderInformation Folder { get; set; }
    }
}