using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{

    public Button EuclideanPressed;


    void Start()
    {

    }

    void Update()
    {

    }

    public void EuclideanSwitch()
    {

    }

    public void HyperbolicSwitch()
    {
        SceneManager.LoadScene("HyperbolicScene");
        Debug.Log("HyperbolicSwitch");
    }

    public void EllipticSwitch()
    {
        SceneManager.LoadScene("ElipticScene");

    }
}
