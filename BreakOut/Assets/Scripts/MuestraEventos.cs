using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class MuestraEventos : MonoBehaviour
{
	public UnityEvent EventUnity;
	public event EventHandler OnSpacePressed;
	
    // Start is called before the first frame update
    void Start()
    {
	    OnSpacePressed += HeardEvent;
    }

    // Update is called once per frame
    void Update()
    {
	    if (Input.GetKeyDown(KeyCode.Space))
	    {
	    	OnSpacePressed?.Invoke(this, EventArgs.Empty);
	    	EventUnity.Invoke();
	    }
    }
    
	public void HeardEvent(object sender, EventArgs e)
	{
		Debug.Log("El evento se escucho");
	}
	
	public void UnityEventFire()
	{
		Debug.Log("El evento Unity se disparo");
	}
}
