using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Update is called once per frame
    void Awake()
    {
        Debug.Log("Game Object Awake!");
        Debug.LogWarning("This is a warning massage!");
        Debug.LogError("This is a error massage!");
    }

}

