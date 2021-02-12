using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
   private Rigidbody _rigidbody;
   private float _movementX;
   private float _movementY;
   public static bool hasAKey = false;
   [SerializeField] private float speed;
   
   private void Start()
   {
      _rigidbody = GetComponent<Rigidbody>();
      ScoreManager.pickupScore = 0;
   }
   

   void OnMove(InputValue movementValue)
   {
      Vector2 movement = movementValue.Get<Vector2>();

      _movementX = movement.x;
      _movementY = movement.y;
   }

   private void FixedUpdate()
   {
      Vector3 movement = new Vector3(_movementX, 0f, _movementY);
      _rigidbody.AddForce(movement * speed); 
   }

   private void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("PickUps"))
      {
         other.gameObject.SetActive(false);
         SoundManager.instance.Play("Collectable");
         ScoreManager.pickupScore++;
         MasterManager.instance.uiManager.UpdateUI();
      }

      if (other.CompareTag("GameKey"))
      {         
         hasAKey = true;
         SoundManager.instance.Play("CollectedKey");
         MasterManager.instance.uiManager.congratsText.gameObject.SetActive(hasAKey);
         other.gameObject.SetActive(false);
      }
   }

  
}
