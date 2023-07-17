using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class SwitchGeometry : MonoBehaviour
{
    public Shader elliptic;
    public Material material;
    public Material material2;
    GeometryControl geomControl;
    public Button EuclideanPressed;
    Material Geom;

    void Start()
    {
        Geom = Resources.Load("Noneuclidean/Materials/Standard Material", typeof(Material)) as Material;
        if (geomControl == null)
        {
            geomControl = FindObjectOfType<GeometryControl>();
        }
        if (geomControl == null)
        {
            enabled = false;
        }
    }

    void Update()
    {
       
    }

    public void EuclideanSwitch()
    {
        Shader standardShader = Shader.Find("Standard");


        if (standardShader != null)
        {

            material.shader = standardShader;
            material2.shader = standardShader;
        }
        else
        {
            Debug.LogWarning("Standard Shader not found!");
        }
    }

    public void EllipticSwitch()
    {
        material.shader = elliptic;
        material2.shader = elliptic;

    }

    public void HyperbolicScene()
    {
        SceneManager.LoadScene("HyperbolicScene");
    }

    public void PresentationScene()
    {
        SceneManager.LoadScene("PresentationScene");
    }

    public void EllipticScene()
    {
        SceneManager.LoadScene("ElipticScene");
    }
}
