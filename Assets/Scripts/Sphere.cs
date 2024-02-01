using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

//INHERITANCE
public class Sphere : Shape
{
    //ENCAPSULATION
    private MeshRenderer meshRenderer;
    private Material material;
    public Color Color { get; private set; }
    [SerializeField] private TextMeshProUGUI greetText;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        material = meshRenderer.material;

        material.color = Color.blue;
    }

    //INHERITANCE, POLYMORPHISM
    protected override void Greet()
    {
        greetText.text = "Hi, I'm a Sphere!";
        StartCoroutine(ResetGreetMessage());
    }

    IEnumerator ResetGreetMessage()
    {
        yield return new WaitForSeconds(2);
        greetText.text = "";
    }
}
