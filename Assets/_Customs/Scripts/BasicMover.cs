using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;

    public bool doSpin = true;
    public bool doMotion = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doSpin)
        {
            // Rotates Around the up axis of the gameObject
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }

        if (doMotion)
        {
            // Moves up and down the gameObject
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        }
        
        
    }
}
