using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.XR;

public class HideIfDaydream : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (XRSettings.loadedDeviceName == "daydream")
            gameObject.SetActive(false);
    }
}
