using GroupDocs.Conversion;
using GroupDocs.Conversion.FileTypes;
using GroupDocs.Conversion.Options.Convert;
using System.Collections.Generic;
using System.Drawing;

namespace Bibliotec.Arquivos
{
    public class ClsImagens
    {
        public static List<Bitmap> lBitmaps = new List<Bitmap>();

        //public static List<ImageFileType> lFormato = new List<ImageFileType>()
        //{
        //    new ImageConvertOptions
        //    {
        //        Format = ImageFileType.Bmp
        //    }
        //};

        public void FU_ConvertImagens(string sFormato)
        {
            List<Bitmap> lBitmapsConvertida = new List<Bitmap>();
            foreach (Bitmap bmp in lBitmaps)
            {
                using (Converter converter = new Converter("./Resources/groupdocs_conversion-brand.webp"))
                {
                    ImageConvertOptions options = new ImageConvertOptions
                    { // Set the conversion format to JPG
                        Format = ImageFileType.Jpg
                    };
                    converter.Convert(@"./Output/converted-image.jpg", options);
                }

            }

        }
    }
}
