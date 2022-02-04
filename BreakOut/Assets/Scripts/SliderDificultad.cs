using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SliderDificultad : MonoBehaviour
{
	public Opciones opciones;
	private TMP_Dropdown dificultad;
	public AdministradorBloques adminBloques;
	
    // Start is called before the first frame update
    void Start()
	{
		opciones.Cargar();
		dificultad = GetComponent<TMP_Dropdown>();
		adminBloques = GameObject.Find("AdministradorDeBloques").GetComponent<AdministradorBloques>();
		adminBloques.CambiarResistencias();
		if (opciones.NivelDificultad.ToString() == "normal")
		{
			dificultad.value = 1;
		}
		else if (opciones.NivelDificultad.ToString() == "facil")
		{
			dificultad.value = 0;
		}
		else if (opciones.NivelDificultad.ToString() == "dificil")
		{
			dificultad.value = 2;
		}
	    dificultad.onValueChanged.AddListener(delegate{opciones.CambiarDificultad(dificultad.value);});
    }
}
