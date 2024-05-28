using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPresnetaci�n
{
   void Accion();
}
public interface ITakeDamage
{
    void Recibirda�o();
}
public class Enemy : MonoBehaviour, IPresnetaci�n, ITakeDamage
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
    public void Recibirda�o()
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
