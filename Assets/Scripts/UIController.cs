using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
public GameObject _cutter;
    public void StartButton(GameObject _panel){
      _panel.SetActive(false);
      _cutter.SetActive(true);
    }
}
