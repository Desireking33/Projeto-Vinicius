using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sair : MonoBehaviour
{
   public void LogOff(){
    Application.Quit(0);
    SceneManager.LoadScene("Cena1");


   }
}
