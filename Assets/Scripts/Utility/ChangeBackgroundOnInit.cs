using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackgroundOnInit : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayerFaceTracker;

    [SerializeField]
    private GameObject Background;

    public float XValue, YValue, ZValue;


    private void Start()
    {
        StartCoroutine(changeBackgroundOnStart());
    }
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
        Background.transform.localPosition = Vector3.zero;
        Background.transform.localPosition = new Vector3(PlayerFaceTracker.transform.position.x + XValue, PlayerFaceTracker.transform.position.y + YValue, PlayerFaceTracker.transform.position.z + ZValue) ;
    }

    private void showFaceMessage()
    {
        Debug.Log("Show Face to Continue!");
    }

    IEnumerator changeBackgroundOnStart()
    {
        yield return new WaitForSeconds(0.2f);
        setBackgroundDistance();
    }
}
