using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4try
{
    internal class WriteShapesToFiles
    {
        public static void WriteShapesToFile(string filename, IEnumerable<Shape> shapes)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var shape in shapes)
                {
                    writer.WriteLine(shape);
                }
            }
        }
    }
}
