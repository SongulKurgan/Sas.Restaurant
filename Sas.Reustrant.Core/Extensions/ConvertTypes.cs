using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Core.Extensions
{
   public static class ConvertTypes
    {
        public static byte[] ImageToByteArray(this Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        public static Image ByteArrayToImage(this byte[] imgData)
        {
            using (var stream=new MemoryStream(imgData))
            {
                return Image.FromStream(stream);
            }
        }
    }
}
