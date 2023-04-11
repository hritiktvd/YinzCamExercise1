using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackgroundOnInit : MonoBehaviour
{
    private void OnEnable()
    {
        EventsManager.onFaceDetected += setBackgroundDistance;
        EventsManager.onFaceLost += showFaceMessage;
    }

    private void OnDisable()
    {
        EventsManager.onFaceDetected -= setBackgroundDistance;
        EventsManager.onFaceLost -= showFaceMessage;
    }

    public void FaceTrackON()
    {
        EventsManager.FaceDetected();
    }

    public void FaceTrackOFF()
    {
        EventsManager.LostFace();
    }

    private void setBackgroundDistance()
    {
        Debug.Log("Background Distance Changed");
    }

    private void showFaceMessage()
    {
        Debug.Log("Show Face to Continue!");
    }
}
