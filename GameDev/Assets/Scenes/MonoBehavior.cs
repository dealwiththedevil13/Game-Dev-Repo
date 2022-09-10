using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehavior : MonoBehaviour
{
   //Destroy pickup on contact
   public void OnTriggerEnter(Collider other)
  {
      Destroy(gameObject);
  }
}
