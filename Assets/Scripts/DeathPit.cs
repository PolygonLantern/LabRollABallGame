using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPit : MonoBehaviour
{
    public Transform playerTransform;
    public Transform respawnPoint;
    
    private void OnTriggerEnter(Collider other)
    {
        SoundManager.instance.Play("DeathSound");
        playerTransform.transform.position = respawnPoint.position;
    }
}
