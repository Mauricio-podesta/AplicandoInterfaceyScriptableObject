using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( fileName = "EnemySaludo", menuName = "enemy")]


public class ScripEnemy : ScriptableObject

{
    [SerializeField] private string nombre;
    [SerializeField] private float vida;
    [SerializeField] private string saludo;
    
    public string Nombre { get { return nombre; } }
    public float Vida { get { return vida; } }
    public string Saludo { get { return saludo; } }

    void Start()
    {        
    }
    void Update()
    {
        
    }
}
