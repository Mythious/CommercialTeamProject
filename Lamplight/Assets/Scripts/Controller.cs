using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pPlayer;
    public Vector3 mLastLook;
    public Vector3 mCurrentLook;
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

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 _directionVector = new Vector3(horizontal, 0, vertical);


        // Translate
        Vector3 _movement = _directionVector.normalized * speed * Time.deltaTime;
        rb.transform.Translate(_movement, Space.World);

        // Rotate
        if (_movement != Vector3.zero)
        {
            mCurrentLook = _directionVector;
        }
        Quaternion _direction = Quaternion.LookRotation(mCurrentLook);
        transform.rotation = Quaternion.Slerp(transform.rotation, _direction, Time.deltaTime * 8);
        

        UpdateLightSources();
        mLastLook = mCurrentLook;
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
