using System.Windows.Forms;

namespace A19_Ex03_Vova_321924466_Anton_321829707.StrategyPattern
{
    public class AscendingLikesSort : ISort
    {
        public PictureBox[] sortAlgorithm(PictureBox[] io_PicsBoxArr)
        {
            /* Because of Facebook permissions we can't fetch user liked pages and data. Thus this part is only to show that this method is working as needed. */

            foreach (PictureBox singlePicBox in io_PicsBoxArr)
            {
                singlePicBox.ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/2/20/1UpGreenArrow.png";
            }

            return io_PicsBoxArr;
        }
    }
}
