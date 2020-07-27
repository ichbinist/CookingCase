using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

  private Touch touch;
  private float speedModifier;
  [SerializeField]private GameObject DecorationObject;
  [SerializeField]private bool iscut = true;

    // Start is called before the first frame update
    void Start()
    {
        speedModifier = 0.01f;

    }

    // Update is called once per frame
    void Update()
    {

      if(Input.touchCount > 0){
        touch = Input.GetTouch(0);
        if(iscut){
        gameObject.transform.GetChild(2).GetComponent<slicerPlane>().cut();
        }else{
          //Decoration
          Instantiate(DecorationObject, new Vector3(transform.position.x,transform.position.y-1f,transform.position.z), Quaternion.identity);
        }
        if(touch.phase == TouchPhase.Moved){
          transform.position = new Vector3(
          transform.position.x + touch.deltaPosition.x*speedModifier,
          transform.position.y                                      ,
          transform.position.z + touch.deltaPosition.y*speedModifier);
        }
      }


    }
}
