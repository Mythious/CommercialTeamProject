using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunter_Script : MonoBehaviour
{
    Basic_Movement movement;

    private float HunterSpeedDefault = 5;
    private bool slowdownStatus = false;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Basic_Movement>();
        movement.PlayerMovementSpeed = HunterSpeedDefault;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SlowdownStatusEffect()
    {
        if (slowdownStatus == false)
        {
            slowdownStatus = true;
            movement.PlayerMovementSpeed *= 0.65f;
            Invoke("ReturnToNormalSpeed", 4);
        }
    }

    void ReturnToNormalSpeed()
    {
        slowdownStatus = false;
        movement.PlayerMovementSpeed = HunterSpeedDefault;
    }
}
