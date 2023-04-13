using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public List<GameObject> UIElements;

    //public RectTransform RacingLight;

    //private int racingLightCount = 5;

    private void OnEnable()
    {
        EventsManager.onFilterStart += showInventoryUI;
    }

    private void OnDisable()
    {
        EventsManager.onFilterStart += showInventoryUI;
    }

    private void Start()
    {
        showStartUI();
    }

    public void showStartUI()
    {
        HideAllUI();
        UIElements[0].SetActive(true);
    }
    public void HideStartUI()
    {
        HideAllUI();
        UIElements[0].SetActive(false);
        EventsManager.FilterStarted();
    }

    private void showInventoryUI()
    {
        HideAllUI();
        UIElements[1].SetActive(true);
    }

    //private void showRacingUI()
    //{
    //    HideAllUI();
    //    UIElements[2].SetActive(true);
    //    StartCoroutine(SpawnRacingLight());
    //}


    private void HideAllUI()
    {
        foreach (var UI in UIElements)
        {
            UI.SetActive(false);
        }
    }

    //IEnumerator SpawnRacingLight()
    //{
    //    for (var i = 0; i <= racingLightCount; i++)
    //    {
    //        yield return new WaitForSeconds(1f);
    //        Instantiate(RacingLight, new Vector2(RacingLight.anchoredPosition.x + 5f, RacingLight.anchoredPosition.y), RacingLight.transform.rotation);
    //    }
    //    showInventoryUI();
    //}
}
