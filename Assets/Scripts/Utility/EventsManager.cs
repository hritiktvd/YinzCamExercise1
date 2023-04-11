using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    public delegate void FaceDetect();
    public static event FaceDetect onFaceDetected;

    public delegate void FaceLost();
    public static event FaceLost onFaceLost;

    public static void FaceDetected() { onFaceDetected?.Invoke(); }
    public static void LostFace() { onFaceLost?.Invoke(); }



}
