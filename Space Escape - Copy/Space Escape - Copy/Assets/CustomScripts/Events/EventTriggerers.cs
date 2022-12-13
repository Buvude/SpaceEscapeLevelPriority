using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriggerers : MonoBehaviour
{
    public EventExecuter EE;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.layer+"trigger");
        if (other.gameObject.layer == 9)
        {
            EE.DeathRespawn1();
        }
        else if (other.gameObject.layer == 10)
        {
            other.gameObject.GetComponentInParent<Animator>().SetBool("press", true);
            EE.Room1Button();
        }
        else if (other.gameObject.layer == 11)
        {
            print("Event Trigger Door Activated");
            EE.openingDoors(other);
        }
        else if (other.gameObject.layer == 12)
        {
            other.gameObject.GetComponentInParent<Animator>().SetBool("press", true);
            EE.Room2Button();
        }
    }
}
