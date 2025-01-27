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
        private Image gifImage;

        public LoadingHandler(Form parentForm)
        {
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.Manual;
            BackColor = Color.Gray; // 배경색
            Opacity = 0.5; // 반투명도 (0.0 - 1.0)
            ShowInTaskbar = false;
            Size = parentForm.Size;
            Location = parentForm.Location;

            // 마우스 이벤트 차단
            Enabled = false;

            gifImage = Image.FromFile(@"data\images\loading.gif");
            // 로딩 애니메이션 추가
            loadingAnimation = new PictureBox
            {
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Image = gifImage
            };

            Controls.Add(loadingAnimation);
            CenterLoadingAnimation();

            ImageAnimator.Animate(gifImage, OnFrameChanged);
        }

        // 애니메이션 프레임 변경 이벤트
        private void OnFrameChanged(object sender, EventArgs e)
        {
            if (loadingAnimation.Image != null)
            {
                ImageAnimator.UpdateFrames(gifImage); // GIF 애니메이션 업데이트
                loadingAnimation.Invalidate(); // PictureBox 다시 그리기
            }
        }

        // 로딩 애니메이션 중앙 배치
        private void CenterLoadingAnimation()
        {
            loadingAnimation.Location = new Point(
                (Width - loadingAnimation.Width) / 2,
                (Height - loadingAnimation.Height) / 2
            );
        }

        // 폼 닫힐 때 애니메이션 정지
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            ImageAnimator.StopAnimate(gifImage, OnFrameChanged);
        }
        // 창 크기가 변경될 때 로딩 애니메이션 위치 업데이트
        // => 창 크기가 변경되는 경우가 없음.(삭제)
    }
}
