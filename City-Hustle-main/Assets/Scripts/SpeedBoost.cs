using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float speedMultiplier = 1.5f;
   private void OnTriggerEnter(Collider other)
  {
    if(other.name == "ThirdPersonController")
    {
        PlayerScript.speed *= speedMultiplier; 
        Destroy(gameObject);
    }
  }
}
