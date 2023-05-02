using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class camera : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        VuforiaApplication.Instance.OnVuforiaStarted += StartFocus;
    }

    public void StartFocus()
    {
        VuforiaBehaviour.Instance.CameraDevice.SetFocusMode(FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
