using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    public Animator Leva_Low;
    
    public void AttackOne()
    {
        Leva_Low.SetTrigger("AttackOneTrigger");
    }

    public void AttackTwo()
    {
        Leva_Low.SetTrigger("AttackTwo");
    }
}
