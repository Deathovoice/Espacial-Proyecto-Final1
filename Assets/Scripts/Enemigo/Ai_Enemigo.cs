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
    void Start()
    {
        
    }

    
    void Update()
    {
        IA.speed = Velocidad;
        IA.SetDestination(Objetivo.position);
    }
}
