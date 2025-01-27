namespace WeatherViewer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.updateTimeLabel = new System.Windows.Forms.Label();
            this.authKeyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.authKeyLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timeLabel1 = new System.Windows.Forms.Label();
            this.timeLabel2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timeLabel3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timeLabel4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timeLabel5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timeLabel6 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.tempLabel1 = new System.Windows.Forms.Label();
            this.tempLabel2 = new System.Windows.Forms.Label();
            this.tempLabel3 = new System.Windows.Forms.Label();
            this.tempLabel4 = new System.Windows.Forms.Label();
            this.tempLabel5 = new System.Windows.Forms.Label();
            this.tempLabel6 = new System.Windows.Forms.Label();
            this.humiLabel1 = new System.Windows.Forms.Label();
            this.humiLabel2 = new System.Windows.Forms.Label();
            this.humiLabel3 = new System.Windows.Forms.Label();
            this.humiLabel4 = new System.Windows.Forms.Label();
            this.humiLabel5 = new System.Windows.Forms.Label();
            this.humiLabel6 = new System.Windows.Forms.Label();
            this.precLabel1 = new System.Windows.Forms.Label();
            this.precLabel2 = new System.Windows.Forms.Label();
            this.precLabel3 = new System.Windows.Forms.Label();
            this.precLabel4 = new System.Windows.Forms.Label();
            this.precLabel5 = new System.Windows.Forms.Label();
            this.precLabel6 = new System.Windows.Forms.Label();
            this.windDirLabel1 = new System.Windows.Forms.Label();
            this.windDirLabel2 = new System.Windows.Forms.Label();
            this.windDirLabel3 = new System.Windows.Forms.Label();
            this.windDirLabel4 = new System.Windows.Forms.Label();
            this.windDirLabel5 = new System.Windows.Forms.Label();
            this.windDirLabel6 = new System.Windows.Forms.Label();
            this.windSpdLabel1 = new System.Windows.Forms.Label();
            this.windSpdLabel2 = new System.Windows.Forms.Label();
            this.windSpdLabel3 = new System.Windows.Forms.Label();
            this.windSpdLabel4 = new System.Windows.Forms.Label();
            this.windSpdLabel5 = new System.Windows.Forms.Label();
            this.windSpdLabel6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(693, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "갱신";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "최종업데이트시각:";
            // 
            // updateTimeLabel
            // 
            this.updateTimeLabel.AutoSize = true;
            this.updateTimeLabel.Location = new System.Drawing.Point(150, 325);
            this.updateTimeLabel.Name = "updateTimeLabel";
            this.updateTimeLabel.Size = new System.Drawing.Size(93, 12);
            this.updateTimeLabel.TabIndex = 3;
            this.updateTimeLabel.Text = "0000.00.00 00:00";
            // 
            // authKeyButton
            // 
            this.authKeyButton.Font = new System.Drawing.Font("나눔스퀘어 Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.authKeyButton.Location = new System.Drawing.Point(590, 303);
            this.authKeyButton.Name = "authKeyButton";
            this.authKeyButton.Size = new System.Drawing.Size(97, 34);
            this.authKeyButton.TabIndex = 0;
            this.authKeyButton.Text = "인증키입력";
            this.authKeyButton.UseVisualStyleBackColor = true;
            this.authKeyButton.Click += new System.EventHandler(this.authKeyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "인증키입력: ";
            // 
            // authKeyLabel
            // 
            this.authKeyLabel.AutoSize = true;
            this.authKeyLabel.ForeColor = System.Drawing.Color.Red;
            this.authKeyLabel.Location = new System.Drawing.Point(328, 325);
            this.authKeyLabel.Name = "authKeyLabel";
            this.authKeyLabel.Size = new System.Drawing.Size(43, 12);
            this.authKeyLabel.TabIndex = 3;
            this.authKeyLabel.Text = "FALSE";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timeLabel1
            // 
            this.timeLabel1.AutoSize = true;
            this.timeLabel1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel1.Location = new System.Drawing.Point(90, 30);
            this.timeLabel1.Name = "timeLabel1";
            this.timeLabel1.Size = new System.Drawing.Size(31, 14);
            this.timeLabel1.TabIndex = 1;
            this.timeLabel1.Text = "시간";
            this.timeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel2
            // 
            this.timeLabel2.AutoSize = true;
            this.timeLabel2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel2.Location = new System.Drawing.Point(211, 30);
            this.timeLabel2.Name = "timeLabel2";
            this.timeLabel2.Size = new System.Drawing.Size(31, 14);
            this.timeLabel2.TabIndex = 1;
            this.timeLabel2.Text = "시간";
            this.timeLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(182, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // timeLabel3
            // 
            this.timeLabel3.AutoSize = true;
            this.timeLabel3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel3.Location = new System.Drawing.Point(331, 30);
            this.timeLabel3.Name = "timeLabel3";
            this.timeLabel3.Size = new System.Drawing.Size(31, 14);
            this.timeLabel3.TabIndex = 1;
            this.timeLabel3.Text = "시간";
            this.timeLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(302, 55);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // timeLabel4
            // 
            this.timeLabel4.AutoSize = true;
            this.timeLabel4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel4.Location = new System.Drawing.Point(447, 30);
            this.timeLabel4.Name = "timeLabel4";
            this.timeLabel4.Size = new System.Drawing.Size(31, 14);
            this.timeLabel4.TabIndex = 1;
            this.timeLabel4.Text = "시간";
            this.timeLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(418, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // timeLabel5
            // 
            this.timeLabel5.AutoSize = true;
            this.timeLabel5.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel5.Location = new System.Drawing.Point(565, 30);
            this.timeLabel5.Name = "timeLabel5";
            this.timeLabel5.Size = new System.Drawing.Size(31, 14);
            this.timeLabel5.TabIndex = 1;
            this.timeLabel5.Text = "시간";
            this.timeLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(536, 55);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // timeLabel6
            // 
            this.timeLabel6.AutoSize = true;
            this.timeLabel6.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.timeLabel6.Location = new System.Drawing.Point(685, 30);
            this.timeLabel6.Name = "timeLabel6";
            this.timeLabel6.Size = new System.Drawing.Size(31, 14);
            this.timeLabel6.TabIndex = 1;
            this.timeLabel6.Text = "시간";
            this.timeLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(656, 55);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 100);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // tempLabel1
            // 
            this.tempLabel1.AutoSize = true;
            this.tempLabel1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tempLabel1.Location = new System.Drawing.Point(90, 167);
            this.tempLabel1.Name = "tempLabel1";
            this.tempLabel1.Size = new System.Drawing.Size(31, 14);
            this.tempLabel1.TabIndex = 1;
            this.tempLabel1.Text = "기온";
            this.tempLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempLabel2
            // 
            this.tempLabel2.AutoSize = true;
            this.tempLabel2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tempLabel2.Location = new System.Drawing.Point(211, 167);
            this.tempLabel2.Name = "tempLabel2";
            this.tempLabel2.Size = new System.Drawing.Size(31, 14);
            this.tempLabel2.TabIndex = 1;
            this.tempLabel2.Text = "기온";
            this.tempLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempLabel3
            // 
            this.tempLabel3.AutoSize = true;
            this.tempLabel3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tempLabel3.Location = new System.Drawing.Point(331, 167);
            this.tempLabel3.Name = "tempLabel3";
            this.tempLabel3.Size = new System.Drawing.Size(31, 14);
            this.tempLabel3.TabIndex = 1;
            this.tempLabel3.Text = "기온";
            this.tempLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempLabel4
            // 
            this.tempLabel4.AutoSize = true;
            this.tempLabel4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tempLabel4.Location = new System.Drawing.Point(447, 167);
            this.tempLabel4.Name = "tempLabel4";
            this.tempLabel4.Size = new System.Drawing.Size(31, 14);
            this.tempLabel4.TabIndex = 1;
            this.tempLabel4.Text = "기온";
            this.tempLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempLabel5
            // 
            this.tempLabel5.AutoSize = true;
            this.tempLabel5.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tempLabel5.Location = new System.Drawing.Point(565, 167);
            this.tempLabel5.Name = "tempLabel5";
            this.tempLabel5.Size = new System.Drawing.Size(31, 14);
            this.tempLabel5.TabIndex = 1;
            this.tempLabel5.Text = "기온";
            this.tempLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempLabel6
            // 
            this.tempLabel6.AutoSize = true;
            this.tempLabel6.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tempLabel6.Location = new System.Drawing.Point(685, 167);
            this.tempLabel6.Name = "tempLabel6";
            this.tempLabel6.Size = new System.Drawing.Size(31, 14);
            this.tempLabel6.TabIndex = 1;
            this.tempLabel6.Text = "기온";
            this.tempLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humiLabel1
            // 
            this.humiLabel1.AutoSize = true;
            this.humiLabel1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.humiLabel1.Location = new System.Drawing.Point(90, 192);
            this.humiLabel1.Name = "humiLabel1";
            this.humiLabel1.Size = new System.Drawing.Size(31, 14);
            this.humiLabel1.TabIndex = 1;
            this.humiLabel1.Text = "습도";
            this.humiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humiLabel2
            // 
            this.humiLabel2.AutoSize = true;
            this.humiLabel2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.humiLabel2.Location = new System.Drawing.Point(211, 192);
            this.humiLabel2.Name = "humiLabel2";
            this.humiLabel2.Size = new System.Drawing.Size(31, 14);
            this.humiLabel2.TabIndex = 1;
            this.humiLabel2.Text = "습도";
            this.humiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humiLabel3
            // 
            this.humiLabel3.AutoSize = true;
            this.humiLabel3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.humiLabel3.Location = new System.Drawing.Point(331, 192);
            this.humiLabel3.Name = "humiLabel3";
            this.humiLabel3.Size = new System.Drawing.Size(31, 14);
            this.humiLabel3.TabIndex = 1;
            this.humiLabel3.Text = "습도";
            this.humiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humiLabel4
            // 
            this.humiLabel4.AutoSize = true;
            this.humiLabel4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.humiLabel4.Location = new System.Drawing.Point(447, 192);
            this.humiLabel4.Name = "humiLabel4";
            this.humiLabel4.Size = new System.Drawing.Size(31, 14);
            this.humiLabel4.TabIndex = 1;
            this.humiLabel4.Text = "습도";
            this.humiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humiLabel5
            // 
            this.humiLabel5.AutoSize = true;
            this.humiLabel5.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.humiLabel5.Location = new System.Drawing.Point(565, 192);
            this.humiLabel5.Name = "humiLabel5";
            this.humiLabel5.Size = new System.Drawing.Size(31, 14);
            this.humiLabel5.TabIndex = 1;
            this.humiLabel5.Text = "습도";
            this.humiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humiLabel6
            // 
            this.humiLabel6.AutoSize = true;
            this.humiLabel6.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.humiLabel6.Location = new System.Drawing.Point(685, 192);
            this.humiLabel6.Name = "humiLabel6";
            this.humiLabel6.Size = new System.Drawing.Size(31, 14);
            this.humiLabel6.TabIndex = 1;
            this.humiLabel6.Text = "습도";
            this.humiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precLabel1
            // 
            this.precLabel1.AutoSize = true;
            this.precLabel1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.precLabel1.Location = new System.Drawing.Point(84, 216);
            this.precLabel1.Name = "precLabel1";
            this.precLabel1.Size = new System.Drawing.Size(43, 14);
            this.precLabel1.TabIndex = 1;
            this.precLabel1.Text = "강수량";
            this.precLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precLabel2
            // 
            this.precLabel2.AutoSize = true;
            this.precLabel2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.precLabel2.Location = new System.Drawing.Point(205, 216);
            this.precLabel2.Name = "precLabel2";
            this.precLabel2.Size = new System.Drawing.Size(43, 14);
            this.precLabel2.TabIndex = 1;
            this.precLabel2.Text = "강수량";
            this.precLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precLabel3
            // 
            this.precLabel3.AutoSize = true;
            this.precLabel3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.precLabel3.Location = new System.Drawing.Point(325, 216);
            this.precLabel3.Name = "precLabel3";
            this.precLabel3.Size = new System.Drawing.Size(43, 14);
            this.precLabel3.TabIndex = 1;
            this.precLabel3.Text = "강수량";
            this.precLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precLabel4
            // 
            this.precLabel4.AutoSize = true;
            this.precLabel4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.precLabel4.Location = new System.Drawing.Point(441, 216);
            this.precLabel4.Name = "precLabel4";
            this.precLabel4.Size = new System.Drawing.Size(43, 14);
            this.precLabel4.TabIndex = 1;
            this.precLabel4.Text = "강수량";
            this.precLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precLabel5
            // 
            this.precLabel5.AutoSize = true;
            this.precLabel5.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.precLabel5.Location = new System.Drawing.Point(559, 216);
            this.precLabel5.Name = "precLabel5";
            this.precLabel5.Size = new System.Drawing.Size(43, 14);
            this.precLabel5.TabIndex = 1;
            this.precLabel5.Text = "강수량";
            this.precLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // precLabel6
            // 
            this.precLabel6.AutoSize = true;
            this.precLabel6.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.precLabel6.Location = new System.Drawing.Point(679, 216);
            this.precLabel6.Name = "precLabel6";
            this.precLabel6.Size = new System.Drawing.Size(43, 14);
            this.precLabel6.TabIndex = 1;
            this.precLabel6.Text = "강수량";
            this.precLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windDirLabel1
            // 
            this.windDirLabel1.AutoSize = true;
            this.windDirLabel1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.windDirLabel1.Location = new System.Drawing.Point(90, 245);
            this.windDirLabel1.Name = "windDirLabel1";
            this.windDirLabel1.Size = new System.Drawing.Size(31, 14);
            this.windDirLabel1.TabIndex = 1;
            this.windDirLabel1.Text = "풍향";
            this.windDirLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windDirLabel2
            // 
            this.windDirLabel2.AutoSize = true;
            this.windDirLabel2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.windDirLabel2.Location = new System.Drawing.Point(211, 245);
            this.windDirLabel2.Name = "windDirLabel2";
            this.windDirLabel2.Size = new System.Drawing.Size(31, 14);
            this.windDirLabel2.TabIndex = 1;
            this.windDirLabel2.Text = "풍향";
            this.windDirLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windDirLabel3
            // 
            this.windDirLabel3.AutoSize = true;
            this.windDirLabel3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.windDirLabel3.Location = new System.Drawing.Point(331, 245);
            this.windDirLabel3.Name = "windDirLabel3";
            this.windDirLabel3.Size = new System.Drawing.Size(31, 14);
            this.windDirLabel3.TabIndex = 1;
            this.windDirLabel3.Text = "풍향";
            this.windDirLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windDirLabel4
            // 
            this.windDirLabel4.AutoSize = true;
            this.windDirLabel4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.windDirLabel4.Location = new System.Drawing.Point(447, 245);
            this.windDirLabel4.Name = "windDirLabel4";
            this.windDirLabel4.Size = new System.Drawing.Size(31, 14);
            this.windDirLabel4.TabIndex = 1;
            this.windDirLabel4.Text = "풍향";
            this.windDirLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windDirLabel5
            // 
            this.windDirLabel5.AutoSize = true;
            this.windDirLabel5.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.windDirLabel5.Location = new System.Drawing.Point(565, 245);
            this.windDirLabel5.Name = "windDirLabel5";
            this.windDirLabel5.Size = new System.Drawing.Size(31, 14);
            this.windDirLabel5.TabIndex = 1;
            this.windDirLabel5.Text = "풍향";
            this.windDirLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windDirLabel6
            // 
            this.windDirLabel6.AutoSize = true;
            this.windDirLabel6.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.windDirLabel6.Location = new System.Drawing.Point(685, 245);
            this.windDirLabel6.Name = "windDirLabel6";
            this.windDirLabel6.Size = new System.Drawing.Size(31, 14);
            this.windDirLabel6.TabIndex = 1;
            this.windDirLabel6.Text = "풍향";
            this.windDirLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windSpdLabel1
            // 
            this.windSpdLabel1.AutoSize = true;
            this.windSpdLabel1.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.windSpdLabel1.Location = new System.Drawing.Point(90, 268);
            this.windSpdLabel1.Name = "windSpdLabel1";
            this.windSpdLabel1.Size = new System.Drawing.Size(31, 14);
            this.windSpdLabel1.TabIndex = 1;
            this.windSpdLabel1.Text = "풍속";
            this.windSpdLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windSpdLabel2
            // 
            this.windSpdLabel2.AutoSize = true;
            this.windSpdLabel2.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.windSpdLabel2.Location = new System.Drawing.Point(211, 268);
            this.windSpdLabel2.Name = "windSpdLabel2";
            this.windSpdLabel2.Size = new System.Drawing.Size(31, 14);
            this.windSpdLabel2.TabIndex = 1;
            this.windSpdLabel2.Text = "풍속";
            this.windSpdLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windSpdLabel3
            // 
            this.windSpdLabel3.AutoSize = true;
            this.windSpdLabel3.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.windSpdLabel3.Location = new System.Drawing.Point(331, 268);
            this.windSpdLabel3.Name = "windSpdLabel3";
            this.windSpdLabel3.Size = new System.Drawing.Size(31, 14);
            this.windSpdLabel3.TabIndex = 1;
            this.windSpdLabel3.Text = "풍속";
            this.windSpdLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windSpdLabel4
            // 
            this.windSpdLabel4.AutoSize = true;
            this.windSpdLabel4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.windSpdLabel4.Location = new System.Drawing.Point(447, 268);
            this.windSpdLabel4.Name = "windSpdLabel4";
            this.windSpdLabel4.Size = new System.Drawing.Size(31, 14);
            this.windSpdLabel4.TabIndex = 1;
            this.windSpdLabel4.Text = "풍속";
            this.windSpdLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windSpdLabel5
            // 
            this.windSpdLabel5.AutoSize = true;
            this.windSpdLabel5.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.windSpdLabel5.Location = new System.Drawing.Point(565, 268);
            this.windSpdLabel5.Name = "windSpdLabel5";
            this.windSpdLabel5.Size = new System.Drawing.Size(31, 14);
            this.windSpdLabel5.TabIndex = 1;
            this.windSpdLabel5.Text = "풍속";
            this.windSpdLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windSpdLabel6
            // 
            this.windSpdLabel6.AutoSize = true;
            this.windSpdLabel6.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.windSpdLabel6.Location = new System.Drawing.Point(685, 268);
            this.windSpdLabel6.Name = "windSpdLabel6";
            this.windSpdLabel6.Size = new System.Drawing.Size(31, 14);
            this.windSpdLabel6.TabIndex = 1;
            this.windSpdLabel6.Text = "풍속";
            this.windSpdLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "자동업데이트중...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(15, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "기온";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(15, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "습도";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(3, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "강수량";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(15, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 1;
            this.label7.Text = "풍향";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어 Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(15, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 14);
            this.label8.TabIndex = 1;
            this.label8.Text = "풍속";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(791, 349);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.timeLabel6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timeLabel5);
            this.Controls.Add(this.authKeyLabel);
            this.Controls.Add(this.timeLabel4);
            this.Controls.Add(this.updateTimeLabel);
            this.Controls.Add(this.timeLabel3);
            this.Controls.Add(this.timeLabel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.precLabel6);
            this.Controls.Add(this.precLabel5);
            this.Controls.Add(this.windSpdLabel6);
            this.Controls.Add(this.windSpdLabel5);
            this.Controls.Add(this.windDirLabel6);
            this.Controls.Add(this.windDirLabel5);
            this.Controls.Add(this.humiLabel6);
            this.Controls.Add(this.humiLabel5);
            this.Controls.Add(this.windSpdLabel4);
            this.Controls.Add(this.precLabel4);
            this.Controls.Add(this.windDirLabel4);
            this.Controls.Add(this.tempLabel6);
            this.Controls.Add(this.humiLabel4);
            this.Controls.Add(this.windSpdLabel3);
            this.Controls.Add(this.precLabel3);
            this.Controls.Add(this.windDirLabel3);
            this.Controls.Add(this.tempLabel5);
            this.Controls.Add(this.humiLabel3);
            this.Controls.Add(this.windSpdLabel2);
            this.Controls.Add(this.precLabel2);
            this.Controls.Add(this.windDirLabel2);
            this.Controls.Add(this.tempLabel4);
            this.Controls.Add(this.humiLabel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.windSpdLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.precLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.windDirLabel1);
            this.Controls.Add(this.tempLabel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.humiLabel1);
            this.Controls.Add(this.tempLabel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tempLabel1);
            this.Controls.Add(this.timeLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authKeyButton);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label updateTimeLabel;
        private System.Windows.Forms.Button authKeyButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label authKeyLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label timeLabel1;
        private System.Windows.Forms.Label timeLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label timeLabel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label timeLabel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label timeLabel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label timeLabel6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label tempLabel1;
        private System.Windows.Forms.Label tempLabel2;
        private System.Windows.Forms.Label tempLabel3;
        private System.Windows.Forms.Label tempLabel4;
        private System.Windows.Forms.Label tempLabel5;
        private System.Windows.Forms.Label tempLabel6;
        private System.Windows.Forms.Label humiLabel1;
        private System.Windows.Forms.Label humiLabel2;
        private System.Windows.Forms.Label humiLabel3;
        private System.Windows.Forms.Label humiLabel4;
        private System.Windows.Forms.Label humiLabel5;
        private System.Windows.Forms.Label humiLabel6;
        private System.Windows.Forms.Label precLabel1;
        private System.Windows.Forms.Label precLabel2;
        private System.Windows.Forms.Label precLabel3;
        private System.Windows.Forms.Label precLabel4;
        private System.Windows.Forms.Label precLabel5;
        private System.Windows.Forms.Label precLabel6;
        private System.Windows.Forms.Label windDirLabel1;
        private System.Windows.Forms.Label windDirLabel2;
        private System.Windows.Forms.Label windDirLabel3;
        private System.Windows.Forms.Label windDirLabel4;
        private System.Windows.Forms.Label windDirLabel5;
        private System.Windows.Forms.Label windDirLabel6;
        private System.Windows.Forms.Label windSpdLabel1;
        private System.Windows.Forms.Label windSpdLabel2;
        private System.Windows.Forms.Label windSpdLabel3;
        private System.Windows.Forms.Label windSpdLabel4;
        private System.Windows.Forms.Label windSpdLabel5;
        private System.Windows.Forms.Label windSpdLabel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

