using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer
{
    public abstract class Observer : MonoBehaviour
    {
        public abstract void OnNotify(NotificationType notificationType);
      

    }

    

}

