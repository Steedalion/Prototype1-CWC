using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	float turnSpeed = 60;
	float speed = 10f;
	float horizontalInput;
	float forwardInput;
	// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		forwardInput = Input.GetAxis("Vertical");
		Debug.Log(horizontalInput);
		transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
		transform.Rotate(Vector3.up*Time.deltaTime*turnSpeed*horizontalInput);
    }
}
