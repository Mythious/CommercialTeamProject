using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pPlayer;
    // Update is called once per frame
    private float speed = 5;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Cursor.lockState = CursorLockMode.Locked;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.transform.Translate(horizontal * speed * Time.deltaTime, 0f, vertical * speed * Time.deltaTime);
    }
}
