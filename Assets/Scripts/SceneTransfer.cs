
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneTransfer : MonoBehaviour
{
    public Text _sceneNameText;
    public void Start()
    {
        _sceneNameText.text = SceneManager.GetActiveScene().name;
    }
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

