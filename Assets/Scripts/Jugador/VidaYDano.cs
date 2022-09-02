using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidayDano : MonoBehaviour
{
    public int vida = 100;
    public bool invencible = false;
    public float tiempo_invencible = 1f;
    public float tiempo_frenado = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestarVida(int cantidad)
    {
        if(!invencible && vida >0)
        {
            vida -= cantidad;
            StarCoroutine(Invulnerabilidad());
            StarCoroutine(FrenarVelocidad());
        }
    }

    IEnumerator Invulnerabilidad()
    {
        invencible = true;
        yield return new WaitForSeconds(tiempo_invencible);
        invencible = false;
    }

    IEnumerator FrenarVelocidad()
    {
        var velocidadActual = GetComponent<V Third Person Controller>().Walk Speed;
        GetComponent<V Third Person Controller>().Walk Speed = 0;
        yield return new WaitForSeconds(tiempo_frenado);
        GetComponent<V Third Person Controller>().Walk Speed = Walk Speed;
    }
}
