using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dispenser : MonoBehaviour
{
    [SerializeField] TMP_Text Text;

    ParticleSystem ps;
    int counter = 0;

    Vector3 newPos;

    private void Awake()
    {
        ps = GetComponent<ParticleSystem>();
        newPos = transform.position;
    }

    public void OnParticleTrigger()
    {
        counter++;
        Text.text = counter.ToString();
    }

    private void Update()
    {
        float inputX = 0;
        float inputY = 0;

        inputX = Input.GetAxisRaw("Mouse X");
        inputY = Input.GetAxisRaw("Mouse Y");

        newPos.y += inputY;
        newPos.x -= inputX;

        transform.position = newPos;
    }
}
