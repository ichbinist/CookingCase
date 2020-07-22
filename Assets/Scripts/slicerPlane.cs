using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EzySlice;

public class slicerPlane : MonoBehaviour
{
    public Material mat;
    public LayerMask mask;

    public void OnDrawGizmos(){

      EzySlice.Plane cuttingPlane = new EzySlice.Plane();
      cuttingPlane.Compute(transform);
      cuttingPlane.OnDebugDraw();

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
          Collider[] kesilecekNesneler = Physics.OverlapBox(transform.position, new Vector3(1f,0f,.1f), transform.rotation, mask);

          foreach(Collider nesne in kesilecekNesneler){
            SlicedHull kesilenNesne = Kes(nesne.GetComponent<Collider>().gameObject,mat);
            GameObject kesilmisUst = kesilenNesne.CreateUpperHull(nesne.gameObject,mat);
            GameObject kesilmisAlt = kesilenNesne.CreateLowerHull(nesne.gameObject,mat);

            BilesenEkle(kesilmisUst);
            BilesenEkle(kesilmisAlt);

            Destroy(nesne.gameObject);
          }
        }
    }//--End of Update Function

    public SlicedHull Kes(GameObject obj, Material mat){
      return obj.Slice(transform.position, transform.up, mat);
    }

    void BilesenEkle(GameObject obj){

      obj.AddComponent<MeshCollider>().convex = true;
      obj.AddComponent<Rigidbody>();
      obj.GetComponent<Rigidbody>().interpolation = RigidbodyInterpolation.Interpolate;
      obj.GetComponent<Rigidbody>().AddExplosionForce(100,obj.transform.position,20);
      obj.layer = 8;
    }
}
