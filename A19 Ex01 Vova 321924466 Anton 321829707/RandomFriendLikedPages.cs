using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A19_Ex01_Vova_321924466_Anton_321829707
{
    public class RandomFriendLikedPages
    {
        private User m_LoggedInUser;
        private User m_RandomFriend;
        private PictureBox[] m_PicsBoxArr;
        private GroupBox m_GroupBoxFriendsLikedPagesWithPictures;

        public RandomFriendLikedPages(User io_LoggedInUser, GroupBox io_GroupBoxFriendsLikedPagesWithPictures)
        {
            m_LoggedInUser = io_LoggedInUser;
            m_GroupBoxFriendsLikedPagesWithPictures = io_GroupBoxFriendsLikedPagesWithPictures;
        }

        public GroupBox GetPages()
        {
            m_GroupBoxFriendsLikedPagesWithPictures.Controls.Clear();
            createArrayOfTenPictures();
            getRandomFriend();
            getFriendsLikedPagesWithURL();

            return m_GroupBoxFriendsLikedPagesWithPictures;
        }

        private void createArrayOfTenPictures()
        {
            int colSize = m_GroupBoxFriendsLikedPagesWithPictures.Width / 2;
            int rowSize = m_GroupBoxFriendsLikedPagesWithPictures.Height / 5;
            int picsBoxArrIndex = 0;
            m_PicsBoxArr = new PictureBox[10];

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
                m_RandomFriend = m_LoggedInUser.Friends[randomFriendIndex.Next(m_LoggedInUser.Friends.Count)];
            }
            else
            {
                MessageBox.Show("Sorry, you have no friends using this application.");
            }
        }

        private void getFriendsLikedPagesWithURL()
        {           
            int pageIndex = 0;

            try
            {
                foreach (Page friendLikedPage in m_RandomFriend.LikedPages)
                {
                    if (pageIndex < 10)
                    {
                        m_PicsBoxArr[pageIndex].ImageLocation = friendLikedPage.PictureURL;
                        pageIndex++;
                    }
                }
            }
            catch (Exception friendLikedPageException)
            {
                MessageBox.Show(@"We were unable to receive liked pages of your friend. ¯\_(ツ)_/¯" + System.Environment.NewLine + friendLikedPageException.Message);
            }

            /* This part is only to show that the pictures grid working well */
            while (pageIndex < 10)
            {
                m_PicsBoxArr[pageIndex].ImageLocation = m_LoggedInUser.PictureNormalURL;
                pageIndex++;
            }
        }
    }
}