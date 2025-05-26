using UnityEngine;
using UnityEngine.UI;

public class CharacterScaler : MonoBehaviour
{
    public Transform maleCharacter;
    public Transform femaleCharacter;
    public Slider widthSlider;
    public Slider heightSlider;

    public float minScale = 0.5f;
    public float maxScale = 2.0f;

    private Transform activeCharacter;

    void Start()
    {
        
        activeCharacter = maleCharacter.gameObject.activeSelf ? maleCharacter : femaleCharacter;

        SetupSliders();

        widthSlider.onValueChanged.AddListener(OnWidthChanged);
        heightSlider.onValueChanged.AddListener(OnHeightChanged);
    }

    void Update()
    {
        
        if (maleCharacter.gameObject.activeSelf)
            activeCharacter = maleCharacter;
        else if (femaleCharacter.gameObject.activeSelf)
            activeCharacter = femaleCharacter;
    }

    void SetupSliders()
    {
        if (activeCharacter == null) return;

        widthSlider.minValue = minScale;
        widthSlider.maxValue = maxScale;
        widthSlider.value = activeCharacter.localScale.x;

        heightSlider.minValue = minScale;
        heightSlider.maxValue = maxScale;
        heightSlider.value = activeCharacter.localScale.y;
    }

    void OnWidthChanged(float newWidth)
    {
        if (activeCharacter == null) return;

        Vector3 scale = activeCharacter.localScale;
        scale.x = newWidth;
        activeCharacter.localScale = scale;
    }

    void OnHeightChanged(float newHeight)
    {
        if (activeCharacter == null) return;

        Vector3 scale = activeCharacter.localScale;
        scale.y = newHeight;
        activeCharacter.localScale = scale;
    }
}
