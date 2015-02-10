using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.FFMPEG;
using AForge.Imaging.Filters;
using System.Drawing.Imaging;



namespace Frames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void nC(UInt64 i);





        VideoFileSource videoFile = new VideoFileSource("");
        VideoFileReader reader = new VideoFileReader();

        UInt64 frameNum = 1;
        UInt64 currentFrameNum = 1;
        private void openVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    reader.Open(openFileDialog1.FileName);

                    videoFile.Source = openFileDialog1.FileName;
                    video.VideoSource = videoFile;
                    videoFile.FrameIntervalFromSource = true;
                    videoFile.NewFrame += videoFile_NewFrame;
                    info();

                    frameNum = 1;
                    //video.Start();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not open file. Original error: " + ex.Message);
                }
            }
        }

        void videoFile_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {


            frameTxt.Invoke(new nC((s) => frameTxt.Text = s.ToString()), frameNum);
            frameNum++;


        }



        private void startBtn_Click(object sender, EventArgs e)
        {
            video.Start();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            //video.Stop();
            video.SignalToStop();
        }

        private void nextFrame_Click(object sender, EventArgs e)
        {
            if (firstFrameNum.Value >= lastFrameNum.Value)
            {
                MessageBox.Show("Укажите правильный промежуток кадров");
                return;
            }

            while (currentFrameNum < firstFrameNum.Value)
            {
                reader.ReadVideoFrame().Dispose();
                currentFrameNum++;
            }
            if (currentFrameNum > lastFrameNum.Value - frameOffset.Value)
            {
                tm.Stop();
                return;
            }

            picture.Image = null;
            picture.Image = getBtm((int)frameOffset.Value);
            nextFrame.Enabled = true;
            currentFrame.Text = currentFrameNum.ToString();
        }

        private void intervalNum_ValueChanged(object sender, EventArgs e)
        {
            videoFile.FrameIntervalFromSource = false;
            videoFile.FrameInterval = (int)intervalNum.Value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            video.Stop();
            reader.Close();
        }

        private void info()
        {
            videoWidth.Text = reader.Width.ToString();
            videoHeight.Text = reader.Height.ToString();
            totalFrames.Text = reader.FrameCount > 0 ? reader.FrameCount.ToString() : "Unavailable";
            framesFPS.Text = reader.FrameRate.ToString();
            videoCodec.Text = reader.CodecName;
            frameOffset.Value = reader.FrameRate;
            lastFrameNum.Value = reader.FrameCount > 0 ? reader.FrameCount : 100;



        }

        private Bitmap getBtm(int offset)
        {

            nextFrame.Enabled = false;

            for (int i = 0; i < offset; i++)
            {
                reader.ReadVideoFrame().Dispose();
                currentFrameNum++;

            }
            currentFrameNum++;



            return reader.ReadVideoFrame();

        }



        Timer tm = new Timer();


        private void playImages_Click(object sender, EventArgs e)
        {
            if (playImages.Text == "Остановить")
            {
                tm.Stop();
                playImages.Text = "Слайдшоу";
            }
            else
            {
                playImages.Text = "Остановить";
                tm.Tick += tm_Tick;
                tm.Interval = 1000 / (int)frameOffset.Value;
                tm.Enabled = true;
                tm.Start();
            }
        }

        void tm_Tick(object sender, EventArgs e)
        {
            nextFrame_Click(null, null);
        }

        private void fromTheBeginning_Click(object sender, EventArgs e)
        {
            tm.Stop();
            playImages.Text = "Слайдшоу";
            picture.Image = null;
            reader.Close();
            reader.Open(videoFile.Source);
            currentFrameNum = 0;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void process_Click(object sender, EventArgs e)
        {
            #region preload
            processLabel.Text = "Обработка";
            progress.Value = 0;
            progress.Maximum = (int)lastFrameNum.Value - (int)firstFrameNum.Value;

            List<Bitmap> images = new List<Bitmap>();
            VideoFileReader read2 = new VideoFileReader();
            BrightnessCorrection bc = new BrightnessCorrection((int)brightnessValue.Value);
            ulong frameForfilter = 0;
            read2.Open(videoFile.Source);


            if (firstFrameNum.Value >= lastFrameNum.Value)
            {
                MessageBox.Show("Укажите правильный промежуток кадров");
                return;
            }

            while (frameForfilter < firstFrameNum.Value)
            {
                read2.ReadVideoFrame().Dispose();
                frameForfilter++;
                progress.Value++;
            }
            int index = 0;

            while (frameForfilter <= (lastFrameNum.Value - frameOffset.Value)-1)
            {

                Bitmap b;

                nextFrame.Enabled = false;

                for (int i = 0; i < frameOffset.Value; i++)
                {
                    read2.ReadVideoFrame().Dispose();
                    frameForfilter++;

                }
                frameForfilter++;
                b = read2.ReadVideoFrame();
                
                images.Add(bc.Apply(b));


                progress.Value = ((int)frameOffset.Value + progress.Value) > progress.Maximum ? progress.Maximum : (int)frameOffset.Value + progress.Value;
            }
            nextFrame.Enabled = true;
            progress.Value = 0;
            processLabel.Text = "";
            #endregion

            #region processeing
            processLabel.Text = "Совмещение фотографий";
            progress.Maximum = images.Count;
            Bitmap resultImage = images[0];

            List<Add> filters = new List<Add>();
            foreach (Bitmap b in images)
            {
                filters.Add(new Add(b));
            }

            for (int i = 1; i < filters.Count; i++)
            {
                resultImage = filters[i].Apply(resultImage);
                progress.Value++;
            }







            // apply the filter



            #endregion

            #region finalizing
            picture.Image = resultImage;
            read2.Close();
            progress.Value = 0;
            processLabel.Text = "";
            #endregion




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (picture.Image == null) return;

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Png Image|*.gif";
            saveFile.Title = "Save an Image File";
            saveFile.ShowDialog();

            if (saveFile.FileName != "")
            {

                System.IO.FileStream fs = (System.IO.FileStream)saveFile.OpenFile();

                switch (saveFile.FilterIndex)
                {
                    case 1:
                        picture.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        picture.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        picture.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }

                fs.Close();
            }
        }
    }
}
