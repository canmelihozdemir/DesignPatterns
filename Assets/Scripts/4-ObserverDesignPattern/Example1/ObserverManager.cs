using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DesignPatterns.Observer
{
    public class ObserverManager : MonoBehaviour
    {
        #region Singleton
        private static ObserverManager _instance = null;
        public static ObserverManager Instance => _instance;
        #endregion  

        private List<Subject> _subjects = null;

        private void Awake()
        {
            if (_instance==null)
            {
                _instance = this;
            }
        }

        public void RegisterSubject(Subject subject)
        {
            if (_subjects==null)
            {
                _subjects = new List<Subject>();
            }
            _subjects.Add(subject);
        }

        public void RegisterObserver(Observer observer,SubjectType subjectType)
        {
            foreach (var subject in _subjects)
            {
                if (subject.SubjectType==subjectType)
                {
                    subject.RegisterObserver(observer);
                }
            }
        }

      
    }

    public enum NotificationType
    {
        ForwardButton,
        BackButton,
        LeftButton,
        RightButton,
        AchievementScore
    }

    public enum SubjectType
    {
        MovementPanel,
        Achievement
    }
}

