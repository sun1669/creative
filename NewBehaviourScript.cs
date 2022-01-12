using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject Panel;

    public void OpenPanel()
     {
        if(Panel != null)
         {
        Panel.SetActive(true);
    }
    }

        public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

   public void LoadMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

      public void LoadMapLocationTajScene()
    {
        SceneManager.LoadScene("MapLocationTajScene");
    }

      public void LoadTajPointCameraScene()
    {
        SceneManager.LoadScene("TajPointCameraScene");
    }

       public void LoadTajMahalScene()
    {
        SceneManager.LoadScene("TajMahalScene");
    }

       public void LoadChinaMapLocationScene()
    {
        SceneManager.LoadScene("ChinaMapLocationScene");
    }

      public void LoadGreatWallPointCameraScene()
    {
        SceneManager.LoadScene("GreatWallPointCameraScene");
    }

   public void LoadGreatWallChinaScene()
    {
        SceneManager.LoadScene("GreatWallchinaScene");
    }

   public void LoadPyramidMapLocationScene()
    {
        SceneManager.LoadScene("PyramidMapLocationScene");
    }

   public void LoadPyramidPointCameraScene()
    {
        SceneManager.LoadScene("PyramidPointCameraScene");
    }

   public void LoadPyramidScene()
    {
        SceneManager.LoadScene("PyramidScene");
    }


  public void LoadPetraMapLocationScene()
    {
        SceneManager.LoadScene("PetraMapLocationScene");
    }

       public void LoadPetraPointCameraScene()
    {
        SceneManager.LoadScene("PetraPointCameraScene");
    }

   public void LoadPetraScene()
    {
        SceneManager.LoadScene("PetraScene");
    }

  public void LoadMachuPichuMapLocationScene()
    {
        SceneManager.LoadScene("MachuPichuMapLocationScene");
    }
       public void LoadMachuPichuPointCameraScene()
    {
        SceneManager.LoadScene("MachuPichuPointCameraScene");
    }

   public void LoadMachuPichuScene()
    {
        SceneManager.LoadScene("MachuPichuScene");
    }


  public void LoadChristMapLocationScene()
    {
        SceneManager.LoadScene("ChristMapLocationScene");
    }

       public void LoadChristPointCameraScene()
    {
        SceneManager.LoadScene("ChristPointCameraScene");
    }

   public void LoadChristScene()
    {
        SceneManager.LoadScene("ChristScene");
    }


  public void LoadColosseumMapLocationScene()
    {
        SceneManager.LoadScene("ColosseumMapLocationScene");
    }
       public void LoadColosseumPointCameraScene()
    {
        SceneManager.LoadScene("ColosseumPointCameraScene");
    }

   public void LoadColosseumScene()
    {
        SceneManager.LoadScene("ColosseumScene");
    }




    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("You have quit the app");
    }

    //public void LoadMenuScene()
    //{
      //  SceneManager.LoadScene("MenuScene");
    //}
}
