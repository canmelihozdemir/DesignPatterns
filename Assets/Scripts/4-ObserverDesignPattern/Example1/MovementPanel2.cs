using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class MovementPanel2 : MonoBehaviour//Subject
    {
        public static event Action OnForwardButtonClicked;
        public static event Action OnBackButtonClicked;
        public static event Action OnRightButtonClicked;
        public static event Action OnLeftButtonClicked;

        public static event Action<Vector3> OnDirectionButtonClicked;
        public void ForwardOnClick()
        {
            //OnForwardButtonClicked?.Invoke();
            OnDirectionButtonClicked?.Invoke(Vector3.forward*10);
        }
        public void BackOnClick()
        {
            //OnBackButtonClicked?.Invoke();
            OnDirectionButtonClicked?.Invoke(Vector3.back);
        }
        public void RightOnClick()
        {
            //OnRightButtonClicked?.Invoke();
            OnDirectionButtonClicked?.Invoke(Vector3.right);
        }
        public void LeftOnClick()
        {
            //OnLeftButtonClicked?.Invoke();
            OnDirectionButtonClicked?.Invoke(Vector3.left);
        }
    }
}

