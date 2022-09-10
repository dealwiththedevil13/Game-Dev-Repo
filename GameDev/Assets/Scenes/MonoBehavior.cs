using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehavior : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;

   private void Awake()
   {
        awakeEvent.Invoke();
   }

    private void Start()
   {
        startEvent.Invoke();
   }

    private void OnDisable()
   {
        disableEvent.Invoke();
   }
   
 //Up and down motion. Still in the works.Get help from tutors
   public void Update()
    {
        transform.position = new Vector3(0, Mathf.Sin(Time.time), 0);
    }
   
   //Destroy pickup on contact
   public void OnTriggerEnter(Collider other)
  {
      Destroy(gameObject);
  }
  public void OnDestroy()
  {

  }
}
