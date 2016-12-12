using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speedX = 10f, speedY = 10f;
    
	// Update is called once per frame
	void Update ()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * speedX , 0, 0));
        transform.Translate(new Vector3(0,Input.GetAxis("Vertical") * Time.deltaTime * speedX , 0));


    }
}
