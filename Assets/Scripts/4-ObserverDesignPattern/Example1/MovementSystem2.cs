using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public class MovementSystem2 : MonoBehaviour//Observer
    {
        private void Start()
        {
            //MovementPanel2.OnForwardButtonClicked += MoveForward;
            //MovementPanel2.OnBackButtonClicked += MoveBack;
            //MovementPanel2.OnRightButtonClicked += MoveRight;
            //MovementPanel2.OnLeftButtonClicked += MoveLeft;
            MovementPanel2.OnDirectionButtonClicked += Move;
            MovementPanel2.OnDirectionButtonClicked += Rotate;
        }

        private void OnDestroy()
        {
            //MovementPanel2.OnForwardButtonClicked -= MoveForward;
            //MovementPanel2.OnBackButtonClicked -= MoveBack;
            //MovementPanel2.OnRightButtonClicked -= MoveRight;
            //MovementPanel2.OnLeftButtonClicked -= MoveLeft;
            MovementPanel2.OnDirectionButtonClicked -= Move;
            MovementPanel2.OnDirectionButtonClicked -= Rotate;
        }
        public void MoveForward() => transform.Translate(Vector3.forward);
        public void MoveBack() => transform.Translate(Vector3.back);
        public void MoveRight() => transform.Translate(Vector3.right);
        public void MoveLeft() => transform.Translate(Vector3.left);
        public void Move(Vector3 value) => transform.Translate(value);
        public void Rotate(Vector3 value) => transform.Rotate(value);

    }
}

