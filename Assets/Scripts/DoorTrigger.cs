using System;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    private Animator _animator;
    public int id;
    public int levelRequirement;
    public bool requireKey;
    private void Start()
    {
        _animator = GetComponent<Animator>();
        DoorManager.OnEnterDoorTrigger += OpenDoors;
        DoorManager.OnEnterFinalDoorTrigger += OpenFinalDoor;
    }
    
    private void OnDisable()
    {
        DoorManager.OnEnterDoorTrigger -= OpenDoors;
        DoorManager.OnEnterFinalDoorTrigger -= OpenFinalDoor;

    }

    void OpenDoors(int doorId)
    { 
        if (doorId == id && ScoreManager.pickupScore >= levelRequirement && doorId != 3) 
        {
            SoundManager.instance.Play("DoorsOpen");
            _animator.SetTrigger("GateTrigger" + doorId);
        }
        
    }

    void OpenFinalDoor(int doorId, bool hasAKey)
    {
        if (hasAKey)
        {
            MasterManager.instance.exitLevel.SetActive(true);    
        }

        if (doorId == 3 && hasAKey == requireKey) 
        {
            SoundManager.instance.Play("DoorsOpen");
            _animator.SetTrigger("GateTrigger" + doorId);
        }
    }
}
