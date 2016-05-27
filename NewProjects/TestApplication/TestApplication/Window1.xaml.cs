using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using System;
using System.IO;
using System.IO.IsolatedStorage;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace TestApplication
{
    
    public partial class Window1 : Window
    {
        
            
        Microphone microphone = Microphone.Default;             
        byte[] buffer;                                             //MY_VOICE buffer array to stoere the 
        byte[] tempBuffer;
        private MemoryStream memStream = new MemoryStream();       // MY_VOICE memoryStream to get and store temporarily the sound from the specific buffer
        private MemoryStream memStream_2 = new MemoryStream();      // IDEAL_VOICE memoryStream to get and store temporarily the sound from the specific buffer
        private SoundEffectInstance soundInstance;              
        private bool soundIsPlaying = false;                    
        
        private double pitch;                                   //storing the pitch value of IDEAL_VOICE to convey to MY_VOICE
                               
        private bool check=true;                                // to handle the first and second recording
       

        public Window1()
        {
            InitializeComponent();


           
            //backend thread timer.. works to update the dispatcher
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromMilliseconds(33);
            dt.Tick += new EventHandler(settingState);
            dt.Start();
        }

        //MY_VOICE buffer to memorystream
        void microphone_Buffer1ToStream(object sender, EventArgs e)
        {
            try
            {
                microphone.GetData(buffer);
                memStream.Write(buffer, 0, buffer.Length);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }
        //IDEAL_VOICE buffer to memorystream
        void microphone_Buffer2ToStream(object sender, EventArgs e)
        {
            try
            {
                microphone.GetData(tempBuffer);
                memStream_2.Write(tempBuffer, 0, tempBuffer.Length);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

        }
        
        

       //setting states and updating the Dispatcher while recording the sound.
        void settingState(object sender, EventArgs e)
        {
            try
            {
                try { FrameworkDispatcher.Update(); }
                catch(Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
                if (soundIsPlaying == true)
                {
                    if (soundInstance.State != SoundState.Playing)
                    {
                        soundIsPlaying = false;

                        UserHelp1.Text = "press play";
                        SetButtonStates(true, true, false, true);

                    }
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

       //MY_VOICE function to play the sound *(ALSO SETTING THE PITCH)* called later in thread for background playing
        private void playSound()
        {

            SoundEffect sound = new SoundEffect(memStream.ToArray(), microphone.SampleRate, AudioChannels.Mono);
            soundInstance = sound.CreateInstance();
            soundIsPlaying = true;
            soundInstance.Pitch = (float)pitch;
            soundInstance.Play();
        }

        //IDEAL_VOICE function to get THE PITCH ideal voice before my voice is played
        private void playSound_tempVoice()
        {

            SoundEffect IDEALsound = new SoundEffect(memStream_2.ToArray(), microphone.SampleRate, AudioChannels.Mono);
            soundInstance = IDEALsound.CreateInstance();
            soundIsPlaying = true;
            pitch = soundInstance.Pitch;
           
        }

       // setting button visibilty to increase the usability and clearity
        private void SetButtonStates(bool recordEnabled, bool playEnabled, bool stopEnabled, bool saveEnabled)
        {
            try
            {
                
                recordButton.IsEnabled = recordEnabled;
                playButton.IsEnabled = playEnabled;
                stopButton.IsEnabled = stopEnabled;         
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
           
        }
        

        private void Button_Click(object sender, RoutedEventArgs e) //Recording Button
        {
            try
            {
                //setting image
                var imageUri = new Uri( @"Assets/mic11.png",UriKind.Relative);
                DisplayImage.Source = new BitmapImage(imageUri);

                if (check==false)
                {
                        //RECORDING MY_VOICE
                        this.Grid_Loaded(null,null);
                        microphone.BufferDuration = TimeSpan.FromMilliseconds(500);
                        buffer = new byte[microphone.GetSampleSizeInBytes(microphone.BufferDuration)];

                        UserHelp1.Text = "Recording Your Voice";
                   
                }
                else
                {
                        //RECORDING IDEAL_VOICE
                        microphone.BufferDuration= TimeSpan.FromMilliseconds(500);
                        tempBuffer = new byte[microphone.GetSampleSizeInBytes(microphone.BufferDuration)];
                        
                        UserHelp1.Text = "Recording IDEAL Voice";
                    
                
                }
                //setting streams empty for the upcoming buffer
                memStream_2.SetLength(0);
                memStream.SetLength(0);
                microphone.Start();

                SetButtonStates(false, false, true, false);
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
         
        }
        
        private void playButton_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var imageUri = new Uri(@"Assets/playbutton.png", UriKind.Relative);
                DisplayImage.Source = new BitmapImage(imageUri);
            
                if (memStream.Length > 0)
                {
                    SetButtonStates(false, false, true, false);
                    UserHelp1.Text = "playing";

                    this.playSound_tempVoice();//getting pitch of IDEAL_VOICE
                    Thread soundThread = new Thread(new ThreadStart(playSound));//palying in backgreound after settign the pitch
                    
                    soundThread.Start();
                }
                else
                {
                    MessageBox.Show("Please record something before pressing play.");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
           
        }

        private void stopButton_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var imageUri = new Uri(@"Assets/gif(5).gif", UriKind.Relative);
                DisplayImage.Source = new BitmapImage(imageUri);
                if (check==false)
                {
                    if (microphone.State == MicrophoneState.Started)
                    {
                        // IF RECORDING
                        microphone.Stop();
                    }
                    else if (soundInstance.State == SoundState.Playing)
                    {
                        // IF PLAYING
                        soundInstance.Stop();
                    }
                    SetButtonStates(false, true, false, false);
                    UserHelp1.Text = "Now Press Play";
                }
                else
                {
                    check=false;
                    if (microphone.State == MicrophoneState.Started)
                    {
                        // IF RECORDING
                        microphone.Stop();
                    }
                    else if (soundInstance.State == SoundState.Playing)
                    {
                        // IF PLAYING
                        soundInstance.Stop();
                    }
                    SetButtonStates(true, false, false, false);
                    UserHelp1.Text = "Record Your Voice";

                }
               
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);

            }
           
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            if (check == true)
            {
                microphone.BufferReady += new EventHandler<EventArgs>(microphone_Buffer2ToStream);
            }
            else
            {
                microphone.BufferReady += new EventHandler<EventArgs>(microphone_Buffer1ToStream);
            }
        }

       

       
    }
}
         