using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBot : MonoBehaviour
{
    private int hp;
    private bool Dead => hp <= 0;

    void Start() => hp = 100;
    
    public void Damage(bool headshot)
    {
        if (Dead) return;
        else hp -= headshot ? 60 : 20;
        
        if (Dead)
        {
            FindObjectOfType<ControlGanar>().cont++;
            Destroy(gameObject);
        }
    }
}
