using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour
{
    public float kickDist;
    public float kickForce;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") == true)
        {
            //Draw interaction ray from camera
            Debug.DrawRay(transform.position, transform.forward * kickDist, Color.green, 1.5f);
            //raycast in forward direction from camera position
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, kickDist) == true)
            {
                // get direction player is facing
                Vector3 dir = new Vector3(transform.forward.x, 0, transform.forward.z);
                // draw kick directory
                Debug.DrawRay(transform.position, dir * 3, Color.green, 1.5f);

                if (hit.collider.tag == "Ball")
                {
                    if (hit.collider.TryGetComponent(out Rigidbody rb) == true)
                    {
                        rb.AddForce(dir * kickForce, ForceMode.Impulse);
                    }
                }
            }
        }
    }
}