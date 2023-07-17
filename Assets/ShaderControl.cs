using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderControl : MonoBehaviour
{
    public SliderControl sliderControll;
    public string property = "globalScale";
    public Material material1;
    public Material material2;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetShaderProperty(sliderControll.GetSlider());
    }

    private void SetShaderProperty(float value)
    {
        // Check if the targetMaterial and property exist
        if (material1 != null && material1.HasProperty(property))
        {
            material1.SetFloat(property, value);
        }

        if (material2 != null && material2.HasProperty(property))
        {
            material2.SetFloat(property, value);
        }
    }
}