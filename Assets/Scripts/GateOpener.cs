using System;
using UnityEngine;

public class GateOpener : MonoBehaviour
{
    public int id;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {   
            
            MasterManager.instance.doorManager.EnterDoorTrigger(id);
            MasterManager.instance.doorManager.EnterFinalDoorTrigger(id, PlayerController.hasAKey);
        }
    }
    
}
