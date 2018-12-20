using System.Collections.Generic;
using UnityEngine;

public class flammeManager : MonoBehaviour {

    public List<GameObject> flammes;
    List<GameObject> flammes_allume;
    private bool isactive = true;
    public bool action_fini;

    // Use this for initialization
    void Start () {
        flammes_allume = flammes;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < flammes_allume.Count; i++)
        {
            if (flammes_allume[i].GetComponent<flamme>().active == isactive)
            {
                flammes_allume.Remove(flammes_allume[i]);
            }
        }

        if (flammes_allume.Count == 0)
        {
            action_fini = true;
            gameObject.GetComponent<pincedisabled>().enabled = true;
        }
    }
}