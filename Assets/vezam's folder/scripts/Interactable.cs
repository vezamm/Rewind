using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objects/Interactable /Ball")]

public class Interactable : ScriptableObject
{

    [SerializeField] private string ObjectName;
    [SerializeField] private string description;
    [SerializeField] private int ID;

}
