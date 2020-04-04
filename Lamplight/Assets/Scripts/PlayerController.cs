using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 7.0f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10.0f;
        }
        else
        {
            speed = 7.0f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        rb.transform.Translate(horizontal * speed * Time.deltaTime, 0f, vertical * speed * Time.deltaTime);
    }


}
