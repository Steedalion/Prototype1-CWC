using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	float turnSpeed = 60;
	[SerializeField] private float horsePower;
	float horizontalInput;
	float forwardInput;
	Rigidbody rb;
	public WheelCollider[] wheels;
	[SerializeField] bool grounded => isGrounded();
	// Start is called before the first frame update
    void Start()
    {
	    rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
	{
		if(grounded)
		{
			horizontalInput = Input.GetAxis("Horizontal");
			forwardInput = Input.GetAxis("Vertical");
			rb.AddRelativeForce(Vector3.forward * forwardInput * horsePower);
			transform.Rotate(Vector3.up*Time.deltaTime*turnSpeed*horizontalInput);
		}
	}
    
	bool isGrounded()
	{
		int wheelsOnGround = 0;
		foreach (WheelCollider wheel in wheels)
		{
			if(wheel.isGrounded)
			{
				wheelsOnGround++;
			}
		}
		return wheelsOnGround == wheels.Length;
	}
}
