using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{

    public float rayDistance = 1f;
    public bool isHolding;
    public Camera player;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    
    // Update is called once per frame
    void Update()
    {
     // cast the ray to determine where you're looking for bugs
     //if you find a bug with your ray you hit it with the ray 
     //when you've hit the bug use the pick up script
       Ray myRay = new Ray(transform.position, transform.forward);

       Debug.DrawRay(myRay.origin, myRay.direction * rayDistance, Color.blue);
        
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance))
        {
            if (hit.collider.CompareTag("bug") && Input.GetKeyDown(KeyCode.E))
            {
                isHolding = !isHolding;
                print("hit");

                if (isHolding)
                {
                    hit.collider.gameObject.transform.parent = player.transform;
                    Debug.Log("im holding something");
                }
                else
                {
                    hit.collider.gameObject.transform.parent = null;
                    Debug.Log("nope");

                }
            }
        }
    }
}