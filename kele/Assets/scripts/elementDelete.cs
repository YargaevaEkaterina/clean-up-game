using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elementDelete : MonoBehaviour
{
    randomspawn randomElements;
    void Start()
    {
        randomElements = FindObjectOfType<randomspawn>();
    }

    // Update is called once per frame
    public void OnClickDestroy()
    {
        randomElements.DestroyObjectToSpawn(gameObject);
    }
}
