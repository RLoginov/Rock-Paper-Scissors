using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteActivator : MonoBehaviour
{
    SpriteRenderer sr;
    public KeyCode key;
    bool active = false;
    GameObject note;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>(); 
    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetKeyDown(key) && active)
        {
            Destroy(note);
            StartCoroutine(Pressed());
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        active = true; 
        if(collision.gameObject.tag == "Note" )
        {
            note = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        active = false;

    }

    IEnumerator Pressed()
    {
        Color old = sr.color;
        sr.color = new Color(1, 1, 1);
        yield return new WaitForSeconds(0.2f);
        sr.color = old;
    }
}
