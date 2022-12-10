using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventExecuter : MonoBehaviour
{
    public bool Door1Unlocked = false, FinalDoorUnlocked = false;
    public GameObject Player;
    public Transform respawn1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeathRespawn1()
    {
        Debug.Log("You are dead");
        foreach (HandControllerRedo hand in HandControllerRedo.handList)
        {
            hand.grabbing = false;
        }
        Player.transform.position = respawn1.position;
    }

    public void Room1Button()
    {
        Door1Unlocked = true;
    }

    public void FinalDoorOpened()
    {
        FinalDoorUnlocked = true;
    }
}
