using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
  public Slider slider;
  private int direction = 1;
  private float speed = 0.015f;
  public float min = 0.4f, max = 0.7f;
  public MaterialHolder[] ingredients;
  public GameObject GameController;
    void Start(){
      ingredients = FindObjectsOfType<MaterialHolder>();
    }
    void Update()
    {
      if(slider.value > min && slider.value < max){
        GetComponent<Image>().color = Color.green;
      }else{
        GetComponent<Image>().color = Color.Lerp(Color.white, Color.red, slider.value);
      }
        slider.value += direction*speed;
        if(slider.value == 1f){
          direction = -1;
        }else if(slider.value == 0f){
          direction = 1;
        }
    }

    public void FryingButton(){
    UIController controller = GameController.GetComponent<UIController>();

      if(slider.value > min && slider.value < max){
          //Succesful
          foreach(MaterialHolder m in ingredients){
            m.gameObject.GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("Succesful");
          }
          controller.PassButton();
      }else{
          //Fail
          foreach(MaterialHolder m in ingredients){
            m.gameObject.GetComponent<Renderer>().material.color = Color.black;
          }
          controller.PassButton();
          Debug.Log("Failed");
      }
    }
}
