using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace TamrielTradeApp {
    public static class ItemImages {
        public static bool IsHaveLoadedImage(string imageHtmlName) {
            return false;
        }

        public static Image GetImage(string imageHtmlName) {
            //Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/ItemImages");

            Image itemImage = null;



            //try {
            //    if(File.Exists(Directory.GetCurrentDirectory() + $"/ItemImages/{imageHtmlName}.png")) {
            //        using(FileStream stream = File.Open(Directory.GetCurrentDirectory() + $"/ItemImages/{imageHtmlName}.png", FileMode.Open, FileAccess.ReadWrite)) {
            //            Debug.WriteLine("Image Loaded From File Start ");
            //            //itemImage = Image.FromStream(stream);
            //            Debug.WriteLine("Image Loaded From File End ");
            //        }
            //    } else {
            //        Debug.WriteLine("Image Loaded From Internet Start");
            //        itemImage = DownloadImage(GetFullURL(imageHtmlName));
            //        Debug.WriteLine("Image Loaded From Internet End");
            //        using(FileStream stream = File.Open(Directory.GetCurrentDirectory() + $"/ItemImages/{imageHtmlName}.png", FileMode.OpenOrCreate, FileAccess.ReadWrite)) {
            //            //stream.
            //            //itemImage.Save(Directory.GetCurrentDirectory() + $"/ItemImages/{imageHtmlName}.png", ImageFormat.Png);
            //            //File.Create(Directory.GetCurrentDirectory() + $"/ItemImages/{imageHtmlName}.png");
            //            //itemImage.Save(stream, ImageFormat.Png);
            //        }
            //    }

            //} catch(Exception e) {
            //    Debug.WriteLine(e.Message);
            //    throw;
            //}
            
            //
            //itemImage = DownloadImage(Directory.GetCurrentDirectory() + $"/ItemImages/{imageHtmlName}.png");
            //itemImage = DownloadImage(Directory.GetCurrentDirectory() + $"/ItemImages/{imageHtmlName}.png");

            //using(FileStream stream = File.Open(Directory.GetCurrentDirectory() + $"/ItemImages/{imageHtmlName}.png", FileMode.Open)) {
            //    itemImage = Image.FromStream(stream);
            //}
            return itemImage;
        }

        static Image DownloadImage(string fromUrl) {
            using(System.Net.WebClient webClient = new()) {
                using(Stream stream = webClient.OpenRead(fromUrl)) {
                    return Image.FromStream(stream);
                }
            }
        }

        public static string GetFullURL(string imageHtmlName) {
            return $"https://" + $"eu.tamrieltradecentre.com/Content/icons/{imageHtmlName}.png";
        }
    }
}
