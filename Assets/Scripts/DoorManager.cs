using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public static event Action<int> OnEnterDoorTrigger;
    public static event Action<int, bool> OnEnterFinalDoorTrigger;
    
    public void EnterDoorTrigger(int id)
    {
        OnEnterDoorTrigger?.Invoke(id);
    }

    public void EnterFinalDoorTrigger(int id, bool hasAKey)
    {
        OnEnterFinalDoorTrigger?.Invoke(id, hasAKey);
    }
    
}
