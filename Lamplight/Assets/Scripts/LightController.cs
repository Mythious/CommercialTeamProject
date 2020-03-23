using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class LightController : MonoBehaviour
{
    public float mBaseIntensity = 0.0f;
    public float mMaxIntensity = 0.5f;
    public float mMinIntensity = 1f;
    public float mFrequency = 0.0f;
    public float mAmplitude = 0.0f;
    public Light mLightSource;

    private Color mOriginalColour;
    // Start is called before the first frame update
    void Start()
    {
        mOriginalColour = mLightSource.color;
    }

    // Update is called once per frame
    void Update()
    {
        //float _noise = Mathf.PerlinNoise(Random.Range(0.0f, 65000.0f), Time.deltaTime * Random.Range(0.01f,1f));
        mLightSource.color = mOriginalColour * FLickerAttenuation();
    }

    public float FLickerAttenuation()
    {
        float _offsetX = (Time.deltaTime * Random.Range(0.01f, 1f)) * mFrequency;
        _offsetX = _offsetX - Mathf.Floor(_offsetX);
        float _offsetY = Mathf.PerlinNoise(_offsetX, Random.value * 2);
        return (_offsetY * mAmplitude) + mBaseIntensity;
    }
}
