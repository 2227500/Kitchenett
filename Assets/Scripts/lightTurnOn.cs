using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightTurnOn : MonoBehaviour
{

    public Light spotLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightSwitch()
    {
        if (spotLight.enabled == true)
        {
            spotLight.enabled = false;
        }
        else
        {
            spotLight.enabled = true;
        }
    }
}
