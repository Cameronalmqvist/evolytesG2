using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    public Animator Sphere;
    
    public void AttackOne()
    {
        Sphere.SetTrigger("AttackOne");
    }

    public void AttackTwo()
    {
        Sphere.SetTrigger("AttackTwo");
    }
}
