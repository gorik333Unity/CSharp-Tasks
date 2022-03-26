using System;

namespace Learning
{
    public class Stopwatch
    {
        private DateTime _start = DateTime.UnixEpoch;
        /// <summary>
        /// Starts timer
        /// </summary>
        public void StartTiming()
        {
            if (_start == DateTime.UnixEpoch)
                _start = DateTime.Now;
            else
                throw new InvalidOperationException("Cannot be started twice");
        }
        /// <summary>
        /// Stops timer, resets timer and returns elapsed time in seconds
        /// </summary>
        /// <returns>Seconds</returns>
        public int StopTiming()
        {
            var seconds = ElapsedTimeInSeconds();

            ResetTime();

            return seconds;
        }
        /// <summary>
        /// Calculates time from start to now
        /// </summary>
        /// <returns>seconds</returns>
        private int ElapsedTimeInSeconds()
        {
            var timeSpan = DateTime.Now - _start;
            var elapsedTime = timeSpan.Seconds;

            return elapsedTime;
        }
        /// <summary>
        /// Resets time
        /// </summary>
        private void ResetTime()
        {
            _start = DateTime.UnixEpoch;
        }
    }
}
