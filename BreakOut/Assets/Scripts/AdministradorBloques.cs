using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorBloques : MonoBehaviour
{
	public GameObject MenuFinNivel;
	public GameObject[] bloques;
	
	void Start()
	{
		CambiarResistencias();
	}
    // Update is called once per frame
    void Update()
    {
	    if(transform.childCount == 0)
	    {
	    	MenuFinNivel.SetActive(true);
	    }
    }
    
	public void CambiarResistencias()
	{
		bloques = GameObject.FindGameObjectsWithTag("Bloque");
		for (int i = 0; i < bloques.Length; i++) 
		{
			bloques[i].GetComponent<Bloque>().CambiarResistencia();
		}
		
	}
}
