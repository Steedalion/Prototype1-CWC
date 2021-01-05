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
	// Start is called before the first frame update
    void Start()
    {
	    rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		forwardInput = Input.GetAxis("Vertical");
		rb.AddRelativeForce(Vector3.forward * forwardInput * horsePower);
		
		transform.Rotate(Vector3.up*Time.deltaTime*turnSpeed*horizontalInput);
    }
}
