using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCenterOfMass : MonoBehaviour
{
	Rigidbody rb;
	public GameObject centerOfMass;
    // Start is called before the first frame update
    void Start()
    {
	    rb = GetComponent<Rigidbody>();
	    rb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
