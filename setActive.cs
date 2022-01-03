using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActive : MonoBehaviour
{
    public GameObject toSet;
    // Start is called before the first frame update
    void Start()
    {
        toSet.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
