using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace E_Commerce_ShoebApi.Models
{
    public class ImageFormat
    {
        protected Byte[] ImageToByteArray(string image)
        {
            byte[] array = Encoding.ASCII.GetBytes(image);
            return array;
        }
        protected string ByteArrayToString(Byte[] ImageArray)
        {
            string utfString = Encoding.UTF8.GetString(ImageArray, 0, ImageArray.Length);
            return utfString;
        }
    }
}