using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepAudio : MonoBehaviour
{
    void Start()
    {
      DontDestroyOnLoad(transform.gameObject);
    }
}
