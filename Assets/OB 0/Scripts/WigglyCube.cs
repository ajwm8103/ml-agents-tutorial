using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WigglyCube : MonoBehaviour
{
    // Defining a field for the object's Transform
    private Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        // Access the transform component and store it in a field
        // We do this because GetComponent<> is slow, so accessing it only once is good
        myTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // Store myTransform.position, as the x-coordinate is not directly editable
        Vector3 pos = myTransform.position;
        // Edit the x-coordinate to match the sine of the current time
        pos.x = Mathf.Sin(Time.time);
        // Set the new myTransform.position value to pos
        myTransform.position = pos;
    }
}
