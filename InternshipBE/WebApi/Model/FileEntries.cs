using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    public class FileDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public Format Formats { get; set; }

        public enum Format
        {
            Mp3,
            Wma
        }
    }
}
