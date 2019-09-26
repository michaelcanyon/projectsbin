using System.Drawing;
namespace FractalSets
{
    public interface IPicture
    {
        int Width { get; set; }
        int Height { get; set; }
        Bitmap Draw();
    }
}
