using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
	public int resistencia = 2;
	public int res = 2;
	public UnityEvent AumentarPuntaje;
	public Opciones opciones;
	

	public void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag("Bola"))
		{
			RebotarBola(col);
		}
	}
	
	public virtual void RebotarBola(Collision col)
	{
		Vector3 direccion = col.contacts[0].point - transform.position;
		direccion = direccion.normalized;
		col.rigidbody.velocity = col.gameObject.GetComponent<Bola>().ballSpeed * direccion;
		res--;
	}
	
    // Update is called once per frame
    void Update()
	{
		if (res <= 0)
	    {
	    	AumentarPuntaje.Invoke();
	    	Destroy(gameObject);
	    }
    }
	
	public void CambiarResistencia()
	{
		if (opciones.NivelDificultad.ToString() == "facil")
		{
			res = resistencia - 1;
		}
		else if (opciones.NivelDificultad.ToString() == "normal")
		{
			res = resistencia;
		}
		else if (opciones.NivelDificultad.ToString() == "dificil")
		{
			res = resistencia +1;
		}
	}
}
