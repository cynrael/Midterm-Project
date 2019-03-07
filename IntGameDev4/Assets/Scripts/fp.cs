using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fp : MonoBehaviour
{
	public Rigidbody thisRigidBody; // the rigidbody we'll be moving
	public Camera thisCamera;   // the camera

	public float pitch; // the mouse movement up/down
	public float yaw;   // the mouse movement left/right

	public float fpForwardBackward; // input float from  W and S keys
	public float fpStrafe;  // input float from A D keys

	public Vector3 inputVelocity;  // cumulative velocity to move character

	public float velocityModifier;  // velocity of controller multiplied by this number
	
	public GameObject player;
	public GameObject bug;

	public GameObject[] bugs;

	public bool isHolding;
	
	

	
	void Start()
	{
		thisRigidBody = GetComponent<Rigidbody>();
		bugs = GameObject.FindGameObjectsWithTag("bug");
	}

	void Update()
	{
		yaw = Input.GetAxis("Mouse X");
		transform.Rotate(0, yaw, 0);

		pitch = Input.GetAxis("Mouse Y");
		thisCamera.transform.Rotate(-pitch, 0, 0);

		fpForwardBackward = Input.GetAxis("Vertical");
		fpStrafe = Input.GetAxis("Horizontal");

		inputVelocity = transform.forward * fpForwardBackward;
		inputVelocity += transform.right * fpStrafe;
// cast the ray to determine where you're looking for bugs
		//if you find a bug with your ray you hit it with the ray 
		//when youve hit the bug use the next script
		
		if (Vector3.Distance(player.transform.position, bug.transform.position) < 3f)
		{
			//Debug.Log("sup");
			if (Input.GetKeyDown(KeyCode.E))
			{
				isHolding = !isHolding;

				if (isHolding)
				{
					bug.transform.parent = player.transform;
					Debug.Log("im holding something");
				}
				else
				{
						bug.transform.parent = null;
						Debug.Log("nope");
			
					}
				}
			}
	}

	void FixedUpdate()
	{
		thisRigidBody.velocity = inputVelocity * velocityModifier + (Physics.gravity * .69f);
	}	
}
