using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour
{
    public Vector3 swimDestination;
    public float speed = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        FindNewDestination();
    }

    void FindNewDestination()
    {
        swimDestination = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));

    }

    // Update is called once per frame
    void Update()
    {
        //move towards destination
        this.transform.position = Vector3.MoveTowards(this.transform.position, swimDestination, speed * Time.deltaTime);
        
        //tell fish to look at destination
        this.transform.LookAt(swimDestination);
        
        //draw the debug line
        Debug.DrawLine(this.transform.position, swimDestination, Color.yellow);
        
        //when you reach the destination, find a new point
        if (Vector3.Distance(this.transform.position, swimDestination) < 2)
        {
            FindNewDestination();
        }
    }
}
