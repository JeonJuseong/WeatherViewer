using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace WeatherViewer
{
    internal class IconHandler
    {
        //pty값이 0이 아니라면 -> 강수: priority가 높게 설정
        //즉, 우선 pty값을 체크하고, 이것이 0일때 SkyCode를 확인
        //강수형태(PTY) 코드 : (초단기) 없음(0), 비(1), 비/눈(2), 눈(3), 빗방울(5), 빗방울눈날림(6), 눈날림(7) 
        internal void PrecTypeToIcon(PictureBox[] pictureBoxes, string ptyCode, int boxNum)
        {
            const string iconPath = @"data\images\";
            switch (ptyCode)
            {
                case "1":
                    pictureBoxes[boxNum].Image = Image.FromFile(Path.Combine(iconPath, "rainy.png"));
                    break;
                case "2":
                    pictureBoxes[boxNum].Image = Image.FromFile(Path.Combine(iconPath, "rainsnow.png"));
                    break;
                case "3":
                    pictureBoxes[boxNum].Image = Image.FromFile(Path.Combine(iconPath, "snowy.png"));
                    break;
                case "5":
                    pictureBoxes[boxNum].Image = Image.FromFile(Path.Combine(iconPath, "raindrop.png"));
                    break;
                case "6":
                    pictureBoxes[boxNum].Image = Image.FromFile(Path.Combine(iconPath, "rainsnow.png"));
                    break;
                case "7":
                    pictureBoxes[boxNum].Image = Image.FromFile(Path.Combine(iconPath, "snowflake.png"));
                    break;
                default:
                    pictureBoxes[boxNum].Image = Image.FromFile(Path.Combine(iconPath, "loading.gif"));
                    break;
            }
            pictureBoxes[boxNum].SizeMode = PictureBoxSizeMode.Zoom;
        }

        internal void SkyCodeToIcon(PictureBox[] pictureBoxes, string skyCode, int boxNum)
        {
            const string iconPath = @"data\images\";
            switch (skyCode)
            {
                case "1":
                    pictureBoxes[boxNum].Image = Image.FromFile(Path.Combine(iconPath, "sunny.png"));
                    break;
                case "3":
                    pictureBoxes[boxNum].Image = Image.FromFile(Path.Combine(iconPath, "cloud_half.png"));
                    break;
                case "4":
                    pictureBoxes[boxNum].Image = Image.FromFile(Path.Combine(iconPath, "cloud.png"));
                    break;
                default:
                    pictureBoxes[boxNum].Image = Image.FromFile(Path.Combine(iconPath, "loading.gif"));
                    break;
            }
            pictureBoxes[boxNum].SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
