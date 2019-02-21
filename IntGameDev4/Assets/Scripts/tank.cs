using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour
{
	public Rigidbody thisRigidBody;
	public Vector2 inputAxis;
	public int forceMultiplyer;
	public float tankVelocity;
	public float inputToTorque;
	public float torqueMultiplyer;
	

	// Use this for initialization
	void Start ()
	{
		thisRigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		inputAxis.y = Input.GetAxis("Vertical");
		inputAxis.x = Input.GetAxis("Horizontal");

		inputToTorque = inputAxis.x;

	}

	void FixedUpdate()
	{
		tankVelocity = thisRigidBody.velocity.magnitude;
		if (thisRigidBody.velocity.magnitude < 8f)
		{
			thisRigidBody.AddForce(transform.forward * inputAxis.y * forceMultiplyer, ForceMode.Impulse);
		}
		thisRigidBody.AddTorque(0, inputToTorque * torqueMultiplyer, 0, ForceMode.VelocityChange);
	}
}
