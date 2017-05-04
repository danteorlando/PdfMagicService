using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfMagic.Model
{
    public class Form
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public List<FormField> Fields { get; set; }
    }
}
