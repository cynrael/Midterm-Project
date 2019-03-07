using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    
    public float rayDistance = 5;
    public Camera camera;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = new Ray(camera.transform.position, Vector3.forward);

        Debug.DrawRay(myRay.origin, new Vector3(rayDistance, 0, 0), Color.blue);
    }
}
