using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour 
{
    public float distance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") ==true) //if we press the designated button the code in the peramiter below will be executed on that frame
        {
            RaycastHit hit; // only exists within this statement
            if(Physics.Raycast(transform.position, transform.forward, out hit, distance) == true)
            {
                Debug.DrawRay(transform.position, transform.forward * distance, Color.red, 0.2f);
                if(hit.collider.TryGetComponent(out Interactable interaction) == true)
                {
                    interaction.Activate();
                }
            }
        }
    }
}

public abstract class Interactable : MonoBehaviour
{
    public abstract void Activate(); 
}
