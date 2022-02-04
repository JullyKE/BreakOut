using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bola : MonoBehaviour
{
	public float ballSpeed = 10f;
	
	Vector3 ultimaPosicion = Vector3.zero;
	Vector3 direccion = Vector3.zero;
	Rigidbody rb;
	private ControlBordes control;
	public UnityEvent BolaDestruida;
	public Opciones opciones;
	
	bool isStart;
	
	void Awake()
	{
		control = GetComponent<ControlBordes>();
	}
	
    // Start is called before the first frame update
    void Start()
	{
		ballSpeed = opciones.velocidadBola;
	    Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
	    posicionInicial.y += 3;
	    transform.position = posicionInicial;
	    transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
	    rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
	{
		ballSpeed = opciones.velocidadBola;
		
		if (control.salioAbajo)
		{
			BolaDestruida.Invoke();
			Destroy(gameObject);
		}
		if (control.salioArriba)
		{
			direccion = transform.position - ultimaPosicion;
			direccion.y *= -1;
			direccion = direccion.normalized;
			rb.velocity = ballSpeed * direccion;
			control.salioArriba = false;
			control.enabled = false;
			Invoke("HabilitarControl", 0.5f);
		}
		if (control.salioDerecha)
		{
			direccion = transform.position - ultimaPosicion;
			direccion.x *= -1;
			direccion = direccion.normalized;
			rb.velocity = ballSpeed * direccion;
			control.salioDerecha = false;
			control.enabled = false;
			Invoke("HabilitarControl", 0.5f);
		}
		if (control.salioIzquierda)
		{
			direccion = transform.position - ultimaPosicion;
			direccion.x *= -1;
			direccion = direccion.normalized;
			rb.velocity = ballSpeed * direccion;
			control.salioIzquierda = false;
			control.enabled = false;
			Invoke("HabilitarControl", 0.5f);
		}
		
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
    
	private void HabilitarControl()
	{
		control.enabled = true;
	}
	void FixedUpdate()
	{
		ultimaPosicion = transform.position;
	}
	
	void LateUpdate()
	{
		if (direccion != Vector3.zero)
		{
			direccion = Vector3.zero;
		}
	}
}
