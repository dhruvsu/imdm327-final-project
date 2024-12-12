using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayInfo : MonoBehaviour
{
    public AudioClip soundfx;
    private AudioSource audioSource;
    SpriteRenderer spriteRenderer;
    public string language_name;
    public string countries_spoken;

    // Start is called before the first frame update
    void Start()
    {
        GameObject map = GameObject.Find("map");
        foreach(Transform child in map.transform){
            SpriteRenderer currRenderer = child.GetComponent<SpriteRenderer>();
            child.transform.position = new Vector3(0, 0, 253);
            currRenderer.color = Color.black;
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GameObject.Find("click noise").GetComponent<AudioSource> ();
    }

    private void OnMouseDown(){
        Debug.Log("GameObject clicked: " + gameObject.name);

        GameObject map = GameObject.Find("map");
        foreach(Transform child in map.transform){
            SpriteRenderer currRenderer = child.GetComponent<SpriteRenderer>();
            child.transform.position = new Vector3(0, 0, 253);
            currRenderer.color = Color.black;
        }

        audioSource.clip = soundfx;
        audioSource.Play ();
        
        TextMeshProUGUI nameText = GameObject.Find("language_name").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI descText = GameObject.Find("countries_spoken").GetComponent<TextMeshProUGUI>();
        nameText.text = language_name;
        descText.text = countries_spoken;
        gameObject.transform.position = new Vector3(0, 0, 248);
        spriteRenderer.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
