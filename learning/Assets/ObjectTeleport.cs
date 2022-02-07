using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTeleport : MonoBehaviour
{
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")

            if(other.TryGetComponent(out Rigidbody rb) == true)
            {
                rb.velocity = Vector3.zero;

            }
        other.transform.position = spawnPoint.position;
    }
}
