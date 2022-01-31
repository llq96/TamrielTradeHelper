using System;

namespace TamrielTradeApp {
    public class Timer {
        //[Header("Settings")]
        public bool isReactivateTimer;
        public float maxTimeValue;

        public Timer(float maxTimeValue = 0, bool isReactivateTimer = true) {
            this.isReactivateTimer = isReactivateTimer;
            this.maxTimeValue = maxTimeValue;
        }

        public bool isTimerActive { get; private set; }
        public float currentTime { get; private set; }

        public event Action OnEndTime;


        #region Public Functions
        public void TimerSetActive(bool isActive, bool isReset = false) {
            isTimerActive = isActive;
            if(isReset) {
                currentTime = maxTimeValue;
            }
        }

        public string GetTimeString(ViewType viewType) {
            return viewType switch {
                ViewType.JustInt => ((int)currentTime).ToString(),
                ViewType.JustFloat => currentTime.ToString(),
                ViewType.Time => GetReadableTime((int)currentTime),
                _ => "",
            };
        }
        #endregion

        //public static string GetReadableTime(int seconds) => $"{seconds / 3600:00}:{seconds / 60 % 60:00}:{seconds % 60:00}";
        public static string GetReadableTime(int seconds) {
            if(seconds >= 3600) {
                return $"{seconds / 3600:00}:{seconds / 60 % 60:00}:{seconds % 60:00}";
            } else {
                return $"{seconds / 60 % 60:00}:{seconds % 60:00}";
            }
            
        }

        #region Update Functions

        public void UpdateFunc(float deltaTime) {
            if(!isTimerActive) {
                return;
            }

            currentTime -= deltaTime;
            currentTime = Math.Clamp(currentTime, 0f, maxTimeValue);

            if(currentTime <= 0f) {
                OnEndTime?.Invoke();
                TimerSetActive(isReactivateTimer, isReactivateTimer);
            }
        }
        #endregion

        public enum ViewType {
            JustInt, JustFloat , Time //TODO Add Type 00:00
        }
    }
}
