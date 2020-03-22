using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost_Script : MonoBehaviour
{
    Basic_Movement movement;

    private float GhostDefaultSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Basic_Movement>();
        movement.PlayerMovementSpeed = GhostDefaultSpeed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
