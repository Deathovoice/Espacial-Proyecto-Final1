using System.Xml;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ai_Enemigo : MonoBehaviour
{
    public Transform Objetivo;
    public float Velocidad;
    public NavMeshAgent IA;

    public Animation Anim;
    public string NombreAnimacionCaminar;
    public string NombreAnimacionAtacar;
    void Start()
    {
        
    }

    
    void Update()
    {
        IA.speed = Velocidad;
        IA.SetDestination(Objetivo.position);


        if(IA.velocity == Vector3.zero)
        {
            Anim.CrossFade(NombreAnimacionAtacar);
        }
        else
        {
            Anim.CrossFade(NombreAnimacionCaminar);
        }
    }
}
