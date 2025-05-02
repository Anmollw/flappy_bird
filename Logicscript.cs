using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Logicscript : MonoBehaviour
{
   public int playerscore ;
   public Text scoreText ;
   [ContextMenu("Increase Score")]
   public void addscore(int scoretoadd) 
   {
    playerscore += scoretoadd ;
    scoreText.text = playerscore.ToString() ;
   }
}

