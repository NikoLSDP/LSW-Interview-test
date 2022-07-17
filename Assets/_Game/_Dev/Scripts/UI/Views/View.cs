using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    [SerializeField] GameState state;

    public GameState State { get { return state; } }


}
