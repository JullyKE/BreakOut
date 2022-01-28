using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
	public float ballSpeed = 10f;
	bool isStart;
    // Start is called before the first frame update
    void Start()
    {
	    Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
	    posicionInicial.y += 3;
	    transform.position = posicionInicial;
	    transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
    }

    // Update is called once per frame
    void Update()
    {
	    if (Input.GetKeyDown(KeyCode.Q) ||Input.GetButtonDown("Submit"))
	    {
	    	if (!isStart)
	    	{
	    		isStart = true;
	    		transform.SetParent(null);
	    		GetComponent<Rigidbody>().velocity = ballSpeed * Vector3.up;
	    	}
	    }
    }
}
