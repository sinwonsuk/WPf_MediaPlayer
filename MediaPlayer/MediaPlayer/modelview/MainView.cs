using CommunityToolkit.Mvvm.Input;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace MediaPlayer.ModelView
{
    internal class MainView : INotifyPropertyChanged
    {

        private DispatcherTimer _timer;

        public ICommand? StartClick { get; set; }
        public ICommand? PauseClick { get; set; }
        public ICommand? StopClick { get; set; }
        public ICommand? FileOpenClick { get; set; }
        public ICommand? ScrollClick { get; set; }

        public ICommand? DragStarted { get; set; }

        public ICommand? DragCompleted { get; set; }

        public ICommand? SoundSlid { get; set; }


        private int sliderValue;
        public int SliderValue
        {
            get { return sliderValue; } 
            set
            {
                sliderValue = value;
                NotifyPropertyChanged(nameof(sliderValue));
            }
        }

        private double soundsliderValue;
        public double SoundsliderValue
        {
            get { return soundsliderValue; }
            set
            {
                soundsliderValue = value;
                NotifyPropertyChanged(nameof(soundsliderValue));
            }
        }
        private double mediaFinishTime;

        public double MediaFinishTime
        {
            get => mediaFinishTime;
            set
            {
                if (mediaFinishTime != value)
                {
                    mediaFinishTime = value;
                    NotifyPropertyChanged(nameof(MediaFinishTime));
                }

            }
        }


        public MainView()
        {
            // TaskCanMyButton을 IAsyncPredicate<object>로 전달
            StartClick = new RelayCommand<MediaElement>(StartButton);
            PauseClick = new RelayCommand<MediaElement>(PauseButton);
            FileOpenClick = new RelayCommand<MediaElement>(FileOpen);
            StopClick = new RelayCommand<MediaElement>(StopButton);
            DragStarted = new RelayCommand<MediaElement>(OnDragStarted);
            DragCompleted = new RelayCommand<MediaElement>(OnDragCompleted);
            SoundSlid = new RelayCommand<MediaElement>(SoundSlidCompleted);

            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1) // 1초마다 실행
            };

            SoundsliderValue = 50f;
            _timer.Tick += Timer_Tick;            
        }

        public void ScrollMove()
        {
            int a = 0;
            //double value = slider.Value;      
        }
        public void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // Slider의 값이 변경될 때마다 실행될 Command를 실행
            int a = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SliderValue++;
        }
      

        public void StartButton(MediaElement VideoPlayer)
        {
            VideoPlayer.Play();
            _timer.Start();
        }
        public void StopButton(MediaElement VideoPlayer)
        {
            VideoPlayer.Stop();
            _timer.Stop();
            SliderValue = 0;
        }
        public void PauseButton(MediaElement VideoPlayer)
        {
            VideoPlayer.Pause();
            _timer.Stop();
        }
        public void FileOpen(MediaElement VideoPlayer)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "All files (*.*)|*.*";

            _timer.Stop();

            if (openFileDialog.ShowDialog() == true)
            {
                string path = openFileDialog.FileName;

                VideoPlayer.Source = new Uri(path);


                VideoPlayer.MediaOpened += (sender, args) =>
                {
                    Duration duration = VideoPlayer.NaturalDuration;

                    // Duration이 Automatic이 아닌지 확인
                    if (duration.HasTimeSpan)
                    {
                        MediaFinishTime = VideoPlayer.NaturalDuration.TimeSpan.TotalSeconds;
                    }
                                  
                };
                _timer.Start();
                SliderValue = 0;
                VideoPlayer.Play();
            }

        }


        public void SoundSlidCompleted(MediaElement VideoPlayer)
        {
            VideoPlayer.Volume = (double)SoundsliderValue/100;
        }



        public void OnDragStarted(MediaElement VideoPlayer)
        {
            VideoPlayer.Pause();
            _timer.Stop();
        }
        private void OnDragCompleted(MediaElement VideoPlayer)
        {
            Console.WriteLine("Drag started");
           
            VideoPlayer.Position = TimeSpan.FromSeconds(sliderValue);
         
            VideoPlayer.Play();

            _timer.Start();


        }

       

        public event PropertyChangedEventHandler? PropertyChanged;

        // PropertyChanged 이벤트 트리거
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

   
}