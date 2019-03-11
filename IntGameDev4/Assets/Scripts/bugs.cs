using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bugs : MonoBehaviour
{
    public GameObject goal;
    public GameObject icon;
    public GameObject bug;
 
    public bool iconActive;

    void Start()
    {
        icon.gameObject.SetActive(false);
    }
    
    void Update()
    {
            if (Vector3.Distance(bug.transform.position, goal.transform.position) < 3f)
            {
                iconActive = !iconActive;
                icon.gameObject.SetActive(iconActive);

            }  
        }

        
    }
