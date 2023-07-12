using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ManagerScene : MonoBehaviour
{
    public void IniciarMapa()
    {
        //Carga el juego.
        SceneManager.LoadScene(1);

    }
    public void IniciarRA()
    {
        //Carga el juego.
        SceneManager.LoadScene(2);

    }
    public void Finalizar()
    {
        //Cierra el juego.
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }
}
