using System;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
   public static SoundManager instance;
   public Sound[] sounds;

   private void Awake()
   {
      if (instance == null) instance = this;
      else Destroy(gameObject);
   
      DontDestroyOnLoad(gameObject);
      foreach (Sound sound in sounds)
      {
         sound.source = gameObject.AddComponent<AudioSource>();
         sound.source.clip = sound.clip;
         sound.source.loop = sound.loop;
         sound.source.volume = sound.volume;
         sound.source.pitch = sound.pitch;
      }
   }

   private void Start()
   {
      Play("BackgroundSound");
   }

   public void Play(string soundName)
   {
      Sound sound = Array.Find(sounds, s => s.clipName == soundName);
      sound?.source.Play();
   }
}
