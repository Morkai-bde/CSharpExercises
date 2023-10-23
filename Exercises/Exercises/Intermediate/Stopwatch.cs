using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;

namespace Exercises.Exercises.Intermediate
{
    internal class Stopwatch
    {
        public string Name { get; private set; }
        private DateTime StartTime { get; set; }
        private DateTime StopTime { get; set; }
        private DateTime LapStart { get; set; }
        private DateTime LapStop { get; set; }
        public TimeSpan TotalTime { get; set; }
        private bool IsRunning { get; set; }
        private bool IsLap { get; set; }
        //public List<Lap> Laps { get; private set; }
        public List<TimeSpan> Laps { get; set; }

        public Stopwatch(string name)
        {
            Name = name;
            IsRunning = false;
            IsLap = false;
            Laps = new List<TimeSpan>();
        }

        internal void Start()
        {
            if (IsRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running");
            }
                StartTime = DateTime.Now;
                IsRunning = true;
        }

        internal void Stop()
        {
            if (!IsRunning)
            {
                throw new InvalidOperationException("Stopwatch is not running");
            }

            StopTime = DateTime.Now;
            IsRunning = false;
            //updateTotalTime();
            TotalTime = TotalTime + (DateTime.Now - StartTime);
        }

        private TimeSpan Sum()
        {
            var timeSpanSum = TimeSpan.Zero;
            foreach (var item in Laps)
            {
                timeSpanSum += item;
            }
            return timeSpanSum;
        }
        private void updateTotalTime()
        {
            TotalTime = TotalTime + (DateTime.Now - StartTime);
        }


        internal void Lap()
        {
            var totalTime = DateTime.Now - StartTime;
            //updateTotalTime();
            var lap = totalTime - Sum();
            Console.WriteLine("{0} : {1} : {2}",lap, TotalTime, Sum());
            Laps.Add(lap);

            //var lap = new Lap(TotalTime);
            //var allLapTime = Laps.

            //if(!IsLap)
            //{
            //    LapStart = DateTime.Now;
            //    Console.WriteLine(LapStart);
            //    IsLap = true;
            //}
            //if(IsLap)
            //{
            //    LapStop = DateTime.Now;
            //    IsLap = false;
            //    var lapTime = LapStop - LapStart;
            //    var lap = new Lap(lapTime);
            //    Console.WriteLine(LapStop);
            //    Console.WriteLine(lapTime.Seconds);
            //    Laps.Add(lap);

            //}
        }

        internal void PrintTime()
        {
            //var totalTime = StopTime - StartTime;
            //var totalTime = Laps[Laps.Count - 1].lapTime - Laps[0].lapTime;
            Console.WriteLine("{0} Total Time is: {1}s", this.Name, TotalTime.Seconds) ;
        }

        internal void Reset()
        {
            if (IsRunning)
            {
                StartTime = DateTime.Now;
            }
                TotalTime = TimeSpan.Zero;
        }
        internal void PrintLaps()
        {
            for (int i = 1; i <= Laps.Count; i++)
            {
                Console.WriteLine("Lap {0}: {1}", i, Laps[i-1].Seconds);
                //Console.WriteLine("Lap {0}: {1}", i, Laps[i].lapTime.Second - Laps[i-1].lapTime.Second);
            }
        }

    }

    internal class Lap
    {
        public TimeSpan lapTime { get; set; }

        public TimeSpan TotalTime { get; set; }
        
        //public Lap(TimeSpan totalTime)
        //{
        //    TotalTime = totalTime;
        //}

        public Lap(TimeSpan lapTime)
        {
            this.lapTime = lapTime;
        }

    }

}
