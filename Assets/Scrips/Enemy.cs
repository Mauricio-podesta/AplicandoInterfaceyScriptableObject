using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPresnetación
{
   void Accion();
}
public interface ITakeDamage
{
    void Recibirdaño();
}
public class Enemy : MonoBehaviour, IPresnetación, ITakeDamage
{
    [SerializeField] private ScripEnemy EnemyData;
    public string Nombre;
    public float Vida;
    public string Saludo;
    void Start()
    {
        Nombre = EnemyData.Nombre;
        Vida = EnemyData.Vida;
        Saludo = EnemyData.Saludo;
    }
public void Accion()
    {
        Debug.Log(Nombre +"Su vida es: " + Vida + " :" + Saludo);
    }
    public void Recibirdaño()
    {
        Vida -= 1;
        Debug.Log("Me atacaste aaaa" + "  vida restante:" + Vida);
        if (Vida == 0)
            Destroy(gameObject);
    }
    void Update()
    {
        
    }
}
