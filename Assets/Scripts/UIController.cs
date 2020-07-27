using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
public GameObject _cutter;
public GameObject _cooker;
public GameObject _decorator;

public GameObject _maingamePanel;
public GameObject _fryingPanel;
public GameObject _decoratorPanel;

public GameObject PassButtonObject;
    public void StartButton(GameObject _panel){
      _panel.SetActive(false);
      _cutter.SetActive(true);
      _maingamePanel.SetActive(true);
    }//start button end line
    public void PassButton(){
      if(_cutter.active == true){
          _cutter.SetActive(false);
          _fryingPanel.SetActive(true);
          _cooker.SetActive(true);
          PassButtonObject.SetActive(false);
      }else if(_cooker.active == true){
          _cooker.SetActive(false);
          _fryingPanel.SetActive(false);
          _decorator.SetActive(true);
          _decoratorPanel.SetActive(true);

      }else if(_decorator.active == true){
        //Open Finish  Screen
      }
    }//pass button end line


}//Class end line
