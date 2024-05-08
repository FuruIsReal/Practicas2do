using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class aim : MonoBehaviour
{
    // Speed of rotation
    public float rotationSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Get the position of the mouse cursor in the world space
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f; // Ensure the mouse position is at the same z-level as the object

        // Calculate the direction from the object to the mouse position
        Vector3 direction = mousePos - transform.position;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotate the object towards the mouse position
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }
}


