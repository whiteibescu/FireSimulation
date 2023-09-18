using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColliderDistance : MonoBehaviour
{
    public float maxRaycastDistance = 10f;
    private RaycastHit hit;
    public float arrowHeight = 1f;
    void Update()
    {
/*        // Cast a ray from the GameObject's position forward
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxRaycastDistance))
        {
            // Check if the ray hit a collider
            Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.green);
            Debug.Log("Distance to closest collider: " + hit.distance + " units");


            Vector3 currentPosition = this.transform.position;
            Vector3 newPosition = new Vector3(currentPosition.x, hit.distance + arrowHeight, currentPosition.z);
            this.transform.position = newPosition;
        }
        else
        {
            // If the ray didn't hit anything, draw it as a red line
            Debug.DrawRay(transform.position, transform.forward * maxRaycastDistance, Color.red);
            Debug.Log("No collider hit.");
        }*/


            // Define the ray's origin and direction based on your GameObject's transform
            Vector3 rayOrigin = transform.position;
        Vector3 rayDirection = Vector3.down;

            RaycastHit hit;

            // Cast a ray into the scene
            if (Physics.Raycast(rayOrigin, rayDirection, out hit, maxRaycastDistance, LayerMask.GetMask("Terrain")))
            {
                // Check if the ray hit the terrain collider
                Debug.DrawRay(rayOrigin, rayDirection * hit.distance, Color.green);
                Debug.Log("Distance to terrain: " + hit.distance + " units");

            Vector3 currentPosition = this.transform.position;
            float newDistance = this.transform.position.y - hit.distance;
            Vector3 newPosition = new Vector3(currentPosition.x, newDistance + arrowHeight, currentPosition.z);
            this.transform.position = newPosition;
        }
            else
            {
                // If the ray didn't hit the terrain, draw it as a red line
                Debug.DrawRay(rayOrigin, rayDirection * maxRaycastDistance, Color.red);
                Debug.Log("No terrain hit.");
            }

    }
}