using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherViewer
{
    internal class LoadingHandler : Form
    {
        private PictureBox loadingAnimation;

        public LoadingHandler()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.Gray; // 배경색
            this.Opacity = 0.5; // 반투명도 (0.0 - 1.0)
            this.ShowInTaskbar = false;
            this.TopMost = true;

            // 마우스 이벤트 차단
            this.Enabled = false;

            // 로딩 애니메이션 추가
            loadingAnimation = new PictureBox
            {
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Image = Image.FromFile(@"data\images\loading.gif")
            };

            this.Controls.Add(loadingAnimation);
            CenterLoadingAnimation();
        }

        // 로딩 애니메이션 중앙 배치
        private void CenterLoadingAnimation()
        {
            loadingAnimation.Location = new Point(
                (this.Width - loadingAnimation.Width) / 2,
                (this.Height - loadingAnimation.Height) / 2
            );
        }

        // 창 크기가 변경될 때 로딩 애니메이션 위치 업데이트
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CenterLoadingAnimation();
        }
    }
}
