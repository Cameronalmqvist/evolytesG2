using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSound : MonoBehaviour
{

    private AudioSource audioSource;
    private float lastRotationY;
    private float clickThreshold = 15f; // Play a click sound every 15 degrees of rotation

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        lastRotationY = transform.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        float currentRotationY = transform.eulerAngles.y;
        if (Mathf.Abs(currentRotationY - lastRotationY) >= clickThreshold)
        {
            audioSource.Play();
            lastRotationY = currentRotationY;
        }
    }
}
