using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float velocidadX = 0.0f;
    void Start()
    {
        
    }
    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(inputHorizontal * velocidadX * Time.deltaTime, 0.0f);
        if(Input.GetKeyDown(KeyCode.R))
        {
            Interactuar();
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            atacar();
        }
    }
    private void atacar()
    {
        float distanciaRaycast = 20;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, distanciaRaycast);
        Debug.DrawRay(transform.position, Vector2.up * distanciaRaycast, Color.red);
        if (hit.collider.GetComponent<ITakeDamage>() != null)
        {
            hit.collider.GetComponent<ITakeDamage>().Recibirda�o();
        }
        else
            Debug.Log("No Estoy atacando");
    }
    private void Interactuar()
    {
        float distanciaRaycast = 20;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, distanciaRaycast);
        Debug.DrawRay(transform.position, Vector2.up * distanciaRaycast, Color.red);
        if (hit.collider.GetComponent<IPresnetaci�n>() != null)
        {
            Debug.Log("Interacci�n" + hit.collider.name);
            hit.collider.GetComponent<IPresnetaci�n>().Accion();

        }
   
        else
            Debug.Log("No Estoy Interactuando");
    }
 
}
