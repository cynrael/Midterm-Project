using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bugs : MonoBehaviour
{

    public GameObject goal;
    public GameObject bee;
    public GameObject maroonIcon;
    public GameObject woolybear;
    public GameObject redIcon;
    public GameObject ladybug;
    public GameObject orangeIcon;
    public GameObject cranefly;
    public GameObject yellowIcon;
    public GameObject mantis;
    public GameObject greenIcon;
    public GameObject boxbeetle;
    public GameObject blueIcon;
    
    
    
/*    public bool maroonIconActive;
    public bool redIconActive;
    public bool orangeIconActive;
    public bool yellowIconActive;
    public bool greenIconActive;
    public bool blueIconActive;*/


    void Start()
    {
        /*maroonIcon.gameObject.SetActive(false);
        redIcon.gameObject.SetActive(false);
        orangeIcon.gameObject.SetActive(false);
        yellowIcon.gameObject.SetActive(false);
        greenIcon.gameObject.SetActive(false);
        blueIcon.gameObject.SetActive(false);  */ 
    }

    void Update()
    {
        if (Vector3.Distance(bee.transform.position, goal.transform.position) < 3f && 
            Vector3.Distance(woolybear.transform.position, goal.transform.position) < 3f &&
            Vector3.Distance(ladybug.transform.position, goal.transform.position) < 3f && 
            Vector3.Distance(cranefly.transform.position, goal.transform.position) < 3f &&
            Vector3.Distance(mantis.transform.position, goal.transform.position) < 3f &&
            Vector3.Distance(boxbeetle.transform.position, goal.transform.position) < 3f)
        {
/*            maroonIconActive = !maroonIconActive;
            maroonIcon.gameObject.SetActive(maroonIconActive);*/
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }

        /*if (Vector3.Distance(woolybear.transform.position, goal.transform.position) < 3f)
        {
            /*redIconActive = !redIconActive;
            redIcon.gameObject.SetActive(redIconActive);#1#
        }

        if (Vector3.Distance(ladybug.transform.position, goal.transform.position) < 3f)
        {
            /*orangeIconActive = !orangeIconActive;
            orangeIcon.gameObject.SetActive(orangeIconActive);#1#
        }
        if (Vector3.Distance(cranefly.transform.position, goal.transform.position) < 3f)
        {
            /*yellowIconActive = !yellowIconActive;
            yellowIcon.gameObject.SetActive(yellowIconActive);#1#
        }
        if (Vector3.Distance(mantis.transform.position, goal.transform.position) < 3f)
        {
            /*greenIconActive = !greenIconActive;
            greenIcon.gameObject.SetActive(greenIconActive);#1#
        }
        if (Vector3.Distance(boxbeetle.transform.position, goal.transform.position) < 3f)
        {
            /*blueIconActive = !blueIconActive;
            blueIcon.gameObject.SetActive(blueIconActive);#1#
        }*/
    }
}
