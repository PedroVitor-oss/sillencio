using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMental : MonoBehaviour
{
   public float estresse = 0.0f;
   public float addEstresse = 0.001f;
   public Animator aniObjectve;

   private void Update() {
        estresse += Time.deltaTime * addEstresse;
   }
   private void OnObjectve(){
    Debug.Log("mostrar ojetivos");
    aniObjectve.SetBool("show",true);
    Invoke("DesativeAniObjective",1);
   }
   public float   nivelEstresse (){
        return estresse;
   }
   private void DesativeAniObjective(){
        aniObjectve.SetBool("show",false);

   }
   public void SetAddEstresse(float ae)
   {
     addEstresse = ae;
   }
}
