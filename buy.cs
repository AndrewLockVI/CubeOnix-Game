using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buy : MonoBehaviour
{
    public Animation anim;

    void Update()
    {
        if (PlayerPrefs.GetInt("credits") >= 50 * (PlayerPrefs.GetInt("owned")  + 1) & PlayerPrefs.GetInt("owned") < 11)
        {
            anim = gameObject.GetComponent<Animation>();
            anim.Play();
        }
    }
}
