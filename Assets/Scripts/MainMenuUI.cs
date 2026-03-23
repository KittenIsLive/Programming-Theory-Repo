using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;




#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuUI : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public void OnClickStart()
    {
        Debug.Log("Game Starting");
        DataManager.Instance.nameText = nameInputField.text;
        SceneManager.LoadScene(1);
    }

    public void OnClickQuit()
    {
        Debug.Log("Quitting Game");
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
