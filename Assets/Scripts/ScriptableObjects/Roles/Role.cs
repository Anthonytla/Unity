using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Role : MonoBehaviour
{
    // L'attribut doit être sérialisé
    [SerializeField]
    private int _attack;
    // L'attribut doit être sérialisé
    [SerializeField]
    private int _defense;
}
