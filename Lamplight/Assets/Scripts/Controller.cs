using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pPlayer;
    // Update is called once per frame
    private float speed = 5;
    private Rigidbody rb;

    // Lamp Specific
    public GameObject mLamp;
    public List<Light> mSources = new List<Light>();

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Cursor.lockState = CursorLockMode.Locked;

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 _directionVector = new Vector3(horizontal, 0, vertical);


        // Translate
        Vector3 _movement = _directionVector * speed * Time.deltaTime;
        rb.transform.Translate(_movement, Space.World);

        // Rotate
        Quaternion _direction = Quaternion.LookRotation(_directionVector);
        transform.rotation = Quaternion.Slerp(transform.rotation, _direction, Time.deltaTime * 8);
        

        UpdateLightSources();
    }

    private void UpdateLightSources()
    {
        foreach(Light _sources in mSources)
        {
            _sources.transform.position = mLamp.transform.localPosition + this.gameObject.transform.position;
            _sources.transform.rotation = this.gameObject.transform.rotation;
        }
    }
}
