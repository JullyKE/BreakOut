using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
	public int limiteX = 23;
	public int velocidadPaddle = 5;
	Vector3 mousePos2D;
	Vector3 mousePos3D;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
	{
		//Mouse Es el que gusta mas
	    /*mousePos2D = Input.mousePosition;
	    mousePos2D.z = -Camera.main.transform.position.z;
	    mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
	    */
	    
		//GetKey
	    /*if (Input.GetKey(KeyCode.RightArrow))
	    {
	    	transform.Translate(Vector3.down * velocidadPaddle * Time.deltaTime);
	    }
	    if (Input.GetKey(KeyCode.LeftArrow))
	    {
	    	transform.Translate(Vector3.up * velocidadPaddle * Time.deltaTime);
	    }*/
	    
		//GetAxis
		/*float inputVertical = Input.GetAxis("Horizontal");
		if (inputVertical > 0)
		{
			transform.Translate(Vector3.down * velocidadPaddle * Time.deltaTime);
		}
		if (inputVertical < 0)
		{
			transform.Translate(Vector3.up * velocidadPaddle * Time.deltaTime);
		}*/
		
		//Control
		transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * velocidadPaddle * Time.deltaTime);
		
		
	    
	    Vector3 pos = transform.position;
	    //pos.x = mousePos3D.x;
	    if (pos.x < -limiteX)
	    {
	    	pos.x = -limiteX;
	    }
	    else if (pos.x > limiteX)
	    {
	    	pos.x = limiteX;
	    }

	    transform.position = pos;
    }
}
