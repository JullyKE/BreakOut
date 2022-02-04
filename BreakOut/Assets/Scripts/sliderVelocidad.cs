using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderVelocidad : MonoBehaviour
{
	public Opciones opciones;
	Slider slider;
	
    // Start is called before the first frame update
    void Start()
	{
		opciones.Cargar();
		slider = GetComponent<Slider>();
		slider.value = opciones.velocidadBola;
	    slider.onValueChanged.AddListener(delegate{ControlCambio();});
    }

	void ControlCambio()
	{
		opciones.CambiarVelocidad(slider.value);
	}
}
