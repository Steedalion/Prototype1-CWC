using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateSpeedometer : MonoBehaviour
{
	public TextMeshProUGUI speedometer;
	Rigidbody rb;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
    // Update is called once per frame
	void LateUpdate()
    {
	    UpdateText();
    }
    
	void UpdateText()
	{
		int speed = Mathf.RoundToInt(rb.velocity.magnitude*3.6f);
		speedometer.text = "Speed: "+speed;
	}
}
