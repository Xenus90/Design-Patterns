using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using A19_Ex03_Vova_321924466_Anton_321829707.CacheProxyPattern;
using A19_Ex03_Vova_321924466_Anton_321829707.FactoryMethodPattern;
using A19_Ex03_Vova_321924466_Anton_321829707.StrategyPattern;

namespace A19_Ex03_Vova_321924466_Anton_321829707
{
    public class RandomFriendLikedPages : IFacebookFeature
    {
        private User m_LoggedInUser;
        private User m_RandomFriend;
        private PictureBox[] m_PicsBoxArr;
        private GroupBox m_GroupBoxFriendsLikedPagesWithPictures;
        private IGetLikedPages m_GetLikedPages;
        private ISort m_SortAlgorithm;

        public RandomFriendLikedPages(User io_LoggedInUser, GroupBox io_GroupBoxFriendsLikedPagesWithPictures)
        {
            this.m_LoggedInUser = io_LoggedInUser;
            this.m_GroupBoxFriendsLikedPagesWithPictures = io_GroupBoxFriendsLikedPagesWithPictures;
            m_GetLikedPages = new GetLikedPagesCacheProxy();
        }

        public User LoggedInUser { get; set; }

        public GroupBox GetPages()
        {
            this.m_GroupBoxFriendsLikedPagesWithPictures.Controls.Clear();
            this.createArrayOfTenPictures();
            this.getRandomFriend();
            new Thread(this.getFriendsLikedPagesWithURL).Start();
            
            return m_GroupBoxFriendsLikedPagesWithPictures;
        }

        public void sortPicsBoxArrAlgorithm(string i_sortAlgoritm)
        {
            switch (i_sortAlgoritm)
            {
                case "Ascending (likes amount)":
                    m_SortAlgorithm = new AscendingLikesSort();
                    break;
                case "Descending (likes amount)":
                    m_SortAlgorithm = new DescendingLikesSort();
                    break;
            }
            
            m_PicsBoxArr = m_SortAlgorithm.sortAlgorithm(m_PicsBoxArr);
        }

        private void createArrayOfTenPictures()
        {
            int colSize = m_GroupBoxFriendsLikedPagesWithPictures.Width / 2;
            int rowSize = m_GroupBoxFriendsLikedPagesWithPictures.Height / 5;
            int picsBoxArrIndex = 0;
            this.m_PicsBoxArr = new PictureBox[10];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    m_PicsBoxArr[picsBoxArrIndex] = new PictureBox();
                    m_PicsBoxArr[picsBoxArrIndex].Location = new Point(colSize * j, rowSize * i);
                    m_PicsBoxArr[picsBoxArrIndex].Height = rowSize;
                    m_PicsBoxArr[picsBoxArrIndex].Width = colSize;
                    m_PicsBoxArr[picsBoxArrIndex].SizeMode = PictureBoxSizeMode.StretchImage;
                    m_GroupBoxFriendsLikedPagesWithPictures.Controls.Add(m_PicsBoxArr[picsBoxArrIndex]);
                    picsBoxArrIndex++;
                }
            }
        }

        private void getRandomFriend()
        {
            if (m_LoggedInUser.Friends.Count != 0)
            {
                Random randomFriendIndex = new Random();
                this.m_RandomFriend = m_LoggedInUser.Friends[randomFriendIndex.Next(this.m_LoggedInUser.Friends.Count)];
            }
            else
            {
                MessageBox.Show("Sorry, you have no friends using this application.");
            }
        }

        private void getFriendsLikedPagesWithURL()
        {
            try
            {
                string[] pageImageLocation = m_GetLikedPages.GetRandomFriendLikedPages(m_RandomFriend);

                for (int i = 0; i < m_PicsBoxArr.Length && i < pageImageLocation.Length; i++)
                {
                    m_PicsBoxArr[i].ImageLocation = pageImageLocation[i];
                }
            }
            catch (Exception friendLikedPageException)
            {
                MessageBox.Show(@"We were unable to receive liked pages of your friend. ¯\_(ツ)_/¯" + System.Environment.NewLine + friendLikedPageException.Message);

                /* This part is only to show that picture grid working well. */
                for (int i = 0; i < m_PicsBoxArr.Length; i++)
                {
                    m_PicsBoxArr[i].ImageLocation = m_RandomFriend.PictureNormalURL;
                }
            }
        }
    }
}