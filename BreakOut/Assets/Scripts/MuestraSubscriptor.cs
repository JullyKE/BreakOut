using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MuestraSubscriptor : MonoBehaviour
{
	MuestraEventos subdcriptor;
	
    // Start is called before the first frame update
    void Start()
    {
	    subdcriptor = GetComponent<MuestraEventos>();
	    subdcriptor.OnSpacePressed += MensajeSubcriptor;
    }

	public void MensajeSubcriptor(object sender, EventArgs e)
	{
		Debug.Log("El evento se escucho en el subscriptor");
		subdcriptor.OnSpacePressed -= MensajeSubcriptor;
	}
}
